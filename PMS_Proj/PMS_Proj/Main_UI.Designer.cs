namespace PMS_Proj
{
    partial class Main_UI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Login_User_Field = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Logout_Btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.Logout_Btn);
            this.panel1.Controls.Add(this.Login_User_Field);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(984, 79);
            this.panel1.TabIndex = 0;
            // 
            // Login_User_Field
            // 
            this.Login_User_Field.AutoSize = true;
            this.Login_User_Field.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Login_User_Field.Location = new System.Drawing.Point(830, 9);
            this.Login_User_Field.Name = "Login_User_Field";
            this.Login_User_Field.Size = new System.Drawing.Size(142, 21);
            this.Login_User_Field.TabIndex = 1;
            this.Login_User_Field.Text = "login_User_Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "ProductManageMentSystem_Project";
            // 
            // Logout_Btn
            // 
            this.Logout_Btn.Location = new System.Drawing.Point(909, 56);
            this.Logout_Btn.Name = "Logout_Btn";
            this.Logout_Btn.Size = new System.Drawing.Size(75, 23);
            this.Logout_Btn.TabIndex = 2;
            this.Logout_Btn.Text = "Logout";
            this.Logout_Btn.UseVisualStyleBackColor = true;
            this.Logout_Btn.Click += new System.EventHandler(this.Logout_Btn_Click);
            // 
            // Main_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.panel1);
            this.Name = "Main_UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main_UI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label Login_User_Field;
        private Label label1;
        private Button Logout_Btn;
    }
}