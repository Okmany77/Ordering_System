using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections; //ArrayList 命名空間

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

            lbl班級.Text = GlobalVar.班級;
            lbl值日生.Text = GlobalVar.學生;

            if (GlobalVar.List訂購品項列表.Count > 0)
            {
                foreach (ArrayList 訂單item in GlobalVar.List訂購品項列表)
                {
                    string 店家 = (string)訂單item[0];
                    string 菜名 = (string)訂單item[1];
                    int 數量 = (int)訂單item[2];
                    int 單價 = (int)訂單item[3];
                    string 電話 = (string)訂單item[4];

                    string str品項資訊 = string.Format("{0} \n  {1}  {2}個    單價{3}    電話{4}", 店家,菜名,數量,單價,電話);
                    lbox訂購品項.Items.Add(str品項資訊);
                    
                }
            }
            lbl訂單總價.Text = "訂單總共" + 計算訂單總價().ToString() + "元";



        }

        int 計算訂單總價()
        {
            int 總價 = 0;
            foreach (ArrayList 訂購item in GlobalVar.List訂購品項列表)
            {
                總價 += (int)訂購item[2] * (int)訂購item[3];
            }
            return 總價;
        }

        private void lbox訂購品項_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl訂單總價_Click(object sender, EventArgs e)
        {

        }

        private void btn移除所選品項_Click(object sender, EventArgs e)
        {
            if (lbox訂購品項.SelectedIndex > -1)
            {
                int selIndex = lbox訂購品項.SelectedIndex;
                GlobalVar.List訂購品項列表.RemoveAt(selIndex);
                lbox訂購品項.Items.RemoveAt(selIndex);
                lbl訂單總價.Text = "訂單總共" + 計算訂單總價().ToString() + "元";
            }
            else
            {
                MessageBox.Show("請選擇品項");
            }
        }

        private void btn清除所有品項_Click(object sender, EventArgs e)
        {
            GlobalVar.List訂購品項列表.Clear();
            lbox訂購品項.Items.Clear();
            lbl訂單總價.Text = "訂單總共" + 計算訂單總價().ToString() + "元";
        }

        private void btn關閉表單_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn送出訂購_Click(object sender, EventArgs e)
        {
            string str檔案路徑 = @"C:\Users\user\Documents\資策會上課\.net 元件開發\作業";
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

            ////列印訂購單
            List<string> list訂單資訊 = new List<string>();
            list訂單資訊.Add("*****************便當訂購單 *****************\n");
            list訂單資訊.Add("訂單日期:" + DateTime.Now.ToString());
            list訂單資訊.Add("                                              ");
            list訂單資訊.Add(GlobalVar.班級 +"             "+ GlobalVar.學生);
            list訂單資訊.Add("-------------------------------------------\n");
           

            ////顯示訂購便當品項
            if (GlobalVar.List訂購品項列表.Count > 0)
            {
                foreach (ArrayList 訂單item in GlobalVar.List訂購品項列表)
                {
                    string 店家 = (string)訂單item[0];
                    string 菜名 = (string)訂單item[1];
                    int 數量 = (int)訂單item[2];
                    int 單價 = (int)訂單item[3];
                    string 電話 = (string)訂單item[4];

                    string str品項資訊 = string.Format("{0} \n  {1}  {2}個    單價{3}    電話{4}", 店家, 菜名, 數量, 單價, 電話);
                    list訂單資訊.Add(str品項資訊);

                }
            }
            else
            { 
            
            }

            list訂單資訊.Add("-------------------------------------------\n");
            list訂單資訊.Add("訂單總計金額:" + 計算訂單總價().ToString() + "元\n");
            list訂單資訊.Add("-------------------------------------------\n");
            list訂單資訊.Add("***************   謝謝光臨   ***************");

            System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
        }
    }
}
