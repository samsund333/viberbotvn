using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Sendkeys
{
    public partial class Login_form : Form
    {
        public Login_form()
        {
            InitializeComponent();
        }
        //string sqlcn = @"Data Source=.\SQLEXPRESS;AttachDbFilename=" + @"C:\Users\Bui Xuan Hoang\Documents\Visual Studio 2010\Projects\Sendkeys\Sendkeys\App_Data\Botvn.mdf" + ";Integrated Security=True;User Instance=True";
        //public SqlConnection Conn;
        //public void connect()
        //{
        //    try
        //    {
        //        Conn = new SqlConnection(sqlcn);
        //        Conn.Open();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Khong the ket noi toi co so du lieu","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        //    }
        //}

        MySql.Data.MySqlClient.MySqlConnection conn;
        string myConnectionString;
        public void connect()
        {
            myConnectionString = "server=112.213.89.2;port=3306;uid=botvn_skypeads;pwd='123456';database=botvn_wp;";

            try
            {
                conn = new MySql.Data.MySqlClient.MySqlConnection();
                conn.ConnectionString = myConnectionString;
                conn.Open();
                //MessageBox.Show("ket noi thanh cong");
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            const string message =
        "Are you sure that you would like to close the form?";
            const string caption = "Form Closing";
            var result = MessageBox.Show(message, caption,
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Login_form_Load(object sender, EventArgs e)
        {
            this.Location = new Point((Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2,
                          (Screen.PrimaryScreen.WorkingArea.Height - this.Height) / 2);
            label4.Text = "Today : "+DateTime.Now.ToString("d/M/yyyy");

            //connect();
            connect();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txt_username.Text == "" || txt_username == null)
            {
                MessageBox.Show("Please insert username");
                return;
            }
            if (txt_password.Text == "" || txt_password == null)
            {
                MessageBox.Show("Please insert password");
                return;
            }
            MySqlDataAdapter sda = new MySqlDataAdapter("Select Count(*) from users where username='" + txt_username.Text + "' and password='" + txt_password.Text + "'", conn);
            //SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) from users where username='"+ txt_username.Text+"' and password='"+txt_password.Text+"'",Conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                MySqlDataAdapter da = new MySqlDataAdapter("Select * from users where username='" + txt_username.Text + "' and password='" + txt_password.Text + "'", conn);
                DataTable dt2 = new DataTable();
                da.Fill(dt2);
                if ((DateTime)dt2.Rows[0][5] > DateTime.Now)
                {
                    //MessageBox.Show("OK");
                    this.Hide();
                    Form1 frm = new Form1();
                    frm.Show();
                }
                else
                {
                    MessageBox.Show("Thời hạn sử dụng của bạn đã hết! Liện hệ BOTVN ngay");
                }
            }
            else
            {
                MessageBox.Show("Please check Username and password");
            }
        }

    }
}
