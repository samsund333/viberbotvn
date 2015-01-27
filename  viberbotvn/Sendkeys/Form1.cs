using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Collections;
using WindowsInput;
using WindowsInput.Native;
using System.Text.RegularExpressions;

using System.Globalization;
using System.Resources;
using System.Diagnostics;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sendkeys
{
    //[Flags]


    public partial class Form1 : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32")]
        public static extern int SetCursorPos(int x, int y);

        [DllImport("user32.dll", SetLastError = true)]
        internal static extern bool MoveWindow(IntPtr hWnd, int X, int Y, int nWidth, int nHeight, bool bRepaint);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        //De tim cai window minh dang lam viec
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern int FindWindow(string lpClassName, string lpWindowName);

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hwc, IntPtr hwp);

        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }

        #region Fields
        private const int MOUSEEVENTF_MOVE = 0x0001; /* mouse move */
        private const int MOUSEEVENTF_LEFTDOWN = 0x0002; /* left button down */
        private const int MOUSEEVENTF_LEFTUP = 0x0004; /* left button up */
        private const int MOUSEEVENTF_RIGHTDOWN = 0x0008; /* right button down */
        private const int MOUSEEVENTF_RIGHTUP = 0x0010; /* right button up */
        private const int MOUSEEVENTF_MIDDLEDOWN = 0x0020; /* middle button down */
        private const int MOUSEEVENTF_MIDDLEUP = 0x0040; /* middle button up */
        private const int MOUSEEVENTF_XDOWN = 0x0080; /* x button down */
        private const int MOUSEEVENTF_XUP = 0x0100; /* x button down */
        private const int MOUSEEVENTF_WHEEL = 0x0800; /* wheel button rolled */
        private const int MOUSEEVENTF_VIRTUALDESK = 0x4000; /* map to entire virtual desktop */
        private const int MOUSEEVENTF_ABSOLUTE = 0x8000; /* absolute move */


        //Phần ngôn ngữ
        ResourceManager res_man;
        CultureInfo cul;
        #endregion
        string image1 = "";

        public Form1()
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(1175,605);
            this.MinimumSize = new System.Drawing.Size(375, 605);
            
            worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;

            worker.DoWork += new DoWorkEventHandler(worker_DoWork);
            worker.RunWorkerCompleted+=new RunWorkerCompletedEventHandler(worker_RunWorkerCompleted);
            worker.ProgressChanged+=new ProgressChangedEventHandler(worker_ProgressChanged);

            //Thread.Sleep(5000);
            openviber();
        }

        public static Process p;
        private void openviber()
        {
            StreamReader rd1 = new StreamReader("dd.txt");
            string st = rd1.ReadLine();
            string filepath = st;
            //Xóa các tiến trình Viber đang chạy
            Process[] proc = Process.GetProcessesByName("Viber");
            foreach (Process prs in proc)
            {
                prs.Kill();
            }
            Thread.Sleep(1000);

            //Chạy tiến trình viber mới
            p = Process.Start(filepath);
            Thread.Sleep(3000);
            //p.WaitForInputIdle();
            //SetParent(p.MainWindowHandle, this.tabPage1.Handle);

            //Di chuyển vị trí của form xử lý tới vị trí cố định
            IntPtr id = p.MainWindowHandle;
            Form1.MoveWindow(p.MainWindowHandle, 569, 77, 500, 500, true);
            //Thread.Sleep(3000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn_start.Enabled = false;
            btn_stop.Enabled = true;
            if (!worker.IsBusy)
            {
                worker.RunWorkerAsync();
            }
            
        }

        public void Do_Work()
        {
            StreamReader rd_dd = new StreamReader("dd.txt");
            StreamReader checksdt = new StreamReader("sdt.txt");
            string checksdt_2 = checksdt.ReadLine();
            string st = rd_dd.ReadLine();
            //Lấy tên đường dẫn file
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please! Insert text in textbox");
            }
            else if (!(System.IO.File.Exists(st)))
            {
                MessageBox.Show("Please! File Viber không tồn tại");
            }
            else if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("Kiem tra lai sdt");
            }
            else
            {
                Form1.MoveWindow(p.MainWindowHandle, 569, 77, 500, 500, true);
                Thread.Sleep(2000);
                SetCursorPos((1068), (131));
                Thread.Sleep(500);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);

                //Sử dụng biến simulator để truyền phím
                InputSimulator simulator = new InputSimulator();

                #region docfile
                //StreamReader rd = new StreamReader("sdt.txt");
                Random random = new Random();
                string line = "";
                int i = 0;
                int r = 0;
                while (r < dataGridView1.RowCount)
                {
                    Form1.MoveWindow(p.MainWindowHandle, 569, 77, 500, 500, true);
                    line = dataGridView1.Rows[r].Cells[1].Value.ToString();

                    if (line == "")
                    {
                        break;
                    }
                    else
                    {
                        Thread.Sleep(1000 * random.Next(1, 3));
                        simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_D);


                        for (i = 0; i < 20; i++)
                        {
                            simulator.Keyboard.KeyPress(VirtualKeyCode.BACK);
                            Thread.Sleep(60);
                        }
                        //simulator.Keyboard.KeyPress(VirtualKeyCode.ADD);
                        Thread.Sleep(40);
                        //gui nhieu no khong gui duoc nen phai lam the nay;
                        foreach (char c in line)
                        {
                            simulator.Keyboard.TextEntry("" + c);
                            Thread.Sleep(60);
                        }

                        simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        Thread.Sleep(500 * random.Next(1, 10));
                        SetCursorPos((793), (481));
                        Thread.Sleep(500);
                        mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
                        //mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
                        Thread.Sleep(1000 * random.Next(1, 10));

                        simulator.Keyboard.TextEntry("Xin chao " + line);
                        Thread.Sleep(500);
                        simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        Thread.Sleep(500);
                        foreach (char c in textBox2.Text)
                        {
                            simulator.Keyboard.TextEntry("" + c);
                            Thread.Sleep(60);
                        }
                        simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        Thread.Sleep(1000);
                        if (image1 != "")
                        {
                            SendKeys.Flush();
                            simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);

                            Thread.Sleep(2000);
                            //simulator.Keyboard.ModifiedKeyStroke(VirtualKeyCode.CONTROL, VirtualKeyCode.VK_P);                           
                            SendKeys.SendWait("^p");
                            Thread.Sleep(3000);
                            //SendKeys.SendWait("^p");
                            //Thread.Sleep(2000);
                            simulator.Keyboard.TextEntry(image1);
                            //foreach (char c in image1)
                            //{
                            //    simulator.Keyboard.TextEntry("" + c);
                            //    Thread.Sleep(20);
                            //}
                            Thread.Sleep(2000);
                            simulator.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                        }
                        SendKeys.Flush();
                        if (numericDelay.Enabled == true)
                        {
                            Thread.Sleep(1000 * int.Parse(numericDelay.Value.ToString()));
                        }
                        else
                        {
                            Thread.Sleep(1000 * random.Next(30, 60));
                        }
                        r++;
                    }
                }
                #endregion
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Check xem đường dẫn tới file viber đã ok chưa
            StreamReader rd1 = new StreamReader("dd.txt");
            string st = rd1.ReadLine();
            if (System.IO.File.Exists(st))
            {
                lbl4.ForeColor = System.Drawing.Color.Blue;
                lbl4.Text = "Đường dẫn Viber đã ổn!";
            }
            else {
                lbl4.ForeColor = System.Drawing.Color.Red;
                lbl4.Text = "Đường dẫn Viber chưa ổn, vui lòng kiểm tra lại!";
            }

            //Check lại sđt
            checkphonestatus();

            this.DesktopLocation = new Point(192, 78);
            textBox2.Text = "Nhập vào nội dung tại đây...";
            string info = "\nPhần mềm được phát triển bởi công ty BOTVN -2015 \n\nPhần mềm chuyên dụng dành cho marketing online";
            info += "\n\nDịch vụ gia công phần mềm IT BotVN cung cấp dịch vụ gia công\n phần mềm lớp đầu tiên cho các khách hàng của chúng tôi trên toàn\n cầu. Chúng tôi cung cấp kết quả vượt quá mong đợi của bạn.\n\nMọi thông tin chi tiết truy cập tại địa chỉ:\n";
            lbl_info.Text = info;
            linklbl1.Text = "http://botvn.net/";
            lbl_info2.Text = "LIÊN HỆ\nMr Vũ :0967783497\nMr Nhật :0908336851\nSkype : john.do.vn\nEmail: botvn.net@gmail.com";
            // lay nguon cho file ngon ngữ
            res_man = new ResourceManager("Sendkeys.Resource.Res", typeof(Form1).Assembly);

            //this.Width = 1175;

                      
        }
        

        //Thay doi ngon ngu function
        private void switch_language()
        {
            if (radio_english.Checked == true)
            {
                cul = CultureInfo.CreateSpecificCulture("en");
            }
            else
            {
                cul = CultureInfo.CreateSpecificCulture("vi");
            }

            tabPage1.Text = res_man.GetString("tab_sendmsg", cul);
            tabPage2.Text = res_man.GetString("tab_about", cul);
            label1.Text = res_man.GetString("lbl_msg", cul);
            textBox2.Text = res_man.GetString("txt_content", cul);
            lbl1.Text = res_man.GetString("lbl_viber", cul);
            lbl4.Text = res_man.GetString("lbl_viber_yes", cul);
            lbl2.Text = res_man.GetString("lbl_phone", cul);
            lbl5.Text = res_man.GetString("lbl_phone_yes", cul);
            lbl3.Text = res_man.GetString("lbl_content", cul);
            lbl6.Text = res_man.GetString("lbl_content_yes", cul);
            btn_start.Text = res_man.GetString("btn_send", cul);
            lbl_info.Text = res_man.GetString("lbl_info", cul);
            lbl_import.Text = res_man.GetString("lbl_import", cul);
            lbl_phonelist.Text = res_man.GetString("lbl_phonelist", cul);
            btn_image.Text = res_man.GetString("btn_image", cul);
            btn_del_image.Text = res_man.GetString("btn_image_delete", cul);
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                lbl6.Text = "Dont have any text in textbox";
                lbl6.ForeColor = System.Drawing.Color.Red;
                lbl6.Visible = true;
            }
            else
            {
                lbl6.ForeColor = System.Drawing.Color.Blue;
                lbl6.Text = "Content is OK! Check is again for suite";
                
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            worker.Dispose();
            //Xóa các tiến trình Viber đang chạy
            Process[] proc = Process.GetProcessesByName("Viber");
            foreach (Process prs in proc)
            {
                prs.Kill();
            }
            Thread.Sleep(500);

            Application.Exit();
        }

        private void radio_english_CheckedChanged(object sender, EventArgs e)
        {
            
            
        }

        private void radio_vietnam_CheckedChanged(object sender, EventArgs e)
        {
            switch_language();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void lbl_import_Click(object sender, EventArgs e)
        {
            ofd.Filter = "TXT|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                bool ck = true;
                foreach (var line in File.ReadAllLines(ofd.FileName))
                {
                    if (line.Length > 20 || !IsNumber(line) || (line.IndexOf(".") !=-1) )
                    {
                        ck = false; break;
                    }
                }

                if (ck == true)
                {
                    dataGridView1.DataSource = Phonenumber.LoadPhoneListFromFile(ofd.FileName);
                }
                else
                {
                    MessageBox.Show("Error in numberphone file");
                    
                }
            }
        }

        private void dataGridView1_DataSourceChanged(object sender, EventArgs e)
        {
            checkphonestatus();
        }

        public void checkphonestatus()
        {
            int row = dataGridView1.RowCount;

            if (row == 0)
            {
                lbl5.ForeColor = System.Drawing.Color.Red;
                lbl5.Text = "Số điện thoại chưa phù hợp, vui lòng kiểm tra lại";
            }
            else
            {
                lbl5.ForeColor = System.Drawing.Color.Blue;
                lbl5.Text = "Số điện thoại đã phù hợp!";
            }
        }
        public bool IsNumber(string pText)
        {
            Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
            return regex.IsMatch(pText);
        }
        

        private void btn_image_Click(object sender, EventArgs e)
        {
            ofd.Title = "Browse Image";
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(ofd.FileName);
                image1 = ofd.FileName;
                //MessageBox.Show(image1);
            }
        }

        private void btn_del_image_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (image1 != "") i = 1;
            if (i == 1)
            {
                pictureBox1.Image = null;
                image1 = "";
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            Do_Work();
        }

        private void worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

        }

        private void worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            worker.CancelAsync();
            btn_start.Enabled = true;
            btn_stop.Enabled = false;
            
        }

        private void radiorandom_delay_CheckedChanged(object sender, EventArgs e)
        {
            numericDelay.Enabled = false;
        }

        private void radiodelay_CheckedChanged(object sender, EventArgs e)
        {
            numericDelay.Enabled = true;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            
        }


    }

    public class Phonenumber
    {
        public string STT { get; set; }
        public string Phone { get; set; }


        public static List<Phonenumber> LoadPhoneListFromFile(string path)
        {
            var phones = new List<Phonenumber>();
            int count = 0;
            foreach (var line in File.ReadAllLines(path))
            {
                if (line == "")
                {
                    break;
                }
                else
                {
                    var columns = line.Split('\t');
                    phones.Add(new Phonenumber
                    {
                        STT = (count = count + 1).ToString(),
                        Phone = "+"+columns[0],
                    });
                }
            }

            return phones;
        }
    }
}
