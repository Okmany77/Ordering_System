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
    public partial class 刪除菜單Form : Form
    {

        public Form1_Manager 訂便當系統;
        public 刪除菜單Form(Form1_Manager form)
        {
            this.訂便當系統 = form;
            InitializeComponent();
        }

        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
       

        public 刪除菜單Form()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();


         
            SqlConnection con1 = new SqlConnection(myDBConnectionString);
            con1.Open();
            string strSQL1 = "select 店家 from stores group by 店家 ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            //string strMsg = "";
            int j = 0;
            while (reader1.Read())
            {

                cob店家.Items.Add(reader1["店家"].ToString());
                j += 1;
            }
            cob店家.SelectedIndex = 0;
            reader1.Close();
            con1.Close();                       
        }

        public void UpData()
        {
            cob店家.Items.Clear();
            SqlConnection con1 = new SqlConnection(myDBConnectionString);
            con1.Open();
            string strSQL1 = "select 店家 from stores group by 店家 ";
            SqlCommand cmd1 = new SqlCommand(strSQL1, con1);
            SqlDataReader reader1 = cmd1.ExecuteReader();
            //string strMsg = "";
            int j = 0;
            while (reader1.Read())
            {

                cob店家.Items.Add(reader1["店家"].ToString());
                j += 1;
            }
            cob店家.SelectedIndex = 0;
            reader1.Close();
            con1.Close();
        }

        private void btn刪除_Click(object sender, EventArgs e)
        {
            if (cob店家.SelectedItem != null && cob菜名.SelectedItem != null)
            {
                DialogResult res = MessageBox.Show("確定要刪除品項?", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.OK)
                {
                    string Store = cob店家.SelectedItem.ToString();
                    string Menu = cob菜名.SelectedItem.ToString();
                    string strSQL = "delete from stores where 店家=@Store and 菜名 = @Menu ;";
                    SqlConnection con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@Store", Store);
                    cmd.Parameters.AddWithValue("@Menu", Menu);
                    int rows = cmd.ExecuteNonQuery();

                    con.Close();

                    //cob店家.SelectedItem.ToString = "";
                    //cob菜名.SelectedItem.ToString = "";

                    MessageBox.Show("刪除" + rows.ToString() + "筆資料");
                    訂便當系統.UpData1();
                    UpData();
                }
                else {
                   

                }
               

            }
            else
            {
                MessageBox.Show("您未選擇品項");
            }
        }

        private void btn取消_Click(object sender, EventArgs e)
        {            
            Close();
          
            訂便當系統.UpData1();

        }

        private void cob菜名_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cob店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            cob菜名.Items.Clear();
           
            if (cob店家.SelectedItem != null)
            {
                string strSQL4 = "select 菜名 from stores where 店家 = @strFieldName";

                SqlConnection con4 = new SqlConnection(myDBConnectionString);
                con4.Open();
                SqlCommand cmd4 = new SqlCommand(strSQL4, con4);
                cmd4.Parameters.AddWithValue("@strFieldName", cob店家.SelectedItem);
                SqlDataReader reader4 = cmd4.ExecuteReader();
                int M = 0;
                while (reader4.Read())
                {
                    cob菜名.Items.Add(reader4["菜名"].ToString());
                     M += 1;
                }

                cob菜名.SelectedIndex = 0;
                reader4.Close();
                con4.Close();
            }
            else
            {
                MessageBox.Show("請選擇刪除品項");
            }
        }
    }
}
