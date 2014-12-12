namespace MBlog.Forms
{
    partial class FormProjectSettings
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPageBlog = new System.Windows.Forms.TabPage();
            this.tabPageTemplate = new System.Windows.Forms.TabPage();
            this.buttonFooter = new System.Windows.Forms.Button();
            this.textBoxFooter = new System.Windows.Forms.TextBox();
            this.labelFooter = new System.Windows.Forms.Label();
            this.buttonHeader = new System.Windows.Forms.Button();
            this.textBoxHeader = new System.Windows.Forms.TextBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.buttonArchivePage = new System.Windows.Forms.Button();
            this.textBoxArchivePage = new System.Windows.Forms.TextBox();
            this.labelArchivePage = new System.Windows.Forms.Label();
            this.buttonTagsPage = new System.Windows.Forms.Button();
            this.textBoxTagsPage = new System.Windows.Forms.TextBox();
            this.labelTagsPage = new System.Windows.Forms.Label();
            this.buttonPostPage = new System.Windows.Forms.Button();
            this.textBoxPostPage = new System.Windows.Forms.TextBox();
            this.labelPostPage = new System.Windows.Forms.Label();
            this.buttonIndex = new System.Windows.Forms.Button();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.labelIndex = new System.Windows.Forms.Label();
            this.tabPageGit = new System.Windows.Forms.TabPage();
            this.buttonGit = new System.Windows.Forms.Button();
            this.textBoxGit = new System.Windows.Forms.TextBox();
            this.labelGit = new System.Windows.Forms.Label();
            this.textBoxBlogName = new System.Windows.Forms.TextBox();
            this.labelBlogName = new System.Windows.Forms.Label();
            this.textBoxBlogDescription = new System.Windows.Forms.TextBox();
            this.labelBlogDescription = new System.Windows.Forms.Label();
            this.textBoxBlogAddress = new System.Windows.Forms.TextBox();
            this.labelBlogAddress = new System.Windows.Forms.Label();
            this.buttonOutputPath = new System.Windows.Forms.Button();
            this.textBoxOutputPath = new System.Windows.Forms.TextBox();
            this.labelOutputPath = new System.Windows.Forms.Label();
            this.openFileDialogSettings = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogSettings = new System.Windows.Forms.SaveFileDialog();
            this.panelBottom.SuspendLayout();
            this.tabControlSettings.SuspendLayout();
            this.tabPageBlog.SuspendLayout();
            this.tabPageTemplate.SuspendLayout();
            this.tabPageGit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.buttonRight);
            this.panelBottom.Controls.Add(this.buttonLeft);
            this.panelBottom.Controls.Add(this.buttonOk);
            this.panelBottom.Controls.Add(this.buttonCancel);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 325);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(608, 31);
            this.panelBottom.TabIndex = 0;
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(93, 5);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(75, 23);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.Text = "Next >>";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(12, 5);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(75, 23);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.Text = "<< Prev.";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(440, 5);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(75, 23);
            this.buttonOk.TabIndex = 1;
            this.buttonOk.Text = "OK";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(521, 5);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 0;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPageBlog);
            this.tabControlSettings.Controls.Add(this.tabPageTemplate);
            this.tabControlSettings.Controls.Add(this.tabPageGit);
            this.tabControlSettings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlSettings.Location = new System.Drawing.Point(0, 0);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(608, 325);
            this.tabControlSettings.TabIndex = 1;
            // 
            // tabPageBlog
            // 
            this.tabPageBlog.Controls.Add(this.buttonOutputPath);
            this.tabPageBlog.Controls.Add(this.textBoxOutputPath);
            this.tabPageBlog.Controls.Add(this.labelOutputPath);
            this.tabPageBlog.Controls.Add(this.textBoxBlogAddress);
            this.tabPageBlog.Controls.Add(this.labelBlogAddress);
            this.tabPageBlog.Controls.Add(this.textBoxBlogDescription);
            this.tabPageBlog.Controls.Add(this.labelBlogDescription);
            this.tabPageBlog.Controls.Add(this.textBoxBlogName);
            this.tabPageBlog.Controls.Add(this.labelBlogName);
            this.tabPageBlog.Location = new System.Drawing.Point(4, 22);
            this.tabPageBlog.Name = "tabPageBlog";
            this.tabPageBlog.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBlog.Size = new System.Drawing.Size(600, 299);
            this.tabPageBlog.TabIndex = 0;
            this.tabPageBlog.Text = "Blog";
            this.tabPageBlog.UseVisualStyleBackColor = true;
            // 
            // tabPageTemplate
            // 
            this.tabPageTemplate.Controls.Add(this.buttonFooter);
            this.tabPageTemplate.Controls.Add(this.textBoxFooter);
            this.tabPageTemplate.Controls.Add(this.labelFooter);
            this.tabPageTemplate.Controls.Add(this.buttonHeader);
            this.tabPageTemplate.Controls.Add(this.textBoxHeader);
            this.tabPageTemplate.Controls.Add(this.labelHeader);
            this.tabPageTemplate.Controls.Add(this.buttonArchivePage);
            this.tabPageTemplate.Controls.Add(this.textBoxArchivePage);
            this.tabPageTemplate.Controls.Add(this.labelArchivePage);
            this.tabPageTemplate.Controls.Add(this.buttonTagsPage);
            this.tabPageTemplate.Controls.Add(this.textBoxTagsPage);
            this.tabPageTemplate.Controls.Add(this.labelTagsPage);
            this.tabPageTemplate.Controls.Add(this.buttonPostPage);
            this.tabPageTemplate.Controls.Add(this.textBoxPostPage);
            this.tabPageTemplate.Controls.Add(this.labelPostPage);
            this.tabPageTemplate.Controls.Add(this.buttonIndex);
            this.tabPageTemplate.Controls.Add(this.textBoxIndex);
            this.tabPageTemplate.Controls.Add(this.labelIndex);
            this.tabPageTemplate.Location = new System.Drawing.Point(4, 22);
            this.tabPageTemplate.Name = "tabPageTemplate";
            this.tabPageTemplate.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTemplate.Size = new System.Drawing.Size(600, 299);
            this.tabPageTemplate.TabIndex = 2;
            this.tabPageTemplate.Text = "Template";
            this.tabPageTemplate.UseVisualStyleBackColor = true;
            // 
            // buttonFooter
            // 
            this.buttonFooter.Location = new System.Drawing.Point(567, 232);
            this.buttonFooter.Name = "buttonFooter";
            this.buttonFooter.Size = new System.Drawing.Size(25, 20);
            this.buttonFooter.TabIndex = 20;
            this.buttonFooter.Text = "...";
            this.buttonFooter.UseVisualStyleBackColor = true;
            // 
            // textBoxFooter
            // 
            this.textBoxFooter.Location = new System.Drawing.Point(8, 233);
            this.textBoxFooter.Name = "textBoxFooter";
            this.textBoxFooter.Size = new System.Drawing.Size(553, 20);
            this.textBoxFooter.TabIndex = 19;
            // 
            // labelFooter
            // 
            this.labelFooter.AutoSize = true;
            this.labelFooter.Location = new System.Drawing.Point(5, 217);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(40, 13);
            this.labelFooter.TabIndex = 18;
            this.labelFooter.Text = "Footer:";
            // 
            // buttonHeader
            // 
            this.buttonHeader.Location = new System.Drawing.Point(567, 187);
            this.buttonHeader.Name = "buttonHeader";
            this.buttonHeader.Size = new System.Drawing.Size(25, 20);
            this.buttonHeader.TabIndex = 17;
            this.buttonHeader.Text = "...";
            this.buttonHeader.UseVisualStyleBackColor = true;
            // 
            // textBoxHeader
            // 
            this.textBoxHeader.Location = new System.Drawing.Point(8, 188);
            this.textBoxHeader.Name = "textBoxHeader";
            this.textBoxHeader.Size = new System.Drawing.Size(553, 20);
            this.textBoxHeader.TabIndex = 16;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Location = new System.Drawing.Point(5, 172);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(45, 13);
            this.labelHeader.TabIndex = 15;
            this.labelHeader.Text = "Header:";
            // 
            // buttonArchivePage
            // 
            this.buttonArchivePage.Location = new System.Drawing.Point(567, 145);
            this.buttonArchivePage.Name = "buttonArchivePage";
            this.buttonArchivePage.Size = new System.Drawing.Size(25, 20);
            this.buttonArchivePage.TabIndex = 14;
            this.buttonArchivePage.Text = "...";
            this.buttonArchivePage.UseVisualStyleBackColor = true;
            // 
            // textBoxArchivePage
            // 
            this.textBoxArchivePage.Location = new System.Drawing.Point(8, 146);
            this.textBoxArchivePage.Name = "textBoxArchivePage";
            this.textBoxArchivePage.Size = new System.Drawing.Size(553, 20);
            this.textBoxArchivePage.TabIndex = 13;
            // 
            // labelArchivePage
            // 
            this.labelArchivePage.AutoSize = true;
            this.labelArchivePage.Location = new System.Drawing.Point(5, 130);
            this.labelArchivePage.Name = "labelArchivePage";
            this.labelArchivePage.Size = new System.Drawing.Size(71, 13);
            this.labelArchivePage.TabIndex = 12;
            this.labelArchivePage.Text = "ArchivePage:";
            // 
            // buttonTagsPage
            // 
            this.buttonTagsPage.Location = new System.Drawing.Point(567, 103);
            this.buttonTagsPage.Name = "buttonTagsPage";
            this.buttonTagsPage.Size = new System.Drawing.Size(25, 20);
            this.buttonTagsPage.TabIndex = 11;
            this.buttonTagsPage.Text = "...";
            this.buttonTagsPage.UseVisualStyleBackColor = true;
            // 
            // textBoxTagsPage
            // 
            this.textBoxTagsPage.Location = new System.Drawing.Point(8, 104);
            this.textBoxTagsPage.Name = "textBoxTagsPage";
            this.textBoxTagsPage.Size = new System.Drawing.Size(553, 20);
            this.textBoxTagsPage.TabIndex = 10;
            // 
            // labelTagsPage
            // 
            this.labelTagsPage.AutoSize = true;
            this.labelTagsPage.Location = new System.Drawing.Point(5, 88);
            this.labelTagsPage.Name = "labelTagsPage";
            this.labelTagsPage.Size = new System.Drawing.Size(62, 13);
            this.labelTagsPage.TabIndex = 9;
            this.labelTagsPage.Text = "Tags Page:";
            // 
            // buttonPostPage
            // 
            this.buttonPostPage.Location = new System.Drawing.Point(567, 60);
            this.buttonPostPage.Name = "buttonPostPage";
            this.buttonPostPage.Size = new System.Drawing.Size(25, 20);
            this.buttonPostPage.TabIndex = 8;
            this.buttonPostPage.Text = "...";
            this.buttonPostPage.UseVisualStyleBackColor = true;
            // 
            // textBoxPostPage
            // 
            this.textBoxPostPage.Location = new System.Drawing.Point(8, 61);
            this.textBoxPostPage.Name = "textBoxPostPage";
            this.textBoxPostPage.Size = new System.Drawing.Size(553, 20);
            this.textBoxPostPage.TabIndex = 7;
            // 
            // labelPostPage
            // 
            this.labelPostPage.AutoSize = true;
            this.labelPostPage.Location = new System.Drawing.Point(5, 45);
            this.labelPostPage.Name = "labelPostPage";
            this.labelPostPage.Size = new System.Drawing.Size(58, 13);
            this.labelPostPage.TabIndex = 6;
            this.labelPostPage.Text = "Post page:";
            // 
            // buttonIndex
            // 
            this.buttonIndex.Location = new System.Drawing.Point(567, 19);
            this.buttonIndex.Name = "buttonIndex";
            this.buttonIndex.Size = new System.Drawing.Size(25, 20);
            this.buttonIndex.TabIndex = 5;
            this.buttonIndex.Text = "...";
            this.buttonIndex.UseVisualStyleBackColor = true;
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Location = new System.Drawing.Point(8, 20);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(553, 20);
            this.textBoxIndex.TabIndex = 4;
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Location = new System.Drawing.Point(5, 4);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(36, 13);
            this.labelIndex.TabIndex = 3;
            this.labelIndex.Text = "Index:";
            // 
            // tabPageGit
            // 
            this.tabPageGit.Controls.Add(this.buttonGit);
            this.tabPageGit.Controls.Add(this.textBoxGit);
            this.tabPageGit.Controls.Add(this.labelGit);
            this.tabPageGit.Location = new System.Drawing.Point(4, 22);
            this.tabPageGit.Name = "tabPageGit";
            this.tabPageGit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageGit.Size = new System.Drawing.Size(600, 299);
            this.tabPageGit.TabIndex = 1;
            this.tabPageGit.Text = "Git";
            this.tabPageGit.UseVisualStyleBackColor = true;
            // 
            // buttonGit
            // 
            this.buttonGit.Location = new System.Drawing.Point(567, 20);
            this.buttonGit.Name = "buttonGit";
            this.buttonGit.Size = new System.Drawing.Size(25, 20);
            this.buttonGit.TabIndex = 2;
            this.buttonGit.Text = "...";
            this.buttonGit.UseVisualStyleBackColor = true;
            // 
            // textBoxGit
            // 
            this.textBoxGit.Location = new System.Drawing.Point(8, 20);
            this.textBoxGit.Name = "textBoxGit";
            this.textBoxGit.Size = new System.Drawing.Size(553, 20);
            this.textBoxGit.TabIndex = 1;
            // 
            // labelGit
            // 
            this.labelGit.AutoSize = true;
            this.labelGit.Location = new System.Drawing.Point(5, 4);
            this.labelGit.Name = "labelGit";
            this.labelGit.Size = new System.Drawing.Size(68, 13);
            this.labelGit.TabIndex = 0;
            this.labelGit.Text = "Git.exe Path:";
            // 
            // textBoxBlogName
            // 
            this.textBoxBlogName.Location = new System.Drawing.Point(8, 20);
            this.textBoxBlogName.Name = "textBoxBlogName";
            this.textBoxBlogName.Size = new System.Drawing.Size(553, 20);
            this.textBoxBlogName.TabIndex = 7;
            // 
            // labelBlogName
            // 
            this.labelBlogName.AutoSize = true;
            this.labelBlogName.Location = new System.Drawing.Point(5, 4);
            this.labelBlogName.Name = "labelBlogName";
            this.labelBlogName.Size = new System.Drawing.Size(62, 13);
            this.labelBlogName.TabIndex = 6;
            this.labelBlogName.Text = "Blog Name:";
            // 
            // textBoxBlogDescription
            // 
            this.textBoxBlogDescription.Location = new System.Drawing.Point(8, 62);
            this.textBoxBlogDescription.Name = "textBoxBlogDescription";
            this.textBoxBlogDescription.Size = new System.Drawing.Size(553, 20);
            this.textBoxBlogDescription.TabIndex = 10;
            // 
            // labelBlogDescription
            // 
            this.labelBlogDescription.AutoSize = true;
            this.labelBlogDescription.Location = new System.Drawing.Point(5, 46);
            this.labelBlogDescription.Name = "labelBlogDescription";
            this.labelBlogDescription.Size = new System.Drawing.Size(87, 13);
            this.labelBlogDescription.TabIndex = 9;
            this.labelBlogDescription.Text = "Blog Description:";
            // 
            // textBoxBlogAddress
            // 
            this.textBoxBlogAddress.Location = new System.Drawing.Point(8, 103);
            this.textBoxBlogAddress.Name = "textBoxBlogAddress";
            this.textBoxBlogAddress.Size = new System.Drawing.Size(553, 20);
            this.textBoxBlogAddress.TabIndex = 12;
            // 
            // labelBlogAddress
            // 
            this.labelBlogAddress.AutoSize = true;
            this.labelBlogAddress.Location = new System.Drawing.Point(5, 87);
            this.labelBlogAddress.Name = "labelBlogAddress";
            this.labelBlogAddress.Size = new System.Drawing.Size(72, 13);
            this.labelBlogAddress.TabIndex = 11;
            this.labelBlogAddress.Text = "Blog Address:";
            // 
            // buttonOutputPath
            // 
            this.buttonOutputPath.Location = new System.Drawing.Point(569, 146);
            this.buttonOutputPath.Name = "buttonOutputPath";
            this.buttonOutputPath.Size = new System.Drawing.Size(25, 20);
            this.buttonOutputPath.TabIndex = 15;
            this.buttonOutputPath.Text = "...";
            this.buttonOutputPath.UseVisualStyleBackColor = true;
            // 
            // textBoxOutputPath
            // 
            this.textBoxOutputPath.Location = new System.Drawing.Point(10, 147);
            this.textBoxOutputPath.Name = "textBoxOutputPath";
            this.textBoxOutputPath.Size = new System.Drawing.Size(553, 20);
            this.textBoxOutputPath.TabIndex = 14;
            // 
            // labelOutputPath
            // 
            this.labelOutputPath.AutoSize = true;
            this.labelOutputPath.Location = new System.Drawing.Point(7, 131);
            this.labelOutputPath.Name = "labelOutputPath";
            this.labelOutputPath.Size = new System.Drawing.Size(67, 13);
            this.labelOutputPath.TabIndex = 13;
            this.labelOutputPath.Text = "Output Path:";
            // 
            // openFileDialogSettings
            // 
            this.openFileDialogSettings.FileName = "openFileDialog1";
            // 
            // FormProjectSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 356);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.panelBottom);
            this.Name = "FormProjectSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Project Settings";
            this.panelBottom.ResumeLayout(false);
            this.tabControlSettings.ResumeLayout(false);
            this.tabPageBlog.ResumeLayout(false);
            this.tabPageBlog.PerformLayout();
            this.tabPageTemplate.ResumeLayout(false);
            this.tabPageTemplate.PerformLayout();
            this.tabPageGit.ResumeLayout(false);
            this.tabPageGit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPageBlog;
        private System.Windows.Forms.TabPage tabPageGit;
        private System.Windows.Forms.TabPage tabPageTemplate;
        private System.Windows.Forms.Button buttonGit;
        private System.Windows.Forms.TextBox textBoxGit;
        private System.Windows.Forms.Label labelGit;
        private System.Windows.Forms.Button buttonIndex;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Button buttonFooter;
        private System.Windows.Forms.TextBox textBoxFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Button buttonHeader;
        private System.Windows.Forms.TextBox textBoxHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonArchivePage;
        private System.Windows.Forms.TextBox textBoxArchivePage;
        private System.Windows.Forms.Label labelArchivePage;
        private System.Windows.Forms.Button buttonTagsPage;
        private System.Windows.Forms.TextBox textBoxTagsPage;
        private System.Windows.Forms.Label labelTagsPage;
        private System.Windows.Forms.Button buttonPostPage;
        private System.Windows.Forms.TextBox textBoxPostPage;
        private System.Windows.Forms.Label labelPostPage;
        private System.Windows.Forms.Button buttonOutputPath;
        private System.Windows.Forms.TextBox textBoxOutputPath;
        private System.Windows.Forms.Label labelOutputPath;
        private System.Windows.Forms.TextBox textBoxBlogAddress;
        private System.Windows.Forms.Label labelBlogAddress;
        private System.Windows.Forms.TextBox textBoxBlogDescription;
        private System.Windows.Forms.Label labelBlogDescription;
        private System.Windows.Forms.TextBox textBoxBlogName;
        private System.Windows.Forms.Label labelBlogName;
        private System.Windows.Forms.OpenFileDialog openFileDialogSettings;
        private System.Windows.Forms.SaveFileDialog saveFileDialogSettings;
    }
}