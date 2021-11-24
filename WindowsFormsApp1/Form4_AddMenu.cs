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
    public partial class Form4_AddMenu : Form
    {
        public Form1_Manager 訂便當系統;
        public Form4_AddMenu(Form1_Manager form)
        {
            this.訂便當系統 = form;
            InitializeComponent();
        }

        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";

        public Form4_AddMenu()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

           
        }

        private void cob店家名稱_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt新增菜名_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt新增圖片_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn新增菜名_Click(object sender, EventArgs e)
        {
            if(txt店家.Text != "" )
                {
                if (txt新增菜名.Text != "" && txt價格.Text != "" && txt電話.Text != "" && txt地址.Text != "")
                {
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    string strSQL = "insert into stores values( @ShopName, @MenuName, @Pic, @Price, @Tel, @Address)";
                    SqlCommand cmd = new SqlCommand(strSQL, con);

                    cmd.Parameters.AddWithValue("@ShopName", txt店家.Text);
                    cmd.Parameters.AddWithValue("@MenuName", txt新增菜名.Text);
                    cmd.Parameters.AddWithValue("@Pic", txt新增圖片.Text);
                    cmd.Parameters.AddWithValue("@Price", Int32.Parse(txt價格.Text));
                    cmd.Parameters.AddWithValue("@Tel", txt電話.Text);
                    cmd.Parameters.AddWithValue("@Address", txt地址.Text);
                   
                    int rows = cmd.ExecuteNonQuery();
                    con.Close();
                    
                    MessageBox.Show("加入品項成功");
                    txt店家.Text = "";
                    txt新增菜名.Text = "";
                    txt新增圖片.Text = "";
                    txt價格.Text = "";
                    txt電話.Text = "";
                    txt地址.Text = "";
                }
                else
                {
                    MessageBox.Show("請完整填入品項資訊");
                }
            }
            else
            {
                MessageBox.Show("請填入新增廠商");
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {
            //Form1 訂便當系統 = new Form1();
            ////form訂購單列表.show();
            //訂便當系統.ShowDialog();
            Close();
            訂便當系統.UpData1();
        }
    }
}
