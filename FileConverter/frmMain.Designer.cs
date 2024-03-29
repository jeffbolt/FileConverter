﻿namespace FileConverter
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
			this.lnkUpdate = new System.Windows.Forms.LinkLabel();
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
			this.lblImageBrowse = new System.Windows.Forms.Label();
			this.tabDocuments = new System.Windows.Forms.TabPage();
			this.btnDocumentSaveAs = new System.Windows.Forms.Button();
			this.gbDocumentInfo = new System.Windows.Forms.GroupBox();
			this.pbDocumentIcon = new System.Windows.Forms.PictureBox();
			this.lblDocumentName = new System.Windows.Forms.Label();
			this.lblDocumentNameTitle = new System.Windows.Forms.Label();
			this.lblDocumentSize = new System.Windows.Forms.Label();
			this.lblDocumentSizeTitle = new System.Windows.Forms.Label();
			this.lblDocumentType = new System.Windows.Forms.Label();
			this.lblDocumentTypeTitle = new System.Windows.Forms.Label();
			this.btnDocumentBrowse = new System.Windows.Forms.Button();
			this.txtDocumentPath = new System.Windows.Forms.TextBox();
			this.lblBrowseDocument = new System.Windows.Forms.Label();
			this.ssMain = new System.Windows.Forms.StatusStrip();
			this.sslStatus = new System.Windows.Forms.ToolStripStatusLabel();
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
			this.tabDocuments.SuspendLayout();
			this.gbDocumentInfo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDocumentIcon)).BeginInit();
			this.ssMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlTop
			// 
			this.pnlTop.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pnlTop.BackColor = System.Drawing.Color.Transparent;
			this.pnlTop.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlTop.BackgroundImage")));
			this.pnlTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pnlTop.Controls.Add(this.lnkUpdate);
			this.pnlTop.Controls.Add(this.pbTitle);
			this.pnlTop.Controls.Add(this.lblVersion);
			this.pnlTop.Controls.Add(this.lblTitle);
			this.pnlTop.Location = new System.Drawing.Point(0, 0);
			this.pnlTop.Name = "pnlTop";
			this.pnlTop.Size = new System.Drawing.Size(584, 60);
			this.pnlTop.TabIndex = 2;
			// 
			// lnkUpdate
			// 
			this.lnkUpdate.ActiveLinkColor = System.Drawing.Color.Lime;
			this.lnkUpdate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkUpdate.LinkColor = System.Drawing.Color.Lime;
			this.lnkUpdate.Location = new System.Drawing.Point(51, 36);
			this.lnkUpdate.Name = "lnkUpdate";
			this.lnkUpdate.Size = new System.Drawing.Size(516, 15);
			this.lnkUpdate.TabIndex = 13;
			this.lnkUpdate.TextAlign = System.Drawing.ContentAlignment.TopRight;
			this.lnkUpdate.VisitedLinkColor = System.Drawing.Color.Lime;
			this.lnkUpdate.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkUpdate_LinkClicked);
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
			this.lblVersion.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
			this.tcMain.Controls.Add(this.tabDocuments);
			this.tcMain.Location = new System.Drawing.Point(12, 65);
			this.tcMain.Name = "tcMain";
			this.tcMain.SelectedIndex = 0;
			this.tcMain.Size = new System.Drawing.Size(560, 266);
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
			this.tabBinary.Size = new System.Drawing.Size(552, 238);
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
			this.btnBinaryFileCopyClipboard.Size = new System.Drawing.Size(120, 23);
			this.btnBinaryFileCopyClipboard.TabIndex = 3;
			this.btnBinaryFileCopyClipboard.Tag = "";
			this.btnBinaryFileCopyClipboard.Text = "Copy as Binary";
			this.btnBinaryFileCopyClipboard.UseVisualStyleBackColor = true;
			this.btnBinaryFileCopyClipboard.Click += new System.EventHandler(this.btnBinaryFileCopyClipboard_Click);
			// 
			// btnSaveBinaryFileAs
			// 
			this.btnSaveBinaryFileAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnSaveBinaryFileAs.Enabled = false;
			this.btnSaveBinaryFileAs.Location = new System.Drawing.Point(142, 201);
			this.btnSaveBinaryFileAs.Name = "btnSaveBinaryFileAs";
			this.btnSaveBinaryFileAs.Size = new System.Drawing.Size(120, 23);
			this.btnSaveBinaryFileAs.TabIndex = 4;
			this.btnSaveBinaryFileAs.Tag = "";
			this.btnSaveBinaryFileAs.Text = "Save Binary as...";
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
			this.grpBinaryFileInfo.Size = new System.Drawing.Size(520, 135);
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
			this.lblBinaryFileName.Size = new System.Drawing.Size(415, 15);
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
			this.lblBinaryFileSize.Size = new System.Drawing.Size(415, 15);
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
			this.lblBinaryFileType.Size = new System.Drawing.Size(398, 15);
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
			this.btnBinaryFileBrowse.Location = new System.Drawing.Point(461, 31);
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
			this.txtBinaryFilePath.Size = new System.Drawing.Size(439, 23);
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
			this.tabImage.Controls.Add(this.lblImageBrowse);
			this.tabImage.Location = new System.Drawing.Point(4, 24);
			this.tabImage.Name = "tabImage";
			this.tabImage.Padding = new System.Windows.Forms.Padding(3);
			this.tabImage.Size = new System.Drawing.Size(552, 238);
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
			this.btnImageFileSaveAs.Location = new System.Drawing.Point(142, 201);
			this.btnImageFileSaveAs.Name = "btnImageFileSaveAs";
			this.btnImageFileSaveAs.Size = new System.Drawing.Size(120, 23);
			this.btnImageFileSaveAs.TabIndex = 7;
			this.btnImageFileSaveAs.Tag = "";
			this.btnImageFileSaveAs.Text = "Save Image as...";
			this.btnImageFileSaveAs.UseVisualStyleBackColor = true;
			this.btnImageFileSaveAs.Click += new System.EventHandler(this.btnImageFileSaveAs_Click);
			// 
			// btnImageFileCopyClipboard
			// 
			this.btnImageFileCopyClipboard.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnImageFileCopyClipboard.Enabled = false;
			this.btnImageFileCopyClipboard.Location = new System.Drawing.Point(16, 201);
			this.btnImageFileCopyClipboard.Name = "btnImageFileCopyClipboard";
			this.btnImageFileCopyClipboard.Size = new System.Drawing.Size(120, 23);
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
			this.gbImageFileInfo.Size = new System.Drawing.Size(520, 135);
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
			this.pbImageFilePreview.Size = new System.Drawing.Size(102, 100);
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
			this.lblImageFileName.Size = new System.Drawing.Size(309, 15);
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
			this.lblImageFileSize.Size = new System.Drawing.Size(309, 15);
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
			this.lblImageFileType.Size = new System.Drawing.Size(292, 15);
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
			this.btnImageFileBrowse.Location = new System.Drawing.Point(461, 31);
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
			this.txtImageFilePath.Size = new System.Drawing.Size(439, 23);
			this.txtImageFilePath.TabIndex = 4;
			this.txtImageFilePath.TextChanged += new System.EventHandler(this.txtImageFilePath_TextChanged);
			// 
			// lblImageBrowse
			// 
			this.lblImageBrowse.AutoSize = true;
			this.lblImageBrowse.Location = new System.Drawing.Point(16, 13);
			this.lblImageBrowse.Name = "lblImageBrowse";
			this.lblImageBrowse.Size = new System.Drawing.Size(163, 15);
			this.lblImageBrowse.TabIndex = 7;
			this.lblImageBrowse.Text = "Drag or browse for image file:";
			// 
			// tabDocuments
			// 
			this.tabDocuments.AllowDrop = true;
			this.tabDocuments.Controls.Add(this.btnDocumentSaveAs);
			this.tabDocuments.Controls.Add(this.gbDocumentInfo);
			this.tabDocuments.Controls.Add(this.btnDocumentBrowse);
			this.tabDocuments.Controls.Add(this.txtDocumentPath);
			this.tabDocuments.Controls.Add(this.lblBrowseDocument);
			this.tabDocuments.Location = new System.Drawing.Point(4, 24);
			this.tabDocuments.Name = "tabDocuments";
			this.tabDocuments.Padding = new System.Windows.Forms.Padding(3);
			this.tabDocuments.Size = new System.Drawing.Size(552, 238);
			this.tabDocuments.TabIndex = 2;
			this.tabDocuments.Text = "Document Conversion";
			this.tabDocuments.UseVisualStyleBackColor = true;
			this.tabDocuments.DragDrop += new System.Windows.Forms.DragEventHandler(this.tabDocuments_DragDrop);
			this.tabDocuments.DragEnter += new System.Windows.Forms.DragEventHandler(this.tabDocuments_DragEnter);
			// 
			// btnDocumentSaveAs
			// 
			this.btnDocumentSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDocumentSaveAs.Enabled = false;
			this.btnDocumentSaveAs.Location = new System.Drawing.Point(16, 201);
			this.btnDocumentSaveAs.Name = "btnDocumentSaveAs";
			this.btnDocumentSaveAs.Size = new System.Drawing.Size(120, 23);
			this.btnDocumentSaveAs.TabIndex = 12;
			this.btnDocumentSaveAs.Tag = "";
			this.btnDocumentSaveAs.Text = "Save as...";
			this.btnDocumentSaveAs.UseVisualStyleBackColor = true;
			this.btnDocumentSaveAs.Click += new System.EventHandler(this.btnDocumentSaveAs_Click);
			// 
			// gbDocumentInfo
			// 
			this.gbDocumentInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.gbDocumentInfo.Controls.Add(this.pbDocumentIcon);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentName);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentNameTitle);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentSize);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentSizeTitle);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentType);
			this.gbDocumentInfo.Controls.Add(this.lblDocumentTypeTitle);
			this.gbDocumentInfo.Location = new System.Drawing.Point(16, 60);
			this.gbDocumentInfo.Name = "gbDocumentInfo";
			this.gbDocumentInfo.Size = new System.Drawing.Size(520, 135);
			this.gbDocumentInfo.TabIndex = 11;
			this.gbDocumentInfo.TabStop = false;
			this.gbDocumentInfo.Text = "File Information";
			// 
			// pbDocumentIcon
			// 
			this.pbDocumentIcon.Location = new System.Drawing.Point(99, 34);
			this.pbDocumentIcon.Name = "pbDocumentIcon";
			this.pbDocumentIcon.Size = new System.Drawing.Size(16, 16);
			this.pbDocumentIcon.TabIndex = 11;
			this.pbDocumentIcon.TabStop = false;
			// 
			// lblDocumentName
			// 
			this.lblDocumentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDocumentName.AutoEllipsis = true;
			this.lblDocumentName.Location = new System.Drawing.Point(99, 19);
			this.lblDocumentName.Name = "lblDocumentName";
			this.lblDocumentName.Size = new System.Drawing.Size(415, 15);
			this.lblDocumentName.TabIndex = 10;
			this.lblDocumentName.Text = "[file name]";
			// 
			// lblDocumentNameTitle
			// 
			this.lblDocumentNameTitle.AutoSize = true;
			this.lblDocumentNameTitle.Location = new System.Drawing.Point(6, 19);
			this.lblDocumentNameTitle.Name = "lblDocumentNameTitle";
			this.lblDocumentNameTitle.Size = new System.Drawing.Size(63, 15);
			this.lblDocumentNameTitle.TabIndex = 9;
			this.lblDocumentNameTitle.Text = "File Name:";
			// 
			// lblDocumentSize
			// 
			this.lblDocumentSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDocumentSize.AutoEllipsis = true;
			this.lblDocumentSize.Location = new System.Drawing.Point(99, 49);
			this.lblDocumentSize.Name = "lblDocumentSize";
			this.lblDocumentSize.Size = new System.Drawing.Size(415, 15);
			this.lblDocumentSize.TabIndex = 8;
			this.lblDocumentSize.Text = "[file size]";
			// 
			// lblDocumentSizeTitle
			// 
			this.lblDocumentSizeTitle.AutoSize = true;
			this.lblDocumentSizeTitle.Location = new System.Drawing.Point(6, 49);
			this.lblDocumentSizeTitle.Name = "lblDocumentSizeTitle";
			this.lblDocumentSizeTitle.Size = new System.Drawing.Size(30, 15);
			this.lblDocumentSizeTitle.TabIndex = 7;
			this.lblDocumentSizeTitle.Text = "Size:";
			// 
			// lblDocumentType
			// 
			this.lblDocumentType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblDocumentType.AutoEllipsis = true;
			this.lblDocumentType.Location = new System.Drawing.Point(116, 34);
			this.lblDocumentType.Name = "lblDocumentType";
			this.lblDocumentType.Size = new System.Drawing.Size(398, 15);
			this.lblDocumentType.TabIndex = 6;
			this.lblDocumentType.Text = "[file type]";
			// 
			// lblDocumentTypeTitle
			// 
			this.lblDocumentTypeTitle.AutoSize = true;
			this.lblDocumentTypeTitle.Location = new System.Drawing.Point(6, 34);
			this.lblDocumentTypeTitle.Name = "lblDocumentTypeTitle";
			this.lblDocumentTypeTitle.Size = new System.Drawing.Size(55, 15);
			this.lblDocumentTypeTitle.TabIndex = 5;
			this.lblDocumentTypeTitle.Text = "File Type:";
			// 
			// btnDocumentBrowse
			// 
			this.btnDocumentBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnDocumentBrowse.Location = new System.Drawing.Point(461, 31);
			this.btnDocumentBrowse.Name = "btnDocumentBrowse";
			this.btnDocumentBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnDocumentBrowse.TabIndex = 10;
			this.btnDocumentBrowse.Text = "Browse...";
			this.btnDocumentBrowse.UseVisualStyleBackColor = true;
			this.btnDocumentBrowse.Click += new System.EventHandler(this.btnDocumentBrowse_Click);
			// 
			// txtDocumentPath
			// 
			this.txtDocumentPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtDocumentPath.Location = new System.Drawing.Point(16, 31);
			this.txtDocumentPath.Name = "txtDocumentPath";
			this.txtDocumentPath.Size = new System.Drawing.Size(439, 23);
			this.txtDocumentPath.TabIndex = 9;
			this.txtDocumentPath.TextChanged += new System.EventHandler(this.txtDocumentPath_TextChanged);
			// 
			// lblBrowseDocument
			// 
			this.lblBrowseDocument.AutoSize = true;
			this.lblBrowseDocument.Location = new System.Drawing.Point(16, 13);
			this.lblBrowseDocument.Name = "lblBrowseDocument";
			this.lblBrowseDocument.Size = new System.Drawing.Size(166, 15);
			this.lblBrowseDocument.TabIndex = 8;
			this.lblBrowseDocument.Text = "Drag or browse for document:";
			// 
			// ssMain
			// 
			this.ssMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sslStatus});
			this.ssMain.Location = new System.Drawing.Point(0, 319);
			this.ssMain.Name = "ssMain";
			this.ssMain.Size = new System.Drawing.Size(584, 22);
			this.ssMain.TabIndex = 3;
			this.ssMain.Text = "statusStrip1";
			// 
			// sslStatus
			// 
			this.sslStatus.Name = "sslStatus";
			this.sslStatus.Size = new System.Drawing.Size(0, 17);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(584, 341);
			this.Controls.Add(this.ssMain);
			this.Controls.Add(this.tcMain);
			this.Controls.Add(this.pnlTop);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
			this.tabDocuments.ResumeLayout(false);
			this.tabDocuments.PerformLayout();
			this.gbDocumentInfo.ResumeLayout(false);
			this.gbDocumentInfo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbDocumentIcon)).EndInit();
			this.ssMain.ResumeLayout(false);
			this.ssMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

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
	}
}