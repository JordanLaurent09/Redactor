
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
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.secondNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.birthDateDTP = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.authorCB = new System.Windows.Forms.CheckBox();
            this.readerCB = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
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
            this.UserNameTB.Location = new System.Drawing.Point(113, 40);
            this.UserNameTB.Name = "UserNameTB";
            this.UserNameTB.Size = new System.Drawing.Size(100, 20);
            this.UserNameTB.TabIndex = 1;
            // 
            // userPassTB
            // 
            this.userPassTB.Location = new System.Drawing.Point(113, 91);
            this.userPassTB.Name = "userPassTB";
            this.userPassTB.Size = new System.Drawing.Size(100, 20);
            this.userPassTB.TabIndex = 2;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(114, 139);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Придумайте логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Придумайте пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Введите свое имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(112, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Введите свою фамилию:";
            // 
            // secondNameTB
            // 
            this.secondNameTB.Location = new System.Drawing.Point(114, 187);
            this.secondNameTB.Name = "secondNameTB";
            this.secondNameTB.Size = new System.Drawing.Size(100, 20);
            this.secondNameTB.TabIndex = 9;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(113, 238);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(216, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Укажите свой адрес электронной почты:";
            // 
            // birthDateDTP
            // 
            this.birthDateDTP.Location = new System.Drawing.Point(113, 289);
            this.birthDateDTP.Name = "birthDateDTP";
            this.birthDateDTP.Size = new System.Drawing.Size(200, 20);
            this.birthDateDTP.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(111, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Укажите свою дату рождения:";
            // 
            // authorCB
            // 
            this.authorCB.AutoSize = true;
            this.authorCB.Location = new System.Drawing.Point(115, 353);
            this.authorCB.Name = "authorCB";
            this.authorCB.Size = new System.Drawing.Size(56, 17);
            this.authorCB.TabIndex = 14;
            this.authorCB.Text = "Автор";
            this.authorCB.UseVisualStyleBackColor = true;
            // 
            // readerCB
            // 
            this.readerCB.AutoSize = true;
            this.readerCB.Location = new System.Drawing.Point(233, 353);
            this.readerCB.Name = "readerCB";
            this.readerCB.Size = new System.Drawing.Size(74, 17);
            this.readerCB.TabIndex = 15;
            this.readerCB.Text = "Читатель";
            this.readerCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Укажите свою роль:";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.readerCB);
            this.Controls.Add(this.authorCB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.birthDateDTP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.secondNameTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNameTB);
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
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox secondNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthDateDTP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox authorCB;
        private System.Windows.Forms.CheckBox readerCB;
        private System.Windows.Forms.Label label7;
    }
}