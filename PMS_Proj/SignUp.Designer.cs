namespace PMS_Proj
{
    partial class SignUp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SignUp_ID_Field = new System.Windows.Forms.TextBox();
            this.SignUp_PW_Field = new System.Windows.Forms.TextBox();
            this.SignUp_NAME_Field = new System.Windows.Forms.TextBox();
            this.SignUp_PHONE_Field = new System.Windows.Forms.TextBox();
            this.SignUp_EMAIL_Field = new System.Windows.Forms.TextBox();
            this.Sign_Up_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(64, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 21);
            this.label3.TabIndex = 0;
            this.label3.Text = "NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "PHONE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 21);
            this.label5.TabIndex = 0;
            this.label5.Text = "E-MAIL";
            // 
            // SignUp_ID_Field
            // 
            this.SignUp_ID_Field.Location = new System.Drawing.Point(166, 96);
            this.SignUp_ID_Field.Name = "SignUp_ID_Field";
            this.SignUp_ID_Field.Size = new System.Drawing.Size(139, 23);
            this.SignUp_ID_Field.TabIndex = 1;
            // 
            // SignUp_PW_Field
            // 
            this.SignUp_PW_Field.Location = new System.Drawing.Point(166, 136);
            this.SignUp_PW_Field.Name = "SignUp_PW_Field";
            this.SignUp_PW_Field.Size = new System.Drawing.Size(139, 23);
            this.SignUp_PW_Field.TabIndex = 1;
            // 
            // SignUp_NAME_Field
            // 
            this.SignUp_NAME_Field.Location = new System.Drawing.Point(166, 176);
            this.SignUp_NAME_Field.Name = "SignUp_NAME_Field";
            this.SignUp_NAME_Field.Size = new System.Drawing.Size(139, 23);
            this.SignUp_NAME_Field.TabIndex = 1;
            // 
            // SignUp_PHONE_Field
            // 
            this.SignUp_PHONE_Field.Location = new System.Drawing.Point(166, 219);
            this.SignUp_PHONE_Field.Name = "SignUp_PHONE_Field";
            this.SignUp_PHONE_Field.Size = new System.Drawing.Size(139, 23);
            this.SignUp_PHONE_Field.TabIndex = 1;
            // 
            // SignUp_EMAIL_Field
            // 
            this.SignUp_EMAIL_Field.Location = new System.Drawing.Point(166, 268);
            this.SignUp_EMAIL_Field.Name = "SignUp_EMAIL_Field";
            this.SignUp_EMAIL_Field.Size = new System.Drawing.Size(139, 23);
            this.SignUp_EMAIL_Field.TabIndex = 1;
            // 
            // Sign_Up_Btn
            // 
            this.Sign_Up_Btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Sign_Up_Btn.Location = new System.Drawing.Point(126, 345);
            this.Sign_Up_Btn.Name = "Sign_Up_Btn";
            this.Sign_Up_Btn.Size = new System.Drawing.Size(100, 38);
            this.Sign_Up_Btn.TabIndex = 2;
            this.Sign_Up_Btn.Text = "SignUp";
            this.Sign_Up_Btn.UseVisualStyleBackColor = true;
            this.Sign_Up_Btn.Click += new System.EventHandler(this.Sign_Up_Btn_Click);
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.Sign_Up_Btn);
            this.Controls.Add(this.SignUp_EMAIL_Field);
            this.Controls.Add(this.SignUp_PHONE_Field);
            this.Controls.Add(this.SignUp_NAME_Field);
            this.Controls.Add(this.SignUp_PW_Field);
            this.Controls.Add(this.SignUp_ID_Field);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox SignUp_ID_Field;
        private TextBox SignUp_PW_Field;
        private TextBox SignUp_NAME_Field;
        private TextBox SignUp_PHONE_Field;
        private TextBox SignUp_EMAIL_Field;
        private Button Sign_Up_Btn;
    }
}