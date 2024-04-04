namespace FileConverter
{
	partial class frmMain
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			pnlTop = new Panel();
			lnkUpdate = new LinkLabel();
			pbTitle = new PictureBox();
			lblVersion = new Label();
			lblTitle = new Label();
			tcMain = new TabControl();
			tabBinary = new TabPage();
			btnBinaryFileCopyClipboard = new Button();
			btnSaveBinaryFileAs = new Button();
			grpBinaryFileInfo = new GroupBox();
			pbBinaryFileIcon = new PictureBox();
			lblBinaryFileName = new Label();
			lblBinaryFileNameTitle = new Label();
			lblBinaryFileSize = new Label();
			lblBinaryFileSizeTitle = new Label();
			lblBinaryFileType = new Label();
			lblBinaryFileTypeTitle = new Label();
			btnBinaryFileBrowse = new Button();
			txtBinaryFilePath = new TextBox();
			lblBinaryBrowse = new Label();
			tabImage = new TabPage();
			btnImageFileSaveAs = new Button();
			btnImageFileCopyClipboard = new Button();
			gbImageFileInfo = new GroupBox();
			pbImageFileIcon = new PictureBox();
			pbImageFilePreview = new PictureBox();
			lblImageFileName = new Label();
			lblImageFileNameTitle = new Label();
			lblImageFileSize = new Label();
			lblImageFileSizeTitle = new Label();
			lblImageFileType = new Label();
			lblImageFileTypeTitle = new Label();
			btnImageFileBrowse = new Button();
			txtImageFilePath = new TextBox();
			lblImageBrowse = new Label();
			tabDocuments = new TabPage();
			btnDocumentSaveAs = new Button();
			gbDocumentInfo = new GroupBox();
			pbDocumentIcon = new PictureBox();
			lblDocumentName = new Label();
			lblDocumentNameTitle = new Label();
			lblDocumentSize = new Label();
			lblDocumentSizeTitle = new Label();
			lblDocumentType = new Label();
			lblDocumentTypeTitle = new Label();
			btnDocumentBrowse = new Button();
			txtDocumentPath = new TextBox();
			lblBrowseDocument = new Label();
			ssMain = new StatusStrip();
			sslStatus = new ToolStripStatusLabel();
			ttUpdate = new ToolTip(components);
			pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbTitle).BeginInit();
			tcMain.SuspendLayout();
			tabBinary.SuspendLayout();
			grpBinaryFileInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbBinaryFileIcon).BeginInit();
			tabImage.SuspendLayout();
			gbImageFileInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbImageFileIcon).BeginInit();
			((System.ComponentModel.ISupportInitialize)pbImageFilePreview).BeginInit();
			tabDocuments.SuspendLayout();
			gbDocumentInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)pbDocumentIcon).BeginInit();
			ssMain.SuspendLayout();
			SuspendLayout();
			// 
			// pnlTop
			// 
			pnlTop.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			pnlTop.BackColor = Color.Transparent;
			pnlTop.BackgroundImage = (Image)resources.GetObject("pnlTop.BackgroundImage");
			pnlTop.BorderStyle = BorderStyle.FixedSingle;
			pnlTop.Controls.Add(lnkUpdate);
			pnlTop.Controls.Add(pbTitle);
			pnlTop.Controls.Add(lblVersion);
			pnlTop.Controls.Add(lblTitle);
			pnlTop.Location = new Point(0, 0);
			pnlTop.Name = "pnlTop";
			pnlTop.Size = new Size(584, 60);
			pnlTop.TabIndex = 2;
			// 
			// lnkUpdate
			// 
			lnkUpdate.ActiveLinkColor = Color.Lime;
			lnkUpdate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lnkUpdate.LinkColor = Color.Lime;
			lnkUpdate.Location = new Point(51, 36);
			lnkUpdate.Name = "lnkUpdate";
			lnkUpdate.Size = new Size(516, 15);
			lnkUpdate.TabIndex = 13;
			lnkUpdate.TextAlign = ContentAlignment.TopRight;
			ttUpdate.SetToolTip(lnkUpdate, "Click to check if new version is available.");
			lnkUpdate.VisitedLinkColor = Color.Lime;
			lnkUpdate.LinkClicked += lnkUpdate_LinkClicked;
			// 
			// pbTitle
			// 
			pbTitle.ErrorImage = null;
			pbTitle.Image = Properties.Resources.App;
			pbTitle.Location = new Point(11, 8);
			pbTitle.Name = "pbTitle";
			pbTitle.Size = new Size(34, 37);
			pbTitle.SizeMode = PictureBoxSizeMode.Zoom;
			pbTitle.TabIndex = 12;
			pbTitle.TabStop = false;
			// 
			// lblVersion
			// 
			lblVersion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			lblVersion.AutoSize = true;
			lblVersion.BackColor = Color.Transparent;
			lblVersion.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
			lblVersion.ForeColor = Color.White;
			lblVersion.Location = new Point(516, 19);
			lblVersion.Name = "lblVersion";
			lblVersion.RightToLeft = RightToLeft.Yes;
			lblVersion.Size = new Size(51, 17);
			lblVersion.TabIndex = 11;
			lblVersion.Text = "v0.0.0.0";
			lblVersion.TextAlign = ContentAlignment.TopRight;
			// 
			// lblTitle
			// 
			lblTitle.AutoSize = true;
			lblTitle.BackColor = Color.Transparent;
			lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
			lblTitle.ForeColor = Color.White;
			lblTitle.Location = new Point(51, 8);
			lblTitle.Name = "lblTitle";
			lblTitle.Size = new Size(174, 32);
			lblTitle.TabIndex = 1;
			lblTitle.Text = "File Converter";
			// 
			// tcMain
			// 
			tcMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			tcMain.Controls.Add(tabBinary);
			tcMain.Controls.Add(tabImage);
			tcMain.Controls.Add(tabDocuments);
			tcMain.Location = new Point(12, 65);
			tcMain.Name = "tcMain";
			tcMain.SelectedIndex = 0;
			tcMain.Size = new Size(560, 266);
			tcMain.TabIndex = 1;
			// 
			// tabBinary
			// 
			tabBinary.AllowDrop = true;
			tabBinary.Controls.Add(btnBinaryFileCopyClipboard);
			tabBinary.Controls.Add(btnSaveBinaryFileAs);
			tabBinary.Controls.Add(grpBinaryFileInfo);
			tabBinary.Controls.Add(btnBinaryFileBrowse);
			tabBinary.Controls.Add(txtBinaryFilePath);
			tabBinary.Controls.Add(lblBinaryBrowse);
			tabBinary.Location = new Point(4, 24);
			tabBinary.Name = "tabBinary";
			tabBinary.Padding = new Padding(3);
			tabBinary.Size = new Size(552, 238);
			tabBinary.TabIndex = 0;
			tabBinary.Text = "Binary Conversion";
			tabBinary.UseVisualStyleBackColor = true;
			tabBinary.DragDrop += tabBinary_DragDrop;
			tabBinary.DragEnter += tabBinary_DragEnter;
			// 
			// btnBinaryFileCopyClipboard
			// 
			btnBinaryFileCopyClipboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnBinaryFileCopyClipboard.Enabled = false;
			btnBinaryFileCopyClipboard.Location = new Point(16, 201);
			btnBinaryFileCopyClipboard.Name = "btnBinaryFileCopyClipboard";
			btnBinaryFileCopyClipboard.Size = new Size(120, 23);
			btnBinaryFileCopyClipboard.TabIndex = 3;
			btnBinaryFileCopyClipboard.Tag = "";
			btnBinaryFileCopyClipboard.Text = "Copy as Binary";
			btnBinaryFileCopyClipboard.UseVisualStyleBackColor = true;
			btnBinaryFileCopyClipboard.Click += btnBinaryFileCopyClipboard_Click;
			// 
			// btnSaveBinaryFileAs
			// 
			btnSaveBinaryFileAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnSaveBinaryFileAs.Enabled = false;
			btnSaveBinaryFileAs.Location = new Point(142, 201);
			btnSaveBinaryFileAs.Name = "btnSaveBinaryFileAs";
			btnSaveBinaryFileAs.Size = new Size(120, 23);
			btnSaveBinaryFileAs.TabIndex = 4;
			btnSaveBinaryFileAs.Tag = "";
			btnSaveBinaryFileAs.Text = "Save Binary as...";
			btnSaveBinaryFileAs.UseVisualStyleBackColor = true;
			btnSaveBinaryFileAs.Click += btnSaveBinaryFileAs_Click;
			// 
			// grpBinaryFileInfo
			// 
			grpBinaryFileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			grpBinaryFileInfo.Controls.Add(pbBinaryFileIcon);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileName);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileNameTitle);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileSize);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileSizeTitle);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileType);
			grpBinaryFileInfo.Controls.Add(lblBinaryFileTypeTitle);
			grpBinaryFileInfo.Location = new Point(16, 60);
			grpBinaryFileInfo.Name = "grpBinaryFileInfo";
			grpBinaryFileInfo.Size = new Size(520, 135);
			grpBinaryFileInfo.TabIndex = 7;
			grpBinaryFileInfo.TabStop = false;
			grpBinaryFileInfo.Text = "File Information";
			// 
			// pbBinaryFileIcon
			// 
			pbBinaryFileIcon.Location = new Point(99, 34);
			pbBinaryFileIcon.Name = "pbBinaryFileIcon";
			pbBinaryFileIcon.Size = new Size(16, 16);
			pbBinaryFileIcon.TabIndex = 11;
			pbBinaryFileIcon.TabStop = false;
			// 
			// lblBinaryFileName
			// 
			lblBinaryFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblBinaryFileName.AutoEllipsis = true;
			lblBinaryFileName.Location = new Point(99, 19);
			lblBinaryFileName.Name = "lblBinaryFileName";
			lblBinaryFileName.Size = new Size(415, 15);
			lblBinaryFileName.TabIndex = 10;
			lblBinaryFileName.Text = "[file name]";
			// 
			// lblBinaryFileNameTitle
			// 
			lblBinaryFileNameTitle.AutoSize = true;
			lblBinaryFileNameTitle.Location = new Point(6, 19);
			lblBinaryFileNameTitle.Name = "lblBinaryFileNameTitle";
			lblBinaryFileNameTitle.Size = new Size(63, 15);
			lblBinaryFileNameTitle.TabIndex = 9;
			lblBinaryFileNameTitle.Text = "File Name:";
			// 
			// lblBinaryFileSize
			// 
			lblBinaryFileSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblBinaryFileSize.AutoEllipsis = true;
			lblBinaryFileSize.Location = new Point(99, 49);
			lblBinaryFileSize.Name = "lblBinaryFileSize";
			lblBinaryFileSize.Size = new Size(415, 15);
			lblBinaryFileSize.TabIndex = 8;
			lblBinaryFileSize.Text = "[file size]";
			// 
			// lblBinaryFileSizeTitle
			// 
			lblBinaryFileSizeTitle.AutoSize = true;
			lblBinaryFileSizeTitle.Location = new Point(6, 49);
			lblBinaryFileSizeTitle.Name = "lblBinaryFileSizeTitle";
			lblBinaryFileSizeTitle.Size = new Size(30, 15);
			lblBinaryFileSizeTitle.TabIndex = 7;
			lblBinaryFileSizeTitle.Text = "Size:";
			// 
			// lblBinaryFileType
			// 
			lblBinaryFileType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblBinaryFileType.AutoEllipsis = true;
			lblBinaryFileType.Location = new Point(116, 34);
			lblBinaryFileType.Name = "lblBinaryFileType";
			lblBinaryFileType.Size = new Size(398, 15);
			lblBinaryFileType.TabIndex = 6;
			lblBinaryFileType.Text = "[file type]";
			// 
			// lblBinaryFileTypeTitle
			// 
			lblBinaryFileTypeTitle.AutoSize = true;
			lblBinaryFileTypeTitle.Location = new Point(6, 34);
			lblBinaryFileTypeTitle.Name = "lblBinaryFileTypeTitle";
			lblBinaryFileTypeTitle.Size = new Size(55, 15);
			lblBinaryFileTypeTitle.TabIndex = 5;
			lblBinaryFileTypeTitle.Text = "File Type:";
			// 
			// btnBinaryFileBrowse
			// 
			btnBinaryFileBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnBinaryFileBrowse.Location = new Point(461, 31);
			btnBinaryFileBrowse.Name = "btnBinaryFileBrowse";
			btnBinaryFileBrowse.Size = new Size(75, 23);
			btnBinaryFileBrowse.TabIndex = 2;
			btnBinaryFileBrowse.Text = "Browse...";
			btnBinaryFileBrowse.UseVisualStyleBackColor = true;
			btnBinaryFileBrowse.Click += btnBinaryFileBrowse_Click;
			// 
			// txtBinaryFilePath
			// 
			txtBinaryFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtBinaryFilePath.Location = new Point(16, 31);
			txtBinaryFilePath.Name = "txtBinaryFilePath";
			txtBinaryFilePath.Size = new Size(439, 23);
			txtBinaryFilePath.TabIndex = 1;
			txtBinaryFilePath.TextChanged += txtBinaryFilePath_TextChanged;
			// 
			// lblBinaryBrowse
			// 
			lblBinaryBrowse.AutoSize = true;
			lblBinaryBrowse.Location = new Point(16, 13);
			lblBinaryBrowse.Name = "lblBinaryBrowse";
			lblBinaryBrowse.Size = new Size(163, 15);
			lblBinaryBrowse.TabIndex = 4;
			lblBinaryBrowse.Text = "Drag or browse for binary file:";
			// 
			// tabImage
			// 
			tabImage.AllowDrop = true;
			tabImage.Controls.Add(btnImageFileSaveAs);
			tabImage.Controls.Add(btnImageFileCopyClipboard);
			tabImage.Controls.Add(gbImageFileInfo);
			tabImage.Controls.Add(btnImageFileBrowse);
			tabImage.Controls.Add(txtImageFilePath);
			tabImage.Controls.Add(lblImageBrowse);
			tabImage.Location = new Point(4, 24);
			tabImage.Name = "tabImage";
			tabImage.Padding = new Padding(3);
			tabImage.Size = new Size(552, 238);
			tabImage.TabIndex = 1;
			tabImage.Text = "Image Conversion";
			tabImage.UseVisualStyleBackColor = true;
			tabImage.DragDrop += tabImage_DragDrop;
			tabImage.DragEnter += tabImage_DragEnter;
			// 
			// btnImageFileSaveAs
			// 
			btnImageFileSaveAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnImageFileSaveAs.Enabled = false;
			btnImageFileSaveAs.Location = new Point(142, 201);
			btnImageFileSaveAs.Name = "btnImageFileSaveAs";
			btnImageFileSaveAs.Size = new Size(120, 23);
			btnImageFileSaveAs.TabIndex = 7;
			btnImageFileSaveAs.Tag = "";
			btnImageFileSaveAs.Text = "Save Image as...";
			btnImageFileSaveAs.UseVisualStyleBackColor = true;
			btnImageFileSaveAs.Click += btnImageFileSaveAs_Click;
			// 
			// btnImageFileCopyClipboard
			// 
			btnImageFileCopyClipboard.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnImageFileCopyClipboard.Enabled = false;
			btnImageFileCopyClipboard.Location = new Point(16, 201);
			btnImageFileCopyClipboard.Name = "btnImageFileCopyClipboard";
			btnImageFileCopyClipboard.Size = new Size(120, 23);
			btnImageFileCopyClipboard.TabIndex = 6;
			btnImageFileCopyClipboard.Tag = "";
			btnImageFileCopyClipboard.Text = "Copy as Base-64";
			btnImageFileCopyClipboard.UseVisualStyleBackColor = true;
			btnImageFileCopyClipboard.Click += btnImageFileCopyClipboard_Click;
			// 
			// gbImageFileInfo
			// 
			gbImageFileInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gbImageFileInfo.Controls.Add(pbImageFileIcon);
			gbImageFileInfo.Controls.Add(pbImageFilePreview);
			gbImageFileInfo.Controls.Add(lblImageFileName);
			gbImageFileInfo.Controls.Add(lblImageFileNameTitle);
			gbImageFileInfo.Controls.Add(lblImageFileSize);
			gbImageFileInfo.Controls.Add(lblImageFileSizeTitle);
			gbImageFileInfo.Controls.Add(lblImageFileType);
			gbImageFileInfo.Controls.Add(lblImageFileTypeTitle);
			gbImageFileInfo.Location = new Point(16, 60);
			gbImageFileInfo.Name = "gbImageFileInfo";
			gbImageFileInfo.Size = new Size(520, 135);
			gbImageFileInfo.TabIndex = 10;
			gbImageFileInfo.TabStop = false;
			gbImageFileInfo.Text = "File Information";
			// 
			// pbImageFileIcon
			// 
			pbImageFileIcon.Location = new Point(99, 34);
			pbImageFileIcon.Name = "pbImageFileIcon";
			pbImageFileIcon.Size = new Size(16, 16);
			pbImageFileIcon.TabIndex = 11;
			pbImageFileIcon.TabStop = false;
			// 
			// pbImageFilePreview
			// 
			pbImageFilePreview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			pbImageFilePreview.BorderStyle = BorderStyle.FixedSingle;
			pbImageFilePreview.Location = new Point(412, 19);
			pbImageFilePreview.Name = "pbImageFilePreview";
			pbImageFilePreview.Size = new Size(102, 100);
			pbImageFilePreview.SizeMode = PictureBoxSizeMode.Zoom;
			pbImageFilePreview.TabIndex = 11;
			pbImageFilePreview.TabStop = false;
			// 
			// lblImageFileName
			// 
			lblImageFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblImageFileName.AutoEllipsis = true;
			lblImageFileName.Location = new Point(99, 19);
			lblImageFileName.Name = "lblImageFileName";
			lblImageFileName.Size = new Size(309, 15);
			lblImageFileName.TabIndex = 10;
			lblImageFileName.Text = "[file name]";
			// 
			// lblImageFileNameTitle
			// 
			lblImageFileNameTitle.AutoSize = true;
			lblImageFileNameTitle.Location = new Point(6, 19);
			lblImageFileNameTitle.Name = "lblImageFileNameTitle";
			lblImageFileNameTitle.Size = new Size(63, 15);
			lblImageFileNameTitle.TabIndex = 9;
			lblImageFileNameTitle.Text = "File Name:";
			// 
			// lblImageFileSize
			// 
			lblImageFileSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblImageFileSize.AutoEllipsis = true;
			lblImageFileSize.Location = new Point(99, 49);
			lblImageFileSize.Name = "lblImageFileSize";
			lblImageFileSize.Size = new Size(309, 15);
			lblImageFileSize.TabIndex = 8;
			lblImageFileSize.Text = "[file size]";
			// 
			// lblImageFileSizeTitle
			// 
			lblImageFileSizeTitle.AutoSize = true;
			lblImageFileSizeTitle.Location = new Point(6, 49);
			lblImageFileSizeTitle.Name = "lblImageFileSizeTitle";
			lblImageFileSizeTitle.Size = new Size(30, 15);
			lblImageFileSizeTitle.TabIndex = 7;
			lblImageFileSizeTitle.Text = "Size:";
			// 
			// lblImageFileType
			// 
			lblImageFileType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblImageFileType.AutoEllipsis = true;
			lblImageFileType.Location = new Point(116, 34);
			lblImageFileType.Name = "lblImageFileType";
			lblImageFileType.Size = new Size(292, 15);
			lblImageFileType.TabIndex = 6;
			lblImageFileType.Text = "[file type]";
			// 
			// lblImageFileTypeTitle
			// 
			lblImageFileTypeTitle.AutoSize = true;
			lblImageFileTypeTitle.Location = new Point(6, 34);
			lblImageFileTypeTitle.Name = "lblImageFileTypeTitle";
			lblImageFileTypeTitle.Size = new Size(55, 15);
			lblImageFileTypeTitle.TabIndex = 5;
			lblImageFileTypeTitle.Text = "File Type:";
			// 
			// btnImageFileBrowse
			// 
			btnImageFileBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnImageFileBrowse.Location = new Point(461, 31);
			btnImageFileBrowse.Name = "btnImageFileBrowse";
			btnImageFileBrowse.Size = new Size(75, 23);
			btnImageFileBrowse.TabIndex = 5;
			btnImageFileBrowse.Text = "Browse...";
			btnImageFileBrowse.UseVisualStyleBackColor = true;
			btnImageFileBrowse.Click += btnImageFileBrowse_Click;
			// 
			// txtImageFilePath
			// 
			txtImageFilePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtImageFilePath.Location = new Point(16, 31);
			txtImageFilePath.Name = "txtImageFilePath";
			txtImageFilePath.Size = new Size(439, 23);
			txtImageFilePath.TabIndex = 4;
			txtImageFilePath.TextChanged += txtImageFilePath_TextChanged;
			// 
			// lblImageBrowse
			// 
			lblImageBrowse.AutoSize = true;
			lblImageBrowse.Location = new Point(16, 13);
			lblImageBrowse.Name = "lblImageBrowse";
			lblImageBrowse.Size = new Size(163, 15);
			lblImageBrowse.TabIndex = 7;
			lblImageBrowse.Text = "Drag or browse for image file:";
			// 
			// tabDocuments
			// 
			tabDocuments.AllowDrop = true;
			tabDocuments.Controls.Add(btnDocumentSaveAs);
			tabDocuments.Controls.Add(gbDocumentInfo);
			tabDocuments.Controls.Add(btnDocumentBrowse);
			tabDocuments.Controls.Add(txtDocumentPath);
			tabDocuments.Controls.Add(lblBrowseDocument);
			tabDocuments.Location = new Point(4, 24);
			tabDocuments.Name = "tabDocuments";
			tabDocuments.Padding = new Padding(3);
			tabDocuments.Size = new Size(552, 238);
			tabDocuments.TabIndex = 2;
			tabDocuments.Text = "Document Conversion";
			tabDocuments.UseVisualStyleBackColor = true;
			tabDocuments.DragDrop += tabDocuments_DragDrop;
			tabDocuments.DragEnter += tabDocuments_DragEnter;
			// 
			// btnDocumentSaveAs
			// 
			btnDocumentSaveAs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			btnDocumentSaveAs.Enabled = false;
			btnDocumentSaveAs.Location = new Point(16, 201);
			btnDocumentSaveAs.Name = "btnDocumentSaveAs";
			btnDocumentSaveAs.Size = new Size(120, 23);
			btnDocumentSaveAs.TabIndex = 12;
			btnDocumentSaveAs.Tag = "";
			btnDocumentSaveAs.Text = "Save as...";
			btnDocumentSaveAs.UseVisualStyleBackColor = true;
			btnDocumentSaveAs.Click += btnDocumentSaveAs_Click;
			// 
			// gbDocumentInfo
			// 
			gbDocumentInfo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			gbDocumentInfo.Controls.Add(pbDocumentIcon);
			gbDocumentInfo.Controls.Add(lblDocumentName);
			gbDocumentInfo.Controls.Add(lblDocumentNameTitle);
			gbDocumentInfo.Controls.Add(lblDocumentSize);
			gbDocumentInfo.Controls.Add(lblDocumentSizeTitle);
			gbDocumentInfo.Controls.Add(lblDocumentType);
			gbDocumentInfo.Controls.Add(lblDocumentTypeTitle);
			gbDocumentInfo.Location = new Point(16, 60);
			gbDocumentInfo.Name = "gbDocumentInfo";
			gbDocumentInfo.Size = new Size(520, 135);
			gbDocumentInfo.TabIndex = 11;
			gbDocumentInfo.TabStop = false;
			gbDocumentInfo.Text = "File Information";
			// 
			// pbDocumentIcon
			// 
			pbDocumentIcon.Location = new Point(99, 34);
			pbDocumentIcon.Name = "pbDocumentIcon";
			pbDocumentIcon.Size = new Size(16, 16);
			pbDocumentIcon.TabIndex = 11;
			pbDocumentIcon.TabStop = false;
			// 
			// lblDocumentName
			// 
			lblDocumentName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDocumentName.AutoEllipsis = true;
			lblDocumentName.Location = new Point(99, 19);
			lblDocumentName.Name = "lblDocumentName";
			lblDocumentName.Size = new Size(415, 15);
			lblDocumentName.TabIndex = 10;
			lblDocumentName.Text = "[file name]";
			// 
			// lblDocumentNameTitle
			// 
			lblDocumentNameTitle.AutoSize = true;
			lblDocumentNameTitle.Location = new Point(6, 19);
			lblDocumentNameTitle.Name = "lblDocumentNameTitle";
			lblDocumentNameTitle.Size = new Size(63, 15);
			lblDocumentNameTitle.TabIndex = 9;
			lblDocumentNameTitle.Text = "File Name:";
			// 
			// lblDocumentSize
			// 
			lblDocumentSize.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDocumentSize.AutoEllipsis = true;
			lblDocumentSize.Location = new Point(99, 49);
			lblDocumentSize.Name = "lblDocumentSize";
			lblDocumentSize.Size = new Size(415, 15);
			lblDocumentSize.TabIndex = 8;
			lblDocumentSize.Text = "[file size]";
			// 
			// lblDocumentSizeTitle
			// 
			lblDocumentSizeTitle.AutoSize = true;
			lblDocumentSizeTitle.Location = new Point(6, 49);
			lblDocumentSizeTitle.Name = "lblDocumentSizeTitle";
			lblDocumentSizeTitle.Size = new Size(30, 15);
			lblDocumentSizeTitle.TabIndex = 7;
			lblDocumentSizeTitle.Text = "Size:";
			// 
			// lblDocumentType
			// 
			lblDocumentType.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			lblDocumentType.AutoEllipsis = true;
			lblDocumentType.Location = new Point(116, 34);
			lblDocumentType.Name = "lblDocumentType";
			lblDocumentType.Size = new Size(398, 15);
			lblDocumentType.TabIndex = 6;
			lblDocumentType.Text = "[file type]";
			// 
			// lblDocumentTypeTitle
			// 
			lblDocumentTypeTitle.AutoSize = true;
			lblDocumentTypeTitle.Location = new Point(6, 34);
			lblDocumentTypeTitle.Name = "lblDocumentTypeTitle";
			lblDocumentTypeTitle.Size = new Size(55, 15);
			lblDocumentTypeTitle.TabIndex = 5;
			lblDocumentTypeTitle.Text = "File Type:";
			// 
			// btnDocumentBrowse
			// 
			btnDocumentBrowse.Anchor = AnchorStyles.Top | AnchorStyles.Right;
			btnDocumentBrowse.Location = new Point(461, 31);
			btnDocumentBrowse.Name = "btnDocumentBrowse";
			btnDocumentBrowse.Size = new Size(75, 23);
			btnDocumentBrowse.TabIndex = 10;
			btnDocumentBrowse.Text = "Browse...";
			btnDocumentBrowse.UseVisualStyleBackColor = true;
			btnDocumentBrowse.Click += btnDocumentBrowse_Click;
			// 
			// txtDocumentPath
			// 
			txtDocumentPath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			txtDocumentPath.Location = new Point(16, 31);
			txtDocumentPath.Name = "txtDocumentPath";
			txtDocumentPath.Size = new Size(439, 23);
			txtDocumentPath.TabIndex = 9;
			txtDocumentPath.TextChanged += txtDocumentPath_TextChanged;
			// 
			// lblBrowseDocument
			// 
			lblBrowseDocument.AutoSize = true;
			lblBrowseDocument.Location = new Point(16, 13);
			lblBrowseDocument.Name = "lblBrowseDocument";
			lblBrowseDocument.Size = new Size(166, 15);
			lblBrowseDocument.TabIndex = 8;
			lblBrowseDocument.Text = "Drag or browse for document:";
			// 
			// ssMain
			// 
			ssMain.Items.AddRange(new ToolStripItem[] { sslStatus });
			ssMain.Location = new Point(0, 319);
			ssMain.Name = "ssMain";
			ssMain.Size = new Size(584, 22);
			ssMain.TabIndex = 3;
			ssMain.Text = "statusStrip1";
			// 
			// sslStatus
			// 
			sslStatus.Name = "sslStatus";
			sslStatus.Size = new Size(0, 17);
			// 
			// ttUpdate
			// 
			ttUpdate.IsBalloon = true;
			ttUpdate.ToolTipIcon = ToolTipIcon.Info;
			ttUpdate.ToolTipTitle = "Auto-update";
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(584, 341);
			Controls.Add(ssMain);
			Controls.Add(tcMain);
			Controls.Add(pnlTop);
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "frmMain";
			SizeGripStyle = SizeGripStyle.Show;
			StartPosition = FormStartPosition.CenterScreen;
			Text = "File Converter";
			Load += frmMain_Load;
			pnlTop.ResumeLayout(false);
			pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbTitle).EndInit();
			tcMain.ResumeLayout(false);
			tabBinary.ResumeLayout(false);
			tabBinary.PerformLayout();
			grpBinaryFileInfo.ResumeLayout(false);
			grpBinaryFileInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbBinaryFileIcon).EndInit();
			tabImage.ResumeLayout(false);
			tabImage.PerformLayout();
			gbImageFileInfo.ResumeLayout(false);
			gbImageFileInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbImageFileIcon).EndInit();
			((System.ComponentModel.ISupportInitialize)pbImageFilePreview).EndInit();
			tabDocuments.ResumeLayout(false);
			tabDocuments.PerformLayout();
			gbDocumentInfo.ResumeLayout(false);
			gbDocumentInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)pbDocumentIcon).EndInit();
			ssMain.ResumeLayout(false);
			ssMain.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private Panel pnlTop;
		private Label lblTitle;
		private TabControl tcMain;
		private TabPage tabBinary;
		private TabPage tabImage;
		private Label lblBinaryBrowse;
		private Button btnBinaryFileBrowse;
		private TextBox txtBinaryFilePath;
		private GroupBox grpBinaryFileInfo;
		private Label lblBinaryFileSize;
		private Label lblBinaryFileSizeTitle;
		private Label lblBinaryFileType;
		private Label lblBinaryFileTypeTitle;
		private Label lblBinaryFileName;
		private Label lblBinaryFileNameTitle;
		private PictureBox pbBinaryFileIcon;
		private Label lblVersion;
		private Button btnBinaryFileCopyClipboard;
		private Button btnSaveBinaryFileAs;
		private Button btnImageFileBrowse;
		private TextBox txtImageFilePath;
		private Label lblImageBrowse;
		private PictureBox pbImageFilePreview;
		private GroupBox gbImageFileInfo;
		private PictureBox pbImageFileIcon;
		private Label lblImageFileName;
		private Label lblImageFileNameTitle;
		private Label lblImageFileSize;
		private Label lblImageFileSizeTitle;
		private Label lblImageFileType;
		private Label lblImageFileTypeTitle;
		private Button btnImageFileCopyClipboard;
		private Button btnImageFileSaveAs;
		private PictureBox pbTitle;
		private LinkLabel lnkUpdate;
		private StatusStrip ssMain;
		private ToolStripStatusLabel sslStatus;
		private TabPage tabDocuments;
		private Button btnDocumentSaveAs;
		private GroupBox gbDocumentInfo;
		private PictureBox pbDocumentIcon;
		private Label lblDocumentName;
		private Label lblDocumentNameTitle;
		private Label lblDocumentSize;
		private Label lblDocumentSizeTitle;
		private Label lblDocumentType;
		private Label lblDocumentTypeTitle;
		private Button btnDocumentBrowse;
		private TextBox txtDocumentPath;
		private Label lblBrowseDocument;
		private ToolTip ttUpdate;
	}
}