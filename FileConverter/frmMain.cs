using FileConverter.UpdateService;

using System.Diagnostics;
using System.Reflection;

namespace FileConverter
{
	public partial class frmMain : Form
	{
		private Version? CurrentVersion;
		private const string SupportedImageFileTypes = "*.bmp;*.jpg;*.jpeg;*.png;*.gif";
		private readonly List<string> ImageFileTypes = new(SupportedImageFileTypes.Replace("*", "").Split(';'));

		private bool IsSupportedImageFile(string filename)
		{
			foreach (string imageFileType in ImageFileTypes)
				if (filename.EndsWith(imageFileType, StringComparison.OrdinalIgnoreCase))
					return true;
			return false;
		}

		#region Form Events

		public frmMain()
		{
			InitializeComponent();
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			CurrentVersion = AssemblyHelper.GetAssemblyVersion();
			lblVersion.Text = $"v{CurrentVersion}";
			
			ResetBinaryFileInfo();
			ResetImageFileInfo();
#if AUTOUPDATE
			lnkUpdate.Tag = "Unknown";
			lnkUpdate.Text = "Check for Update";
			CheckForUpdateAsync();
#endif
			ResetStatusBarMessage();
		}

		private void ResetStatusBarMessage()
		{
			sslStatus.Text = "Ready";
		}

		private void ShowStatusBarMessage(string message)
		{
			sslStatus.Text = message;
		}

		private void lnkUpdate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			if (lnkUpdate.Tag.Equals("UpdateAvailable"))
				DownloadAndInstallUpdate();
			else if (!lnkUpdate.Tag.Equals("Checking"))
				CheckForUpdateAsync();
		}

		public DateTime DateFromUnixHex(string hex)
		{
			// https://stackoverflow.com/questions/28321924/how-to-convert-hex-to-decimal-in-c-net#28322047
			if (string.IsNullOrEmpty(hex))
				return DateTime.MinValue;

			if (hex.StartsWith("0x"))
			{
				//hex = hex.TrimStart(new char[] { '0', 'x' });
				//hex = hex.Substring(2, hex.Length - 2);
				hex = hex[2..];
			}

			if (int.TryParse(hex, System.Globalization.NumberStyles.HexNumber, System.Globalization.CultureInfo.InvariantCulture, out int value))
				return DateTime.UnixEpoch.AddSeconds(value);
			else
				return DateTime.MinValue;
		}

		public static string GenerateId(string name)
		{
			const string Format = "yyyyMMddHHmmss";
			DateTime _lastTimestamp = DateTime.MinValue;
			object _lock = new();
			var now = DateTime.UtcNow;
			var timestamp = new DateTime(now.Year, now.Month, now.Day, now.Hour, now.Minute, now.Second);

			lock (_lock)
			{
				if (timestamp <= _lastTimestamp)
				{
					timestamp = _lastTimestamp.AddSeconds(1);
				}

				_lastTimestamp = timestamp;
			}

			return timestamp.ToString(Format, System.Globalization.CultureInfo.InvariantCulture) + "_" + name;
		}

		#endregion

		#region Auto Update

		//private void CheckForUpdate(bool promptToInstall = true)
		//{
		//	try
		//	{
		//		var latestVersion = Updater.GetLatestRelease()?.Version;
		//		if (latestVersion > CurrentVersion)
		//		{
		//			lnkUpdate.Tag = "UpdateAvailable";
		//			lnkUpdate.Text = $"Click to download v{latestVersion}";
		//			if (promptToInstall && MessageBoxEx.Show(this, $"Version v{latestVersion} is avaible. Download and install now?", 
		//				"New Version Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
		//			{
		//				DownloadAndInstallUpdate();
		//			}
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		Debug.WriteLine(ex.ToString());
		//	}
		//}

		private async void CheckForUpdateAsync(bool promptToInstall = true)
		{
			try
			{
				lnkUpdate.Tag = "Checking";
				lnkUpdate.Text = "Checking for update...";

				var latestRelease = await Updater.GetLatestReleaseAsync();
				if (latestRelease != null)
				{
					var latestVersion = latestRelease.Version;
					if (latestVersion > CurrentVersion)
					{
						lnkUpdate.Tag = "UpdateAvailable";
						lnkUpdate.Text = $"Click to download v{latestVersion}";
						if (promptToInstall && MessageBoxEx.Show(this, $"Version v{latestVersion} is avaible. Download and install now?",
							"New Version Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
						{
							DownloadAndInstallUpdate();
						}
					}
					else if (latestVersion == CurrentVersion)
					{
						lnkUpdate.Tag = "Latest";
						lnkUpdate.Text = "Running latest version";
					}
					else
					{
						lnkUpdate.Tag = "Unknown";
						lnkUpdate.Text = "Check for Update";
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private void DownloadAndInstallUpdate()
		{
			// TODO: Call update service and close
			Close();
		}

		#endregion

		#region Tab Control Events

		//private void tabFiles_MouseDown(object sender, MouseEventArgs e)
		//{
		//	tabFiles.DoDragDrop(tabFiles.Text, DragDropEffects.Copy | DragDropEffects.Move);
		//}

		#endregion

		#region Binary File Tab Page Events

		private void tabBinary_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data is DataObject && e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void tabBinary_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files.Any())
				txtBinaryFilePath.Text = files.First(); //select the first one  
		}

		private void txtBinaryFilePath_TextChanged(object sender, EventArgs e)
		{
			LoadBinaryFileInfo();
		}

		private void btnBinaryFileBrowse_Click(object sender, EventArgs e)
		{
			BrowseForBinaryFile();
		}
		
		private void btnBinaryFileCopyClipboard_Click(object sender, EventArgs e)
		{
			CopyBinaryFileToClipboard();
		}

		private void btnSaveBinaryFileAs_Click(object sender, EventArgs e)
		{
			SaveBinaryFileAs();
		}

		#endregion

		#region Image File Tab Page Events

		private void tabImage_DragEnter(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private void tabImage_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetData(DataFormats.FileDrop) is string[] files && files.Any())
				txtImageFilePath.Text = files.FirstOrDefault(x => IsSupportedImageFile(x));
		}

		private void txtImageFilePath_TextChanged(object sender, EventArgs e)
		{
			LoadImageFileInfo();
		}

		private void btnImageFileBrowse_Click(object sender, EventArgs e)
		{
			BrowseForImageFile();
		}

		private void btnImageFileCopyClipboard_Click(object sender, EventArgs e)
		{
			CopyImageFileToClipboard();
		}

		private void btnImageFileSaveAs_Click(object sender, EventArgs e)
		{
			SaveImageFileAs();
		}

		#endregion

		#region Binary File Tab Methods

		private void BrowseForBinaryFile()
		{
			using var dialog = new OpenFileDialog();
			if (dialog.ShowDialog() == DialogResult.OK)
			{
				txtBinaryFilePath.Text = dialog.FileName;
			}
		}

		private void ResetBinaryFileInfo()
		{
			lblBinaryFileName.Text = "";
			lblBinaryFileType.Text = "";
			lblBinaryFileSize.Text = "";
			pbBinaryFileIcon.Visible = false;
			EnableBinaryFileButtons(false);
		}

		private void EnableBinaryFileButtons(bool enable, bool includeBrowse = false)
		{
			if (includeBrowse) btnBinaryFileBrowse.Enabled = enable;
			btnBinaryFileCopyClipboard.Enabled = enable;
			btnSaveBinaryFileAs.Enabled = enable;
		}

		private void LoadBinaryFileInfo()
		{
			string filePath = txtBinaryFilePath.Text.Trim();
			if (File.Exists(filePath))
			{
				var fileInfo = new FileInfo(filePath);
				lblBinaryFileName.Text = fileInfo.Name;
				lblBinaryFileType.Text = $"{fileInfo.GetFileType()} ({fileInfo.Extension})";
				// Format file bytes to nearest whole number unit
				// Method 1: Use recursive function
				lblBinaryFileSize.Text = fileInfo.FormatFileSize(2);
				// Method 2: Use exponent function
				//lblBinaryFileSize.Text = IOHelper.FormatFileSize2(fileInfo.Length, 2);
				// Method 3: Use ByteSize library
				//var byteSize = ByteSizeLib.ByteSize.FromBytes(fileInfo.Length);
				//lblBinaryFileSize.Text = byteSize.ToString();
				//lblBinaryFileSize.Text = byteSize.ToBinaryString();

				try
				{
					using Icon fileIcon = fileInfo.GetIcon(true);
					pbBinaryFileIcon.Visible = true;
					pbBinaryFileIcon.Image = fileIcon.ToBitmap();
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}
				EnableBinaryFileButtons(true, true);
			}
			else
			{
				ResetBinaryFileInfo();
			}
		}

		private void CopyBinaryFileToClipboard()
		{
			try
			{
				ShowStatusBarMessage("Copying binary file contents...");
				EnableBinaryFileButtons(false, true);
				var fileInfo = new FileInfo(txtBinaryFilePath.Text);
				string contents = fileInfo.ConvertToBinary();
				Clipboard.SetText(contents);
				MessageBoxEx.Show(this, "Binary file contents copied.", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBoxEx.Show(this, ex.ToString(), $"Error - {MethodBase.GetCurrentMethod()?.Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ResetStatusBarMessage();
				EnableBinaryFileButtons(true, true);
			}
		}

		private void SaveBinaryFileAs()
		{
			try
			{
				ShowStatusBarMessage("Copying binary file contents...");
				EnableBinaryFileButtons(false, true);
				var fileInfo = new FileInfo(txtBinaryFilePath.Text);
				string contents = fileInfo.ConvertToBinary();
				
				if (File.Exists(fileInfo.FullName))
				{
					string fileExt = fileInfo.Extension;
					string defaultFileName = fileInfo.Name.Replace(fileExt, ".bin");

					using var dialog = new SaveFileDialog()
					{
						Filter = "Binary file (*.bin)|*.bin|All files (*.*)|*.*",
						FileName = defaultFileName,
						DefaultExt = "bin",
						//InitialDirectory = fileInfo.Directory?.FullName,
						RestoreDirectory = true,
						CheckPathExists = true
					};
					if (dialog.ShowDialog() == DialogResult.OK)
					{
						fileInfo.SaveAsBinary(dialog.FileName);
						MessageBoxEx.Show(this, "Binary file saved.", "Save Binary File", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
				}
			}
			catch (Exception ex)
			{
				MessageBoxEx.Show(this, ex.ToString(), $"Error - {MethodBase.GetCurrentMethod()?.Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				ResetStatusBarMessage();
				EnableBinaryFileButtons(true, true);
			}
		}

		#endregion

		#region Image File Tab Methods
		private void BrowseForImageFile()
		{
			using var dialog = new OpenFileDialog()
			{
				Filter = $"Image Files ({SupportedImageFileTypes})|{SupportedImageFileTypes}|All files (*.*)|*.*",
				//InitialDirectory = IOHelper.GetCurrentDirectory()
				RestoreDirectory = true
			};
			if (dialog.ShowDialog() == DialogResult.OK)
				txtImageFilePath.Text = dialog.FileName;
		}

		private void ResetImageFileInfo()
		{
			lblImageFileName.Text = "";
			lblImageFileType.Text = "";
			lblImageFileSize.Text = "";
			pbImageFileIcon.Visible = false;
			pbImageFilePreview.Visible = false;
			EnableImageFileButtons(false);
		}

		private void EnableImageFileButtons(bool enable, bool includeBrowse = false)
		{
			if (includeBrowse) btnImageFileBrowse.Enabled = includeBrowse && enable;
			btnImageFileCopyClipboard.Enabled = enable;
			btnImageFileSaveAs.Enabled = enable;
		}

		private void LoadImageFileInfo()
		{
			string filePath = txtImageFilePath.Text.Trim();
			if (File.Exists(filePath))
			{
				var fileInfo = new FileInfo(filePath);
				lblImageFileName.Text = fileInfo.Name;
				lblImageFileType.Text = $"{fileInfo.GetFileType()} ({fileInfo.Extension})";
				lblImageFileSize.Text = fileInfo.FormatFileSize(2);
				try
				{
					using Icon fileIcon = fileInfo.GetIcon(true);
					pbImageFileIcon.Visible = true;
					pbImageFileIcon.Image = fileIcon.ToBitmap();
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}

				pbImageFilePreview.Visible = true;
				pbImageFilePreview.Image = new Bitmap(filePath);
				EnableImageFileButtons(true, true);
			}
			else
			{
				ResetImageFileInfo();
			}
		}

		private void CopyImageFileToClipboard()
		{
			try
			{
				EnableImageFileButtons(false, true);
				var fileInfo = new FileInfo(txtImageFilePath.Text);
				string contents = fileInfo.ConvertToBase64();
				Clipboard.SetText(contents);
				MessageBoxEx.Show(this, "Image file contents copied as Base-64.", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBoxEx.Show(this, ex.ToString(), $"Error - {MethodBase.GetCurrentMethod().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				EnableImageFileButtons(true, true);
			}
		}

		private void SaveImageFileAs()
		{
			//try
			//{
			//	EnableImageFileButtons(false);
			//	string inputFilePath = txtImageFilePath.Text.Trim();
			//	if (File.Exists(inputFilePath))
			//	{
			//		string fileExt = Path.GetExtension(inputFilePath);
			//		string defaultFileName = inputFilePath.Replace(fileExt, ".dat");

			//		using var dialog = new SaveFileDialog()
			//		{
			//			Filter = "DAT file (*.dat)|*.dat|All files (*.*)|*.*",
			//			FileName = defaultFileName,
			//			DefaultExt = "dat",
			//			InitialDirectory = Path.GetDirectoryName(inputFilePath), //IOHelper.GetCurrentDirectory(),
			//			RestoreDirectory = true
			//		};
			//		if (dialog.ShowDialog() == DialogResult.OK)
			//			IOHelper.SaveAsImage(inputFilePath, dialog.FileName);
			//	}
			//}
			//catch (Exception ex)
			//{
			//	MessageBoxEx.Show(this, ex.ToString(), $"Error - {MethodBase.GetCurrentMethod().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//finally
			//{
			//	EnableImageFileButtons(true);
			//}
		}

		#endregion

	}
}