
namespace Redactor.RoleOfUsers
{
    partial class AuthorForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.ArticleNameTB = new System.Windows.Forms.TextBox();
            this.AddNewArticleBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ArticleListLB = new System.Windows.Forms.ListBox();
            this.AddHeaderBTN = new System.Windows.Forms.Button();
            this.AddUnderheaderBTN = new System.Windows.Forms.Button();
            this.AddParagraphBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.HeaderTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UnderHeaderTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ParagraphTB = new System.Windows.Forms.TextBox();
            this.EditAnArticleBTN = new System.Windows.Forms.Button();
            this.WholeArticleTB = new System.Windows.Forms.TextBox();
            this.CreateArticleBTN = new System.Windows.Forms.Button();
            this.saveChangesBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название статьи";
            // 
            // ArticleNameTB
            // 
            this.ArticleNameTB.Location = new System.Drawing.Point(29, 49);
            this.ArticleNameTB.Name = "ArticleNameTB";
            this.ArticleNameTB.Size = new System.Drawing.Size(107, 20);
            this.ArticleNameTB.TabIndex = 1;
            // 
            // AddNewArticleBTN
            // 
            this.AddNewArticleBTN.Location = new System.Drawing.Point(29, 193);
            this.AddNewArticleBTN.Name = "AddNewArticleBTN";
            this.AddNewArticleBTN.Size = new System.Drawing.Size(122, 92);
            this.AddNewArticleBTN.TabIndex = 2;
            this.AddNewArticleBTN.Text = "Добавить статью";
            this.AddNewArticleBTN.UseVisualStyleBackColor = true;
            this.AddNewArticleBTN.Click += new System.EventHandler(this.AddNewArticleBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Список статей";
            // 
            // ArticleListLB
            // 
            this.ArticleListLB.FormattingEnabled = true;
            this.ArticleListLB.Location = new System.Drawing.Point(251, 49);
            this.ArticleListLB.Name = "ArticleListLB";
            this.ArticleListLB.Size = new System.Drawing.Size(130, 303);
            this.ArticleListLB.TabIndex = 4;
            this.ArticleListLB.SelectedIndexChanged += new System.EventHandler(this.ArticleListLB_SelectedIndexChanged);
            // 
            // AddHeaderBTN
            // 
            this.AddHeaderBTN.Location = new System.Drawing.Point(254, 367);
            this.AddHeaderBTN.Name = "AddHeaderBTN";
            this.AddHeaderBTN.Size = new System.Drawing.Size(127, 23);
            this.AddHeaderBTN.TabIndex = 5;
            this.AddHeaderBTN.Text = "Добавить заголовок";
            this.AddHeaderBTN.UseVisualStyleBackColor = true;
            // 
            // AddUnderheaderBTN
            // 
            this.AddUnderheaderBTN.Location = new System.Drawing.Point(254, 406);
            this.AddUnderheaderBTN.Name = "AddUnderheaderBTN";
            this.AddUnderheaderBTN.Size = new System.Drawing.Size(127, 36);
            this.AddUnderheaderBTN.TabIndex = 6;
            this.AddUnderheaderBTN.Text = "Добавить подзаголовок";
            this.AddUnderheaderBTN.UseVisualStyleBackColor = true;
            // 
            // AddParagraphBTN
            // 
            this.AddParagraphBTN.Location = new System.Drawing.Point(254, 458);
            this.AddParagraphBTN.Name = "AddParagraphBTN";
            this.AddParagraphBTN.Size = new System.Drawing.Size(127, 23);
            this.AddParagraphBTN.TabIndex = 7;
            this.AddParagraphBTN.Text = "Добавить абзац";
            this.AddParagraphBTN.UseVisualStyleBackColor = true;
            this.AddParagraphBTN.Click += new System.EventHandler(this.AddParagraphBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Заголовок";
            // 
            // HeaderTB
            // 
            this.HeaderTB.Location = new System.Drawing.Point(420, 29);
            this.HeaderTB.Name = "HeaderTB";
            this.HeaderTB.Size = new System.Drawing.Size(100, 20);
            this.HeaderTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Подзаголовок";
            // 
            // UnderHeaderTB
            // 
            this.UnderHeaderTB.Location = new System.Drawing.Point(420, 85);
            this.UnderHeaderTB.Name = "UnderHeaderTB";
            this.UnderHeaderTB.Size = new System.Drawing.Size(100, 20);
            this.UnderHeaderTB.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(417, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Абзац";
            // 
            // ParagraphTB
            // 
            this.ParagraphTB.Location = new System.Drawing.Point(420, 135);
            this.ParagraphTB.Multiline = true;
            this.ParagraphTB.Name = "ParagraphTB";
            this.ParagraphTB.Size = new System.Drawing.Size(165, 346);
            this.ParagraphTB.TabIndex = 13;
            // 
            // EditAnArticleBTN
            // 
            this.EditAnArticleBTN.Location = new System.Drawing.Point(29, 291);
            this.EditAnArticleBTN.Name = "EditAnArticleBTN";
            this.EditAnArticleBTN.Size = new System.Drawing.Size(122, 92);
            this.EditAnArticleBTN.TabIndex = 14;
            this.EditAnArticleBTN.Text = "Редактировать существующую статью";
            this.EditAnArticleBTN.UseVisualStyleBackColor = true;
            this.EditAnArticleBTN.Click += new System.EventHandler(this.EditAnArticleBTN_Click);
            // 
            // WholeArticleTB
            // 
            this.WholeArticleTB.Location = new System.Drawing.Point(679, 34);
            this.WholeArticleTB.Multiline = true;
            this.WholeArticleTB.Name = "WholeArticleTB";
            this.WholeArticleTB.Size = new System.Drawing.Size(284, 453);
            this.WholeArticleTB.TabIndex = 15;
            // 
            // CreateArticleBTN
            // 
            this.CreateArticleBTN.Location = new System.Drawing.Point(29, 95);
            this.CreateArticleBTN.Name = "CreateArticleBTN";
            this.CreateArticleBTN.Size = new System.Drawing.Size(122, 92);
            this.CreateArticleBTN.TabIndex = 16;
            this.CreateArticleBTN.Text = "Создать статью";
            this.CreateArticleBTN.UseVisualStyleBackColor = true;
            this.CreateArticleBTN.Click += new System.EventHandler(this.CreateArticleBTN_Click);
            // 
            // saveChangesBTN
            // 
            this.saveChangesBTN.Location = new System.Drawing.Point(29, 389);
            this.saveChangesBTN.Name = "saveChangesBTN";
            this.saveChangesBTN.Size = new System.Drawing.Size(122, 92);
            this.saveChangesBTN.TabIndex = 17;
            this.saveChangesBTN.Text = "Сохранить изменения в отредактированной статье";
            this.saveChangesBTN.UseVisualStyleBackColor = true;
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 499);
            this.Controls.Add(this.saveChangesBTN);
            this.Controls.Add(this.CreateArticleBTN);
            this.Controls.Add(this.WholeArticleTB);
            this.Controls.Add(this.EditAnArticleBTN);
            this.Controls.Add(this.ParagraphTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.UnderHeaderTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.HeaderTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddParagraphBTN);
            this.Controls.Add(this.AddUnderheaderBTN);
            this.Controls.Add(this.AddHeaderBTN);
            this.Controls.Add(this.ArticleListLB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddNewArticleBTN);
            this.Controls.Add(this.ArticleNameTB);
            this.Controls.Add(this.label1);
            this.Name = "AuthorForm";
            this.Text = "AuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ArticleNameTB;
        private System.Windows.Forms.Button AddNewArticleBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox ArticleListLB;
        private System.Windows.Forms.Button AddHeaderBTN;
        private System.Windows.Forms.Button AddUnderheaderBTN;
        private System.Windows.Forms.Button AddParagraphBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox HeaderTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox UnderHeaderTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ParagraphTB;
        private System.Windows.Forms.Button EditAnArticleBTN;
        private System.Windows.Forms.TextBox WholeArticleTB;
        private System.Windows.Forms.Button CreateArticleBTN;
        private System.Windows.Forms.Button saveChangesBTN;
    }
}