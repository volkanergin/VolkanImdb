namespace YMS5573_VolkanIMDB_Project.Admin_Pages
{
    partial class AdminImdbUser
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
            this.grpFindByRole = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cmbFindByRole = new System.Windows.Forms.ComboBox();
            this.grpDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtDeleteById = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grpUpdate = new System.Windows.Forms.GroupBox();
            this.btnFindId = new System.Windows.Forms.Button();
            this.cmbUpdateRole = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtFindById = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtUpdateFirstName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUpdatePassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateUserName = new System.Windows.Forms.TextBox();
            this.txtUpdateLastName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grpAddUser = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbAddRole = new System.Windows.Forms.ComboBox();
            this.txtAddPassword = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddLastName = new System.Windows.Forms.TextBox();
            this.txtAddUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpFindByRole.SuspendLayout();
            this.grpDelete.SuspendLayout();
            this.grpUpdate.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grpAddUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFindByRole
            // 
            this.grpFindByRole.Controls.Add(this.label13);
            this.grpFindByRole.Controls.Add(this.cmbFindByRole);
            this.grpFindByRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpFindByRole.Location = new System.Drawing.Point(504, 90);
            this.grpFindByRole.Name = "grpFindByRole";
            this.grpFindByRole.Size = new System.Drawing.Size(226, 81);
            this.grpFindByRole.TabIndex = 10;
            this.grpFindByRole.TabStop = false;
            this.grpFindByRole.Text = "Find By Role";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(95, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "Choose A Role:";
            // 
            // cmbFindByRole
            // 
            this.cmbFindByRole.FormattingEnabled = true;
            this.cmbFindByRole.Location = new System.Drawing.Point(24, 42);
            this.cmbFindByRole.Name = "cmbFindByRole";
            this.cmbFindByRole.Size = new System.Drawing.Size(185, 21);
            this.cmbFindByRole.TabIndex = 2;
            this.cmbFindByRole.SelectedIndexChanged += new System.EventHandler(this.cmbFindByRole_SelectedIndexChanged);
            // 
            // grpDelete
            // 
            this.grpDelete.Controls.Add(this.btnDelete);
            this.grpDelete.Controls.Add(this.txtDeleteById);
            this.grpDelete.Controls.Add(this.label12);
            this.grpDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpDelete.Location = new System.Drawing.Point(504, 12);
            this.grpDelete.Name = "grpDelete";
            this.grpDelete.Size = new System.Drawing.Size(226, 71);
            this.grpDelete.TabIndex = 9;
            this.grpDelete.TabStop = false;
            this.grpDelete.Text = "Delete User";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(134, 31);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtDeleteById
            // 
            this.txtDeleteById.Location = new System.Drawing.Point(29, 33);
            this.txtDeleteById.Name = "txtDeleteById";
            this.txtDeleteById.Size = new System.Drawing.Size(99, 20);
            this.txtDeleteById.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(4, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Id:";
            // 
            // grpUpdate
            // 
            this.grpUpdate.Controls.Add(this.btnFindId);
            this.grpUpdate.Controls.Add(this.cmbUpdateRole);
            this.grpUpdate.Controls.Add(this.btnUpdate);
            this.grpUpdate.Controls.Add(this.txtFindById);
            this.grpUpdate.Controls.Add(this.label11);
            this.grpUpdate.Controls.Add(this.label10);
            this.grpUpdate.Controls.Add(this.txtUpdateFirstName);
            this.grpUpdate.Controls.Add(this.label6);
            this.grpUpdate.Controls.Add(this.txtUpdatePassword);
            this.grpUpdate.Controls.Add(this.label7);
            this.grpUpdate.Controls.Add(this.label8);
            this.grpUpdate.Controls.Add(this.label9);
            this.grpUpdate.Controls.Add(this.txtUpdateUserName);
            this.grpUpdate.Controls.Add(this.txtUpdateLastName);
            this.grpUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpUpdate.Location = new System.Drawing.Point(258, 12);
            this.grpUpdate.Name = "grpUpdate";
            this.grpUpdate.Size = new System.Drawing.Size(239, 290);
            this.grpUpdate.TabIndex = 8;
            this.grpUpdate.TabStop = false;
            this.grpUpdate.Text = "Update User";
            // 
            // btnFindId
            // 
            this.btnFindId.Location = new System.Drawing.Point(116, 34);
            this.btnFindId.Name = "btnFindId";
            this.btnFindId.Size = new System.Drawing.Size(89, 23);
            this.btnFindId.TabIndex = 2;
            this.btnFindId.Text = "Find By Id";
            this.btnFindId.UseVisualStyleBackColor = true;
            this.btnFindId.Click += new System.EventHandler(this.btnFindId_Click);
            // 
            // cmbUpdateRole
            // 
            this.cmbUpdateRole.FormattingEnabled = true;
            this.cmbUpdateRole.Location = new System.Drawing.Point(80, 215);
            this.cmbUpdateRole.Name = "cmbUpdateRole";
            this.cmbUpdateRole.Size = new System.Drawing.Size(121, 21);
            this.cmbUpdateRole.TabIndex = 2;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(116, 244);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(85, 33);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtFindById
            // 
            this.txtFindById.Location = new System.Drawing.Point(37, 37);
            this.txtFindById.Name = "txtFindById";
            this.txtFindById.Size = new System.Drawing.Size(73, 20);
            this.txtFindById.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(77, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Choose A Role:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "Id:";
            // 
            // txtUpdateFirstName
            // 
            this.txtUpdateFirstName.Location = new System.Drawing.Point(91, 68);
            this.txtUpdateFirstName.Name = "txtUpdateFirstName";
            this.txtUpdateFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateFirstName.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // txtUpdatePassword
            // 
            this.txtUpdatePassword.Location = new System.Drawing.Point(91, 170);
            this.txtUpdatePassword.Name = "txtUpdatePassword";
            this.txtUpdatePassword.PasswordChar = '*';
            this.txtUpdatePassword.Size = new System.Drawing.Size(125, 20);
            this.txtUpdatePassword.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "User Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Last Name:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Password:";
            // 
            // txtUpdateUserName
            // 
            this.txtUpdateUserName.Location = new System.Drawing.Point(91, 135);
            this.txtUpdateUserName.Name = "txtUpdateUserName";
            this.txtUpdateUserName.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateUserName.TabIndex = 1;
            // 
            // txtUpdateLastName
            // 
            this.txtUpdateLastName.Location = new System.Drawing.Point(91, 103);
            this.txtUpdateLastName.Name = "txtUpdateLastName";
            this.txtUpdateLastName.Size = new System.Drawing.Size(125, 20);
            this.txtUpdateLastName.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(29, 312);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(885, 244);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List of Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(872, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // grpAddUser
            // 
            this.grpAddUser.Controls.Add(this.btnCreate);
            this.grpAddUser.Controls.Add(this.cmbAddRole);
            this.grpAddUser.Controls.Add(this.txtAddPassword);
            this.grpAddUser.Controls.Add(this.label5);
            this.grpAddUser.Controls.Add(this.label4);
            this.grpAddUser.Controls.Add(this.txtAddLastName);
            this.grpAddUser.Controls.Add(this.txtAddUserName);
            this.grpAddUser.Controls.Add(this.label2);
            this.grpAddUser.Controls.Add(this.label3);
            this.grpAddUser.Controls.Add(this.txtAddFirstName);
            this.grpAddUser.Controls.Add(this.label1);
            this.grpAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpAddUser.Location = new System.Drawing.Point(29, 12);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(223, 290);
            this.grpAddUser.TabIndex = 6;
            this.grpAddUser.TabStop = false;
            this.grpAddUser.Text = "Add User";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(100, 217);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(99, 32);
            this.btnCreate.TabIndex = 3;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbAddRole
            // 
            this.cmbAddRole.FormattingEnabled = true;
            this.cmbAddRole.Location = new System.Drawing.Point(78, 190);
            this.cmbAddRole.Name = "cmbAddRole";
            this.cmbAddRole.Size = new System.Drawing.Size(121, 21);
            this.cmbAddRole.TabIndex = 2;
            // 
            // txtAddPassword
            // 
            this.txtAddPassword.Location = new System.Drawing.Point(89, 139);
            this.txtAddPassword.Name = "txtAddPassword";
            this.txtAddPassword.PasswordChar = '*';
            this.txtAddPassword.Size = new System.Drawing.Size(125, 20);
            this.txtAddPassword.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(75, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Choose A Role:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Password:";
            // 
            // txtAddLastName
            // 
            this.txtAddLastName.Location = new System.Drawing.Point(89, 72);
            this.txtAddLastName.Name = "txtAddLastName";
            this.txtAddLastName.Size = new System.Drawing.Size(125, 20);
            this.txtAddLastName.TabIndex = 1;
            // 
            // txtAddUserName
            // 
            this.txtAddUserName.Location = new System.Drawing.Point(89, 104);
            this.txtAddUserName.Name = "txtAddUserName";
            this.txtAddUserName.Size = new System.Drawing.Size(125, 20);
            this.txtAddUserName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "User Name:";
            // 
            // txtAddFirstName
            // 
            this.txtAddFirstName.Location = new System.Drawing.Point(89, 37);
            this.txtAddFirstName.Name = "txtAddFirstName";
            this.txtAddFirstName.Size = new System.Drawing.Size(125, 20);
            this.txtAddFirstName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            // 
            // AdminImdbUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 507);
            this.Controls.Add(this.grpFindByRole);
            this.Controls.Add(this.grpDelete);
            this.Controls.Add(this.grpUpdate);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpAddUser);
            this.Name = "AdminImdbUser";
            this.Text = "AdminImdbUser";
            this.Load += new System.EventHandler(this.AdminImdbUser_Load);
            this.grpFindByRole.ResumeLayout(false);
            this.grpFindByRole.PerformLayout();
            this.grpDelete.ResumeLayout(false);
            this.grpDelete.PerformLayout();
            this.grpUpdate.ResumeLayout(false);
            this.grpUpdate.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grpFindByRole;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbFindByRole;
        private System.Windows.Forms.GroupBox grpDelete;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtDeleteById;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grpUpdate;
        private System.Windows.Forms.Button btnFindId;
        private System.Windows.Forms.ComboBox cmbUpdateRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtFindById;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtUpdateFirstName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUpdatePassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateUserName;
        private System.Windows.Forms.TextBox txtUpdateLastName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grpAddUser;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbAddRole;
        private System.Windows.Forms.TextBox txtAddPassword;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddLastName;
        private System.Windows.Forms.TextBox txtAddUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddFirstName;
        private System.Windows.Forms.Label label1;
    }
}