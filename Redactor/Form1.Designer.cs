
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
            this.label2.Location = new System.Drawing.Point(175, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Зарегистрируйтесь";
            // 
            // userLoginTB
            // 
            this.userLoginTB.Location = new System.Drawing.Point(228, 91);
            this.userLoginTB.Name = "userLoginTB";
            this.userLoginTB.Size = new System.Drawing.Size(100, 20);
            this.userLoginTB.TabIndex = 2;
            // 
            // logBTN
            // 
            this.logBTN.Location = new System.Drawing.Point(538, 118);
            this.logBTN.Name = "logBTN";
            this.logBTN.Size = new System.Drawing.Size(75, 23);
            this.logBTN.TabIndex = 3;
            this.logBTN.Text = "button1";
            this.logBTN.UseVisualStyleBackColor = true;
            this.logBTN.Click += new System.EventHandler(this.logBTN_Click);
            // 
            // regBTN
            // 
            this.regBTN.Location = new System.Drawing.Point(463, 335);
            this.regBTN.Name = "regBTN";
            this.regBTN.Size = new System.Drawing.Size(75, 23);
            this.regBTN.TabIndex = 4;
            this.regBTN.Text = "button2";
            this.regBTN.UseVisualStyleBackColor = true;
            this.regBTN.Click += new System.EventHandler(this.regBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regBTN);
            this.Controls.Add(this.logBTN);
            this.Controls.Add(this.userLoginTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userLoginTB;
        private System.Windows.Forms.Button logBTN;
        private System.Windows.Forms.Button regBTN;
    }
}

