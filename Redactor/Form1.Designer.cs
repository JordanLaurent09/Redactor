﻿
namespace Redactor
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userLoginTB = new System.Windows.Forms.TextBox();
            this.logBTN = new System.Windows.Forms.Button();
            this.regBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.userPasswordTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите свой логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 261);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Нет учетной записи?\r\nЗарегистрируйтесь:\r\n";
            // 
            // userLoginTB
            // 
            this.userLoginTB.Location = new System.Drawing.Point(178, 67);
            this.userLoginTB.Name = "userLoginTB";
            this.userLoginTB.Size = new System.Drawing.Size(100, 20);
            this.userLoginTB.TabIndex = 2;
            // 
            // logBTN
            // 
            this.logBTN.Location = new System.Drawing.Point(181, 178);
            this.logBTN.Name = "logBTN";
            this.logBTN.Size = new System.Drawing.Size(113, 23);
            this.logBTN.TabIndex = 3;
            this.logBTN.Text = "Войти в систему";
            this.logBTN.UseVisualStyleBackColor = true;
            this.logBTN.Click += new System.EventHandler(this.logBTN_Click);
            // 
            // regBTN
            // 
            this.regBTN.Location = new System.Drawing.Point(203, 302);
            this.regBTN.Name = "regBTN";
            this.regBTN.Size = new System.Drawing.Size(75, 49);
            this.regBTN.TabIndex = 4;
            this.regBTN.Text = "Создать учетную запись";
            this.regBTN.UseVisualStyleBackColor = true;
            this.regBTN.Click += new System.EventHandler(this.regBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Введите свой пароль";
            // 
            // userPasswordTB
            // 
            this.userPasswordTB.Location = new System.Drawing.Point(181, 135);
            this.userPasswordTB.Name = "userPasswordTB";
            this.userPasswordTB.Size = new System.Drawing.Size(100, 20);
            this.userPasswordTB.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 450);
            this.Controls.Add(this.userPasswordTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regBTN);
            this.Controls.Add(this.logBTN);
            this.Controls.Add(this.userLoginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLoginTB;
        private System.Windows.Forms.Button logBTN;
        private System.Windows.Forms.Button regBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox userPasswordTB;
    }
}

