using RemoveDriveByLetter;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace USB_Creator {
	public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            textBox1.Enabled = changeName.Checked;
            toolStatus.Text = "Ready";
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

        private void button1_Click(object sender, EventArgs e) {
            toolStatus.Text = "Working";
            this.Cursor = Cursors.WaitCursor;
            DriveInfo[] usbs = DriveInfo.GetDrives();
            foreach (DriveInfo usb in usbs) {
                if (usb.IsReady && usb.DriveType == DriveType.Removable) {
                    if (changeName.Checked) {
                        usb.VolumeLabel = textBox1.Text;
                    }
                    bool error = false;
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
                                richTextBox1.AppendText("Failed to copy " + fileInfo.Name + " to  drive " + usb.Name + "\n");
                            } else {
                                richTextBox1.AppendText(fileInfo.Name + " has been copied to  drive " + usb.Name + "\n");
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

        private void remBtn_Click(object sender, EventArgs e) {
            foreach (ListViewItem selItem in files.SelectedItems) {
                files.Items.Remove(selItem);
            }
        }

        private void changeName_CheckedChanged(object sender, EventArgs e) {
            textBox1.Enabled = changeName.Checked;
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
    }
}
