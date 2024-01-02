
namespace Redactor.RoleOfUsers
{
    partial class ModeratorPanel
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
            this.HeadetTB = new System.Windows.Forms.TextBox();
            this.underHeaderTB = new System.Windows.Forms.TextBox();
            this.articleTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.editArticleBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // authorsLB
            // 
            this.authorsLB.FormattingEnabled = true;
            this.authorsLB.Location = new System.Drawing.Point(30, 35);
            this.authorsLB.Name = "authorsLB";
            this.authorsLB.Size = new System.Drawing.Size(78, 199);
            this.authorsLB.TabIndex = 0;
            this.authorsLB.SelectedIndexChanged += new System.EventHandler(this.authorsLB_SelectedIndexChanged);
            // 
            // articlesLB
            // 
            this.articlesLB.FormattingEnabled = true;
            this.articlesLB.Location = new System.Drawing.Point(154, 35);
            this.articlesLB.Name = "articlesLB";
            this.articlesLB.Size = new System.Drawing.Size(75, 199);
            this.articlesLB.TabIndex = 1;
            this.articlesLB.SelectedIndexChanged += new System.EventHandler(this.articlesLB_SelectedIndexChanged);
            // 
            // HeadetTB
            // 
            this.HeadetTB.Location = new System.Drawing.Point(442, 25);
            this.HeadetTB.Name = "HeadetTB";
            this.HeadetTB.Size = new System.Drawing.Size(300, 20);
            this.HeadetTB.TabIndex = 2;
            // 
            // underHeaderTB
            // 
            this.underHeaderTB.Location = new System.Drawing.Point(442, 77);
            this.underHeaderTB.Name = "underHeaderTB";
            this.underHeaderTB.Size = new System.Drawing.Size(300, 20);
            this.underHeaderTB.TabIndex = 3;
            // 
            // articleTB
            // 
            this.articleTB.Location = new System.Drawing.Point(387, 123);
            this.articleTB.Multiline = true;
            this.articleTB.Name = "articleTB";
            this.articleTB.Size = new System.Drawing.Size(401, 315);
            this.articleTB.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Заголовок статьи";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(535, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Подзаголовок статьи";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Текст статьи";
            // 
            // editArticleBTN
            // 
            this.editArticleBTN.Location = new System.Drawing.Point(99, 284);
            this.editArticleBTN.Name = "editArticleBTN";
            this.editArticleBTN.Size = new System.Drawing.Size(75, 42);
            this.editArticleBTN.TabIndex = 8;
            this.editArticleBTN.Text = "Сохранить изменения";
            this.editArticleBTN.UseVisualStyleBackColor = true;
            // 
            // ModeratorPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editArticleBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.articleTB);
            this.Controls.Add(this.underHeaderTB);
            this.Controls.Add(this.HeadetTB);
            this.Controls.Add(this.articlesLB);
            this.Controls.Add(this.authorsLB);
            this.Name = "ModeratorPanel";
            this.Text = "ModeratorPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox authorsLB;
        private System.Windows.Forms.ListBox articlesLB;
        private System.Windows.Forms.TextBox HeadetTB;
        private System.Windows.Forms.TextBox underHeaderTB;
        private System.Windows.Forms.TextBox articleTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button editArticleBTN;
    }
}