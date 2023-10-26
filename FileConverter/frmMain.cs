using FileConverter.UpdateService;

using System.Diagnostics;
using System.Reflection;

namespace FileConverter
{
	public partial class frmMain : Form
	{
		#region Private Variables

		private Version? CurrentVersion;
		private const string SupportedImageFileTypes = "*.bmp;*.jpg;*.jpeg;*.png;*.gif";
		private readonly List<string> ImageFileTypes = new(SupportedImageFileTypes.Replace("*", "").Split(';'));
		private const string SupportedDocumentTypes = "*.doc;*.docx;";
		private readonly List<string> DocumentTypes = new(SupportedDocumentTypes.Replace("*", "").Split(';'));

		#endregion

		#region Common Methods

		private void SetDropEffect(DragEventArgs e, List<string>? fileTypes = null)
		{
			if (e.Data is DataObject && e.Data.GetDataPresent(DataFormats.FileDrop) &&
				e.Data?.GetData(DataFormats.FileDrop) is string[] files && files?.Length == 1 &&
				(fileTypes == null || IsSupportedFile(files[0], fileTypes)))
				e.Effect = DragDropEffects.Copy;
			else
				e.Effect = DragDropEffects.None;
		}

		private static bool IsSupportedFile(string filename, List<string> fileTypes)
		{
			var fi = new FileInfo(filename);
			return fileTypes.Contains(fi.Extension);
		}

		#endregion

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
			ResetDocumentInfo();

			lnkUpdate.Tag = "Unknown";
			lnkUpdate.Text = "Check for Update";
			CheckForUpdate();

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
			//if (lnkUpdate.Tag.Equals("UpdateAvailable"))
			//	DownloadAndInstallUpdate();
			//else if (!lnkUpdate.Tag.Equals("Checking"))
			//	CheckForUpdate();
			CheckForUpdate();
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

		#region Tab Events

		#region Binary File Tab Events

		private void tabBinary_DragEnter(object sender, DragEventArgs e)
		{
			SetDropEffect(e);
		}

		private void tabBinary_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files?.Length == 1)
				txtBinaryFilePath.Text = files.First();  
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

		#region Image File Tab Events

		private void tabImage_DragEnter(object sender, DragEventArgs e)
		{
			SetDropEffect(e, ImageFileTypes);
		}

		private void tabImage_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files?.Length == 1)
				txtImageFilePath.Text = files.First();
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

		#region Image File Tab Events

		private void tabDocuments_DragEnter(object sender, DragEventArgs e)
		{
			SetDropEffect(e, DocumentTypes);
		}

		private void tabDocuments_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data?.GetData(DataFormats.FileDrop) is string[] files && files?.Length == 1)
				txtDocumentPath.Text = files.First();
		}

		private void txtDocumentPath_TextChanged(object sender, EventArgs e)
		{
			LoadDocumentInfo();
		}

		private void btnDocumentBrowse_Click(object sender, EventArgs e)
		{
			BrowseForDocument();
		}

		private void btnDocumentSaveAs_Click(object sender, EventArgs e)
		{
			SaveDocumentAs();
		}

		#endregion

		#endregion

		#region Tab Methods

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

		#region Document Tab Methods

		private void BrowseForDocument()
		{
			using var dialog = new OpenFileDialog()
			{
				Filter = $"Image Files ({SupportedDocumentTypes})|{SupportedDocumentTypes}|All files (*.*)|*.*",
				RestoreDirectory = true
			};
			if (dialog.ShowDialog() == DialogResult.OK)
				txtDocumentPath.Text = dialog.FileName;
		}

		private void ResetDocumentInfo()
		{
			lblDocumentName.Text = "";
			lblDocumentType.Text = "";
			lblDocumentSize.Text = "";
			pbDocumentIcon.Visible = false;
			EnableDocumentButtons(false);
		}

		private void EnableDocumentButtons(bool enable, bool includeBrowse = false)
		{
			if (includeBrowse) btnDocumentBrowse.Enabled = includeBrowse && enable;
			btnDocumentSaveAs.Enabled = enable;
		}

		private void LoadDocumentInfo()
		{
			string filePath = txtDocumentPath.Text.Trim();
			if (File.Exists(filePath))
			{
				var fileInfo = new FileInfo(filePath);
				lblDocumentName.Text = fileInfo.Name;
				lblDocumentType.Text = $"{fileInfo.GetFileType()} ({fileInfo.Extension})";
				lblDocumentSize.Text = fileInfo.FormatFileSize(2);
				try
				{
					using Icon fileIcon = fileInfo.GetIcon(true);
					pbDocumentIcon.Visible = true;
					pbDocumentIcon.Image = fileIcon.ToBitmap();
				}
				catch (Exception ex)
				{
					Debug.WriteLine(ex.ToString());
				}

				EnableDocumentButtons(true, true);
			}
			else
			{
				ResetDocumentInfo();
			}
		}

		private void SaveDocumentAs()
		{
			string filePath = txtDocumentPath.Text.Trim();
			if (!File.Exists(filePath)) return;
			string pdfFilePath = "";

			try
			{
				if (WordHelper.ToPdf(filePath, ref pdfFilePath))
				{
					var fi = new FileInfo(filePath);
					using FileStream fs = new(pdfFilePath, FileMode.Open, FileAccess.Read);
					var sfd = new SaveFileDialog
					{
						FileName = Path.ChangeExtension(fi.Name, "pdf"),
						Filter = "PDF (*.pdf)|*.pdf|All files (*.*)|*.*",
						DefaultExt = "pdf",
						//InitialDirectory = fi.Directory?.FullName,
						RestoreDirectory = true,
						CheckPathExists = true
					};

					if (sfd.ShowDialog() == DialogResult.OK && !string.IsNullOrEmpty(sfd.FileName))
					{
						byte[] bytes = new byte[fs.Length];
						using var ms = new MemoryStream(bytes);
						fs.CopyTo(ms);
						File.WriteAllBytes(sfd.FileName, bytes);
					}
				}
				else
				{
					MessageBoxEx.Show("Document conversion failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBoxEx.Show(ex.Message, "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
			}
			finally
			{
				ResetStatusBarMessage();
				EnableDocumentButtons(true, true);

				// Delete the temp file
				try { if (File.Exists(pdfFilePath)) File.Delete(pdfFilePath); }
				catch { }
			}
		}

		#endregion

		#endregion

		#region Auto-update Methods

		private async void CheckForUpdate(bool promptToInstall = true)
		{
			try
			{
				lnkUpdate.Tag = "Checking";
				lnkUpdate.Text = "Checking for update...";

				var latestRelease = await Updater.GetLatestRelease();

				if (latestRelease != null)
				{
					Version latestVersion = latestRelease.Version;
					List<GitHubAsset>? assets = latestRelease.Assets;

					switch (CurrentVersion.CompareTo(latestVersion))
					{
						case 0:
							lnkUpdate.Tag = "Latest";
							lnkUpdate.Text = "Running latest version";
							break;
						case 1:
							if (assets?.Count > 0)
							{
								lnkUpdate.Tag = "UpdateAvailable";
								lnkUpdate.Text = $"Click to download v{latestVersion}";
								if (promptToInstall && MessageBoxEx.Show(this, $"Version v{latestVersion} is avaible. Download and install now?",
									"New Version Available", MessageBoxButtons.YesNo) == DialogResult.Yes)
								{
									DownloadAndInstallUpdate(assets);
								}
							}
							break;
						case -1:
							lnkUpdate.Tag = "Unknown";
							lnkUpdate.Text = "Check for Update";
							break;
					}
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		private async void DownloadAndInstallUpdate(List<GitHubAsset> assets)
		{
			try
			{
				// Download and run installer
				if (await Updater.DownloadAssets(assets, true))
				{
					// Close app
					Close();
				}
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex.ToString());
			}
		}

		#endregion

	}
}