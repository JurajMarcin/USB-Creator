using System;
using System.Diagnostics;
using System.IO;

namespace USB_Creator {
	internal enum FileSystem { FAT32, NTFS, exFAT };

	internal class FormatDriveTools {

		public static bool FormatDrive(DriveInfo drive, FileSystem fs, string label, bool quick = true, int? allocSize = null) {
			return FormatDrive(drive.Name.ToCharArray()[0], fs, label, quick, allocSize);
		}

		public static bool FormatDrive(char driveLetter, FileSystem fs, string label, bool quick = true, int? allocSize = null) {
			Console.WriteLine("Format {0} as {1}, named {2}", driveLetter, fs.ToString(), label);

			if (!char.IsLetter(driveLetter)) {
				return false;
			}

			bool success = false;
			string drive = driveLetter + ":";
			try {
				var di = new DriveInfo(drive);
				var psi = new ProcessStartInfo();
				psi.FileName = "format.com";
				psi.WorkingDirectory = Environment.SystemDirectory;
				psi.Arguments = "/FS:" + fs +
											 " /Y" +
											 (label != "" ? " /V:" + label : "") +
											 (quick ? " /Q" : "") +
											 (allocSize.HasValue ? " /A:" + allocSize.Value : "") +
											 " " + drive;
				psi.UseShellExecute = false;
				psi.CreateNoWindow = true;
				psi.RedirectStandardOutput = true;
				psi.RedirectStandardInput = true;
				Console.WriteLine(psi.Arguments);
				var formatProcess = Process.Start(psi);
				var swStandardInput = formatProcess.StandardInput;
				swStandardInput.WriteLine();
				formatProcess.WaitForExit();
				success = true;
			} catch (Exception) { }
			return success;
		}
	}
}
