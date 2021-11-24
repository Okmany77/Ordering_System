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
    public partial class loginForm : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        public loginForm()
        {
            InitializeComponent();
        }

        private void loginForm3_Load(object sender, EventArgs e)
        {   
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();
        }

        private void btn學生登入_Click(object sender, EventArgs e)
        {  //C#訪問數據庫步驟:做登入功能、刪除、修改、查詢
           //1.創建資料庫連接對象  伺服器地址:sever 用戶名:userid 密碼:password 數據庫:database
           //SqlConnection conn = new SqlConnection("server=.;uid=sa;pwd=sa;database=SchoolDB")

            UserInfo userInfo = null;
            using (SqlConnection con = new SqlConnection(myDBConnectionString))
            {
                //2.打開資料庫，連接
                con.Open();
                SqlParameter[] paras = {
              new SqlParameter("@帳號",this.txt帳號.Text),
              new SqlParameter("@密碼",this.txt密碼.Text),
            }; 
                //3.創建執行腳本對象
                string strSQL = $@"select * from accounts where 帳號 = @帳號 and 密碼 = @密碼 and 身份 = '學生' ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddRange(paras);

                //SqlCommand ExecuteNonQuery() //添加、刪除、修改
                using (SqlDataReader reader = cmd.ExecuteReader())
                    //執行返回游標對象
                {

                    //根據游標對象讀取對應信息
                    if (reader.Read()) //沒有數據:False  有數據:true
                    {
                        //駝峰命名法，不符合面向對向開發邏輯
                        //UserInfo組織數據
                        userInfo = new UserInfo();
                        userInfo.id = (int)reader["id"];
                        userInfo.班級 = reader["班級"].ToString();
                        userInfo.姓名 = reader["姓名"].ToString();
                        userInfo.帳號 = reader["帳號"].ToString();
                        userInfo.密碼 = reader["密碼"].ToString();
                        userInfo.身份 = reader["身份"].ToString();
                        //某某人登錄了!
                    }
                }
            } //5.關閉對象釋放資源
              //reader.Close(); //關閉游標對象
              //con.Close();  //關閉連接對象


            if (userInfo != null)
            {

                Form_student SF = new Form_student(userInfo);
                SF.Show();
                this.Hide();//隱藏當前窗體
                
            }
            else
            {
                MessageBox.Show("登入失敗");
            }

        }

        private void btn班代登入_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = null;
            using (SqlConnection con = new SqlConnection(myDBConnectionString))
            {
                con.Open();
                SqlParameter[] paras = {
              new SqlParameter("@帳號",this.txt帳號.Text),
              new SqlParameter("@密碼",this.txt密碼.Text),
            };
                string strSQL = $@"select * from accounts where 帳號 = @帳號 and 密碼 = @密碼 and 身份 = '班代' ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddRange(paras);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {


                    if (reader.Read())
                    {
                        userInfo = new UserInfo();
                        userInfo.id = (int)reader["id"];
                        userInfo.班級 = reader["班級"].ToString();
                        userInfo.姓名 = reader["姓名"].ToString();
                        userInfo.帳號 = reader["帳號"].ToString();
                        userInfo.密碼 = reader["密碼"].ToString();
                        userInfo.身份 = reader["身份"].ToString();
                    }
                }
            }


            if (userInfo != null)
            {
                Form_classSever SF = new Form_classSever(userInfo);
                SF.Show();
                this.Hide();//隱藏當前窗體
            }
            else
            {
                MessageBox.Show("登入失敗");
            }
        }

        private void btn管理員登入_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = null;
            using (SqlConnection con = new SqlConnection(myDBConnectionString))
            {
                con.Open();
                SqlParameter[] paras = {
              new SqlParameter("@帳號",this.txt帳號.Text),
              new SqlParameter("@密碼",this.txt密碼.Text),
            };
                string strSQL = $@"select * from accounts where 帳號 = @帳號 and 密碼 = @密碼 and 身份 = '管理員' ";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddRange(paras);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {


                    if (reader.Read())
                    {
                        userInfo = new UserInfo();
                        userInfo.id = (int)reader["id"];
                        userInfo.班級 = reader["班級"].ToString();
                        userInfo.姓名 = reader["姓名"].ToString();
                        userInfo.帳號 = reader["帳號"].ToString();
                        userInfo.密碼 = reader["密碼"].ToString();
                        userInfo.身份 = reader["身份"].ToString();
                    }
                }
            }


            if (userInfo != null)
            {
                Form1_Manager SF = new Form1_Manager(userInfo);
                SF.Show();
                this.Hide();//隱藏當前窗體
            }
            else
            {
                MessageBox.Show("登入失敗");
            }
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
           
            Form1_SignUp SF = new Form1_SignUp();
            SF.Show();
            this.Hide();//隱藏當前窗體
        }

        private void txt帳號_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn離開_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //關閉應用程式
        }
    }
}
