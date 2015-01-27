namespace Sendkeys
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_del_image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_image = new System.Windows.Forms.Button();
            this.lbl_import = new System.Windows.Forms.Button();
            this.lbl_phonelist = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.radio_vietnam = new System.Windows.Forms.RadioButton();
            this.radio_english = new System.Windows.Forms.RadioButton();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lbl_info2 = new System.Windows.Forms.Label();
            this.linklbl1 = new System.Windows.Forms.LinkLabel();
            this.lbl_info = new System.Windows.Forms.Label();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.btn_stop = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radiodelay = new System.Windows.Forms.RadioButton();
            this.radiorandom_delay = new System.Windows.Forms.RadioButton();
            this.numericDelay = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(360, 560);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl3);
            this.tabPage1.Controls.Add(this.lbl2);
            this.tabPage1.Controls.Add(this.lbl1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(352, 534);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gửi tin nhắn";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(12, 230);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(59, 13);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Nội dung : ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(12, 206);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(59, 13);
            this.lbl2.TabIndex = 4;
            this.lbl2.Text = "Nhóm sđt :";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(12, 181);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(40, 13);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Viber : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nội dung tin nhắn : ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 55);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(338, 116);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_stop);
            this.panel1.Controls.Add(this.btn_del_image);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_image);
            this.panel1.Controls.Add(this.lbl_import);
            this.panel1.Controls.Add(this.lbl_phonelist);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.radio_vietnam);
            this.panel1.Controls.Add(this.radio_english);
            this.panel1.Controls.Add(this.lbl6);
            this.panel1.Controls.Add(this.lbl4);
            this.panel1.Controls.Add(this.lbl5);
            this.panel1.Controls.Add(this.btn_start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(346, 528);
            this.panel1.TabIndex = 9;
            // 
            // btn_del_image
            // 
            this.btn_del_image.Location = new System.Drawing.Point(12, 315);
            this.btn_del_image.Name = "btn_del_image";
            this.btn_del_image.Size = new System.Drawing.Size(104, 23);
            this.btn_del_image.TabIndex = 17;
            this.btn_del_image.Text = "Xóa hình";
            this.btn_del_image.UseVisualStyleBackColor = true;
            this.btn_del_image.Click += new System.EventHandler(this.btn_del_image_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(130, 285);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // btn_image
            // 
            this.btn_image.Location = new System.Drawing.Point(12, 285);
            this.btn_image.Name = "btn_image";
            this.btn_image.Size = new System.Drawing.Size(104, 23);
            this.btn_image.TabIndex = 14;
            this.btn_image.Text = "Nhập hình ảnh";
            this.btn_image.UseVisualStyleBackColor = true;
            this.btn_image.Click += new System.EventHandler(this.btn_image_Click);
            // 
            // lbl_import
            // 
            this.lbl_import.Location = new System.Drawing.Point(12, 255);
            this.lbl_import.Name = "lbl_import";
            this.lbl_import.Size = new System.Drawing.Size(104, 24);
            this.lbl_import.TabIndex = 13;
            this.lbl_import.Text = "Nhập sđt";
            this.lbl_import.UseVisualStyleBackColor = true;
            this.lbl_import.Click += new System.EventHandler(this.lbl_import_Click);
            // 
            // lbl_phonelist
            // 
            this.lbl_phonelist.AutoSize = true;
            this.lbl_phonelist.Location = new System.Drawing.Point(9, 349);
            this.lbl_phonelist.Name = "lbl_phonelist";
            this.lbl_phonelist.Size = new System.Drawing.Size(80, 13);
            this.lbl_phonelist.TabIndex = 12;
            this.lbl_phonelist.Text = "Danh sách sđt:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 365);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(324, 161);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.DataSourceChanged += new System.EventHandler(this.dataGridView1_DataSourceChanged);
            // 
            // radio_vietnam
            // 
            this.radio_vietnam.AutoSize = true;
            this.radio_vietnam.Checked = true;
            this.radio_vietnam.Location = new System.Drawing.Point(264, 6);
            this.radio_vietnam.Name = "radio_vietnam";
            this.radio_vietnam.Size = new System.Drawing.Size(72, 17);
            this.radio_vietnam.TabIndex = 10;
            this.radio_vietnam.TabStop = true;
            this.radio_vietnam.Text = "Tiếng việt";
            this.radio_vietnam.UseVisualStyleBackColor = true;
            this.radio_vietnam.CheckedChanged += new System.EventHandler(this.radio_vietnam_CheckedChanged);
            // 
            // radio_english
            // 
            this.radio_english.AutoSize = true;
            this.radio_english.Location = new System.Drawing.Point(264, 29);
            this.radio_english.Name = "radio_english";
            this.radio_english.Size = new System.Drawing.Size(59, 17);
            this.radio_english.TabIndex = 9;
            this.radio_english.Text = "English";
            this.radio_english.UseVisualStyleBackColor = true;
            this.radio_english.CheckedChanged += new System.EventHandler(this.radio_english_CheckedChanged);
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(91, 227);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(35, 13);
            this.lbl6.TabIndex = 8;
            this.lbl6.Text = "label4";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(92, 178);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(35, 13);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = "label2";
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(91, 203);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(35, 13);
            this.lbl5.TabIndex = 7;
            this.lbl5.Text = "label3";
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn_start.FlatAppearance.BorderSize = 0;
            this.btn_start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_start.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_start.Location = new System.Drawing.Point(240, 255);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(101, 23);
            this.btn_start.TabIndex = 1;
            this.btn_start.Text = "Gửi";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lbl_info2);
            this.tabPage2.Controls.Add(this.linklbl1);
            this.tabPage2.Controls.Add(this.lbl_info);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(352, 534);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thông tin phần mềm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lbl_info2
            // 
            this.lbl_info2.AutoSize = true;
            this.lbl_info2.Location = new System.Drawing.Point(10, 159);
            this.lbl_info2.Name = "lbl_info2";
            this.lbl_info2.Size = new System.Drawing.Size(35, 13);
            this.lbl_info2.TabIndex = 2;
            this.lbl_info2.Text = "label2";
            // 
            // linklbl1
            // 
            this.linklbl1.AutoSize = true;
            this.linklbl1.Location = new System.Drawing.Point(10, 139);
            this.linklbl1.Name = "linklbl1";
            this.linklbl1.Size = new System.Drawing.Size(55, 13);
            this.linklbl1.TabIndex = 1;
            this.linklbl1.TabStop = true;
            this.linklbl1.Text = "linkLabel1";
            // 
            // lbl_info
            // 
            this.lbl_info.AutoSize = true;
            this.lbl_info.Location = new System.Drawing.Point(10, 7);
            this.lbl_info.Name = "lbl_info";
            this.lbl_info.Size = new System.Drawing.Size(100, 13);
            this.lbl_info.TabIndex = 0;
            this.lbl_info.Text = "thông tin phần mềm";
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            this.worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.worker_ProgressChanged);
            this.worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.worker_RunWorkerCompleted);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_stop.Enabled = false;
            this.btn_stop.FlatAppearance.BorderSize = 0;
            this.btn_stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_stop.Location = new System.Drawing.Point(130, 255);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(104, 23);
            this.btn_stop.TabIndex = 18;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.numericDelay);
            this.panel2.Controls.Add(this.radiorandom_delay);
            this.panel2.Controls.Add(this.radiodelay);
            this.panel2.Location = new System.Drawing.Point(0, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 30);
            this.panel2.TabIndex = 19;
            // 
            // radiodelay
            // 
            this.radiodelay.AutoSize = true;
            this.radiodelay.Location = new System.Drawing.Point(6, 5);
            this.radiodelay.Name = "radiodelay";
            this.radiodelay.Size = new System.Drawing.Size(58, 17);
            this.radiodelay.TabIndex = 0;
            this.radiodelay.Text = "Delay :";
            this.radiodelay.UseVisualStyleBackColor = true;
            this.radiodelay.CheckedChanged += new System.EventHandler(this.radiodelay_CheckedChanged);
            // 
            // radiorandom_delay
            // 
            this.radiorandom_delay.AutoSize = true;
            this.radiorandom_delay.Checked = true;
            this.radiorandom_delay.Location = new System.Drawing.Point(123, 6);
            this.radiorandom_delay.Name = "radiorandom_delay";
            this.radiorandom_delay.Size = new System.Drawing.Size(95, 17);
            this.radiorandom_delay.TabIndex = 1;
            this.radiorandom_delay.TabStop = true;
            this.radiorandom_delay.Text = "Random Delay";
            this.radiorandom_delay.UseVisualStyleBackColor = true;
            this.radiorandom_delay.CheckedChanged += new System.EventHandler(this.radiorandom_delay_CheckedChanged);
            // 
            // numericDelay
            // 
            this.numericDelay.Enabled = false;
            this.numericDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDelay.Location = new System.Drawing.Point(60, 3);
            this.numericDelay.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDelay.Name = "numericDelay";
            this.numericDelay.Size = new System.Drawing.Size(48, 20);
            this.numericDelay.TabIndex = 2;
            this.numericDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(360, 560);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "VIBER BOT VN";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl_info;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel linklbl1;
        private System.Windows.Forms.Label lbl_info2;
        private System.Windows.Forms.RadioButton radio_vietnam;
        private System.Windows.Forms.RadioButton radio_english;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_phonelist;
        private System.Windows.Forms.Button lbl_import;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_image;
        private System.Windows.Forms.Button btn_del_image;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown numericDelay;
        private System.Windows.Forms.RadioButton radiorandom_delay;
        private System.Windows.Forms.RadioButton radiodelay;
    }
}

