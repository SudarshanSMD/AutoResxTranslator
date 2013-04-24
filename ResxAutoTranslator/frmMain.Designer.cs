﻿namespace ResxAutoTranslator
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
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
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("hellooooo");
			System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("Hiiiiiiiiiiiii");
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.tabMain = new System.Windows.Forms.TabControl();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.txtSrc = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.cmbDesc = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmbSrc = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.txtDesc = new System.Windows.Forms.TextBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.tabResx = new System.Windows.Forms.TabPage();
			this.lstResxLanguages = new System.Windows.Forms.ListView();
			this.lblResxTranslateStatus = new System.Windows.Forms.Label();
			this.btnStartResxTranslate = new System.Windows.Forms.Button();
			this.barResxProgress = new System.Windows.Forms.ProgressBar();
			this.label6 = new System.Windows.Forms.Label();
			this.btnSelectOutputDir = new System.Windows.Forms.Button();
			this.txtOutputDir = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnSelectResxSource = new System.Windows.Forms.Button();
			this.cmbSourceResxLng = new System.Windows.Forms.ComboBox();
			this.txtSourceResx = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lnkAbout = new System.Windows.Forms.LinkLabel();
			this.tabMain.SuspendLayout();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabResx.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabMain
			// 
			this.tabMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabMain.Controls.Add(this.tabPage2);
			this.tabMain.Controls.Add(this.tabResx);
			this.tabMain.Location = new System.Drawing.Point(12, 12);
			this.tabMain.Name = "tabMain";
			this.tabMain.SelectedIndex = 0;
			this.tabMain.Size = new System.Drawing.Size(650, 372);
			this.tabMain.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.splitContainer1);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(642, 346);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Text Translator";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(3, 3);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.txtSrc);
			this.splitContainer1.Panel1.Controls.Add(this.panel1);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.txtDesc);
			this.splitContainer1.Panel2.Controls.Add(this.panel2);
			this.splitContainer1.Size = new System.Drawing.Size(636, 340);
			this.splitContainer1.SplitterDistance = 157;
			this.splitContainer1.TabIndex = 0;
			// 
			// txtSrc
			// 
			this.txtSrc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtSrc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtSrc.Location = new System.Drawing.Point(0, 31);
			this.txtSrc.Multiline = true;
			this.txtSrc.Name = "txtSrc";
			this.txtSrc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtSrc.Size = new System.Drawing.Size(636, 126);
			this.txtSrc.TabIndex = 1;
			this.txtSrc.Text = "Bienvenue.";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnTranslate);
			this.panel1.Controls.Add(this.cmbDesc);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.cmbSrc);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(636, 31);
			this.panel1.TabIndex = 0;
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(444, 5);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnTranslate.TabIndex = 4;
			this.btnTranslate.Text = "Translate";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// cmbDesc
			// 
			this.cmbDesc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbDesc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbDesc.FormattingEnabled = true;
			this.cmbDesc.Location = new System.Drawing.Point(317, 5);
			this.cmbDesc.Name = "cmbDesc";
			this.cmbDesc.Size = new System.Drawing.Size(121, 21);
			this.cmbDesc.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(246, 8);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Translate to:";
			// 
			// cmbSrc
			// 
			this.cmbSrc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbSrc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSrc.FormattingEnabled = true;
			this.cmbSrc.Location = new System.Drawing.Point(103, 5);
			this.cmbSrc.Name = "cmbSrc";
			this.cmbSrc.Size = new System.Drawing.Size(121, 21);
			this.cmbSrc.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(94, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Source Language:";
			// 
			// txtDesc
			// 
			this.txtDesc.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txtDesc.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.txtDesc.Location = new System.Drawing.Point(0, 21);
			this.txtDesc.Multiline = true;
			this.txtDesc.Name = "txtDesc";
			this.txtDesc.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtDesc.Size = new System.Drawing.Size(636, 158);
			this.txtDesc.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label3);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(636, 21);
			this.panel2.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 5);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 0;
			this.label3.Text = "Translation result:";
			// 
			// tabResx
			// 
			this.tabResx.Controls.Add(this.lstResxLanguages);
			this.tabResx.Controls.Add(this.lblResxTranslateStatus);
			this.tabResx.Controls.Add(this.btnStartResxTranslate);
			this.tabResx.Controls.Add(this.barResxProgress);
			this.tabResx.Controls.Add(this.label6);
			this.tabResx.Controls.Add(this.btnSelectOutputDir);
			this.tabResx.Controls.Add(this.txtOutputDir);
			this.tabResx.Controls.Add(this.label5);
			this.tabResx.Controls.Add(this.btnSelectResxSource);
			this.tabResx.Controls.Add(this.cmbSourceResxLng);
			this.tabResx.Controls.Add(this.txtSourceResx);
			this.tabResx.Controls.Add(this.label4);
			this.tabResx.Location = new System.Drawing.Point(4, 22);
			this.tabResx.Name = "tabResx";
			this.tabResx.Padding = new System.Windows.Forms.Padding(3);
			this.tabResx.Size = new System.Drawing.Size(642, 346);
			this.tabResx.TabIndex = 2;
			this.tabResx.Text = "ResX Translator";
			this.tabResx.UseVisualStyleBackColor = true;
			// 
			// lstResxLanguages
			// 
			this.lstResxLanguages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lstResxLanguages.CheckBoxes = true;
			listViewItem1.StateImageIndex = 0;
			listViewItem2.StateImageIndex = 0;
			this.lstResxLanguages.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2});
			this.lstResxLanguages.Location = new System.Drawing.Point(113, 71);
			this.lstResxLanguages.Name = "lstResxLanguages";
			this.lstResxLanguages.Size = new System.Drawing.Size(424, 182);
			this.lstResxLanguages.TabIndex = 12;
			this.lstResxLanguages.UseCompatibleStateImageBehavior = false;
			this.lstResxLanguages.View = System.Windows.Forms.View.List;
			// 
			// lblResxTranslateStatus
			// 
			this.lblResxTranslateStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lblResxTranslateStatus.AutoEllipsis = true;
			this.lblResxTranslateStatus.ForeColor = System.Drawing.Color.Black;
			this.lblResxTranslateStatus.Location = new System.Drawing.Point(113, 289);
			this.lblResxTranslateStatus.Name = "lblResxTranslateStatus";
			this.lblResxTranslateStatus.Size = new System.Drawing.Size(505, 54);
			this.lblResxTranslateStatus.TabIndex = 11;
			// 
			// btnStartResxTranslate
			// 
			this.btnStartResxTranslate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btnStartResxTranslate.Location = new System.Drawing.Point(544, 259);
			this.btnStartResxTranslate.Name = "btnStartResxTranslate";
			this.btnStartResxTranslate.Size = new System.Drawing.Size(75, 23);
			this.btnStartResxTranslate.TabIndex = 10;
			this.btnStartResxTranslate.Text = "Translate";
			this.btnStartResxTranslate.UseVisualStyleBackColor = true;
			this.btnStartResxTranslate.Click += new System.EventHandler(this.btnStartResxTranslate_Click);
			// 
			// barResxProgress
			// 
			this.barResxProgress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.barResxProgress.Location = new System.Drawing.Point(113, 259);
			this.barResxProgress.Name = "barResxProgress";
			this.barResxProgress.Size = new System.Drawing.Size(424, 23);
			this.barResxProgress.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 73);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 13);
			this.label6.TabIndex = 8;
			this.label6.Text = "Output Languages:";
			// 
			// btnSelectOutputDir
			// 
			this.btnSelectOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectOutputDir.Location = new System.Drawing.Point(543, 42);
			this.btnSelectOutputDir.Name = "btnSelectOutputDir";
			this.btnSelectOutputDir.Size = new System.Drawing.Size(75, 23);
			this.btnSelectOutputDir.TabIndex = 6;
			this.btnSelectOutputDir.Text = "Select";
			this.btnSelectOutputDir.UseVisualStyleBackColor = true;
			this.btnSelectOutputDir.Click += new System.EventHandler(this.btnSelectOutputDir_Click);
			// 
			// txtOutputDir
			// 
			this.txtOutputDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtOutputDir.Location = new System.Drawing.Point(113, 44);
			this.txtOutputDir.Name = "txtOutputDir";
			this.txtOutputDir.Size = new System.Drawing.Size(424, 21);
			this.txtOutputDir.TabIndex = 5;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(15, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(92, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Output Directory:";
			// 
			// btnSelectResxSource
			// 
			this.btnSelectResxSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnSelectResxSource.Location = new System.Drawing.Point(543, 15);
			this.btnSelectResxSource.Name = "btnSelectResxSource";
			this.btnSelectResxSource.Size = new System.Drawing.Size(75, 23);
			this.btnSelectResxSource.TabIndex = 3;
			this.btnSelectResxSource.Text = "Select";
			this.btnSelectResxSource.UseVisualStyleBackColor = true;
			this.btnSelectResxSource.Click += new System.EventHandler(this.btnSelectResxSource_Click);
			// 
			// cmbSourceResxLng
			// 
			this.cmbSourceResxLng.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cmbSourceResxLng.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
			this.cmbSourceResxLng.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.cmbSourceResxLng.FormattingEnabled = true;
			this.cmbSourceResxLng.Location = new System.Drawing.Point(416, 17);
			this.cmbSourceResxLng.Name = "cmbSourceResxLng";
			this.cmbSourceResxLng.Size = new System.Drawing.Size(121, 21);
			this.cmbSourceResxLng.TabIndex = 2;
			// 
			// txtSourceResx
			// 
			this.txtSourceResx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtSourceResx.Location = new System.Drawing.Point(113, 17);
			this.txtSourceResx.Name = "txtSourceResx";
			this.txtSourceResx.ReadOnly = true;
			this.txtSourceResx.Size = new System.Drawing.Size(297, 21);
			this.txtSourceResx.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(17, 20);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 0;
			this.label4.Text = "Source Resx File:";
			// 
			// lnkAbout
			// 
			this.lnkAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lnkAbout.AutoSize = true;
			this.lnkAbout.Location = new System.Drawing.Point(621, 13);
			this.lnkAbout.Name = "lnkAbout";
			this.lnkAbout.Size = new System.Drawing.Size(36, 13);
			this.lnkAbout.TabIndex = 3;
			this.lnkAbout.TabStop = true;
			this.lnkAbout.Text = "About";
			this.lnkAbout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkAbout_LinkClicked);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(674, 396);
			this.Controls.Add(this.lnkAbout);
			this.Controls.Add(this.tabMain);
			this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MinimumSize = new System.Drawing.Size(500, 400);
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Resource Auto Translator";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tabMain.ResumeLayout(false);
			this.tabPage2.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabResx.ResumeLayout(false);
			this.tabResx.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TabControl tabMain;
		private System.Windows.Forms.TabPage tabPage2;
		public System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.TextBox txtSrc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.TextBox txtDesc;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.ComboBox cmbDesc;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox cmbSrc;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TabPage tabResx;
		private System.Windows.Forms.Button btnSelectResxSource;
		private System.Windows.Forms.ComboBox cmbSourceResxLng;
		private System.Windows.Forms.TextBox txtSourceResx;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnSelectOutputDir;
		private System.Windows.Forms.TextBox txtOutputDir;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label lblResxTranslateStatus;
		private System.Windows.Forms.Button btnStartResxTranslate;
		private System.Windows.Forms.ProgressBar barResxProgress;
		private System.Windows.Forms.ListView lstResxLanguages;
		private System.Windows.Forms.LinkLabel lnkAbout;
	}
}
