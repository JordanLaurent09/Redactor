
namespace Redactor
{
    partial class RegistrationForm
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
            this.RegistrateBTN = new System.Windows.Forms.Button();
            this.UserNameTB = new System.Windows.Forms.TextBox();
            this.userPassTB = new System.Windows.Forms.TextBox();
            this.userRoleTB = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RegistrateBTN
            // 
            this.RegistrateBTN.Location = new System.Drawing.Point(523, 180);
            this.RegistrateBTN.Name = "RegistrateBTN";
            this.RegistrateBTN.Size = new System.Drawing.Size(126, 23);
            this.RegistrateBTN.TabIndex = 0;
            this.RegistrateBTN.Text = "Зарегистрироваться";
            this.RegistrateBTN.UseVisualStyleBackColor = true;
            this.RegistrateBTN.Click += new System.EventHandler(this.RegistrateBTN_Click);
            // 
            // UserNameTB
            // 
            this.UserNameTB.Location = new System.Drawing.Point(222, 88);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(100, 20);
            this.UserNameTB.TabIndex = 1;
            // 
            // userPassTB
            // 
            this.userPassTB.Location = new System.Drawing.Point(222, 143);
            this.userPassTB.Name = "userPassTB";
            this.userPassTB.Size = new System.Drawing.Size(100, 20);
            this.userPassTB.TabIndex = 2;
            // 
            // userRoleTB
            // 
            this.userRoleTB.Location = new System.Drawing.Point(222, 197);
            this.userRoleTB.Name = "userRoleTB";
            this.userRoleTB.Size = new System.Drawing.Size(100, 20);
            this.userRoleTB.TabIndex = 3;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(222, 257);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.userRoleTB);
            this.Controls.Add(this.userPassTB);
            this.Controls.Add(this.UserNameTB);
            this.Controls.Add(this.RegistrateBTN);
            this.Name = "RegistrationForm";
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RegistrateBTN;
        private System.Windows.Forms.TextBox UserNameTB;
        private System.Windows.Forms.TextBox userPassTB;
        private System.Windows.Forms.TextBox userRoleTB;
        private System.Windows.Forms.TextBox textBox3;
    }
}