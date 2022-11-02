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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.pbTitle = new System.Windows.Forms.PictureBox();
			this.lblVersion = new System.Windows.Forms.Label();
			this.lblTitle = new System.Windows.Forms.Label();
			this.tcMain = new System.Windows.Forms.TabControl();
			this.tabBinary = new System.Windows.Forms.TabPage();
			this.btnBinaryFileCopyClipboard = new System.Windows.Forms.Button();
			this.btnSaveBinaryFileAs = new System.Windows.Forms.Button();
			this.grpBinaryFileInfo = new System.Windows.Forms.GroupBox();
			this.pbBinaryFileIcon = new System.Windows.Forms.PictureBox();
			this.lblBinaryFileName = new System.Windows.Forms.Label();
			this.lblBinaryFileNameTitle = new System.Windows.Forms.Label();
			this.lblBinaryFileSize = new System.Windows.Forms.Label();
			this.lblBinaryFileSizeTitle = new System.Windows.Forms.Label();
			this.lblBinaryFileType = new System.Windows.Forms.Label();
			this.lblBinaryFileTypeTitle = new System.Windows.Forms.Label();
			this.btnBinaryFileBrowse = new System.Windows.Forms.Button();
			this.txtBinaryFilePath = new System.Windows.Forms.TextBox();
			this.lblBinaryBrowse = new System.Windows.Forms.Label();
			this.tabImage = new System.Windows.Forms.TabPage();
			this.btnImageFileSaveAs = new System.Windows.Forms.Button();
			this.btnImageFileCopyClipboard = new System.Windows.Forms.Button();
			this.gbImageFileInfo = new System.Windows.Forms.GroupBox();
			this.pbImageFileIcon = new System.Windows.Forms.PictureBox();
			this.pbImageFilePreview = new System.Windows.Forms.PictureBox();
			this.lblImageFileName = new System.Windows.Forms.Label();
			this.lblImageFileNameTitle = new System.Windows.Forms.Label();
			this.lblImageFileSize = new System.Windows.Forms.Label();
			this.lblImageFileSizeTitle = new System.Windows.Forms.Label();
			this.lblImageFileType = new System.Windows.Forms.Label();
			this.lblImageFileTypeTitle = new System.Windows.Forms.Label();
			this.btnImageFileBrowse = new System.Windows.Forms.Button();
			this.txtImageFilePath = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.pnlTop.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).BeginInit();
			this.tcMain.SuspendLayout();
			this.tabBinary.SuspendLayout();
			this.grpBinaryFileInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBinaryFileIcon)).BeginInit();
			this.tabImage.SuspendLayout();
			this.gbImageFileInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImageFileIcon)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImageFilePreview)).BeginInit();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTop.BackColor = System.Drawing.Color.White;
			this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
			this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTop.Controls.Add(this.pbTitle);
			this.pnlTop.Controls.Add(this.lblVersion);
			this.pnlTop.Controls.Add(this.lblTitle);
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(584, 60);
			this.pnlTop.TabIndex = 2;
			// 
			// pbTitle
			// 
			this.pbTitle.ErrorImage = null;
			this.pbTitle.Image = global::FileConverter.Properties.Resources.App;
			this.pbTitle.Location = new System.Drawing.Point(11, 8);
			this.pbTitle.Name = "pbTitle";
			this.pbTitle.Size = new System.Drawing.Size(34, 37);
			this.pbTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbTitle.TabIndex = 12;
			this.pbTitle.TabStop = false;
			// 
			// lblVersion
			// 
			this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblVersion.AutoSize = true;
			this.lblVersion.BackColor = System.Drawing.Color.Transparent;
			this.lblVersion.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.lblVersion.ForeColor = System.Drawing.Color.White;
			this.lblVersion.Location = new System.Drawing.Point(516, 19);
			this.lblVersion.Name = "lblVersion";
			this.lblVersion.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.lblVersion.Size = new System.Drawing.Size(51, 17);
			this.lblVersion.TabIndex = 11;
			this.lblVersion.Text = "v0.0.0.0";
			// 
			// lblTitle
			// 
			this.lblTitle.AutoSize = true;
			this.lblTitle.BackColor = System.Drawing.Color.Transparent;
			this.lblTitle.Cursor = System.Windows.Forms.Cursors.Default;
			this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.lblTitle.ForeColor = System.Drawing.Color.White;
			this.lblTitle.Location = new System.Drawing.Point(51, 8);
			this.lblTitle.Name = "lblTitle";
			this.lblTitle.Size = new System.Drawing.Size(174, 32);
			this.lblTitle.TabIndex = 1;
			this.lblTitle.Text = "File Converter";
			// 
			// tcMain
			// 
			this.tcMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tcMain.Controls.Add(this.tabBinary);
			this.tcMain.Controls.Add(this.tabImage);
			this.tcMain.Location = new System.Drawing.Point(14, 65);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(558, 266);
			this.tcMain.TabIndex = 1;
			// 
			// tabBinary
			// 
			this.tabBinary.AllowDrop = true;
			this.tabBinary.Controls.Add(this.btnBinaryFileCopyClipboard);
			this.tabBinary.Controls.Add(this.btnSaveBinaryFileAs);
			this.tabBinary.Controls.Add(this.grpBinaryFileInfo);
			this.tabBinary.Controls.Add(this.btnBinaryFileBrowse);
			this.tabBinary.Controls.Add(this.txtBinaryFilePath);
			this.tabBinary.Controls.Add(this.lblBinaryBrowse);
			this.tabBinary.Location = new System.Drawing.Point(4, 24);
			this.tabBinary.Name = "tabBinary";
			this.tabBinary.Padding = new System.Windows.Forms.Padding(3);
			this.tabBinary.Size = new System.Drawing.Size(550, 238);
			this.tabBinary.TabIndex = 0;
			this.tabBinary.Text = "Binary Conversion";
			this.tabBinary.UseVisualStyleBackColor = true;
			this.tabBinary.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabBinary_DragDrop);
			this.tabBinary.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabBinary_DragEnter);
			// 
			// btnBinaryFileCopyClipboard
			// 
			this.btnBinaryFileCopyClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnBinaryFileCopyClipboard.Enabled = false;
			this.btnBinaryFileCopyClipboard.Location = new System.Drawing.Point(16, 201);
			this.btnBinaryFileCopyClipboard.Name = "btnBinaryFileCopyClipboard";
			this.btnBinaryFileCopyClipboard.Size = new System.Drawing.Size(150, 23);
			this.btnBinaryFileCopyClipboard.TabIndex = 3;
			this.btnBinaryFileCopyClipboard.Tag = "";
			this.btnBinaryFileCopyClipboard.Text = "Copy as SQL Binary";
			this.btnBinaryFileCopyClipboard.UseVisualStyleBackColor = true;
			this.btnBinaryFileCopyClipboard.Click += new System.EventHandler(this.btnBinaryFileCopyClipboard_Click);
			// 
			// btnSaveBinaryFileAs
			// 
			this.btnSaveBinaryFileAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveBinaryFileAs.Enabled = false;
			this.btnSaveBinaryFileAs.Location = new System.Drawing.Point(172, 201);
			this.btnSaveBinaryFileAs.Name = "btnSaveBinaryFileAs";
			this.btnSaveBinaryFileAs.Size = new System.Drawing.Size(100, 23);
			this.btnSaveBinaryFileAs.TabIndex = 4;
			this.btnSaveBinaryFileAs.Tag = "";
			this.btnSaveBinaryFileAs.Text = "Save As...";
			this.btnSaveBinaryFileAs.UseVisualStyleBackColor = true;
			this.btnSaveBinaryFileAs.Click += new System.EventHandler(this.btnSaveBinaryFileAs_Click);
			// 
			// grpBinaryFileInfo
			// 
			this.grpBinaryFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.grpBinaryFileInfo.Controls.Add(this.pbBinaryFileIcon);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileName);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileNameTitle);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileSize);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileSizeTitle);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileType);
			this.grpBinaryFileInfo.Controls.Add(this.lblBinaryFileTypeTitle);
			this.grpBinaryFileInfo.Location = new System.Drawing.Point(16, 60);
			this.grpBinaryFileInfo.Name = "grpBinaryFileInfo";
			this.grpBinaryFileInfo.Size = new System.Drawing.Size(518, 135);
			this.grpBinaryFileInfo.TabIndex = 7;
			this.grpBinaryFileInfo.TabStop = false;
			this.grpBinaryFileInfo.Text = "File Information";
			// 
			// pbBinaryFileIcon
			// 
			this.pbBinaryFileIcon.Location = new System.Drawing.Point(99, 34);
			this.pbBinaryFileIcon.Name = "pbBinaryFileIcon";
			this.pbBinaryFileIcon.Size = new System.Drawing.Size(16, 16);
			this.pbBinaryFileIcon.TabIndex = 11;
			this.pbBinaryFileIcon.TabStop = false;
			// 
			// lblBinaryFileName
			// 
			this.lblBinaryFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBinaryFileName.AutoEllipsis = true;
			this.lblBinaryFileName.Location = new System.Drawing.Point(99, 19);
			this.lblBinaryFileName.Name = "lblBinaryFileName";
			this.lblBinaryFileName.Size = new System.Drawing.Size(413, 15);
			this.lblBinaryFileName.TabIndex = 10;
			this.lblBinaryFileName.Text = "[file name]";
			// 
			// lblBinaryFileNameTitle
			// 
			this.lblBinaryFileNameTitle.AutoSize = true;
			this.lblBinaryFileNameTitle.Location = new System.Drawing.Point(6, 19);
			this.lblBinaryFileNameTitle.Name = "lblBinaryFileNameTitle";
			this.lblBinaryFileNameTitle.Size = new System.Drawing.Size(63, 15);
			this.lblBinaryFileNameTitle.TabIndex = 9;
			this.lblBinaryFileNameTitle.Text = "File Name:";
			// 
			// lblBinaryFileSize
			// 
			this.lblBinaryFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBinaryFileSize.AutoEllipsis = true;
			this.lblBinaryFileSize.Location = new System.Drawing.Point(99, 49);
			this.lblBinaryFileSize.Name = "lblBinaryFileSize";
			this.lblBinaryFileSize.Size = new System.Drawing.Size(413, 15);
			this.lblBinaryFileSize.TabIndex = 8;
			this.lblBinaryFileSize.Text = "[file size]";
			// 
			// lblBinaryFileSizeTitle
			// 
			this.lblBinaryFileSizeTitle.AutoSize = true;
			this.lblBinaryFileSizeTitle.Location = new System.Drawing.Point(6, 49);
			this.lblBinaryFileSizeTitle.Name = "lblBinaryFileSizeTitle";
			this.lblBinaryFileSizeTitle.Size = new System.Drawing.Size(30, 15);
			this.lblBinaryFileSizeTitle.TabIndex = 7;
			this.lblBinaryFileSizeTitle.Text = "Size:";
			// 
			// lblBinaryFileType
			// 
			this.lblBinaryFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblBinaryFileType.AutoEllipsis = true;
			this.lblBinaryFileType.Location = new System.Drawing.Point(116, 34);
			this.lblBinaryFileType.Name = "lblBinaryFileType";
			this.lblBinaryFileType.Size = new System.Drawing.Size(396, 15);
			this.lblBinaryFileType.TabIndex = 6;
			this.lblBinaryFileType.Text = "[file type]";
			// 
			// lblBinaryFileTypeTitle
			// 
			this.lblBinaryFileTypeTitle.AutoSize = true;
			this.lblBinaryFileTypeTitle.Location = new System.Drawing.Point(6, 34);
			this.lblBinaryFileTypeTitle.Name = "lblBinaryFileTypeTitle";
			this.lblBinaryFileTypeTitle.Size = new System.Drawing.Size(55, 15);
			this.lblBinaryFileTypeTitle.TabIndex = 5;
			this.lblBinaryFileTypeTitle.Text = "File Type:";
			// 
			// btnBinaryFileBrowse
			// 
			this.btnBinaryFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBinaryFileBrowse.Location = new System.Drawing.Point(459, 31);
			this.btnBinaryFileBrowse.Name = "btnBinaryFileBrowse";
			this.btnBinaryFileBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBinaryFileBrowse.TabIndex = 2;
			this.btnBinaryFileBrowse.Text = "Browse...";
			this.btnBinaryFileBrowse.UseVisualStyleBackColor = true;
			this.btnBinaryFileBrowse.Click += new System.EventHandler(this.btnBinaryFileBrowse_Click);
			// 
			// txtBinaryFilePath
			// 
			this.txtBinaryFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtBinaryFilePath.Location = new System.Drawing.Point(16, 31);
			this.txtBinaryFilePath.Name = "txtBinaryFilePath";
			this.txtBinaryFilePath.Size = new System.Drawing.Size(437, 23);
			this.txtBinaryFilePath.TabIndex = 1;
			this.txtBinaryFilePath.TextChanged += new System.EventHandler(this.txtBinaryFilePath_TextChanged);
			// 
			// lblBinaryBrowse
			// 
			this.lblBinaryBrowse.AutoSize = true;
			this.lblBinaryBrowse.Location = new System.Drawing.Point(16, 13);
			this.lblBinaryBrowse.Name = "lblBinaryBrowse";
			this.lblBinaryBrowse.Size = new System.Drawing.Size(163, 15);
			this.lblBinaryBrowse.TabIndex = 4;
			this.lblBinaryBrowse.Text = "Drag or browse for binary file:";
			// 
			// tabImage
			// 
			this.tabImage.AllowDrop = true;
			this.tabImage.Controls.Add(this.btnImageFileSaveAs);
			this.tabImage.Controls.Add(this.btnImageFileCopyClipboard);
			this.tabImage.Controls.Add(this.gbImageFileInfo);
			this.tabImage.Controls.Add(this.btnImageFileBrowse);
			this.tabImage.Controls.Add(this.txtImageFilePath);
			this.tabImage.Controls.Add(this.label1);
			this.tabImage.Location = new System.Drawing.Point(4, 24);
			this.tabImage.Name = "tabImage";
			this.tabImage.Padding = new System.Windows.Forms.Padding(3);
			this.tabImage.Size = new System.Drawing.Size(550, 238);
			this.tabImage.TabIndex = 1;
			this.tabImage.Text = "Image Conversion";
			this.tabImage.UseVisualStyleBackColor = true;
			this.tabImage.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabImage_DragDrop);
			this.tabImage.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabImage_DragEnter);
			// 
			// btnImageFileSaveAs
			// 
			this.btnImageFileSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImageFileSaveAs.Enabled = false;
			this.btnImageFileSaveAs.Location = new System.Drawing.Point(172, 201);
			this.btnImageFileSaveAs.Name = "btnImageFileSaveAs";
			this.btnImageFileSaveAs.Size = new System.Drawing.Size(100, 23);
			this.btnImageFileSaveAs.TabIndex = 7;
			this.btnImageFileSaveAs.Tag = "";
			this.btnImageFileSaveAs.Text = "Save As...";
			this.btnImageFileSaveAs.UseVisualStyleBackColor = true;
			this.btnImageFileSaveAs.Click += new System.EventHandler(this.btnImageFileSaveAs_Click);
			// 
			// btnImageFileCopyClipboard
			// 
			this.btnImageFileCopyClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImageFileCopyClipboard.Enabled = false;
			this.btnImageFileCopyClipboard.Location = new System.Drawing.Point(16, 201);
			this.btnImageFileCopyClipboard.Name = "btnImageFileCopyClipboard";
			this.btnImageFileCopyClipboard.Size = new System.Drawing.Size(150, 23);
			this.btnImageFileCopyClipboard.TabIndex = 6;
			this.btnImageFileCopyClipboard.Tag = "";
			this.btnImageFileCopyClipboard.Text = "Copy as Base-64";
			this.btnImageFileCopyClipboard.UseVisualStyleBackColor = true;
			this.btnImageFileCopyClipboard.Click += new System.EventHandler(this.btnImageFileCopyClipboard_Click);
			// 
			// gbImageFileInfo
			// 
			this.gbImageFileInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbImageFileInfo.Controls.Add(this.pbImageFileIcon);
			this.gbImageFileInfo.Controls.Add(this.pbImageFilePreview);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileName);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileNameTitle);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileSize);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileSizeTitle);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileType);
			this.gbImageFileInfo.Controls.Add(this.lblImageFileTypeTitle);
			this.gbImageFileInfo.Location = new System.Drawing.Point(16, 60);
			this.gbImageFileInfo.Name = "gbImageFileInfo";
			this.gbImageFileInfo.Size = new System.Drawing.Size(518, 135);
			this.gbImageFileInfo.TabIndex = 10;
			this.gbImageFileInfo.TabStop = false;
			this.gbImageFileInfo.Text = "File Information";
			// 
			// pbImageFileIcon
			// 
			this.pbImageFileIcon.Location = new System.Drawing.Point(99, 34);
			this.pbImageFileIcon.Name = "pbImageFileIcon";
			this.pbImageFileIcon.Size = new System.Drawing.Size(16, 16);
			this.pbImageFileIcon.TabIndex = 11;
			this.pbImageFileIcon.TabStop = false;
			// 
			// pbImageFilePreview
			// 
			this.pbImageFilePreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pbImageFilePreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pbImageFilePreview.Location = new System.Drawing.Point(412, 19);
			this.pbImageFilePreview.Name = "pbImageFilePreview";
			this.pbImageFilePreview.Size = new System.Drawing.Size(100, 100);
			this.pbImageFilePreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pbImageFilePreview.TabIndex = 11;
			this.pbImageFilePreview.TabStop = false;
			// 
			// lblImageFileName
			// 
			this.lblImageFileName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImageFileName.AutoEllipsis = true;
			this.lblImageFileName.Location = new System.Drawing.Point(99, 19);
			this.lblImageFileName.Name = "lblImageFileName";
			this.lblImageFileName.Size = new System.Drawing.Size(307, 15);
			this.lblImageFileName.TabIndex = 10;
			this.lblImageFileName.Text = "[file name]";
			// 
			// lblImageFileNameTitle
			// 
			this.lblImageFileNameTitle.AutoSize = true;
			this.lblImageFileNameTitle.Location = new System.Drawing.Point(6, 19);
			this.lblImageFileNameTitle.Name = "lblImageFileNameTitle";
			this.lblImageFileNameTitle.Size = new System.Drawing.Size(63, 15);
			this.lblImageFileNameTitle.TabIndex = 9;
			this.lblImageFileNameTitle.Text = "File Name:";
			// 
			// lblImageFileSize
			// 
			this.lblImageFileSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImageFileSize.AutoEllipsis = true;
			this.lblImageFileSize.Location = new System.Drawing.Point(99, 49);
			this.lblImageFileSize.Name = "lblImageFileSize";
			this.lblImageFileSize.Size = new System.Drawing.Size(307, 15);
			this.lblImageFileSize.TabIndex = 8;
			this.lblImageFileSize.Text = "[file size]";
			// 
			// lblImageFileSizeTitle
			// 
			this.lblImageFileSizeTitle.AutoSize = true;
			this.lblImageFileSizeTitle.Location = new System.Drawing.Point(6, 49);
			this.lblImageFileSizeTitle.Name = "lblImageFileSizeTitle";
			this.lblImageFileSizeTitle.Size = new System.Drawing.Size(30, 15);
			this.lblImageFileSizeTitle.TabIndex = 7;
			this.lblImageFileSizeTitle.Text = "Size:";
			// 
			// lblImageFileType
			// 
			this.lblImageFileType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblImageFileType.AutoEllipsis = true;
			this.lblImageFileType.Location = new System.Drawing.Point(116, 34);
			this.lblImageFileType.Name = "lblImageFileType";
			this.lblImageFileType.Size = new System.Drawing.Size(290, 15);
			this.lblImageFileType.TabIndex = 6;
			this.lblImageFileType.Text = "[file type]";
			// 
			// lblImageFileTypeTitle
			// 
			this.lblImageFileTypeTitle.AutoSize = true;
			this.lblImageFileTypeTitle.Location = new System.Drawing.Point(6, 34);
			this.lblImageFileTypeTitle.Name = "lblImageFileTypeTitle";
			this.lblImageFileTypeTitle.Size = new System.Drawing.Size(55, 15);
			this.lblImageFileTypeTitle.TabIndex = 5;
			this.lblImageFileTypeTitle.Text = "File Type:";
			// 
			// btnImageFileBrowse
			// 
			this.btnImageFileBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnImageFileBrowse.Location = new System.Drawing.Point(459, 31);
			this.btnImageFileBrowse.Name = "btnImageFileBrowse";
			this.btnImageFileBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnImageFileBrowse.TabIndex = 5;
			this.btnImageFileBrowse.Text = "Browse...";
			this.btnImageFileBrowse.UseVisualStyleBackColor = true;
			this.btnImageFileBrowse.Click += new System.EventHandler(this.btnImageFileBrowse_Click);
			// 
			// txtImageFilePath
			// 
			this.txtImageFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtImageFilePath.Location = new System.Drawing.Point(16, 31);
			this.txtImageFilePath.Name = "txtImageFilePath";
			this.txtImageFilePath.Size = new System.Drawing.Size(437, 23);
			this.txtImageFilePath.TabIndex = 4;
			this.txtImageFilePath.TextChanged += new System.EventHandler(this.txtImageFilePath_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(163, 15);
			this.label1.TabIndex = 7;
			this.label1.Text = "Drag or browse for image file:";
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 341);
			this.Controls.Add(this.tcMain);
			this.Controls.Add(this.pnlTop);
			this.Name = "frmMain";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "File Converter";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlTop.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbTitle)).EndInit();
			this.tcMain.ResumeLayout(false);
			this.tabBinary.ResumeLayout(false);
			this.tabBinary.PerformLayout();
			this.grpBinaryFileInfo.ResumeLayout(false);
			this.grpBinaryFileInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbBinaryFileIcon)).EndInit();
			this.tabImage.ResumeLayout(false);
			this.tabImage.PerformLayout();
			this.gbImageFileInfo.ResumeLayout(false);
			this.gbImageFileInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbImageFileIcon)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbImageFilePreview)).EndInit();
			this.ResumeLayout(false);

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
		private Label label1;
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
	}
}