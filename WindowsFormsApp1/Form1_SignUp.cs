using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1_SignUp : Form
    {

        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public Form1_SignUp()
        {
            InitializeComponent();
        }

        private void Form1_SignUp_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            cob身份.SelectedIndex = 0;
            cob班級.SelectedIndex = 0;
        }

        private void cob身份_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            if (cob班級.Text != "")
            {
                if (txt姓名.Text != "" && txt帳號.Text != "" && txt密碼.Text != "" && cob身份.Text != "")
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into accounts values( @Class, @Name, @Account, @Password, @PClass )";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@Class", cob班級.Text);
                    cmd.Parameters.AddWithValue("@Name", txt姓名.Text);
                    cmd.Parameters.AddWithValue("@Account", txt帳號.Text);
                    cmd.Parameters.AddWithValue("@Password", txt密碼.Text);
                    cmd.Parameters.AddWithValue("@PClass", cob身份.SelectedItem);
                   
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();

                    MessageBox.Show("恭喜註冊成功");
                    cob班級.Text = "";
                    txt姓名.Text = "";
                    txt帳號.Text = "";
                    txt密碼.Text = "";
                    cob身份.SelectedIndex = 0;
                }
                else
                {
                    MessageBox.Show("請完整填入個人資訊");
                }
            }
            else
            {
                MessageBox.Show("請填入班級");
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            loginForm SF = new loginForm();
            SF.Show();
            this.Hide();//隱藏當前窗體
        }
    }
}
