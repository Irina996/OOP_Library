
namespace Library
{
    partial class CreateDocForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.getReaderPswdBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.createIssuingBookBtn = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.authorSurnameBox = new System.Windows.Forms.TextBox();
            this.authorNameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.libCallGoalBox = new System.Windows.Forms.TextBox();
            this.createLibCallBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.getReaderPswdBtn);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 287);
            this.panel1.TabIndex = 2;
            // 
            // getReaderPswdBtn
            // 
            this.getReaderPswdBtn.AutoSize = true;
            this.getReaderPswdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getReaderPswdBtn.Location = new System.Drawing.Point(14, 175);
            this.getReaderPswdBtn.Name = "getReaderPswdBtn";
            this.getReaderPswdBtn.Size = new System.Drawing.Size(244, 34);
            this.getReaderPswdBtn.TabIndex = 33;
            this.getReaderPswdBtn.Text = "Выдать пароль читателя";
            this.getReaderPswdBtn.UseVisualStyleBackColor = true;
            this.getReaderPswdBtn.Click += new System.EventHandler(this.getReaderPswdBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.createIssuingBookBtn);
            this.groupBox2.Controls.Add(this.statusBox);
            this.groupBox2.Controls.Add(this.TitleBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.authorSurnameBox);
            this.groupBox2.Controls.Add(this.authorNameBox);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(351, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(407, 276);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(98, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "Выдача/возврат книги";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(6, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 55);
            this.label7.TabIndex = 32;
            this.label7.Text = "Выдача/возврат/аудиокнига";
            // 
            // createIssuingBookBtn
            // 
            this.createIssuingBookBtn.AutoSize = true;
            this.createIssuingBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createIssuingBookBtn.Location = new System.Drawing.Point(138, 225);
            this.createIssuingBookBtn.Name = "createIssuingBookBtn";
            this.createIssuingBookBtn.Size = new System.Drawing.Size(116, 34);
            this.createIssuingBookBtn.TabIndex = 22;
            this.createIssuingBookBtn.Text = "Оформить";
            this.createIssuingBookBtn.UseVisualStyleBackColor = true;
            this.createIssuingBookBtn.Click += new System.EventHandler(this.createIssuingBookBtn_Click);
            // 
            // statusBox
            // 
            this.statusBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusBox.Location = new System.Drawing.Point(171, 177);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(220, 29);
            this.statusBox.TabIndex = 31;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleBox.Location = new System.Drawing.Point(171, 44);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(220, 29);
            this.TitleBox.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 30;
            this.label6.Text = "Имя автора";
            // 
            // authorSurnameBox
            // 
            this.authorSurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorSurnameBox.Location = new System.Drawing.Point(171, 86);
            this.authorSurnameBox.Name = "authorSurnameBox";
            this.authorSurnameBox.Size = new System.Drawing.Size(220, 29);
            this.authorSurnameBox.TabIndex = 25;
            // 
            // authorNameBox
            // 
            this.authorNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorNameBox.Location = new System.Drawing.Point(171, 130);
            this.authorNameBox.Name = "authorNameBox";
            this.authorNameBox.Size = new System.Drawing.Size(220, 29);
            this.authorNameBox.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(6, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Название книги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(6, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 27;
            this.label4.Text = "Фамилия автора";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.libCallGoalBox);
            this.groupBox1.Controls.Add(this.createLibCallBtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 142);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(62, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Обращение читателя";
            // 
            // libCallGoalBox
            // 
            this.libCallGoalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.libCallGoalBox.Location = new System.Drawing.Point(171, 48);
            this.libCallGoalBox.Name = "libCallGoalBox";
            this.libCallGoalBox.Size = new System.Drawing.Size(146, 29);
            this.libCallGoalBox.TabIndex = 4;
            // 
            // createLibCallBtn
            // 
            this.createLibCallBtn.AutoSize = true;
            this.createLibCallBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createLibCallBtn.Location = new System.Drawing.Point(92, 93);
            this.createLibCallBtn.Name = "createLibCallBtn";
            this.createLibCallBtn.Size = new System.Drawing.Size(162, 34);
            this.createLibCallBtn.TabIndex = 21;
            this.createLibCallBtn.Text = "Зафиксировать";
            this.createLibCallBtn.UseVisualStyleBackColor = true;
            this.createLibCallBtn.Click += new System.EventHandler(this.createLibCallBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "Цель обращения";
            // 
            // CreateDocForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(769, 287);
            this.Controls.Add(this.panel1);
            this.Name = "CreateDocForm";
            this.Text = "CreateDocForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CreateDocForm_FormClosing);
            this.Load += new System.EventHandler(this.CreateDocForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox libCallGoalBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button createIssuingBookBtn;
        private System.Windows.Forms.Button createLibCallBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorSurnameBox;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authorNameBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox statusBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button getReaderPswdBtn;
    }
}