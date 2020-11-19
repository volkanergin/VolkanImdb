namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    partial class AdminGenre
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.grpFindByName = new System.Windows.Forms.GroupBox();
            this.btnFindByName = new System.Windows.Forms.Button();
            this.txtFindByName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteGenre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.grpUpdateGenre = new System.Windows.Forms.GroupBox();
            this.txtUpdateName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnFindById = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpCreateGenre = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtCreateName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.grpFindByName.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpUpdateGenre.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpCreateGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnGetAll);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(754, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(171, 70);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Get All";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(6, 29);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(159, 27);
            this.btnGetAll.TabIndex = 0;
            this.btnGetAll.Text = "Get All Genres";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // grpFindByName
            // 
            this.grpFindByName.Controls.Add(this.btnFindByName);
            this.grpFindByName.Controls.Add(this.txtFindByName);
            this.grpFindByName.Controls.Add(this.label5);
            this.grpFindByName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFindByName.Location = new System.Drawing.Point(562, 93);
            this.grpFindByName.Name = "grpFindByName";
            this.grpFindByName.Size = new System.Drawing.Size(363, 85);
            this.grpFindByName.TabIndex = 10;
            this.grpFindByName.TabStop = false;
            this.grpFindByName.Text = "Find By Name";
            // 
            // btnFindByName
            // 
            this.btnFindByName.Location = new System.Drawing.Point(213, 29);
            this.btnFindByName.Name = "btnFindByName";
            this.btnFindByName.Size = new System.Drawing.Size(130, 26);
            this.btnFindByName.TabIndex = 5;
            this.btnFindByName.Text = "Find By Name";
            this.btnFindByName.UseVisualStyleBackColor = true;
            this.btnFindByName.Click += new System.EventHandler(this.btnFindByName_Click);
            // 
            // txtFindByName
            // 
            this.txtFindByName.Location = new System.Drawing.Point(72, 29);
            this.txtFindByName.Name = "txtFindByName";
            this.txtFindByName.Size = new System.Drawing.Size(135, 23);
            this.txtFindByName.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name:";
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDeleteGenre);
            this.grpDelete.Controls.Add(this.label4);
            this.grpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDelete.Location = new System.Drawing.Point(562, 16);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(186, 75);
            this.grpDelete.TabIndex = 9;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete Genre";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(86, 32);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 26);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteGenre
            // 
            this.txtDeleteGenre.Location = new System.Drawing.Point(46, 32);
            this.txtDeleteGenre.Name = "txtDeleteGenre";
            this.txtDeleteGenre.Size = new System.Drawing.Size(34, 23);
            this.txtDeleteGenre.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Id:";
            // 
            // grpUpdateGenre
            // 
            this.grpUpdateGenre.Controls.Add(this.txtUpdateName);
            this.grpUpdateGenre.Controls.Add(this.btnUpdate);
            this.grpUpdateGenre.Controls.Add(this.btnFindById);
            this.grpUpdateGenre.Controls.Add(this.txtFindById);
            this.grpUpdateGenre.Controls.Add(this.label3);
            this.grpUpdateGenre.Controls.Add(this.label2);
            this.grpUpdateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUpdateGenre.Location = new System.Drawing.Point(279, 14);
            this.grpUpdateGenre.Name = "grpUpdateGenre";
            this.grpUpdateGenre.Size = new System.Drawing.Size(277, 164);
            this.grpUpdateGenre.TabIndex = 8;
            this.grpUpdateGenre.TabStop = false;
            this.grpUpdateGenre.Text = "Update Genre";
            // 
            // txtUpdateName
            // 
            this.txtUpdateName.Location = new System.Drawing.Point(72, 76);
            this.txtUpdateName.Name = "txtUpdateName";
            this.txtUpdateName.Size = new System.Drawing.Size(182, 23);
            this.txtUpdateName.TabIndex = 4;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(163, 108);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 39);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnFindById
            // 
            this.btnFindById.Location = new System.Drawing.Point(151, 37);
            this.btnFindById.Name = "btnFindById";
            this.btnFindById.Size = new System.Drawing.Size(103, 26);
            this.btnFindById.TabIndex = 2;
            this.btnFindById.Text = "Find By Id";
            this.btnFindById.UseVisualStyleBackColor = true;
            this.btnFindById.Click += new System.EventHandler(this.btnFindById_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(42, 37);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(103, 23);
            this.txtFindById.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(1, 184);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(922, 227);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Genre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(895, 195);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpCreateGenre
            // 
            this.grpCreateGenre.Controls.Add(this.btnCreate);
            this.grpCreateGenre.Controls.Add(this.txtCreateName);
            this.grpCreateGenre.Controls.Add(this.label1);
            this.grpCreateGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpCreateGenre.Location = new System.Drawing.Point(3, 14);
            this.grpCreateGenre.Margin = new System.Windows.Forms.Padding(5);
            this.grpCreateGenre.Name = "grpCreateGenre";
            this.grpCreateGenre.Padding = new System.Windows.Forms.Padding(5);
            this.grpCreateGenre.Size = new System.Drawing.Size(267, 164);
            this.grpCreateGenre.TabIndex = 6;
            this.grpCreateGenre.TabStop = false;
            this.grpCreateGenre.Text = "Create Genre";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(140, 69);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(103, 46);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtCreateName
            // 
            this.txtCreateName.Location = new System.Drawing.Point(78, 37);
            this.txtCreateName.Name = "txtCreateName";
            this.txtCreateName.Size = new System.Drawing.Size(165, 23);
            this.txtCreateName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // AdminGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 508);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grpFindByName);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdateGenre);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpCreateGenre);
            this.Name = "AdminGenre";
            this.Text = "AdminGenre";
            this.Load += new System.EventHandler(this.AdminGenre_Load);
            this.groupBox2.ResumeLayout(false);
            this.grpFindByName.ResumeLayout(false);
            this.grpFindByName.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpUpdateGenre.ResumeLayout(false);
            this.grpUpdateGenre.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpCreateGenre.ResumeLayout(false);
            this.grpCreateGenre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.GroupBox grpFindByName;
        private System.Windows.Forms.Button btnFindByName;
        private System.Windows.Forms.TextBox txtFindByName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteGenre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox grpUpdateGenre;
        private System.Windows.Forms.TextBox txtUpdateName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnFindById;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpCreateGenre;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtCreateName;
        private System.Windows.Forms.Label label1;
    }
}