namespace PMS_Proj
{
    partial class Login_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.PW = new System.Windows.Forms.Label();
            this.Id_Field = new System.Windows.Forms.TextBox();
            this.Pw_Field = new System.Windows.Forms.TextBox();
            this.Login_Btn = new System.Windows.Forms.Button();
            this.SignUp_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.SystemColors.Control;
            this.Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Title.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Title.ForeColor = System.Drawing.Color.Black;
            this.Title.Location = new System.Drawing.Point(12, 48);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(360, 49);
            this.Title.TabIndex = 0;
            this.Title.Text = "ProductManagementSystem_Project";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ID.Location = new System.Drawing.Point(103, 173);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(31, 21);
            this.ID.TabIndex = 1;
            this.ID.Text = "I D";
            // 
            // PW
            // 
            this.PW.AutoSize = true;
            this.PW.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PW.Location = new System.Drawing.Point(103, 218);
            this.PW.Name = "PW";
            this.PW.Size = new System.Drawing.Size(40, 21);
            this.PW.TabIndex = 1;
            this.PW.Text = "P W";
            // 
            // Id_Field
            // 
            this.Id_Field.Location = new System.Drawing.Point(157, 171);
            this.Id_Field.Name = "Id_Field";
            this.Id_Field.Size = new System.Drawing.Size(132, 23);
            this.Id_Field.TabIndex = 1;
            // 
            // Pw_Field
            // 
            this.Pw_Field.Location = new System.Drawing.Point(157, 216);
            this.Pw_Field.Name = "Pw_Field";
            this.Pw_Field.Size = new System.Drawing.Size(132, 23);
            this.Pw_Field.TabIndex = 2;
            // 
            // Login_Btn
            // 
            this.Login_Btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_Btn.Location = new System.Drawing.Point(157, 267);
            this.Login_Btn.Name = "Login_Btn";
            this.Login_Btn.Size = new System.Drawing.Size(105, 37);
            this.Login_Btn.TabIndex = 3;
            this.Login_Btn.Text = "Login";
            this.Login_Btn.UseVisualStyleBackColor = true;
            this.Login_Btn.Click += new System.EventHandler(this.Login_Btn_Click);
            // 
            // SignUp_Btn
            // 
            this.SignUp_Btn.AutoSize = true;
            this.SignUp_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUp_Btn.FlatAppearance.BorderSize = 0;
            this.SignUp_Btn.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SignUp_Btn.ForeColor = System.Drawing.Color.Black;
            this.SignUp_Btn.Location = new System.Drawing.Point(157, 319);
            this.SignUp_Btn.Name = "SignUp_Btn";
            this.SignUp_Btn.Size = new System.Drawing.Size(105, 37);
            this.SignUp_Btn.TabIndex = 5;
            this.SignUp_Btn.Text = "SignUp";
            this.SignUp_Btn.UseVisualStyleBackColor = true;
            this.SignUp_Btn.Click += new System.EventHandler(this.SignUp_Btn_Click);
            // 
            // Login_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.SignUp_Btn);
            this.Controls.Add(this.Login_Btn);
            this.Controls.Add(this.Pw_Field);
            this.Controls.Add(this.Id_Field);
            this.Controls.Add(this.PW);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.Title);
            this.Name = "Login_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Title;
        private Label ID;
        private Label PW;
        private TextBox Id_Field;
        private TextBox Pw_Field;
        private Button Login_Btn;
        private Button SignUp_Btn;
    }
}