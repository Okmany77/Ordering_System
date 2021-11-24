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
    
    public partial class Form1_Manager : Form
    {
        SqlConnectionStringBuilder scsb;
        string myDBConnectionString = "";
        int 數量,單價,總價;
        string editno = "";
        UserInfo loginUser; //成員變量


        public Form1_Manager()
        {
            InitializeComponent();

           // lbldata.Text = DateTime.Now.ToShortDateString();
        }

        public Form1_Manager(UserInfo userInfo)
        {
            InitializeComponent();
            this.loginUser = userInfo;
           
            lbldata.Text = DateTime.Now.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = $"歡迎~{loginUser.姓名}登入～{this.Text}";
            scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "mydb";
            scsb.IntegratedSecurity = true;
            myDBConnectionString = scsb.ToString();

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "select 班級 from accounts group by 班級";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();
            //string strMsg = "";
            int i = 0;
            while (reader.Read())
            {

                cob班級.Items.Add(reader["班級"].ToString());
                i += 1;
            }
            cob班級.SelectedIndex = 0;
            reader.Close();
            con.Close();

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

            cob數量.SelectedIndex = 0;
            Cob搜尋選項.SelectedIndex = 0;

        }
        public void UpData1()
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

        private void cob班級_SelectedIndexChanged(object sender, EventArgs e)
        {
            cob姓名.Items.Clear();
            string strFieldClass = cob班級.SelectedItem.ToString();
            SqlConnection con2 = new SqlConnection(myDBConnectionString);
            con2.Open();
            string strSQL2 = "select 姓名 from accounts where 班級 = @strFieldClass";
            SqlCommand cmd2 = new SqlCommand(strSQL2, con2);
            cmd2.Parameters.AddWithValue("@strFieldClass", strFieldClass);
            SqlDataReader reader2 = cmd2.ExecuteReader();
           
            int k = 0;
            while (reader2.Read())
            {

                cob姓名.Items.Add(reader2["姓名"].ToString());
                k += 1;
            }
            cob姓名.SelectedIndex = 0;
            reader2.Close();
            con2.Close();           
        }

        private void cob值日生_SelectedIndexChanged(object sender, EventArgs e)
        {           
            UpData();           
        }

        private void cob店家_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbox菜單.Items.Clear();
            string strFieldName = cob店家.SelectedItem.ToString();
            if (cob店家.SelectedItem != "")
            {
                string strSQL4 = "select 菜名 from stores where 店家 = @strFieldName";

                SqlConnection con4 = new SqlConnection(myDBConnectionString);
                con4.Open();
                SqlCommand cmd4 = new SqlCommand(strSQL4, con4);
                cmd4.Parameters.AddWithValue("@strFieldName", strFieldName);
                SqlDataReader reader4 = cmd4.ExecuteReader();
                int M = 0;
                while (reader4.Read())
                {
                    lbox菜單.Items.Add(reader4["菜名"]);
                    M += 1;
                }

                //lbox菜單.SelectedIndex = 0;
                reader4.Close();
                con4.Close();
            }
            else
            {
                MessageBox.Show("請選擇喜愛的店家");
            }
        }

        private void lbox菜單_SelectedIndexChanged(object sender, EventArgs e)
        {   //顯示便當單價
            lbl單價.Text="";
            string strFieldPrice = lbox菜單.SelectedItem.ToString();
            if (lbox菜單.SelectedIndex >= 0)
            {
                string strSQL5 = "select 價格 from stores where 菜名 = @strFieldPrice";

                SqlConnection con5 = new SqlConnection(myDBConnectionString);
                con5.Open();
                SqlCommand cmd5 = new SqlCommand(strSQL5, con5);
                cmd5.Parameters.AddWithValue("@strFieldPrice", strFieldPrice);
                SqlDataReader reader5 = cmd5.ExecuteReader();
                int N = 0;
                while (reader5.Read())
                {
                    單價 = (int)reader5["價格"];
                    lbl單價.Text = string.Format("{0}",reader5["價格"].ToString() +"元");
                    lbl總價.Text = string.Format("{0}", ((int)reader5["價格"] * 數量).ToString() + "元");
                    N += 1;
                    
                }
                
                reader5.Close();
                con5.Close();
            }
            else
            {
                MessageBox.Show("請選擇喜愛的便當");
            }

            

            //lbox店家資訊(出現便當圖片):
            lbox店家資訊.Items.Clear();
            string strFieldPhAd = lbox菜單.SelectedItem.ToString();
            if (lbox菜單.SelectedIndex >= 0)
            {
                string strSQL6 = "select 電話,地址 from stores where 菜名 = @strFieldPhAd";

                SqlConnection con6 = new SqlConnection(myDBConnectionString);
                con6.Open();
                SqlCommand cmd6 = new SqlCommand(strSQL6, con6);
                cmd6.Parameters.AddWithValue("@strFieldPhAd", strFieldPhAd);
                SqlDataReader reader6 = cmd6.ExecuteReader();
                int O = 0;
                while (reader6.Read())
                {
                    lbox店家資訊.Items.Add("電話:\n"+reader6["電話"]);
                    lbox店家資訊.Items.Add("地址:\n" + reader6["地址"]);
                    O += 1;
                }

                reader6.Close();
                con6.Close();
            }
            else
            {
                MessageBox.Show("請選擇喜愛的便當");
            }

            ////設定圖片變更
            picBox.Image.Dispose();
            string strPicbox = lbox菜單.SelectedItem.ToString();
            if (lbox菜單.SelectedIndex >= 0)
            {
                string strSQL7 = "select 圖片 from stores where 菜名 = @strPicbox";

                SqlConnection con7 = new SqlConnection(myDBConnectionString);
                con7.Open();
                SqlCommand cmd7 = new SqlCommand(strSQL7, con7);
                cmd7.Parameters.AddWithValue("@strPicbox", strPicbox);
                SqlDataReader reader7 = cmd7.ExecuteReader();
                string image_dir = @"images\";
                string image_name = "";

                if (reader7.Read())
                {
                    image_name = (string)reader7["圖片"];
                    picBox.Image = Image.FromFile(image_dir + image_name);
                }

                reader7.Close();
                con7.Close();
            }
            else
            {
                MessageBox.Show("請選擇喜愛的便當");
            }


        }

        private void lbl單價_Click(object sender, EventArgs e)
        {

        }

        private void lbl總價_Click(object sender, EventArgs e)
        {

        }

        private void btn加入訂單_Click(object sender, EventArgs e)
        {
            string orderTime = DateTime.Now.ToShortDateString();
            if (lbox菜單.SelectedItem != null)
            {                
                        SqlConnection con = new SqlConnection(myDBConnectionString);
                        con.Open();
                        string strSQL = "insert into orders values(@ClassName, @StudentName, @ShopName, @MenuName, @Num, @Price, @SumPrice,@date)";
                        SqlCommand cmd = new SqlCommand(strSQL, con);

                        cmd.Parameters.AddWithValue("@ClassName", cob班級.SelectedItem);
                        cmd.Parameters.AddWithValue("@StudentName", cob姓名.SelectedItem);
                        cmd.Parameters.AddWithValue("@ShopName", cob店家.SelectedItem);
                        cmd.Parameters.AddWithValue("@MenuName", lbox菜單.SelectedItem);
                        cmd.Parameters.AddWithValue("@Num", 數量);
                        cmd.Parameters.AddWithValue("@Price", 單價);
                        cmd.Parameters.AddWithValue("@SumPrice", 數量 * 單價);
                        cmd.Parameters.AddWithValue("@date", orderTime);
                        int rows = cmd.ExecuteNonQuery();

                        con.Close();
                        MessageBox.Show("加入品項成功");
                        UpData();            
                   
                 }
            else {
                MessageBox.Show("請選擇訂購品項");
            }
       
        }

        public void UpData()
        {
            if (cob姓名.SelectedItem != null)
            {                
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = "select * from orders where 姓名 = @StudentName;";
                dvgshow.AllowUserToAddRows = false;
                dvgshow.AutoGenerateColumns = true;
                dvgshow.RowHeadersVisible = true;
                SqlDataAdapter adp = new SqlDataAdapter(strSQL, con);
                adp.SelectCommand.Parameters.AddWithValue("@StudentName", cob姓名.SelectedItem);                
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();
                this.dvgshow.DataSource = dt;                               

                if (dvgshow.Rows.Count >0 )
                {   //更新價格
                    con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    strSQL = "select sum (總價) as total from orders where 姓名 = @StudentName;";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@StudentName", cob姓名.SelectedItem);
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                   
                    lbl總計.Text = "共" + ((int)reader["total"]).ToString() + "元";
                    reader.Close();
                    con.Close();
                }
                else
                {
                    lbl總計.Text = "0 元";
                }
                

            }
        }

        private void lbox店家資訊_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cob數量_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cob數量.SelectedItem != null)
            {
                bool ifNum = Int32.TryParse(cob數量.SelectedItem.ToString(), out 數量);

                if ((ifNum == true) && (數量 >= 1))
                {
                    //成功
                }
                else
                {
                    MessageBox.Show("輸入數量錯誤");
                    數量 = 1;
                    cob數量.Text = 數量.ToString();
                }
            }
            else
            {
                //沒有輸入
                數量 = 1;
            }

            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txt輸入搜尋_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn訂單更新_Click(object sender, EventArgs e)
        {
            if ((cob更新數量.SelectedItem != null) && (cob更新品項.SelectedItem != null))
            {
                int changeNum = Convert.ToInt32(cob更新數量.SelectedItem);
               // MessageBox.Show(changeNum.ToString());
                if (changeNum > 0)
                {
                    edit();
                    MessageBox.Show("資料已更新!", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //numUpDown_revisedNum.Value = 1;
                }
                else
                {
                    MessageBox.Show("數量有誤!", "提示視窗", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("請輸入欲更改品項與數量!");
            }
        }

        public void edit()
        {

            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update orders set 菜名=@Menu,數量=@Num, 總價=@SumPrice where id=@Id ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);



            cmd.Parameters.AddWithValue("@Menu", cob更新品項.SelectedItem);
            cmd.Parameters.AddWithValue("@Num", Convert.ToInt32(cob更新數量.SelectedItem));
            cmd.Parameters.AddWithValue("@Price", this.dvgshow.SelectedRows[0].Cells[6].Value);
            cmd.Parameters.AddWithValue("@Id", this.dvgshow.SelectedRows[0].Cells[0].Value);
           
            int newsumprice = Convert.ToInt32(cob更新數量.SelectedItem) * (int)(this.dvgshow.SelectedRows[0].Cells[6].Value);
            cmd.Parameters.AddWithValue("@SumPrice", newsumprice);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("已修改品項數量");         

            con.Close();
            UpData();
        }
        private void btn刪除所選_Click(object sender, EventArgs e)
        {
            if (dvgshow.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("確定要刪除品項?", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {
                    UpData();
                    return;
                }

                string orderID = this.dvgshow.SelectedRows[0].Cells[0].Value.ToString();
                string strSQL = "delete from orders where id = @orderid;";
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                da.SelectCommand.Parameters.AddWithValue("@orderid", orderID);
                int row = da.SelectCommand.ExecuteNonQuery();
                con.Close();

                if (row == 1)
                {
                    MessageBox.Show("已成功刪除訂單!");
                }
                else
                {
                    MessageBox.Show("刪除訂單失敗!");
                }
                UpData();
               // dvgshow.Rows[0].Selected = true;

            }
            else
            {
                MessageBox.Show("您尚未選購商品");
            }
        }

        private void btn清空品項_Click(object sender, EventArgs e)
        {
            if (dvgshow.Rows.Count > 0)
            {
                DialogResult res = MessageBox.Show("確定要全部刪除品項?", "提示框", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Cancel)
                {
                    UpData();
                    return;
                }

               
                string strSQL = "delete from orders where 姓名 = @Name;";
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
                da.SelectCommand.Parameters.AddWithValue("@Name", cob姓名.SelectedItem);
                int row = da.SelectCommand.ExecuteNonQuery();
                con.Close();

                if (row >= 1)
                {
                    MessageBox.Show("已成功刪除訂單!");
                }
                else
                {
                    MessageBox.Show("刪除訂單失敗!");
                }
                UpData();


            }
            else
            {
                MessageBox.Show("您尚未選購商品");
            }
        }

        private void btn離開_Click(object sender, EventArgs e)
        {
           
            loginForm SF = new loginForm();
            SF.Show();
            this.Hide();//隱藏當前窗體
        }

        private void dvgshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cob搜尋選項_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cob更新品項_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cob更新數量_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl總計_Click(object sender, EventArgs e)
        {

        }

        private void lbldata_Click(object sender, EventArgs e)
        {

        }

        private void dvgshow_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {   //更新數量
            SqlConnection con = new SqlConnection(myDBConnectionString);
            con.Open();
            string strSQL = "update orders set 數量=@Num, 單價=@Price, 總價=@SumPrice where 姓名=@StudentName and 菜名=@MenuName ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);



            cmd.Parameters.AddWithValue("@StudentName", cob姓名.Text);
            cmd.Parameters.AddWithValue("@MenuName", this.dvgshow.SelectedRows[0].Cells[4].Value.ToString());
            cmd.Parameters.AddWithValue("@Num", this.dvgshow.SelectedRows[0].Cells[5].Value.ToString());
            cmd.Parameters.AddWithValue("@Price", this.dvgshow.SelectedRows[0].Cells[6].Value);

            int newsumprice = (int)(this.dvgshow.SelectedRows[0].Cells[5].Value) * (int)(this.dvgshow.SelectedRows[0].Cells[6].Value);
            cmd.Parameters.AddWithValue("@SumPrice", newsumprice);
            int rows = cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("已修改品項數量");
            UpData();


          
        }

        private void btn新增廠商_Click(object sender, EventArgs e)
        {
            Form4_AddMenu 新增廠商form = new Form4_AddMenu(this);
            新增廠商form.Show();
           // 新增廠商form.ShowDialog();

        }



        private void btn刪除菜色_Click(object sender, EventArgs e)
        {
            刪除菜單Form 刪除菜單表 = new 刪除菜單Form(this);
            刪除菜單表.Show();
        }

        private void dvgshow_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >-1)
                {
                    cob更新品項.Text = dvgshow.Rows[e.RowIndex].Cells[4].Value.ToString();
                    cob更新數量.Text = dvgshow.Rows[e.RowIndex].Cells[5].Value.ToString();
                    editno = dvgshow.Rows[e.RowIndex].Cells[0].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("請選擇一筆資料！", "錯誤訊息");
            }
        }

        private void dvgshow_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            cob更新品項.Items.Clear();
            cob更新品項.Text = dvgshow.Rows[e.RowIndex].Cells[4].Value.ToString();
            cob更新數量.Text = dvgshow.Rows[e.RowIndex].Cells[5].Value.ToString();

            if (dvgshow.Rows.Count > 0)
            {                         
                string res = dvgshow.Rows[e.RowIndex].Cells["店家"].Value.ToString();               

                SqlConnection con3 = new SqlConnection(myDBConnectionString);
                con3.Open();
                //   MessageBox.Show(res);
                string strSQL3 = "select 菜名 from stores where 店家 = '" + res + "'";
                SqlCommand cmd3 = new SqlCommand(strSQL3, con3);
                SqlDataReader reader3 = cmd3.ExecuteReader();

                while (reader3.Read())
                {
                    cob更新品項.Items.Add(reader3["菜名"].ToString());
                }
                   
                    reader3.Close();
                con3.Close();

            }
            else 
            {
               MessageBox.Show("沒有資料！請再試一次", "錯誤訊息");
            }


        }

        private void btn送出訂單_Click(object sender, EventArgs e)
        {
            if (dvgshow.Rows.Count > 0)
            {
                string str檔案路徑 = @"C:\Users\user\Documents\資策會上課\期中專題";
                System.Random myRnd = new Random();
                int myNum = myRnd.Next(1000, 9999);
                string str檔名 = DateTime.Now.ToString("yyMMddHHmmss") + myNum + @"訂購檔.txt";
                string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;

                System.Windows.Forms.SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = str檔案路徑;
                sfd.FileName = str檔名;
                sfd.Filter = "Text File|*.txt";

                System.Windows.Forms.DialogResult R = sfd.ShowDialog();
                if (R == DialogResult.OK)
                { //確定
                    str完整檔案路徑 = sfd.FileName;

                }
                else
                {
                    return;
                }

                //列印訂購單

                List<string> listorderfile = new List<string>();
                listorderfile.Add("*****************   便當Menu系統訂購單明細   ****************\n");
                listorderfile.Add("");
                listorderfile.Add("                        訂購時間:" + DateTime.Now);
                listorderfile.Add("訂購品項:");
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = $"select 班級, 姓名, 店家, 菜名, 數量, 單價, 總價, 日期 from orders where ( { Cob搜尋選項.SelectedItem.ToString() } like '%{ txt輸入搜尋.Text}%') and (日期 like '%{txt日期關鍵字.Text}%' ) ";

                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ClassName", cob班級.SelectedItem);
                cmd.Parameters.AddWithValue("@StudentName", cob姓名.SelectedItem);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {

                    if (cob姓名.SelectedItem != null)
                    {                                              
                        listorderfile.Add("");
                                               
                        listorderfile.Add((string)reader["班級"] + " " + (string)reader["姓名"] + " " + (string)reader["店家"] + " " + (string)reader["菜名"] + " " + ((int)reader["數量"]).ToString() + "個   單價:"+ ((int)reader["單價"]) + "  共" + ((int)reader["總價"]).ToString() + "元");

                    }
                }

                reader.Close();
                con.Close();

                con.Open();

                strSQL = $"select sum (總價) as total from orders where ( { Cob搜尋選項.SelectedItem.ToString() } like '%{ txt輸入搜尋.Text}%') and (日期 like '%{txt日期關鍵字.Text}%' ); ";
                cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@ClassName",cob姓名.SelectedItem);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    listorderfile.Add("");
                    listorderfile.Add("");
                    listorderfile.Add("-------------------------------------------");
                    listorderfile.Add("總計金額共" + ((int)reader["total"]).ToString() + "元");

                    listorderfile.Add("-------------------------------------------");
                    listorderfile.Add("");
                    listorderfile.Add("");
                    listorderfile.Add("************ 謝謝光臨 歡迎下次再訂購 *************\n");
                }

                reader.Close();
                con.Close();



                System.IO.File.WriteAllLines(str完整檔案路徑, listorderfile, Encoding.UTF8);
                MessageBox.Show("存檔成功");
            }
        }

        private void btn搜尋_Click(object sender, EventArgs e)
        {               
            if (txt輸入搜尋.Text != "" && Cob搜尋選項.SelectedItem != null)
            {
                SqlConnection con = new SqlConnection(myDBConnectionString);
                con.Open();
                string strSQL = $"select * from orders where ( {Cob搜尋選項.SelectedItem.ToString()} like '%{ txt輸入搜尋.Text}%' ) and (日期 like '%{txt日期關鍵字.Text}%' );";
               // MessageBox.Show(dtp開始時間.Value.ToString());

                SqlDataAdapter adp = new SqlDataAdapter(strSQL, con);              
                DataTable dt = new DataTable();
                adp.Fill(dt);
                con.Close();
                this.dvgshow.DataSource = dt;


                if (dvgshow.Rows.Count > 0)
                {   //更新價格
                    con = new SqlConnection(myDBConnectionString);
                    con.Open();
                    strSQL = $"select sum (總價) as total from orders where ({ Cob搜尋選項.SelectedItem.ToString() } like '%{ txt輸入搜尋.Text}%') and (日期 like '%{txt日期關鍵字.Text}%' ); ";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                  
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                   
                    lbl總計.Text = "共" + ((int)reader["total"]).ToString() + "元";
                    reader.Close();
                    con.Close();
                }
                else
                {
                    lbl總計.Text = "0 元";
                }
            }
            else
            {
                MessageBox.Show("請輸入搜尋字串");
            }
        }

        private void Form1_Manager_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit(); //關閉應用程式
        }

      

        private void classBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           

        }
    }
}
