
namespace Redactor.RoleOfUsers
{
    partial class ReaderForm
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
            this.authorsLB = new System.Windows.Forms.ListBox();
            this.articlesLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.headerTB = new System.Windows.Forms.TextBox();
            this.underHeaderTB = new System.Windows.Forms.TextBox();
            this.articleTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorsLB
            // 
            this.authorsLB.FormattingEnabled = true;
            this.authorsLB.Location = new System.Drawing.Point(38, 42);
            this.authorsLB.Name = "authorsLB";
            this.authorsLB.Size = new System.Drawing.Size(120, 381);
            this.authorsLB.TabIndex = 0;
            // 
            // articlesLB
            // 
            this.articlesLB.FormattingEnabled = true;
            this.articlesLB.Location = new System.Drawing.Point(198, 42);
            this.articlesLB.Name = "articlesLB";
            this.articlesLB.Size = new System.Drawing.Size(124, 381);
            this.articlesLB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Авторы";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Статьи";
            // 
            // headerTB
            // 
            this.headerTB.Location = new System.Drawing.Point(464, 13);
            this.headerTB.Name = "headerTB";
            this.headerTB.Size = new System.Drawing.Size(229, 20);
            this.headerTB.TabIndex = 4;
            // 
            // underHeaderTB
            // 
            this.underHeaderTB.Location = new System.Drawing.Point(464, 42);
            this.underHeaderTB.Name = "underHeaderTB";
            this.underHeaderTB.Size = new System.Drawing.Size(229, 20);
            this.underHeaderTB.TabIndex = 5;
            // 
            // articleTB
            // 
            this.articleTB.Location = new System.Drawing.Point(384, 77);
            this.articleTB.Multiline = true;
            this.articleTB.Name = "articleTB";
            this.articleTB.Size = new System.Drawing.Size(404, 346);
            this.articleTB.TabIndex = 6;
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.articleTB);
            this.Controls.Add(this.underHeaderTB);
            this.Controls.Add(this.headerTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articlesLB);
            this.Controls.Add(this.authorsLB);
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorsLB;
        private System.Windows.Forms.ListBox articlesLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox headerTB;
        private System.Windows.Forms.TextBox underHeaderTB;
        private System.Windows.Forms.TextBox articleTB;
    }
}