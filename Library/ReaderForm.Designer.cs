
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.readerBooksListBox = new System.Windows.Forms.ListBox();
            this.prevReaderBooksBtn = new System.Windows.Forms.Button();
            this.nextReaderBooksBtn = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.audioBooksListBox = new System.Windows.Forms.ListBox();
            this.prevAudioBooksBtn = new System.Windows.Forms.Button();
            this.nextAudioBooksBtn = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.PayBookFromListBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.booksListBox = new System.Windows.Forms.ListBox();
            this.pageBox = new System.Windows.Forms.TextBox();
            this.minPageBtn = new System.Windows.Forms.Button();
            this.maxPageBtn = new System.Windows.Forms.Button();
            this.selectPageBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PaySearchedBtn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.searchBookBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.authorNameBox = new System.Windows.Forms.TextBox();
            this.TitleBox = new System.Windows.Forms.TextBox();
            this.authorSurnameBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listBoxChapters = new System.Windows.Forms.ListBox();
            this.axWindowsMediaPlayerBooks = new AxWMPLib.AxWindowsMediaPlayer();
            this.label1 = new System.Windows.Forms.Label();
            this.listenBookBtn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(104)))), ((int)(((byte)(117)))));
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 604);
            this.panel1.TabIndex = 2;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.readerBooksListBox);
            this.groupBox5.Controls.Add(this.prevReaderBooksBtn);
            this.groupBox5.Controls.Add(this.nextReaderBooksBtn);
            this.groupBox5.Location = new System.Drawing.Point(722, 270);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(304, 331);
            this.groupBox5.TabIndex = 41;
            this.groupBox5.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(76, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 24);
            this.label7.TabIndex = 37;
            this.label7.Text = "Книги на руках";
            // 
            // readerBooksListBox
            // 
            this.readerBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readerBooksListBox.FormattingEnabled = true;
            this.readerBooksListBox.HorizontalScrollbar = true;
            this.readerBooksListBox.ItemHeight = 20;
            this.readerBooksListBox.Location = new System.Drawing.Point(18, 52);
            this.readerBooksListBox.Name = "readerBooksListBox";
            this.readerBooksListBox.Size = new System.Drawing.Size(266, 184);
            this.readerBooksListBox.TabIndex = 25;
            // 
            // prevReaderBooksBtn
            // 
            this.prevReaderBooksBtn.AutoSize = true;
            this.prevReaderBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevReaderBooksBtn.Location = new System.Drawing.Point(18, 252);
            this.prevReaderBooksBtn.Name = "prevReaderBooksBtn";
            this.prevReaderBooksBtn.Size = new System.Drawing.Size(136, 34);
            this.prevReaderBooksBtn.TabIndex = 37;
            this.prevReaderBooksBtn.Text = "Предыдущие";
            this.prevReaderBooksBtn.UseVisualStyleBackColor = true;
            this.prevReaderBooksBtn.Click += new System.EventHandler(this.prevReaderBooksBtn_Click);
            // 
            // nextReaderBooksBtn
            // 
            this.nextReaderBooksBtn.AutoSize = true;
            this.nextReaderBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextReaderBooksBtn.Location = new System.Drawing.Point(160, 252);
            this.nextReaderBooksBtn.Name = "nextReaderBooksBtn";
            this.nextReaderBooksBtn.Size = new System.Drawing.Size(124, 34);
            this.nextReaderBooksBtn.TabIndex = 38;
            this.nextReaderBooksBtn.Text = "Следующие";
            this.nextReaderBooksBtn.UseVisualStyleBackColor = true;
            this.nextReaderBooksBtn.Click += new System.EventHandler(this.nextReaderBooksBtn_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.audioBooksListBox);
            this.groupBox4.Controls.Add(this.prevAudioBooksBtn);
            this.groupBox4.Controls.Add(this.nextAudioBooksBtn);
            this.groupBox4.Location = new System.Drawing.Point(412, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(304, 331);
            this.groupBox4.TabIndex = 40;
            this.groupBox4.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(32, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(232, 24);
            this.label5.TabIndex = 37;
            this.label5.Text = "Оплаченные аудиокниги";
            // 
            // audioBooksListBox
            // 
            this.audioBooksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.audioBooksListBox.FormattingEnabled = true;
            this.audioBooksListBox.HorizontalScrollbar = true;
            this.audioBooksListBox.ItemHeight = 20;
            this.audioBooksListBox.Location = new System.Drawing.Point(18, 52);
            this.audioBooksListBox.Name = "audioBooksListBox";
            this.audioBooksListBox.Size = new System.Drawing.Size(266, 184);
            this.audioBooksListBox.TabIndex = 25;
            this.audioBooksListBox.SelectedIndexChanged += new System.EventHandler(this.audioBooksListBox_SelectedIndexChanged);
            // 
            // prevAudioBooksBtn
            // 
            this.prevAudioBooksBtn.AutoSize = true;
            this.prevAudioBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.prevAudioBooksBtn.Location = new System.Drawing.Point(18, 252);
            this.prevAudioBooksBtn.Name = "prevAudioBooksBtn";
            this.prevAudioBooksBtn.Size = new System.Drawing.Size(136, 34);
            this.prevAudioBooksBtn.TabIndex = 37;
            this.prevAudioBooksBtn.Text = "Предыдущие";
            this.prevAudioBooksBtn.UseVisualStyleBackColor = true;
            this.prevAudioBooksBtn.Click += new System.EventHandler(this.prevAudioBooksBtn_Click);
            // 
            // nextAudioBooksBtn
            // 
            this.nextAudioBooksBtn.AutoSize = true;
            this.nextAudioBooksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nextAudioBooksBtn.Location = new System.Drawing.Point(160, 252);
            this.nextAudioBooksBtn.Name = "nextAudioBooksBtn";
            this.nextAudioBooksBtn.Size = new System.Drawing.Size(124, 34);
            this.nextAudioBooksBtn.TabIndex = 38;
            this.nextAudioBooksBtn.Text = "Следующие";
            this.nextAudioBooksBtn.UseVisualStyleBackColor = true;
            this.nextAudioBooksBtn.Click += new System.EventHandler(this.nextAudioBooksBtn_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PayBookFromListBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.booksListBox);
            this.groupBox2.Controls.Add(this.pageBox);
            this.groupBox2.Controls.Add(this.minPageBtn);
            this.groupBox2.Controls.Add(this.maxPageBtn);
            this.groupBox2.Controls.Add(this.selectPageBtn);
            this.groupBox2.Location = new System.Drawing.Point(12, 270);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(394, 331);
            this.groupBox2.TabIndex = 39;
            this.groupBox2.TabStop = false;
            // 
            // PayBookFromListBtn
            // 
            this.PayBookFromListBtn.AutoSize = true;
            this.PayBookFromListBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PayBookFromListBtn.Location = new System.Drawing.Point(86, 282);
            this.PayBookFromListBtn.Name = "PayBookFromListBtn";
            this.PayBookFromListBtn.Size = new System.Drawing.Size(215, 34);
            this.PayBookFromListBtn.TabIndex = 39;
            this.PayBookFromListBtn.Text = "Оплатить аудиокнигу";
            this.PayBookFromListBtn.UseVisualStyleBackColor = true;
            this.PayBookFromListBtn.Click += new System.EventHandler(this.PayBookFromListBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(122, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "Каталог книг";
            // 
            // booksListBox
            // 
            this.booksListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksListBox.FormattingEnabled = true;
            this.booksListBox.HorizontalScrollbar = true;
            this.booksListBox.ItemHeight = 20;
            this.booksListBox.Location = new System.Drawing.Point(18, 52);
            this.booksListBox.Name = "booksListBox";
            this.booksListBox.Size = new System.Drawing.Size(357, 184);
            this.booksListBox.TabIndex = 25;
            this.booksListBox.SelectedIndexChanged += new System.EventHandler(this.booksListBox_SelectedIndexChanged);
            // 
            // pageBox
            // 
            this.pageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pageBox.Location = new System.Drawing.Point(126, 247);
            this.pageBox.Name = "pageBox";
            this.pageBox.Size = new System.Drawing.Size(33, 29);
            this.pageBox.TabIndex = 37;
            // 
            // minPageBtn
            // 
            this.minPageBtn.AutoSize = true;
            this.minPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minPageBtn.Location = new System.Drawing.Point(18, 242);
            this.minPageBtn.Name = "minPageBtn";
            this.minPageBtn.Size = new System.Drawing.Size(96, 34);
            this.minPageBtn.TabIndex = 37;
            this.minPageBtn.Text = "Стр.1";
            this.minPageBtn.UseVisualStyleBackColor = true;
            this.minPageBtn.Click += new System.EventHandler(this.minPageBtn_Click);
            // 
            // maxPageBtn
            // 
            this.maxPageBtn.AutoSize = true;
            this.maxPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maxPageBtn.Location = new System.Drawing.Point(279, 242);
            this.maxPageBtn.Name = "maxPageBtn";
            this.maxPageBtn.Size = new System.Drawing.Size(96, 34);
            this.maxPageBtn.TabIndex = 38;
            this.maxPageBtn.Text = "Стр.";
            this.maxPageBtn.UseVisualStyleBackColor = true;
            this.maxPageBtn.Click += new System.EventHandler(this.maxPageBtn_Click);
            // 
            // selectPageBtn
            // 
            this.selectPageBtn.AutoSize = true;
            this.selectPageBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selectPageBtn.Location = new System.Drawing.Point(165, 242);
            this.selectPageBtn.Name = "selectPageBtn";
            this.selectPageBtn.Size = new System.Drawing.Size(98, 34);
            this.selectPageBtn.TabIndex = 37;
            this.selectPageBtn.Text = "Перейти";
            this.selectPageBtn.UseVisualStyleBackColor = true;
            this.selectPageBtn.Click += new System.EventHandler(this.selectPageBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PaySearchedBtn);
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
            // PaySearchedBtn
            // 
            this.PaySearchedBtn.AutoSize = true;
            this.PaySearchedBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PaySearchedBtn.Location = new System.Drawing.Point(67, 212);
            this.PaySearchedBtn.Name = "PaySearchedBtn";
            this.PaySearchedBtn.Size = new System.Drawing.Size(215, 34);
            this.PaySearchedBtn.TabIndex = 37;
            this.PaySearchedBtn.Text = "Оплатить аудиокнигу";
            this.PaySearchedBtn.UseVisualStyleBackColor = true;
            this.PaySearchedBtn.Click += new System.EventHandler(this.PaySearchedBtn_Click);
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
            this.searchBookBtn.Location = new System.Drawing.Point(126, 176);
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
            this.groupBox3.Size = new System.Drawing.Size(458, 252);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // listBoxChapters
            // 
            this.listBoxChapters.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxChapters.FormattingEnabled = true;
            this.listBoxChapters.HorizontalScrollbar = true;
            this.listBoxChapters.ItemHeight = 16;
            this.listBoxChapters.Location = new System.Drawing.Point(246, 55);
            this.listBoxChapters.Name = "listBoxChapters";
            this.listBoxChapters.Size = new System.Drawing.Size(204, 116);
            this.listBoxChapters.TabIndex = 41;
            this.listBoxChapters.SelectedIndexChanged += new System.EventHandler(this.listBoxChapters_SelectedIndexChanged);
            // 
            // axWindowsMediaPlayerBooks
            // 
            this.axWindowsMediaPlayerBooks.Enabled = true;
            this.axWindowsMediaPlayerBooks.Location = new System.Drawing.Point(6, 55);
            this.axWindowsMediaPlayerBooks.Name = "axWindowsMediaPlayerBooks";
            this.axWindowsMediaPlayerBooks.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayerBooks.OcxState")));
            this.axWindowsMediaPlayerBooks.Size = new System.Drawing.Size(223, 116);
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
            this.listenBookBtn.Location = new System.Drawing.Point(144, 190);
            this.listenBookBtn.Name = "listenBookBtn";
            this.listenBookBtn.Size = new System.Drawing.Size(160, 34);
            this.listenBookBtn.TabIndex = 39;
            this.listenBookBtn.Text = "Слушать";
            this.listenBookBtn.UseVisualStyleBackColor = true;
            this.listenBookBtn.Click += new System.EventHandler(this.listenBookBtn_Click);
            // 
            // ReaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 604);
            this.Controls.Add(this.panel1);
            this.Name = "ReaderForm";
            this.Text = "ReaderForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReaderForm_FormClosing);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayerBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
        private System.Windows.Forms.TextBox pageBox;
        private System.Windows.Forms.Button maxPageBtn;
        private System.Windows.Forms.Button selectPageBtn;
        private System.Windows.Forms.Button minPageBtn;
        private System.Windows.Forms.ListBox booksListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox audioBooksListBox;
        private System.Windows.Forms.Button prevAudioBooksBtn;
        private System.Windows.Forms.Button nextAudioBooksBtn;
        private System.Windows.Forms.Button PaySearchedBtn;
        private System.Windows.Forms.Button PayBookFromListBtn;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox readerBooksListBox;
        private System.Windows.Forms.Button prevReaderBooksBtn;
        private System.Windows.Forms.Button nextReaderBooksBtn;
    }
}