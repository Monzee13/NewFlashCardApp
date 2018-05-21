namespace NewFlashCardApp
{
    partial class frm_Login
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
            this.tbo_Password = new System.Windows.Forms.TextBox();
            this.tbo_UserName = new System.Windows.Forms.TextBox();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.btn_Login1 = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbo_Password
            // 
            this.tbo_Password.Location = new System.Drawing.Point(426, 231);
            this.tbo_Password.Name = "tbo_Password";
            this.tbo_Password.Size = new System.Drawing.Size(100, 26);
            this.tbo_Password.TabIndex = 0;
            // 
            // tbo_UserName
            // 
            this.tbo_UserName.Location = new System.Drawing.Point(426, 183);
            this.tbo_UserName.Name = "tbo_UserName";
            this.tbo_UserName.Size = new System.Drawing.Size(100, 26);
            this.tbo_UserName.TabIndex = 1;
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(258, 189);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 20);
            this.lbl_UserName.TabIndex = 2;
            this.lbl_UserName.Text = "USER NAME :";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(258, 237);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(111, 20);
            this.lbl_Password.TabIndex = 3;
            this.lbl_Password.Text = "PASSWORD :";
            // 
            // btn_Login1
            // 
            this.btn_Login1.Location = new System.Drawing.Point(262, 333);
            this.btn_Login1.Name = "btn_Login1";
            this.btn_Login1.Size = new System.Drawing.Size(75, 50);
            this.btn_Login1.TabIndex = 4;
            this.btn_Login1.Text = "Login";
            this.btn_Login1.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(450, 332);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 51);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_UserName);
            this.Controls.Add(this.tbo_UserName);
            this.Controls.Add(this.tbo_Password);
            this.Name = "frm_Login";
            this.Text = "Flash Card Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbo_Password;
        private System.Windows.Forms.TextBox tbo_UserName;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Button btn_Login1;
        private System.Windows.Forms.Button btn_Cancel;
    }
}