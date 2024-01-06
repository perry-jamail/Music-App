namespace DatabaseSQLMusicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            textBox1 = new TextBox();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            button3 = new Button();
            txt_description = new TextBox();
            label5 = new Label();
            txt_imageURL = new TextBox();
            label4 = new Label();
            txt_year = new TextBox();
            label3 = new Label();
            txt_artist = new TextBox();
            label2 = new Label();
            txt_album = new TextBox();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            label6 = new Label();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(424, 13);
            button1.Name = "button1";
            button1.Size = new Size(199, 34);
            button1.TabIndex = 0;
            button1.Text = "Load Albums";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(424, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(730, 321);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // button2
            // 
            button2.Location = new Point(1018, 11);
            button2.Name = "button2";
            button2.Size = new Size(136, 34);
            button2.TabIndex = 2;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(680, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(332, 31);
            textBox1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(826, 412);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(307, 321);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(txt_description);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_imageURL);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_year);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_artist);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_album);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(380, 303);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Album";
            // 
            // button3
            // 
            button3.Location = new Point(121, 252);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 10;
            button3.Text = "Add";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // txt_description
            // 
            txt_description.Location = new Point(221, 194);
            txt_description.Name = "txt_description";
            txt_description.Size = new Size(150, 31);
            txt_description.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 200);
            label5.Name = "label5";
            label5.Size = new Size(102, 25);
            label5.TabIndex = 8;
            label5.Text = "Description";
            // 
            // txt_imageURL
            // 
            txt_imageURL.Location = new Point(221, 156);
            txt_imageURL.Name = "txt_imageURL";
            txt_imageURL.Size = new Size(150, 31);
            txt_imageURL.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 162);
            label4.Name = "label4";
            label4.Size = new Size(93, 25);
            label4.TabIndex = 6;
            label4.Text = "ImageURL";
            // 
            // txt_year
            // 
            txt_year.Location = new Point(221, 117);
            txt_year.Name = "txt_year";
            txt_year.Size = new Size(150, 31);
            txt_year.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 123);
            label3.Name = "label3";
            label3.Size = new Size(44, 25);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // txt_artist
            // 
            txt_artist.Location = new Point(221, 79);
            txt_artist.Name = "txt_artist";
            txt_artist.Size = new Size(150, 31);
            txt_artist.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 85);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 2;
            label2.Text = "Artist";
            // 
            // txt_album
            // 
            txt_album.Location = new Point(221, 37);
            txt_album.Name = "txt_album";
            txt_album.Size = new Size(150, 31);
            txt_album.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "Album Name";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(22, 398);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 62;
            dataGridView2.RowTemplate.Height = 33;
            dataGridView2.Size = new Size(730, 348);
            dataGridView2.TabIndex = 6;
            dataGridView2.CellClick += dataGridView2_CellClick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 370);
            label6.Name = "label6";
            label6.Size = new Size(59, 25);
            label6.TabIndex = 7;
            label6.Text = "Tracks";
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(335, 752);
            webView21.Name = "webView21";
            webView21.Size = new Size(819, 485);
            webView21.TabIndex = 8;
            webView21.ZoomFactor = 1D;
            // 
            // button4
            // 
            button4.Location = new Point(22, 752);
            button4.Name = "button4";
            button4.Size = new Size(179, 34);
            button4.TabIndex = 9;
            button4.Text = "Delete Selected Text";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1237, 1249);
            Controls.Add(button4);
            Controls.Add(webView21);
            Controls.Add(label6);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(textBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox txt_album;
        private Label label1;
        private Button button3;
        private TextBox txt_description;
        private Label label5;
        private TextBox txt_imageURL;
        private Label label4;
        private TextBox txt_year;
        private Label label3;
        private TextBox txt_artist;
        private DataGridView dataGridView2;
        private Label label6;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Button button4;
    }
}