namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.bookiduser = new System.Windows.Forms.TextBox();
            this.book_id = new System.Windows.Forms.Label();
            this.searchbutton = new System.Windows.Forms.Button();
            this.titleuser = new System.Windows.Forms.TextBox();
            this.authornameuser = new System.Windows.Forms.TextBox();
            this.author_name = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.bookiduserbox = new System.Windows.Forms.TextBox();
            this.cardnouserbox = new System.Windows.Forms.TextBox();
            this.branchiduserbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkoutbutton = new System.Windows.Forms.Button();
            this.displaysearch = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkoutdisplay = new System.Windows.Forms.DataGridView();
            this.checkoutlabel = new System.Windows.Forms.Label();
            this.inbookidtext = new System.Windows.Forms.TextBox();
            this.incardnotext = new System.Windows.Forms.TextBox();
            this.inborrowertext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inbutton = new System.Windows.Forms.Button();
            this.checkinlabel = new System.Windows.Forms.Label();
            this.ingriddisplay = new System.Windows.Forms.DataGridView();
            this.borrowerfirstname = new System.Windows.Forms.TextBox();
            this.borrowerlastname = new System.Windows.Forms.TextBox();
            this.borroweraddress = new System.Windows.Forms.TextBox();
            this.borrowerphone = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.borrowerlabel = new System.Windows.Forms.Label();
            this.indelbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.displaysearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutdisplay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingriddisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // bookiduser
            // 
            this.bookiduser.Location = new System.Drawing.Point(292, 44);
            this.bookiduser.Name = "bookiduser";
            this.bookiduser.Size = new System.Drawing.Size(100, 20);
            this.bookiduser.TabIndex = 0;
            this.bookiduser.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // book_id
            // 
            this.book_id.AutoSize = true;
            this.book_id.Location = new System.Drawing.Point(312, 28);
            this.book_id.Name = "book_id";
            this.book_id.Size = new System.Drawing.Size(46, 13);
            this.book_id.TabIndex = 1;
            this.book_id.Text = "Book_id";
            this.book_id.Click += new System.EventHandler(this.label1_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(425, 78);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 23);
            this.searchbutton.TabIndex = 2;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // titleuser
            // 
            this.titleuser.Location = new System.Drawing.Point(418, 44);
            this.titleuser.Name = "titleuser";
            this.titleuser.Size = new System.Drawing.Size(100, 20);
            this.titleuser.TabIndex = 3;
            this.titleuser.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // authornameuser
            // 
            this.authornameuser.Location = new System.Drawing.Point(549, 44);
            this.authornameuser.Name = "authornameuser";
            this.authornameuser.Size = new System.Drawing.Size(100, 20);
            this.authornameuser.TabIndex = 4;
            // 
            // author_name
            // 
            this.author_name.AutoSize = true;
            this.author_name.Location = new System.Drawing.Point(559, 28);
            this.author_name.Name = "author_name";
            this.author_name.Size = new System.Drawing.Size(72, 13);
            this.author_name.TabIndex = 5;
            this.author_name.Text = "Author_Name";
            this.author_name.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 6;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Location = new System.Drawing.Point(456, 28);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(27, 13);
            this.title.TabIndex = 7;
            this.title.Text = "Title";
            this.title.Click += new System.EventHandler(this.label4_Click);
            // 
            // bookiduserbox
            // 
            this.bookiduserbox.Location = new System.Drawing.Point(292, 245);
            this.bookiduserbox.Name = "bookiduserbox";
            this.bookiduserbox.Size = new System.Drawing.Size(100, 20);
            this.bookiduserbox.TabIndex = 8;
            this.bookiduserbox.TextChanged += new System.EventHandler(this.bookiduserbox_TextChanged);
            // 
            // cardnouserbox
            // 
            this.cardnouserbox.Location = new System.Drawing.Point(549, 245);
            this.cardnouserbox.Name = "cardnouserbox";
            this.cardnouserbox.Size = new System.Drawing.Size(100, 20);
            this.cardnouserbox.TabIndex = 9;
            // 
            // branchiduserbox
            // 
            this.branchiduserbox.Location = new System.Drawing.Point(418, 245);
            this.branchiduserbox.Name = "branchiduserbox";
            this.branchiduserbox.Size = new System.Drawing.Size(100, 20);
            this.branchiduserbox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Book_id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(436, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "branch_id";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(570, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Card_no";
            // 
            // checkoutbutton
            // 
            this.checkoutbutton.Location = new System.Drawing.Point(429, 271);
            this.checkoutbutton.Name = "checkoutbutton";
            this.checkoutbutton.Size = new System.Drawing.Size(75, 23);
            this.checkoutbutton.TabIndex = 14;
            this.checkoutbutton.Text = "check out";
            this.checkoutbutton.UseVisualStyleBackColor = true;
            this.checkoutbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // displaysearch
            // 
            this.displaysearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.displaysearch.Location = new System.Drawing.Point(549, 78);
            this.displaysearch.Name = "displaysearch";
            this.displaysearch.Size = new System.Drawing.Size(240, 103);
            this.displaysearch.TabIndex = 15;
            this.displaysearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.displaysearch_CellContentClick);
            // 
            // checkoutdisplay
            // 
            this.checkoutdisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkoutdisplay.Location = new System.Drawing.Point(549, 286);
            this.checkoutdisplay.Name = "checkoutdisplay";
            this.checkoutdisplay.Size = new System.Drawing.Size(240, 103);
            this.checkoutdisplay.TabIndex = 16;
            this.checkoutdisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // checkoutlabel
            // 
            this.checkoutlabel.AutoSize = true;
            this.checkoutlabel.Location = new System.Drawing.Point(426, 414);
            this.checkoutlabel.Name = "checkoutlabel";
            this.checkoutlabel.Size = new System.Drawing.Size(74, 13);
            this.checkoutlabel.TabIndex = 17;
            this.checkoutlabel.Text = "checkoutlabel";
            this.checkoutlabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // inbookidtext
            // 
            this.inbookidtext.Location = new System.Drawing.Point(292, 469);
            this.inbookidtext.Name = "inbookidtext";
            this.inbookidtext.Size = new System.Drawing.Size(100, 20);
            this.inbookidtext.TabIndex = 18;
            // 
            // incardnotext
            // 
            this.incardnotext.Location = new System.Drawing.Point(418, 469);
            this.incardnotext.Name = "incardnotext";
            this.incardnotext.Size = new System.Drawing.Size(100, 20);
            this.incardnotext.TabIndex = 19;
            // 
            // inborrowertext
            // 
            this.inborrowertext.Location = new System.Drawing.Point(531, 469);
            this.inborrowertext.Name = "inborrowertext";
            this.inborrowertext.Size = new System.Drawing.Size(100, 20);
            this.inborrowertext.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(312, 453);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Book_id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "card_no";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(546, 453);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "borrower";
            // 
            // inbutton
            // 
            this.inbutton.Location = new System.Drawing.Point(429, 504);
            this.inbutton.Name = "inbutton";
            this.inbutton.Size = new System.Drawing.Size(75, 23);
            this.inbutton.TabIndex = 24;
            this.inbutton.Text = "check in";
            this.inbutton.UseVisualStyleBackColor = true;
            this.inbutton.Click += new System.EventHandler(this.inbutton_Click);
            // 
            // checkinlabel
            // 
            this.checkinlabel.AutoSize = true;
            this.checkinlabel.Location = new System.Drawing.Point(436, 639);
            this.checkinlabel.Name = "checkinlabel";
            this.checkinlabel.Size = new System.Drawing.Size(67, 13);
            this.checkinlabel.TabIndex = 25;
            this.checkinlabel.Text = "checkinlabel";
            this.checkinlabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // ingriddisplay
            // 
            this.ingriddisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ingriddisplay.Location = new System.Drawing.Point(562, 516);
            this.ingriddisplay.Name = "ingriddisplay";
            this.ingriddisplay.Size = new System.Drawing.Size(240, 103);
            this.ingriddisplay.TabIndex = 26;
            // 
            // borrowerfirstname
            // 
            this.borrowerfirstname.Location = new System.Drawing.Point(900, 44);
            this.borrowerfirstname.Name = "borrowerfirstname";
            this.borrowerfirstname.Size = new System.Drawing.Size(100, 20);
            this.borrowerfirstname.TabIndex = 27;
            this.borrowerfirstname.TextChanged += new System.EventHandler(this.borrowerfirstname_TextChanged);
            // 
            // borrowerlastname
            // 
            this.borrowerlastname.Location = new System.Drawing.Point(900, 94);
            this.borrowerlastname.Name = "borrowerlastname";
            this.borrowerlastname.Size = new System.Drawing.Size(100, 20);
            this.borrowerlastname.TabIndex = 28;
            this.borrowerlastname.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // borroweraddress
            // 
            this.borroweraddress.Location = new System.Drawing.Point(900, 143);
            this.borroweraddress.Name = "borroweraddress";
            this.borroweraddress.Size = new System.Drawing.Size(100, 20);
            this.borroweraddress.TabIndex = 29;
            this.borroweraddress.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // borrowerphone
            // 
            this.borrowerphone.Location = new System.Drawing.Point(900, 184);
            this.borrowerphone.Name = "borrowerphone";
            this.borrowerphone.Size = new System.Drawing.Size(100, 20);
            this.borrowerphone.TabIndex = 30;
            this.borrowerphone.TextChanged += new System.EventHandler(this.borrowerphone_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1038, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(918, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "first_name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(918, 78);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "last_name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(929, 127);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "address";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(936, 168);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "phone";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // borrowerlabel
            // 
            this.borrowerlabel.AutoSize = true;
            this.borrowerlabel.Location = new System.Drawing.Point(897, 216);
            this.borrowerlabel.Name = "borrowerlabel";
            this.borrowerlabel.Size = new System.Drawing.Size(70, 13);
            this.borrowerlabel.TabIndex = 36;
            this.borrowerlabel.Text = "borrowerlabel";
            this.borrowerlabel.Click += new System.EventHandler(this.borrowerlabel_Click);
            // 
            // indelbutton
            // 
            this.indelbutton.Location = new System.Drawing.Point(429, 549);
            this.indelbutton.Name = "indelbutton";
            this.indelbutton.Size = new System.Drawing.Size(75, 23);
            this.indelbutton.TabIndex = 37;
            this.indelbutton.Text = "delete";
            this.indelbutton.UseVisualStyleBackColor = true;
            this.indelbutton.Click += new System.EventHandler(this.indelbutton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.indelbutton);
            this.Controls.Add(this.borrowerlabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.borrowerphone);
            this.Controls.Add(this.borroweraddress);
            this.Controls.Add(this.borrowerlastname);
            this.Controls.Add(this.borrowerfirstname);
            this.Controls.Add(this.ingriddisplay);
            this.Controls.Add(this.checkinlabel);
            this.Controls.Add(this.inbutton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inborrowertext);
            this.Controls.Add(this.incardnotext);
            this.Controls.Add(this.inbookidtext);
            this.Controls.Add(this.checkoutlabel);
            this.Controls.Add(this.checkoutdisplay);
            this.Controls.Add(this.displaysearch);
            this.Controls.Add(this.checkoutbutton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.branchiduserbox);
            this.Controls.Add(this.cardnouserbox);
            this.Controls.Add(this.bookiduserbox);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.author_name);
            this.Controls.Add(this.authornameuser);
            this.Controls.Add(this.titleuser);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.book_id);
            this.Controls.Add(this.bookiduser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.displaysearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.checkoutdisplay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ingriddisplay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox bookiduser;
        private System.Windows.Forms.Label book_id;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.TextBox titleuser;
        private System.Windows.Forms.TextBox authornameuser;
        private System.Windows.Forms.Label author_name;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.TextBox bookiduserbox;
        private System.Windows.Forms.TextBox cardnouserbox;
        private System.Windows.Forms.TextBox branchiduserbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button checkoutbutton;
        private System.Windows.Forms.DataGridView displaysearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView checkoutdisplay;
        private System.Windows.Forms.Label checkoutlabel;
        private System.Windows.Forms.TextBox inbookidtext;
        private System.Windows.Forms.TextBox incardnotext;
        private System.Windows.Forms.TextBox inborrowertext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button inbutton;
        private System.Windows.Forms.Label checkinlabel;
        private System.Windows.Forms.DataGridView ingriddisplay;
        private System.Windows.Forms.TextBox borrowerfirstname;
        private System.Windows.Forms.TextBox borrowerlastname;
        private System.Windows.Forms.TextBox borroweraddress;
        private System.Windows.Forms.TextBox borrowerphone;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label borrowerlabel;
        private System.Windows.Forms.Button indelbutton;
    }
}

