
namespace Redactor.RoleOfUsers
{
    partial class AdminPanel
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
            this.usersLB = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.createUserBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.firstNameTB = new System.Windows.Forms.TextBox();
            this.secondNameTB = new System.Windows.Forms.TextBox();
            this.emailTB = new System.Windows.Forms.TextBox();
            this.birthDateTB = new System.Windows.Forms.TextBox();
            this.regDateTB = new System.Windows.Forms.TextBox();
            this.roleTB = new System.Windows.Forms.TextBox();
            this.isBlockedTB = new System.Windows.Forms.TextBox();
            this.blockUserBTN = new System.Windows.Forms.Button();
            this.removeUserBTN = new System.Windows.Forms.Button();
            this.unblockUserBTN = new System.Windows.Forms.Button();
            this.saveChangesBTN = new System.Windows.Forms.Button();
            this.isModerTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.grantModPrivBTN = new System.Windows.Forms.Button();
            this.revokeModPrivBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersLB
            // 
            this.usersLB.FormattingEnabled = true;
            this.usersLB.Location = new System.Drawing.Point(62, 36);
            this.usersLB.Name = "usersLB";
            this.usersLB.Size = new System.Drawing.Size(120, 173);
            this.usersLB.TabIndex = 0;
            this.usersLB.SelectedIndexChanged += new System.EventHandler(this.usersLB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список пользователей";
            // 
            // createUserBTN
            // 
            this.createUserBTN.Location = new System.Drawing.Point(675, 204);
            this.createUserBTN.Name = "createUserBTN";
            this.createUserBTN.Size = new System.Drawing.Size(100, 48);
            this.createUserBTN.TabIndex = 2;
            this.createUserBTN.Text = "Создать нового пользователя";
            this.createUserBTN.UseVisualStyleBackColor = true;
            this.createUserBTN.Click += new System.EventHandler(this.createUserBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id пользователя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Имя пользователя";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Фамилия пользователя";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Электронная почта";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Дата рождения";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(409, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Дата регистрации";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(412, 156);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Роль";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(412, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Заблокирован";
            // 
            // idTB
            // 
            this.idTB.Location = new System.Drawing.Point(225, 53);
            this.idTB.Name = "idTB";
            this.idTB.Size = new System.Drawing.Size(100, 20);
            this.idTB.TabIndex = 11;
            // 
            // firstNameTB
            // 
            this.firstNameTB.Location = new System.Drawing.Point(225, 115);
            this.firstNameTB.Name = "firstNameTB";
            this.firstNameTB.Size = new System.Drawing.Size(100, 20);
            this.firstNameTB.TabIndex = 12;
            // 
            // secondNameTB
            // 
            this.secondNameTB.Location = new System.Drawing.Point(225, 174);
            this.secondNameTB.Name = "secondNameTB";
            this.secondNameTB.Size = new System.Drawing.Size(100, 20);
            this.secondNameTB.TabIndex = 13;
            // 
            // emailTB
            // 
            this.emailTB.Location = new System.Drawing.Point(225, 232);
            this.emailTB.Name = "emailTB";
            this.emailTB.Size = new System.Drawing.Size(100, 20);
            this.emailTB.TabIndex = 14;
            // 
            // birthDateTB
            // 
            this.birthDateTB.Location = new System.Drawing.Point(412, 53);
            this.birthDateTB.Name = "birthDateTB";
            this.birthDateTB.Size = new System.Drawing.Size(100, 20);
            this.birthDateTB.TabIndex = 15;
            // 
            // regDateTB
            // 
            this.regDateTB.Location = new System.Drawing.Point(412, 114);
            this.regDateTB.Name = "regDateTB";
            this.regDateTB.Size = new System.Drawing.Size(100, 20);
            this.regDateTB.TabIndex = 16;
            // 
            // roleTB
            // 
            this.roleTB.Location = new System.Drawing.Point(415, 173);
            this.roleTB.Name = "roleTB";
            this.roleTB.Size = new System.Drawing.Size(100, 20);
            this.roleTB.TabIndex = 17;
            // 
            // isBlockedTB
            // 
            this.isBlockedTB.Location = new System.Drawing.Point(412, 231);
            this.isBlockedTB.Name = "isBlockedTB";
            this.isBlockedTB.Size = new System.Drawing.Size(100, 20);
            this.isBlockedTB.TabIndex = 18;
            // 
            // blockUserBTN
            // 
            this.blockUserBTN.Location = new System.Drawing.Point(560, 114);
            this.blockUserBTN.Name = "blockUserBTN";
            this.blockUserBTN.Size = new System.Drawing.Size(99, 64);
            this.blockUserBTN.TabIndex = 19;
            this.blockUserBTN.Text = "Заблокировать пользователя";
            this.blockUserBTN.UseVisualStyleBackColor = true;
            this.blockUserBTN.Click += new System.EventHandler(this.blockUserBTN_Click);
            // 
            // removeUserBTN
            // 
            this.removeUserBTN.Location = new System.Drawing.Point(560, 204);
            this.removeUserBTN.Name = "removeUserBTN";
            this.removeUserBTN.Size = new System.Drawing.Size(99, 48);
            this.removeUserBTN.TabIndex = 20;
            this.removeUserBTN.Text = "Удалить пользователя";
            this.removeUserBTN.UseVisualStyleBackColor = true;
            this.removeUserBTN.Click += new System.EventHandler(this.removeUserBTN_Click);
            // 
            // unblockUserBTN
            // 
            this.unblockUserBTN.Location = new System.Drawing.Point(675, 115);
            this.unblockUserBTN.Name = "unblockUserBTN";
            this.unblockUserBTN.Size = new System.Drawing.Size(100, 63);
            this.unblockUserBTN.TabIndex = 21;
            this.unblockUserBTN.Text = "Разблокировать пользователя";
            this.unblockUserBTN.UseVisualStyleBackColor = true;
            this.unblockUserBTN.Click += new System.EventHandler(this.unblockUserBTN_Click);
            // 
            // saveChangesBTN
            // 
            this.saveChangesBTN.Location = new System.Drawing.Point(621, 352);
            this.saveChangesBTN.Name = "saveChangesBTN";
            this.saveChangesBTN.Size = new System.Drawing.Size(100, 38);
            this.saveChangesBTN.TabIndex = 22;
            this.saveChangesBTN.Text = "Сохранить изменения";
            this.saveChangesBTN.UseVisualStyleBackColor = true;
            this.saveChangesBTN.Click += new System.EventHandler(this.saveChangesBTN_Click);
            // 
            // isModerTB
            // 
            this.isModerTB.Location = new System.Drawing.Point(412, 299);
            this.isModerTB.Name = "isModerTB";
            this.isModerTB.Size = new System.Drawing.Size(100, 20);
            this.isModerTB.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(415, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Модератор?";
            // 
            // grantModPrivBTN
            // 
            this.grantModPrivBTN.Location = new System.Drawing.Point(560, 280);
            this.grantModPrivBTN.Name = "grantModPrivBTN";
            this.grantModPrivBTN.Size = new System.Drawing.Size(99, 52);
            this.grantModPrivBTN.TabIndex = 25;
            this.grantModPrivBTN.Text = "Назначить модератором";
            this.grantModPrivBTN.UseVisualStyleBackColor = true;
            this.grantModPrivBTN.Click += new System.EventHandler(this.grantModPrivBTN_Click);
            // 
            // revokeModPrivBTN
            // 
            this.revokeModPrivBTN.Location = new System.Drawing.Point(675, 280);
            this.revokeModPrivBTN.Name = "revokeModPrivBTN";
            this.revokeModPrivBTN.Size = new System.Drawing.Size(100, 52);
            this.revokeModPrivBTN.TabIndex = 26;
            this.revokeModPrivBTN.Text = "Отозвать полномочия модератора";
            this.revokeModPrivBTN.UseVisualStyleBackColor = true;
            this.revokeModPrivBTN.Click += new System.EventHandler(this.revokeModPrivBTN_Click);
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.revokeModPrivBTN);
            this.Controls.Add(this.grantModPrivBTN);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.isModerTB);
            this.Controls.Add(this.saveChangesBTN);
            this.Controls.Add(this.unblockUserBTN);
            this.Controls.Add(this.removeUserBTN);
            this.Controls.Add(this.blockUserBTN);
            this.Controls.Add(this.isBlockedTB);
            this.Controls.Add(this.roleTB);
            this.Controls.Add(this.regDateTB);
            this.Controls.Add(this.birthDateTB);
            this.Controls.Add(this.emailTB);
            this.Controls.Add(this.secondNameTB);
            this.Controls.Add(this.firstNameTB);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createUserBTN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.usersLB);
            this.Name = "AdminPanel";
            this.Text = "AdminPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox usersLB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createUserBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox firstNameTB;
        private System.Windows.Forms.TextBox secondNameTB;
        private System.Windows.Forms.TextBox emailTB;
        private System.Windows.Forms.TextBox birthDateTB;
        private System.Windows.Forms.TextBox regDateTB;
        private System.Windows.Forms.TextBox roleTB;
        private System.Windows.Forms.TextBox isBlockedTB;
        private System.Windows.Forms.Button blockUserBTN;
        private System.Windows.Forms.Button removeUserBTN;
        private System.Windows.Forms.Button unblockUserBTN;
        private System.Windows.Forms.Button saveChangesBTN;
        private System.Windows.Forms.TextBox isModerTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button grantModPrivBTN;
        private System.Windows.Forms.Button revokeModPrivBTN;
    }
}