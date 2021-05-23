
namespace Library
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReaderForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.authorNameBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.authorSurnameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayerBooks = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.listenBookBtn = new System.Windows.Forms.Button();
            this.getPayBtn = new System.Windows.Forms.Button();
            this.listBoxChapters = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.getPayBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 530);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.searchBookBtn);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.authorNameBox);
            this.groupBox1.Controls.Add(this.TitleBox);
            this.groupBox1.Controls.Add(this.authorSurnameBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 252);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(95, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 24);
            this.label10.TabIndex = 2;
            this.label10.Text = "Найти книгу";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(25, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 24);
            this.label3.TabIndex = 33;
            this.label3.Text = "Название книги";
            // 
            // searchBookBtn
            // 
            this.searchBookBtn.AutoSize = true;
            this.searchBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchBookBtn.Location = new System.Drawing.Point(127, 190);
            this.searchBookBtn.Name = "searchBookBtn";
            this.searchBookBtn.Size = new System.Drawing.Size(96, 34);
            this.searchBookBtn.TabIndex = 1;
            this.searchBookBtn.Text = "Поиск";
            this.searchBookBtn.UseVisualStyleBackColor = true;
            this.searchBookBtn.Click += new System.EventHandler(this.searchBookBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(25, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 24);
            this.label4.TabIndex = 34;
            this.label4.Text = "Фамилия автора";
            // 
            // authorNameBox
            // 
            this.authorNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorNameBox.Location = new System.Drawing.Point(190, 141);
            this.authorNameBox.Name = "authorNameBox";
            this.authorNameBox.Size = new System.Drawing.Size(185, 29);
            this.authorNameBox.TabIndex = 35;
            // 
            // TitleBox
            // 
            this.TitleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TitleBox.Location = new System.Drawing.Point(190, 55);
            this.TitleBox.Name = "TitleBox";
            this.TitleBox.Size = new System.Drawing.Size(185, 29);
            this.TitleBox.TabIndex = 31;
            // 
            // authorSurnameBox
            // 
            this.authorSurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorSurnameBox.Location = new System.Drawing.Point(190, 97);
            this.authorSurnameBox.Name = "authorSurnameBox";
            this.authorSurnameBox.Size = new System.Drawing.Size(185, 29);
            this.authorSurnameBox.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(25, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "Имя автора";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listBoxChapters);
            this.groupBox3.Controls.Add(this.axWindowsMediaPlayerBooks);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.listenBookBtn);
            this.groupBox3.Location = new System.Drawing.Point(412, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(596, 348);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // axWindowsMediaPlayerBooks
            // 
            this.axWindowsMediaPlayerBooks.Enabled = true;
            this.axWindowsMediaPlayerBooks.Location = new System.Drawing.Point(19, 55);
            this.axWindowsMediaPlayerBooks.Name = "axWindowsMediaPlayerBooks";
            this.axWindowsMediaPlayerBooks.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerBooks.OcxState")));
            this.axWindowsMediaPlayerBooks.Size = new System.Drawing.Size(322, 207);
            this.axWindowsMediaPlayerBooks.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(32, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 40;
            this.label1.Text = "Воспроизвести найденную книгу";
            // 
            // listenBookBtn
            // 
            this.listenBookBtn.AutoSize = true;
            this.listenBookBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listenBookBtn.Location = new System.Drawing.Point(103, 286);
            this.listenBookBtn.Name = "listenBookBtn";
            this.listenBookBtn.Size = new System.Drawing.Size(160, 34);
            this.listenBookBtn.TabIndex = 39;
            this.listenBookBtn.Text = "Слушать";
            this.listenBookBtn.UseVisualStyleBackColor = true;
            this.listenBookBtn.Click += new System.EventHandler(this.listenBookBtn_Click);
            // 
            // getPayBtn
            // 
            this.getPayBtn.AutoSize = true;
            this.getPayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.getPayBtn.Location = new System.Drawing.Point(12, 298);
            this.getPayBtn.Name = "getPayBtn";
            this.getPayBtn.Size = new System.Drawing.Size(160, 34);
            this.getPayBtn.TabIndex = 21;
            this.getPayBtn.Text = "Узнать залог";
            this.getPayBtn.UseVisualStyleBackColor = true;
            this.getPayBtn.Click += new System.EventHandler(this.getPayBtn_Click);
            // 
            // listBoxChapters
            // 
            this.listBoxChapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChapters.FormattingEnabled = true;
            this.listBoxChapters.ItemHeight = 16;
            this.listBoxChapters.Location = new System.Drawing.Point(375, 55);
            this.listBoxChapters.Name = "listBoxChapters";
            this.listBoxChapters.Size = new System.Drawing.Size(204, 212);
            this.listBoxChapters.TabIndex = 41;
            this.listBoxChapters.SelectedIndexChanged += new System.EventHandler(this.listBoxChapters_SelectedIndexChanged);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 530);
            this.Controls.Add(this.panel1);
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button getPayBtn;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button searchBookBtn;
        private System.Windows.Forms.Button listenBookBtn;
        private System.Windows.Forms.TextBox TitleBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox authorSurnameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox authorNameBox;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayerBooks;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBoxChapters;
    }
}