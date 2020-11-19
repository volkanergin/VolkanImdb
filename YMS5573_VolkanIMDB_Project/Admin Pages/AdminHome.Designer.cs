namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    partial class AdminHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminHome));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMovieManagement = new System.Windows.Forms.Button();
            this.btnGenreManagement = new System.Windows.Forms.Button();
            this.btnUserManagement = new System.Windows.Forms.Button();
            this.btnAdminLogOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(234, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "volkanergin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(237, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Administrator";
            // 
            // btnMovieManagement
            // 
            this.btnMovieManagement.Location = new System.Drawing.Point(13, 133);
            this.btnMovieManagement.Name = "btnMovieManagement";
            this.btnMovieManagement.Size = new System.Drawing.Size(199, 40);
            this.btnMovieManagement.TabIndex = 3;
            this.btnMovieManagement.Text = "Movie Management";
            this.btnMovieManagement.UseVisualStyleBackColor = true;
            this.btnMovieManagement.Click += new System.EventHandler(this.btnMovieManagement_Click);
            // 
            // btnGenreManagement
            // 
            this.btnGenreManagement.Location = new System.Drawing.Point(13, 251);
            this.btnGenreManagement.Name = "btnGenreManagement";
            this.btnGenreManagement.Size = new System.Drawing.Size(199, 37);
            this.btnGenreManagement.TabIndex = 3;
            this.btnGenreManagement.Text = "Genre Management";
            this.btnGenreManagement.UseVisualStyleBackColor = true;
            this.btnGenreManagement.Click += new System.EventHandler(this.btnGenreManagement_Click);
            // 
            // btnUserManagement
            // 
            this.btnUserManagement.Location = new System.Drawing.Point(12, 192);
            this.btnUserManagement.Name = "btnUserManagement";
            this.btnUserManagement.Size = new System.Drawing.Size(199, 40);
            this.btnUserManagement.TabIndex = 3;
            this.btnUserManagement.Text = "User Management";
            this.btnUserManagement.UseVisualStyleBackColor = true;
            this.btnUserManagement.Click += new System.EventHandler(this.btnUserManagement_Click);
            // 
            // btnAdminLogOut
            // 
            this.btnAdminLogOut.Location = new System.Drawing.Point(414, 34);
            this.btnAdminLogOut.Name = "btnAdminLogOut";
            this.btnAdminLogOut.Size = new System.Drawing.Size(75, 23);
            this.btnAdminLogOut.TabIndex = 4;
            this.btnAdminLogOut.Text = "Log Out";
            this.btnAdminLogOut.UseVisualStyleBackColor = true;
            this.btnAdminLogOut.Click += new System.EventHandler(this.btnAdminLogOut_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 320);
            this.Controls.Add(this.btnAdminLogOut);
            this.Controls.Add(this.btnUserManagement);
            this.Controls.Add(this.btnGenreManagement);
            this.Controls.Add(this.btnMovieManagement);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminHome";
            this.Text = "AdminHome";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMovieManagement;
        private System.Windows.Forms.Button btnGenreManagement;
        private System.Windows.Forms.Button btnUserManagement;
        private System.Windows.Forms.Button btnAdminLogOut;
    }
}