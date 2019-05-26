using RemoveDriveByLetter;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace USB_Creator {

	public partial class Form1 : Form {
		private DriveInfo[] usbs = new DriveInfo[0];

		public Form1() {
			InitializeComponent();
			volumeNameTxt.Enabled = changeName.Checked;
			formatFS.Enabled = format.Checked;
			formatFS.DataSource = Enum.GetValues(typeof(FileSystem));
			formatFS.SelectedIndex = 0;
			toolStatus.Text = "Ready";
			SetUsbList();
			ManagementEventWatcher watcher = new ManagementEventWatcher();
			WqlEventQuery query = new WqlEventQuery("SELECT * FROM Win32_VolumeChangeEvent");
			watcher.EventArrived += new EventArrivedEventHandler(DriveWatcherEvent);
			watcher.Query = query;
			watcher.Start();
		}

		public void DriveWatcherEvent(object sender, EventArrivedEventArgs e) {
			SetUsbListCallback setUsbListCallback = new SetUsbListCallback(SetUsbList);
			this.Invoke(setUsbListCallback);
		}

		private delegate void SetUsbListCallback();

		private void SetUsbList() {
			DriveInfo[] foundDrives = DriveInfo.GetDrives();
			List<DriveInfo> foundUsbs = new List<DriveInfo>();
			foreach (DriveInfo drive in foundDrives) {
				if (drive.IsReady && drive.DriveType == DriveType.Removable) {
					foundUsbs.Add(drive);
				}
			}
			usbs = foundUsbs.ToArray();
			usbList.BeginUpdate();
			usbList.Items.Clear();
			foreach (DriveInfo usb in usbs) {
				usbList.Items.Add(new ListViewItem(new string[] { usb.Name, usb.VolumeLabel, usb.DriveFormat }));
			}
			usbList.EndUpdate();
		}

		private void addBtn_Click(object sender, EventArgs e) {
			openFileDialog1.ShowDialog();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e) {
			foreach (string file in openFileDialog1.FileNames) {
				files.BeginUpdate();
				files.Items.Add(file);
				files.EndUpdate();
			}
		}

		private void remBtn_Click(object sender, EventArgs e) {
			foreach (ListViewItem selItem in files.SelectedItems) {
				files.Items.Remove(selItem);
			}
		}

		private void changeName_CheckedChanged(object sender, EventArgs e) {
			volumeNameTxt.Enabled = changeName.Checked;
		}

		public bool CheckFiles(string fileName, string fileName2) {
			using (var md5 = MD5.Create()) {
				try {
					byte[] hash1;
					byte[] hash2;
					using (var stream = File.OpenRead(fileName)) {
						hash1 = md5.ComputeHash(stream);
					}
					using (var stream = File.OpenRead(fileName2)) {
						hash2 = md5.ComputeHash(stream);
					}
					return hash1.SequenceEqual(hash2);
				} catch (IOException) {
					return false;
				}
			}
		}

		private void copyBtn_Click(object sender, EventArgs e) {
			toolStatus.Text = "Working";
			this.Cursor = Cursors.WaitCursor;
			foreach (DriveInfo usb in usbs) {
				if (usb.IsReady && usb.DriveType == DriveType.Removable) {
					bool error = false;
					if (changeName.Checked) {
						usb.VolumeLabel = volumeNameTxt.Text;
					}
					if (format.Checked) {
						bool formatted = false;
						int i = 0;
						while (!formatted) {
							i++;
							if (i > tries.Value) {
								error = true;
								break;
							}
							Enum.TryParse(formatFS.SelectedValue.ToString(), out FileSystem fs);
							formatted = FormatDriveTools.FormatDrive(usb, fs, volumeNameTxt.Text);
						}
						if (error) {
							log.AppendText("Failed to format " + usb.Name + "\n");
						} else {
							log.AppendText(usb.Name + "has been formatted as " + formatFS.SelectedValue + "\n");
						}
					}
					if (!error) {
						foreach (ListViewItem file in files.Items) {
							FileInfo fileInfo = new FileInfo(file.Text);
							if (fileInfo.Exists) {
								bool same = false;
								int i = 0;
								while (!same) {
									i++;
									if (i > tries.Value) {
										error = true;
										break;
									}
									File.Copy(fileInfo.FullName, usb.RootDirectory + fileInfo.Name, true);
									Console.WriteLine("COPIED");
									same = CheckFiles(fileInfo.FullName, usb.RootDirectory + fileInfo.Name);
								}
								if (error) {
									log.AppendText("Failed to copy " + fileInfo.Name + " to  drive " + usb.Name + "\n");
								} else {
									log.AppendText(fileInfo.Name + " has been copied to drive " + usb.Name + "\n");
								}
							}
						}
					}
					if (eject.Checked && !error) {
						RemoveDriveTools.RemoveDrive(usb.Name.Replace("\\", ""));
					}
				}
			}
			toolStatus.Text = "Ready";
			this.Cursor = Cursors.Arrow;
		}

		private void format_CheckedChanged(object sender, EventArgs e) {
			formatFS.Enabled = format.Checked;
		}
	}
}
