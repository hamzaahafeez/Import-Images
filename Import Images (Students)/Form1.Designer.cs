
namespace Import_Images__Students_
{
    partial class Form1
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
            this.btn_upload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_importtocrm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_save = new System.Windows.Forms.Button();
            this.txtbox_envUrl = new System.Windows.Forms.TextBox();
            this.txtbox_secretid = new System.Windows.Forms.TextBox();
            this.txtbox_clientid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_fieldname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_entityname = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_conection = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_upload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_upload.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_upload.Location = new System.Drawing.Point(343, 56);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(105, 23);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Select Folder";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Folder...";
            // 
            // btn_importtocrm
            // 
            this.btn_importtocrm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_importtocrm.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_importtocrm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_importtocrm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importtocrm.Location = new System.Drawing.Point(62, 98);
            this.btn_importtocrm.Name = "btn_importtocrm";
            this.btn_importtocrm.Size = new System.Drawing.Size(385, 30);
            this.btn_importtocrm.TabIndex = 2;
            this.btn_importtocrm.Text = "Import to CRM";
            this.btn_importtocrm.UseVisualStyleBackColor = false;
            this.btn_importtocrm.Click += new System.EventHandler(this.btn_importtocrm_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(62, 163);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(188, 173);
            this.listBox1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(162, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Import Entity Images";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(260, 163);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(188, 173);
            this.listBox2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Uploaded";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(258, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Not Uploaded";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(59, 416);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Secret ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(59, 385);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Client ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(59, 353);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 15);
            this.label9.TabIndex = 14;
            this.label9.Text = "Env. URL:";
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_save.Location = new System.Drawing.Point(293, 448);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 48);
            this.btn_save.TabIndex = 18;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // txtbox_envUrl
            // 
            this.txtbox_envUrl.Location = new System.Drawing.Point(149, 350);
            this.txtbox_envUrl.Name = "txtbox_envUrl";
            this.txtbox_envUrl.Size = new System.Drawing.Size(298, 20);
            this.txtbox_envUrl.TabIndex = 19;
            // 
            // txtbox_secretid
            // 
            this.txtbox_secretid.Location = new System.Drawing.Point(149, 415);
            this.txtbox_secretid.Name = "txtbox_secretid";
            this.txtbox_secretid.Size = new System.Drawing.Size(298, 20);
            this.txtbox_secretid.TabIndex = 20;
            // 
            // txtbox_clientid
            // 
            this.txtbox_clientid.Location = new System.Drawing.Point(149, 382);
            this.txtbox_clientid.Name = "txtbox_clientid";
            this.txtbox_clientid.Size = new System.Drawing.Size(298, 20);
            this.txtbox_clientid.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(59, 448);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Entity Name";
            // 
            // txtbox_fieldname
            // 
            this.txtbox_fieldname.Location = new System.Drawing.Point(149, 474);
            this.txtbox_fieldname.Name = "txtbox_fieldname";
            this.txtbox_fieldname.Size = new System.Drawing.Size(128, 20);
            this.txtbox_fieldname.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(59, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 15);
            this.label3.TabIndex = 24;
            this.label3.Text = "Field Name";
            // 
            // txtbox_entityname
            // 
            this.txtbox_entityname.Location = new System.Drawing.Point(149, 448);
            this.txtbox_entityname.Name = "txtbox_entityname";
            this.txtbox_entityname.Size = new System.Drawing.Size(128, 20);
            this.txtbox_entityname.TabIndex = 26;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Location = new System.Drawing.Point(372, 448);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 48);
            this.btn_delete.TabIndex = 27;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_conection
            // 
            this.lbl_conection.AutoSize = true;
            this.lbl_conection.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conection.ForeColor = System.Drawing.Color.Red;
            this.lbl_conection.Location = new System.Drawing.Point(363, 24);
            this.lbl_conection.Name = "lbl_conection";
            this.lbl_conection.Size = new System.Drawing.Size(85, 14);
            this.lbl_conection.TabIndex = 28;
            this.lbl_conection.Text = "Not Connected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(521, 508);
            this.Controls.Add(this.lbl_conection);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.txtbox_entityname);
            this.Controls.Add(this.txtbox_fieldname);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_clientid);
            this.Controls.Add(this.txtbox_secretid);
            this.Controls.Add(this.txtbox_envUrl);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_importtocrm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_upload);
            this.Name = "Form1";
            this.Text = "Import Entity Images";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_importtocrm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.TextBox txtbox_envUrl;
        private System.Windows.Forms.TextBox txtbox_secretid;
        private System.Windows.Forms.TextBox txtbox_clientid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_fieldname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_entityname;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_conection;
    }
}

