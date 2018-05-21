namespace NewFlashCardApp
{
    partial class CreateUser
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
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Login1 = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_UserName = new System.Windows.Forms.Label();
            this.tbo_UserName = new System.Windows.Forms.TextBox();
            this.tbo_Password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(458, 274);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 51);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Login1
            // 
            this.btn_Login1.Location = new System.Drawing.Point(270, 275);
            this.btn_Login1.Name = "btn_Login1";
            this.btn_Login1.Size = new System.Drawing.Size(75, 50);
            this.btn_Login1.TabIndex = 10;
            this.btn_Login1.Text = "Add";
            this.btn_Login1.UseVisualStyleBackColor = true;
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.Location = new System.Drawing.Point(266, 179);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(111, 20);
            this.lbl_Password.TabIndex = 9;
            this.lbl_Password.Text = "PASSWORD :";
            // 
            // lbl_UserName
            // 
            this.lbl_UserName.AutoSize = true;
            this.lbl_UserName.Location = new System.Drawing.Point(266, 131);
            this.lbl_UserName.Name = "lbl_UserName";
            this.lbl_UserName.Size = new System.Drawing.Size(113, 20);
            this.lbl_UserName.TabIndex = 8;
            this.lbl_UserName.Text = "USER NAME :";
            // 
            // tbo_UserName
            // 
            this.tbo_UserName.Location = new System.Drawing.Point(434, 125);
            this.tbo_UserName.Name = "tbo_UserName";
            this.tbo_UserName.Size = new System.Drawing.Size(100, 26);
            this.tbo_UserName.TabIndex = 7;
            // 
            // tbo_Password
            // 
            this.tbo_Password.Location = new System.Drawing.Point(434, 173);
            this.tbo_Password.Name = "tbo_Password";
            this.tbo_Password.Size = new System.Drawing.Size(100, 26);
            this.tbo_Password.TabIndex = 6;
            // 
            // CreateUser
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
            this.Name = "CreateUser";
            this.Text = "CreateUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Login1;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_UserName;
        private System.Windows.Forms.TextBox tbo_UserName;
        private System.Windows.Forms.TextBox tbo_Password;
    }
}