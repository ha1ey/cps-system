namespace cpssystem
{
    partial class FormMain
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
            this.lblmessage = new System.Windows.Forms.Label();
            this.lbllogotext = new System.Windows.Forms.Label();
            this.txtsendbox = new System.Windows.Forms.TextBox();
            this.btnsend = new System.Windows.Forms.Button();
            this.lblmessage2 = new System.Windows.Forms.Label();
            this.txtleavemessage = new System.Windows.Forms.TextBox();
            this.lblmessage3 = new System.Windows.Forms.Label();
            this.lblsubscribe = new System.Windows.Forms.Label();
            this.cmbDepartments = new System.Windows.Forms.ComboBox();
            this.cmbPositions = new System.Windows.Forms.ComboBox();
            this.lbldepartments3 = new System.Windows.Forms.Label();
            this.lblposition2 = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.lblname1 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtpostbox = new System.Windows.Forms.TextBox();
            this.sublistbox = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblmessage
            // 
            this.lblmessage.AutoSize = true;
            this.lblmessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblmessage.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblmessage.Location = new System.Drawing.Point(12, 61);
            this.lblmessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage.Name = "lblmessage";
            this.lblmessage.Size = new System.Drawing.Size(69, 15);
            this.lblmessage.TabIndex = 0;
            this.lblmessage.Text = "메시지내용";
            // 
            // lbllogotext
            // 
            this.lbllogotext.AutoSize = true;
            this.lbllogotext.Font = new System.Drawing.Font("경기천년바탕 Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbllogotext.Location = new System.Drawing.Point(182, 17);
            this.lbllogotext.Name = "lbllogotext";
            this.lbllogotext.Size = new System.Drawing.Size(204, 32);
            this.lbllogotext.TabIndex = 16;
            this.lbllogotext.Text = "CPS SYSTEM";
            // 
            // txtsendbox
            // 
            this.txtsendbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtsendbox.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtsendbox.Location = new System.Drawing.Point(86, 55);
            this.txtsendbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtsendbox.Multiline = true;
            this.txtsendbox.Name = "txtsendbox";
            this.txtsendbox.Size = new System.Drawing.Size(407, 29);
            this.txtsendbox.TabIndex = 17;
            // 
            // btnsend
            // 
            this.btnsend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnsend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsend.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsend.ForeColor = System.Drawing.Color.White;
            this.btnsend.Location = new System.Drawing.Point(508, 54);
            this.btnsend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsend.Name = "btnsend";
            this.btnsend.Size = new System.Drawing.Size(73, 28);
            this.btnsend.TabIndex = 18;
            this.btnsend.Text = "전송";
            this.btnsend.UseVisualStyleBackColor = false;
            this.btnsend.Visible = false;
            this.btnsend.Click += new System.EventHandler(this.Btnsend_Click);
            // 
            // lblmessage2
            // 
            this.lblmessage2.AutoSize = true;
            this.lblmessage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblmessage2.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblmessage2.Location = new System.Drawing.Point(12, 98);
            this.lblmessage2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage2.Name = "lblmessage2";
            this.lblmessage2.Size = new System.Drawing.Size(69, 15);
            this.lblmessage2.TabIndex = 19;
            this.lblmessage2.Text = "받은메시지";
            // 
            // txtleavemessage
            // 
            this.txtleavemessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtleavemessage.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtleavemessage.Location = new System.Drawing.Point(15, 257);
            this.txtleavemessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtleavemessage.Multiline = true;
            this.txtleavemessage.Name = "txtleavemessage";
            this.txtleavemessage.Size = new System.Drawing.Size(395, 132);
            this.txtleavemessage.TabIndex = 22;
            // 
            // lblmessage3
            // 
            this.lblmessage3.AutoSize = true;
            this.lblmessage3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblmessage3.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblmessage3.Location = new System.Drawing.Point(12, 236);
            this.lblmessage3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmessage3.Name = "lblmessage3";
            this.lblmessage3.Size = new System.Drawing.Size(69, 15);
            this.lblmessage3.TabIndex = 21;
            this.lblmessage3.Text = "부재메시지";
            this.lblmessage3.Click += new System.EventHandler(this.Lblmessage3_Click);
            // 
            // lblsubscribe
            // 
            this.lblsubscribe.AutoSize = true;
            this.lblsubscribe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblsubscribe.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblsubscribe.Location = new System.Drawing.Point(425, 98);
            this.lblsubscribe.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsubscribe.Name = "lblsubscribe";
            this.lblsubscribe.Size = new System.Drawing.Size(56, 15);
            this.lblsubscribe.TabIndex = 23;
            this.lblsubscribe.Text = "구독하기";
            // 
            // cmbDepartments
            // 
            this.cmbDepartments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbDepartments.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbDepartments.FormattingEnabled = true;
            this.cmbDepartments.Location = new System.Drawing.Point(463, 194);
            this.cmbDepartments.Name = "cmbDepartments";
            this.cmbDepartments.Size = new System.Drawing.Size(118, 23);
            this.cmbDepartments.TabIndex = 41;
            // 
            // cmbPositions
            // 
            this.cmbPositions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.cmbPositions.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmbPositions.FormattingEnabled = true;
            this.cmbPositions.Location = new System.Drawing.Point(463, 157);
            this.cmbPositions.Name = "cmbPositions";
            this.cmbPositions.Size = new System.Drawing.Size(118, 23);
            this.cmbPositions.TabIndex = 40;
            // 
            // lbldepartments3
            // 
            this.lbldepartments3.AutoSize = true;
            this.lbldepartments3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lbldepartments3.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbldepartments3.Location = new System.Drawing.Point(425, 196);
            this.lbldepartments3.Name = "lbldepartments3";
            this.lbldepartments3.Size = new System.Drawing.Size(31, 15);
            this.lbldepartments3.TabIndex = 39;
            this.lbldepartments3.Text = "부서";
            // 
            // lblposition2
            // 
            this.lblposition2.AutoSize = true;
            this.lblposition2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblposition2.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblposition2.Location = new System.Drawing.Point(425, 159);
            this.lblposition2.Name = "lblposition2";
            this.lblposition2.Size = new System.Drawing.Size(32, 15);
            this.lblposition2.TabIndex = 38;
            this.lblposition2.Text = "직책";
            this.lblposition2.Click += new System.EventHandler(this.Lblposition2_Click);
            // 
            // txtNames
            // 
            this.txtNames.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtNames.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtNames.Location = new System.Drawing.Point(463, 122);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(118, 22);
            this.txtNames.TabIndex = 37;
            // 
            // lblname1
            // 
            this.lblname1.AutoSize = true;
            this.lblname1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.lblname1.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblname1.Location = new System.Drawing.Point(425, 122);
            this.lblname1.Name = "lblname1";
            this.lblname1.Size = new System.Drawing.Size(31, 15);
            this.lblname1.TabIndex = 36;
            this.lblname1.Text = "이름";
            this.lblname1.Click += new System.EventHandler(this.Lblname1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(122)))), ((int)(((byte)(235)))));
            this.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsearch.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnsearch.ForeColor = System.Drawing.Color.White;
            this.btnsearch.Location = new System.Drawing.Point(524, 225);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(57, 25);
            this.btnsearch.TabIndex = 42;
            this.btnsearch.Text = "검색";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.Btnsearch_Click);
            // 
            // txtpostbox
            // 
            this.txtpostbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.txtpostbox.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtpostbox.Location = new System.Drawing.Point(15, 122);
            this.txtpostbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtpostbox.Multiline = true;
            this.txtpostbox.Name = "txtpostbox";
            this.txtpostbox.Size = new System.Drawing.Size(395, 98);
            this.txtpostbox.TabIndex = 20;
            // 
            // sublistbox
            // 
            this.sublistbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.sublistbox.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sublistbox.FormattingEnabled = true;
            this.sublistbox.Location = new System.Drawing.Point(428, 257);
            this.sublistbox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sublistbox.Name = "sublistbox";
            this.sublistbox.Size = new System.Drawing.Size(153, 132);
            this.sublistbox.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.comboBox1.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(330, 94);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(80, 23);
            this.comboBox1.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.label1.Font = new System.Drawing.Font("경기천년제목L Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(238, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 45;
            this.label1.Text = "번역 언어 설정";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.sublistbox);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.cmbDepartments);
            this.Controls.Add(this.cmbPositions);
            this.Controls.Add(this.lbldepartments3);
            this.Controls.Add(this.lblposition2);
            this.Controls.Add(this.txtNames);
            this.Controls.Add(this.lblname1);
            this.Controls.Add(this.lblsubscribe);
            this.Controls.Add(this.txtleavemessage);
            this.Controls.Add(this.lblmessage3);
            this.Controls.Add(this.txtpostbox);
            this.Controls.Add(this.lblmessage2);
            this.Controls.Add(this.btnsend);
            this.Controls.Add(this.txtsendbox);
            this.Controls.Add(this.lbllogotext);
            this.Controls.Add(this.lblmessage);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblmessage;
        private System.Windows.Forms.Label lbllogotext;
        private System.Windows.Forms.TextBox txtsendbox;
        private System.Windows.Forms.Button btnsend;
        private System.Windows.Forms.Label lblmessage2;
        private System.Windows.Forms.TextBox txtleavemessage;
        private System.Windows.Forms.Label lblmessage3;
        private System.Windows.Forms.Label lblsubscribe;
        private System.Windows.Forms.ComboBox cmbDepartments;
        private System.Windows.Forms.ComboBox cmbPositions;
        private System.Windows.Forms.Label lbldepartments3;
        private System.Windows.Forms.Label lblposition2;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.Label lblname1;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtpostbox;
        private System.Windows.Forms.CheckedListBox sublistbox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}