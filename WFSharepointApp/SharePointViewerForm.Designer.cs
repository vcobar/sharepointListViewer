namespace WFSharepointApp
{
    partial class SharePointViewerForm
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
            this.txtSiteUrl = new System.Windows.Forms.TextBox();
            this.labelSiteUrl = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelListTitle = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtListTitle = new System.Windows.Forms.TextBox();
            this.btnGetData = new System.Windows.Forms.Button();
            this.dgListResults = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgListResults)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSiteUrl
            // 
            this.txtSiteUrl.Location = new System.Drawing.Point(10, 30);
            this.txtSiteUrl.Name = "txtSiteUrl";
            this.txtSiteUrl.Size = new System.Drawing.Size(424, 20);
            this.txtSiteUrl.TabIndex = 0;
            // 
            // labelSiteUrl
            // 
            this.labelSiteUrl.AutoSize = true;
            this.labelSiteUrl.Location = new System.Drawing.Point(10, 10);
            this.labelSiteUrl.Name = "labelSiteUrl";
            this.labelSiteUrl.Size = new System.Drawing.Size(84, 13);
            this.labelSiteUrl.TabIndex = 1;
            this.labelSiteUrl.Text = "SharePoint URL";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(10, 60);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(55, 13);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(130, 60);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(53, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password";
            // 
            // labelListTitle
            // 
            this.labelListTitle.AutoSize = true;
            this.labelListTitle.Location = new System.Drawing.Point(250, 60);
            this.labelListTitle.Name = "labelListTitle";
            this.labelListTitle.Size = new System.Drawing.Size(46, 13);
            this.labelListTitle.TabIndex = 4;
            this.labelListTitle.Text = "List Title";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(13, 77);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(100, 20);
            this.txtUsername.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(133, 77);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(100, 20);
            this.txtPassword.TabIndex = 6;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtListTitle
            // 
            this.txtListTitle.Location = new System.Drawing.Point(253, 77);
            this.txtListTitle.Name = "txtListTitle";
            this.txtListTitle.Size = new System.Drawing.Size(100, 20);
            this.txtListTitle.TabIndex = 7;
            // 
            // btnGetData
            // 
            this.btnGetData.Location = new System.Drawing.Point(359, 75);
            this.btnGetData.Name = "btnGetData";
            this.btnGetData.Size = new System.Drawing.Size(75, 23);
            this.btnGetData.TabIndex = 8;
            this.btnGetData.Text = "Get Data";
            this.btnGetData.UseVisualStyleBackColor = true;
            this.btnGetData.Click += new System.EventHandler(this.btnGetData_Click);
            // 
            // dgListResults
            // 
            this.dgListResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgListResults.Location = new System.Drawing.Point(10, 118);
            this.dgListResults.Name = "dgListResults";
            this.dgListResults.Size = new System.Drawing.Size(422, 291);
            this.dgListResults.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 421);
            this.Controls.Add(this.dgListResults);
            this.Controls.Add(this.btnGetData);
            this.Controls.Add(this.txtListTitle);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.labelListTitle);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.labelSiteUrl);
            this.Controls.Add(this.txtSiteUrl);
            this.Name = "Form1";
            this.Text = "SharePoint List Viewer";
            ((System.ComponentModel.ISupportInitialize)(this.dgListResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiteUrl;
        private System.Windows.Forms.Label labelSiteUrl;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelListTitle;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtListTitle;
        private System.Windows.Forms.Button btnGetData;
        private System.Windows.Forms.DataGridView dgListResults;
    }
}

