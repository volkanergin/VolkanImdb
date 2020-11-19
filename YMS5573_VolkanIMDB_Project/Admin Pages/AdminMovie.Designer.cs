namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    partial class AdminMovie
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAddMovie = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbAddDirector = new System.Windows.Forms.ComboBox();
            this.cmbAddGenre = new System.Windows.Forms.ComboBox();
            this.txtAddPictureUrl = new System.Windows.Forms.TextBox();
            this.btnAddPicture = new System.Windows.Forms.Button();
            this.txtAddContext = new System.Windows.Forms.TextBox();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ofdAddPicture = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAddMovie.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 372);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 236);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Movies";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(875, 210);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grpAddMovie
            // 
            this.grpAddMovie.Controls.Add(this.btnCreate);
            this.grpAddMovie.Controls.Add(this.cmbAddDirector);
            this.grpAddMovie.Controls.Add(this.cmbAddGenre);
            this.grpAddMovie.Controls.Add(this.txtAddPictureUrl);
            this.grpAddMovie.Controls.Add(this.btnAddPicture);
            this.grpAddMovie.Controls.Add(this.txtAddContext);
            this.grpAddMovie.Controls.Add(this.txtAddTitle);
            this.grpAddMovie.Controls.Add(this.label4);
            this.grpAddMovie.Controls.Add(this.label5);
            this.grpAddMovie.Controls.Add(this.label2);
            this.grpAddMovie.Controls.Add(this.label3);
            this.grpAddMovie.Controls.Add(this.label1);
            this.grpAddMovie.Location = new System.Drawing.Point(12, 2);
            this.grpAddMovie.Name = "grpAddMovie";
            this.grpAddMovie.Size = new System.Drawing.Size(345, 364);
            this.grpAddMovie.TabIndex = 2;
            this.grpAddMovie.TabStop = false;
            this.grpAddMovie.Text = "Add Movie";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(143, 307);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(95, 38);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbAddDirector
            // 
            this.cmbAddDirector.FormattingEnabled = true;
            this.cmbAddDirector.Location = new System.Drawing.Point(83, 280);
            this.cmbAddDirector.Name = "cmbAddDirector";
            this.cmbAddDirector.Size = new System.Drawing.Size(155, 21);
            this.cmbAddDirector.TabIndex = 4;
            // 
            // cmbAddGenre
            // 
            this.cmbAddGenre.FormattingEnabled = true;
            this.cmbAddGenre.Location = new System.Drawing.Point(83, 231);
            this.cmbAddGenre.Name = "cmbAddGenre";
            this.cmbAddGenre.Size = new System.Drawing.Size(155, 21);
            this.cmbAddGenre.TabIndex = 4;
            // 
            // txtAddPictureUrl
            // 
            this.txtAddPictureUrl.Location = new System.Drawing.Point(83, 182);
            this.txtAddPictureUrl.Name = "txtAddPictureUrl";
            this.txtAddPictureUrl.Size = new System.Drawing.Size(155, 20);
            this.txtAddPictureUrl.TabIndex = 3;
            // 
            // btnAddPicture
            // 
            this.btnAddPicture.Location = new System.Drawing.Point(83, 152);
            this.btnAddPicture.Name = "btnAddPicture";
            this.btnAddPicture.Size = new System.Drawing.Size(155, 23);
            this.btnAddPicture.TabIndex = 2;
            this.btnAddPicture.Text = "Choose The Picture";
            this.btnAddPicture.UseVisualStyleBackColor = true;
            this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
            // 
            // txtAddContext
            // 
            this.txtAddContext.Location = new System.Drawing.Point(83, 73);
            this.txtAddContext.Multiline = true;
            this.txtAddContext.Name = "txtAddContext";
            this.txtAddContext.Size = new System.Drawing.Size(155, 71);
            this.txtAddContext.TabIndex = 1;
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(83, 43);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(155, 20);
            this.txtAddTitle.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Context:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose The Director:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose The Genre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Title:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Picture:";
            // 
            // ofdAddPicture
            // 
            this.ofdAddPicture.FileName = "openFileDialog1";
            // 
            // AdminMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAddMovie);
            this.Name = "AdminMovie";
            this.Text = "AdminMovie";
            this.Load += new System.EventHandler(this.AdminMovie_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAddMovie.ResumeLayout(false);
            this.grpAddMovie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpAddMovie;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbAddDirector;
        private System.Windows.Forms.ComboBox cmbAddGenre;
        private System.Windows.Forms.TextBox txtAddPictureUrl;
        private System.Windows.Forms.Button btnAddPicture;
        private System.Windows.Forms.TextBox txtAddContext;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog ofdAddPicture;
    }
}