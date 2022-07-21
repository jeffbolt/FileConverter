using System.Reflection;

using PInvoke;

using static PInvoke.Shell32;

namespace FileConverter
{
	public partial class frmMain : Form
	{
		private const string SupportedImageFileTypes = "*.bmp;*.jpg;*.jpeg;*.png;*.gif";
		private List<string> ImageFileTypes = new(SupportedImageFileTypes.Replace("*", "").Split(';'));

		private bool IsSupportedImageFile(string filename)
		{
			foreach(string imageFileType in ImageFileTypes)
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
			lblVersion.Text = $"v{AssemblyHelper.GetAssemblyVersion()}";
			ResetBinaryFileInfo();
			ResetImageFileInfo();
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
		}

		private void EnableBinaryFileButtons(bool enable)
		{
			btnBinaryFileBrowse.Enabled = enable;
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
				lblBinaryFileSize.Text = fileInfo.GetFileSizeSuffix(2);
				try
				{
					using Icon fileIcon = fileInfo.GetIcon(true);
					pbBinaryFileIcon.Image = fileIcon.ToBitmap();
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.ToString());
				}
			}
			else
			{
				ResetImageFileInfo();
			}
		}

		private void CopyBinaryFileToClipboard()
		{
			try
			{
				EnableBinaryFileButtons(false);
				var fileInfo = new FileInfo(txtBinaryFilePath.Text);
				string contents = fileInfo.ConvertToBinary();
				Clipboard.SetText(contents);
				MessageBox.Show("Binary file contents copied.", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), $"Error - {MethodBase.GetCurrentMethod()?.Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				EnableBinaryFileButtons(true);
			}
		}

		private void SaveBinaryFileAs()
		{
			try
			{
				EnableBinaryFileButtons(false);
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
						InitialDirectory = fileInfo.Directory?.FullName,
						RestoreDirectory = true,
						CheckPathExists = true
					};
					if (dialog.ShowDialog() == DialogResult.OK)
						fileInfo.SaveAsBinary(dialog.FileName);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), $"Error - {MethodBase.GetCurrentMethod()?.Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				EnableBinaryFileButtons(true);
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
		}

		private void EnableImageFileButtons(bool enable)
		{
			btnImageFileBrowse.Enabled = enable;
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
				lblImageFileSize.Text = fileInfo.GetFileSizeSuffix(2);
				try
				{
					using Icon fileIcon = fileInfo.GetIcon(true);
					pbImageFileIcon.Image = fileIcon.ToBitmap();
				}
				catch (Exception ex)
				{
					System.Diagnostics.Debug.WriteLine(ex.ToString());
				}

				pbImageFilePreview.Image = new Bitmap(filePath);
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
				EnableImageFileButtons(false);
				var fileInfo = new FileInfo(txtImageFilePath.Text);
				string contents = fileInfo.ConvertToBase64();
				Clipboard.SetText(contents);
				MessageBox.Show("Image file contents copied as Base-64.", "Copy to Clipboard", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), $"Error - {MethodBase.GetCurrentMethod().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				EnableImageFileButtons(true);
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
			//	MessageBox.Show(ex.ToString(), $"Error - {MethodBase.GetCurrentMethod().Name}", MessageBoxButtons.OK, MessageBoxIcon.Error);
			//}
			//finally
			//{
			//	EnableImageFileButtons(true);
			//}
		}

		#endregion

	}
}