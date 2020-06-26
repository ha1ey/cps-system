namespace cpssystem
{
    partial class FormJoin
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblpasswd = new System.Windows.Forms.Label();
            this.txtPasswdj = new System.Windows.Forms.TextBox();
            this.lblpasswdck = new System.Windows.Forms.Label();
            this.txtPasswdck = new System.Windows.Forms.TextBox();
            this.lblposition = new System.Windows.Forms.Label();
            this.lbldepartments = new System.Windows.Forms.Label();
            this.lbljobyear = new System.Windows.Forms.Label();
            this.txtJobyear = new System.Windows.Forms.TextBox();
            this.cmbPosition = new System.Windows.Forms.ComboBox();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnJoinDB = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("경기천년제목L Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(89, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 23;
            this.label2.Text = "회원가입";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblname.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblname.Location = new System.Drawing.Point(32, 76);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(31, 15);
            this.lblname.TabIndex = 24;
            this.lblname.Text = "이름";
            this.lblname.Click += new System.EventHandler(this.Lblname_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtName.Location = new System.Drawing.Point(117, 71);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(121, 23);
            this.txtName.TabIndex = 25;
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // lblpasswd
            // 
            this.lblpasswd.AutoSize = true;
            this.lblpasswd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblpasswd.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpasswd.Location = new System.Drawing.Point(32, 117);
            this.lblpasswd.Name = "lblpasswd";
            this.lblpasswd.Size = new System.Drawing.Size(55, 15);
            this.lblpasswd.TabIndex = 26;
            this.lblpasswd.Text = "비밀번호";
            // 
            // txtPasswdj
            // 
            this.txtPasswdj.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtPasswdj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPasswdj.Location = new System.Drawing.Point(117, 112);
            this.txtPasswdj.Name = "txtPasswdj";
            this.txtPasswdj.Size = new System.Drawing.Size(121, 23);
            this.txtPasswdj.TabIndex = 27;
            // 
            // lblpasswdck
            // 
            this.lblpasswdck.AutoSize = true;
            this.lblpasswdck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblpasswdck.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblpasswdck.Location = new System.Drawing.Point(32, 158);
            this.lblpasswdck.Name = "lblpasswdck";
            this.lblpasswdck.Size = new System.Drawing.Size(80, 15);
            this.lblpasswdck.TabIndex = 28;
            this.lblpasswdck.Text = "비밀번호확인";
            // 
            // txtPasswdck
            // 
            this.txtPasswdck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtPasswdck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtPasswdck.Location = new System.Drawing.Point(117, 153);
            this.txtPasswdck.Name = "txtPasswdck";
            this.txtPasswdck.Size = new System.Drawing.Size(121, 23);
            this.txtPasswdck.TabIndex = 29;
            // 
            // lblposition
            // 
            this.lblposition.AutoSize = true;
            this.lblposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblposition.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblposition.Location = new System.Drawing.Point(32, 199);
            this.lblposition.Name = "lblposition";
            this.lblposition.Size = new System.Drawing.Size(32, 15);
            this.lblposition.TabIndex = 30;
            this.lblposition.Text = "직책";
            this.lblposition.Click += new System.EventHandler(this.Lblposition_Click);
            // 
            // lbldepartments
            // 
            this.lbldepartments.AutoSize = true;
            this.lbldepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lbldepartments.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldepartments.Location = new System.Drawing.Point(32, 240);
            this.lbldepartments.Name = "lbldepartments";
            this.lbldepartments.Size = new System.Drawing.Size(31, 15);
            this.lbldepartments.TabIndex = 31;
            this.lbldepartments.Text = "부서";
            this.lbldepartments.Click += new System.EventHandler(this.Lbldepartments_Click);
            // 
            // lbljobyear
            // 
            this.lbljobyear.AutoSize = true;
            this.lbljobyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lbljobyear.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbljobyear.Location = new System.Drawing.Point(32, 281);
            this.lbljobyear.Name = "lbljobyear";
            this.lbljobyear.Size = new System.Drawing.Size(56, 15);
            this.lbljobyear.TabIndex = 32;
            this.lbljobyear.Text = "입사년도";
            // 
            // txtJobyear
            // 
            this.txtJobyear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtJobyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtJobyear.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtJobyear.Location = new System.Drawing.Point(117, 277);
            this.txtJobyear.Name = "txtJobyear";
            this.txtJobyear.Size = new System.Drawing.Size(121, 23);
            this.txtJobyear.TabIndex = 33;
            // 
            // cmbPosition
            // 
            this.cmbPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPosition.FormattingEnabled = true;
            this.cmbPosition.Location = new System.Drawing.Point(117, 197);
            this.cmbPosition.Name = "cmbPosition";
            this.cmbPosition.Size = new System.Drawing.Size(121, 24);
            this.cmbPosition.TabIndex = 34;
            this.cmbPosition.SelectedIndexChanged += new System.EventHandler(this.CmbPosition_SelectedIndexChanged);
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Location = new System.Drawing.Point(117, 238);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(121, 24);
            this.cmbDepartment.TabIndex = 35;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.CmbDepartment_SelectedIndexChanged);
            // 
            // btnJoinDB
            // 
            this.btnJoinDB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnJoinDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnJoinDB.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnJoinDB.ForeColor = System.Drawing.Color.White;
            this.btnJoinDB.Location = new System.Drawing.Point(147, 314);
            this.btnJoinDB.Margin = new System.Windows.Forms.Padding(2);
            this.btnJoinDB.Name = "btnJoinDB";
            this.btnJoinDB.Size = new System.Drawing.Size(91, 29);
            this.btnJoinDB.TabIndex = 36;
            this.btnJoinDB.Text = "회원가입";
            this.btnJoinDB.UseVisualStyleBackColor = false;
            this.btnJoinDB.Click += new System.EventHandler(this.BtnJoinDB_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("함초롬돋움", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(35, 314);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(87, 29);
            this.btnReset.TabIndex = 37;
            this.btnReset.Text = "다시쓰기";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // FormJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(271, 383);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnJoinDB);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.cmbPosition);
            this.Controls.Add(this.txtJobyear);
            this.Controls.Add(this.lbljobyear);
            this.Controls.Add(this.lbldepartments);
            this.Controls.Add(this.lblposition);
            this.Controls.Add(this.txtPasswdck);
            this.Controls.Add(this.lblpasswdck);
            this.Controls.Add(this.txtPasswdj);
            this.Controls.Add(this.lblpasswd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormJoin";
            this.Text = "FormJoin";
            this.Load += new System.EventHandler(this.FormJoin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblpasswd;
        private System.Windows.Forms.TextBox txtPasswdj;
        private System.Windows.Forms.Label lblpasswdck;
        private System.Windows.Forms.TextBox txtPasswdck;
        private System.Windows.Forms.Label lblposition;
        private System.Windows.Forms.Label lbldepartments;
        private System.Windows.Forms.Label lbljobyear;
        private System.Windows.Forms.TextBox txtJobyear;
        private System.Windows.Forms.ComboBox cmbPosition;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Button btnJoinDB;
        private System.Windows.Forms.Button btnReset;
    }
}