namespace TemplateDownloader
{
    partial class Form1
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
            listBox1 = new ListBox();
            btnSelectFolder = new Button();
            txtFolderBase = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtUrl = new TextBox();
            btnDescargar = new Button();
            btnOpemFolder = new Button();
            pictureBox1 = new PictureBox();
            splitContainer1 = new SplitContainer();
            lblImagen = new Label();
            btnSincUrl = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(3, 3);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(684, 349);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // btnSelectFolder
            // 
            btnSelectFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelectFolder.Location = new Point(931, 22);
            btnSelectFolder.Name = "btnSelectFolder";
            btnSelectFolder.Size = new Size(122, 23);
            btnSelectFolder.TabIndex = 1;
            btnSelectFolder.Text = "Select folder";
            btnSelectFolder.UseVisualStyleBackColor = true;
            btnSelectFolder.Click += btnSelectFolder_Click;
            // 
            // txtFolderBase
            // 
            txtFolderBase.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtFolderBase.Location = new Point(93, 22);
            txtFolderBase.Name = "txtFolderBase";
            txtFolderBase.Size = new Size(800, 23);
            txtFolderBase.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 3;
            label1.Text = "Folder Base";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 58);
            label2.Name = "label2";
            label2.Size = new Size(28, 15);
            label2.TabIndex = 4;
            label2.Text = "URL";
            // 
            // txtUrl
            // 
            txtUrl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtUrl.Location = new Point(51, 58);
            txtUrl.Name = "txtUrl";
            txtUrl.Size = new Size(805, 23);
            txtUrl.TabIndex = 5;
            txtUrl.Text = "https://7oroof.com/demos/yellowhats/assets/images";
            // 
            // btnDescargar
            // 
            btnDescargar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDescargar.Location = new Point(931, 58);
            btnDescargar.Name = "btnDescargar";
            btnDescargar.Size = new Size(117, 23);
            btnDescargar.TabIndex = 6;
            btnDescargar.Text = "Descargar";
            btnDescargar.UseVisualStyleBackColor = true;
            btnDescargar.Click += btnDescargar_Click;
            // 
            // btnOpemFolder
            // 
            btnOpemFolder.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnOpemFolder.Location = new Point(900, 22);
            btnOpemFolder.Name = "btnOpemFolder";
            btnOpemFolder.Size = new Size(25, 23);
            btnOpemFolder.TabIndex = 7;
            btnOpemFolder.Text = ">";
            btnOpemFolder.UseVisualStyleBackColor = true;
            btnOpemFolder.Click += btnOpenFolder_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(3, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(355, 325);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(7, 98);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(lblImagen);
            splitContainer1.Panel2.Controls.Add(pictureBox1);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(1055, 360);
            splitContainer1.SplitterDistance = 690;
            splitContainer1.TabIndex = 9;
            // 
            // lblImagen
            // 
            lblImagen.AllowDrop = true;
            lblImagen.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblImagen.AutoSize = true;
            lblImagen.Location = new Point(19, 9);
            lblImagen.Name = "lblImagen";
            lblImagen.Size = new Size(0, 15);
            lblImagen.TabIndex = 9;
            // 
            // btnSincUrl
            // 
            btnSincUrl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSincUrl.Location = new Point(862, 58);
            btnSincUrl.Name = "btnSincUrl";
            btnSincUrl.Size = new Size(63, 23);
            btnSincUrl.TabIndex = 10;
            btnSincUrl.Text = "Sync Url";
            btnSincUrl.UseVisualStyleBackColor = true;
            btnSincUrl.Click += btnSyncUrl_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1065, 470);
            Controls.Add(btnSincUrl);
            Controls.Add(splitContainer1);
            Controls.Add(btnOpemFolder);
            Controls.Add(btnDescargar);
            Controls.Add(txtUrl);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFolderBase);
            Controls.Add(btnSelectFolder);
            Name = "Form1";
            Text = "Template Downloader";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button btnSelectFolder;
        private TextBox txtFolderBase;
        private Label label1;
        private Label label2;
        private TextBox txtUrl;
        private Button btnDescargar;
        private Button btnOpemFolder;
        private PictureBox pictureBox1;
        private SplitContainer splitContainer1;
        private Label lblImagen;
        private Button btnSincUrl;
    }
}
