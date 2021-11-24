
namespace WindowsFormsApp1
{
    partial class Form1_Manager
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn刪除菜色 = new System.Windows.Forms.Button();
            this.btn新增廠商 = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.lbox店家資訊 = new System.Windows.Forms.ListBox();
            this.lbldata = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn加入訂單 = new System.Windows.Forms.Button();
            this.lbl總價 = new System.Windows.Forms.Label();
            this.lbl單價 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbox菜單 = new System.Windows.Forms.ListBox();
            this.cob店家 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cob數量 = new System.Windows.Forms.ComboBox();
            this.cob姓名 = new System.Windows.Forms.ComboBox();
            this.cob班級 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn送出訂單 = new System.Windows.Forms.Button();
            this.dvgshow = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn離開 = new System.Windows.Forms.Button();
            this.btn清空品項 = new System.Windows.Forms.Button();
            this.btn刪除所選 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt輸入搜尋 = new System.Windows.Forms.TextBox();
            this.Cob搜尋選項 = new System.Windows.Forms.ComboBox();
            this.btn搜尋 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.cob更新品項 = new System.Windows.Forms.ComboBox();
            this.btn訂單更新 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cob更新數量 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lbl總計 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt日期關鍵字 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.HotPink;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(306, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂便當menu系統";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.OldLace;
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.lbldata);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.btn加入訂單);
            this.groupBox1.Controls.Add(this.lbl總價);
            this.groupBox1.Controls.Add(this.lbl單價);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lbox菜單);
            this.groupBox1.Controls.Add(this.cob店家);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cob數量);
            this.groupBox1.Controls.Add(this.cob姓名);
            this.groupBox1.Controls.Add(this.cob班級);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(48, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(767, 332);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "管理員介面";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.btn刪除菜色);
            this.groupBox4.Controls.Add(this.btn新增廠商);
            this.groupBox4.Controls.Add(this.picBox);
            this.groupBox4.Controls.Add(this.lbox店家資訊);
            this.groupBox4.Location = new System.Drawing.Point(396, 62);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(350, 216);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            // 
            // btn刪除菜色
            // 
            this.btn刪除菜色.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btn刪除菜色.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn刪除菜色.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除菜色.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn刪除菜色.Location = new System.Drawing.Point(237, 93);
            this.btn刪除菜色.Name = "btn刪除菜色";
            this.btn刪除菜色.Size = new System.Drawing.Size(102, 54);
            this.btn刪除菜色.TabIndex = 16;
            this.btn刪除菜色.Text = "刪除廠商 菜單";
            this.btn刪除菜色.UseVisualStyleBackColor = false;
            this.btn刪除菜色.Click += new System.EventHandler(this.btn刪除菜色_Click);
            // 
            // btn新增廠商
            // 
            this.btn新增廠商.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn新增廠商.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn新增廠商.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn新增廠商.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn新增廠商.Location = new System.Drawing.Point(237, 18);
            this.btn新增廠商.Name = "btn新增廠商";
            this.btn新增廠商.Size = new System.Drawing.Size(102, 58);
            this.btn新增廠商.TabIndex = 15;
            this.btn新增廠商.Text = "新增廠商菜單";
            this.btn新增廠商.UseVisualStyleBackColor = false;
            this.btn新增廠商.Click += new System.EventHandler(this.btn新增廠商_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.PowderBlue;
            this.picBox.Image = global::WindowsFormsApp1.Properties.Resources._1;
            this.picBox.Location = new System.Drawing.Point(13, 10);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(196, 149);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 14;
            this.picBox.TabStop = false;
            // 
            // lbox店家資訊
            // 
            this.lbox店家資訊.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox店家資訊.FormattingEnabled = true;
            this.lbox店家資訊.ItemHeight = 20;
            this.lbox店家資訊.Location = new System.Drawing.Point(9, 165);
            this.lbox店家資訊.Name = "lbox店家資訊";
            this.lbox店家資訊.Size = new System.Drawing.Size(303, 44);
            this.lbox店家資訊.TabIndex = 13;
            this.lbox店家資訊.SelectedIndexChanged += new System.EventHandler(this.lbox店家資訊_SelectedIndexChanged);
            // 
            // lbldata
            // 
            this.lbldata.AutoSize = true;
            this.lbldata.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbldata.Location = new System.Drawing.Point(542, 25);
            this.lbldata.Name = "lbldata";
            this.lbldata.Size = new System.Drawing.Size(89, 22);
            this.lbldata.TabIndex = 18;
            this.lbldata.Text = "年    月   日";
            this.lbldata.Click += new System.EventHandler(this.lbldata_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(492, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 22);
            this.label11.TabIndex = 17;
            this.label11.Text = "時間:";
            // 
            // btn加入訂單
            // 
            this.btn加入訂單.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn加入訂單.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn加入訂單.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn加入訂單.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn加入訂單.Location = new System.Drawing.Point(405, 286);
            this.btn加入訂單.Name = "btn加入訂單";
            this.btn加入訂單.Size = new System.Drawing.Size(200, 33);
            this.btn加入訂單.TabIndex = 2;
            this.btn加入訂單.Text = "加入訂單";
            this.btn加入訂單.UseVisualStyleBackColor = false;
            this.btn加入訂單.Click += new System.EventHandler(this.btn加入訂單_Click);
            // 
            // lbl總價
            // 
            this.lbl總價.AutoSize = true;
            this.lbl總價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總價.Location = new System.Drawing.Point(343, 292);
            this.lbl總價.Name = "lbl總價";
            this.lbl總價.Size = new System.Drawing.Size(40, 24);
            this.lbl總價.TabIndex = 12;
            this.lbl總價.Text = "0元";
            this.lbl總價.Click += new System.EventHandler(this.lbl總價_Click);
            // 
            // lbl單價
            // 
            this.lbl單價.AutoSize = true;
            this.lbl單價.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl單價.Location = new System.Drawing.Point(231, 292);
            this.lbl單價.Name = "lbl單價";
            this.lbl單價.Size = new System.Drawing.Size(40, 24);
            this.lbl單價.TabIndex = 11;
            this.lbl單價.Text = "0元";
            this.lbl單價.Click += new System.EventHandler(this.lbl單價_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.ForeColor = System.Drawing.Color.Crimson;
            this.label7.Location = new System.Drawing.Point(293, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "總價";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.LavenderBlush;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(179, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "單價";
            // 
            // lbox菜單
            // 
            this.lbox菜單.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox菜單.FormattingEnabled = true;
            this.lbox菜單.ItemHeight = 22;
            this.lbox菜單.Location = new System.Drawing.Point(182, 70);
            this.lbox菜單.Name = "lbox菜單";
            this.lbox菜單.Size = new System.Drawing.Size(200, 202);
            this.lbox菜單.TabIndex = 8;
            this.lbox菜單.SelectedIndexChanged += new System.EventHandler(this.lbox菜單_SelectedIndexChanged);
            // 
            // cob店家
            // 
            this.cob店家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob店家.FormattingEnabled = true;
            this.cob店家.Location = new System.Drawing.Point(297, 23);
            this.cob店家.Name = "cob店家";
            this.cob店家.Size = new System.Drawing.Size(161, 28);
            this.cob店家.TabIndex = 7;
            this.cob店家.SelectedIndexChanged += new System.EventHandler(this.cob店家_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(204, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "店家廠商";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cob數量
            // 
            this.cob數量.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob數量.FormattingEnabled = true;
            this.cob數量.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cob數量.Location = new System.Drawing.Point(41, 256);
            this.cob數量.Name = "cob數量";
            this.cob數量.Size = new System.Drawing.Size(80, 28);
            this.cob數量.TabIndex = 5;
            this.cob數量.SelectedIndexChanged += new System.EventHandler(this.cob數量_SelectedIndexChanged);
            // 
            // cob姓名
            // 
            this.cob姓名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob姓名.FormattingEnabled = true;
            this.cob姓名.Location = new System.Drawing.Point(29, 167);
            this.cob姓名.Name = "cob姓名";
            this.cob姓名.Size = new System.Drawing.Size(121, 28);
            this.cob姓名.TabIndex = 4;
            this.cob姓名.SelectedIndexChanged += new System.EventHandler(this.cob值日生_SelectedIndexChanged);
            // 
            // cob班級
            // 
            this.cob班級.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob班級.FormattingEnabled = true;
            this.cob班級.Location = new System.Drawing.Point(29, 78);
            this.cob班級.Name = "cob班級";
            this.cob班級.Size = new System.Drawing.Size(121, 28);
            this.cob班級.TabIndex = 3;
            this.cob班級.SelectedIndexChanged += new System.EventHandler(this.cob班級_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(57, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "數量";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(62, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(63, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "班級";
            // 
            // btn送出訂單
            // 
            this.btn送出訂單.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出訂單.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn送出訂單.Location = new System.Drawing.Point(12, 78);
            this.btn送出訂單.Name = "btn送出訂單";
            this.btn送出訂單.Size = new System.Drawing.Size(135, 33);
            this.btn送出訂單.TabIndex = 3;
            this.btn送出訂單.Text = "送出訂購單(存檔)";
            this.btn送出訂單.UseVisualStyleBackColor = true;
            this.btn送出訂單.Click += new System.EventHandler(this.btn送出訂單_Click);
            // 
            // dvgshow
            // 
            this.dvgshow.AllowUserToAddRows = false;
            this.dvgshow.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgshow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgshow.Location = new System.Drawing.Point(48, 490);
            this.dvgshow.Name = "dvgshow";
            this.dvgshow.RowHeadersWidth = 30;
            this.dvgshow.RowTemplate.Height = 24;
            this.dvgshow.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgshow.Size = new System.Drawing.Size(589, 197);
            this.dvgshow.TabIndex = 4;
            this.dvgshow.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dvgshow_CellMouseClick);
            this.dvgshow.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgshow_CellValueChanged);
            this.dvgshow.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgshow_RowEnter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.btn離開);
            this.groupBox2.Controls.Add(this.btn清空品項);
            this.groupBox2.Controls.Add(this.btn刪除所選);
            this.groupBox2.Controls.Add(this.btn送出訂單);
            this.groupBox2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(653, 490);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(159, 156);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // btn離開
            // 
            this.btn離開.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn離開.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn離開.Location = new System.Drawing.Point(12, 114);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(135, 33);
            this.btn離開.TabIndex = 6;
            this.btn離開.Text = "離開選單";
            this.btn離開.UseVisualStyleBackColor = true;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // btn清空品項
            // 
            this.btn清空品項.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清空品項.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn清空品項.Location = new System.Drawing.Point(11, 42);
            this.btn清空品項.Name = "btn清空品項";
            this.btn清空品項.Size = new System.Drawing.Size(135, 33);
            this.btn清空品項.TabIndex = 5;
            this.btn清空品項.Text = "清空所有品項";
            this.btn清空品項.UseVisualStyleBackColor = true;
            this.btn清空品項.Click += new System.EventHandler(this.btn清空品項_Click);
            // 
            // btn刪除所選
            // 
            this.btn刪除所選.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除所選.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn刪除所選.Location = new System.Drawing.Point(12, 6);
            this.btn刪除所選.Name = "btn刪除所選";
            this.btn刪除所選.Size = new System.Drawing.Size(135, 33);
            this.btn刪除所選.TabIndex = 4;
            this.btn刪除所選.Text = "刪除所選品項";
            this.btn刪除所選.UseVisualStyleBackColor = true;
            this.btn刪除所選.Click += new System.EventHandler(this.btn刪除所選_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 19);
            this.label8.TabIndex = 1;
            this.label8.Text = "搜尋關鍵字";
            // 
            // txt輸入搜尋
            // 
            this.txt輸入搜尋.Location = new System.Drawing.Point(107, 17);
            this.txt輸入搜尋.Name = "txt輸入搜尋";
            this.txt輸入搜尋.Size = new System.Drawing.Size(100, 27);
            this.txt輸入搜尋.TabIndex = 2;
            this.txt輸入搜尋.TextChanged += new System.EventHandler(this.txt輸入搜尋_TextChanged);
            // 
            // Cob搜尋選項
            // 
            this.Cob搜尋選項.FormattingEnabled = true;
            this.Cob搜尋選項.Items.AddRange(new object[] {
            "班級",
            "姓名",
            "店家",
            "菜名"});
            this.Cob搜尋選項.Location = new System.Drawing.Point(214, 18);
            this.Cob搜尋選項.Name = "Cob搜尋選項";
            this.Cob搜尋選項.Size = new System.Drawing.Size(105, 27);
            this.Cob搜尋選項.TabIndex = 3;
            this.Cob搜尋選項.SelectedIndexChanged += new System.EventHandler(this.Cob搜尋選項_SelectedIndexChanged);
            // 
            // btn搜尋
            // 
            this.btn搜尋.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn搜尋.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn搜尋.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn搜尋.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn搜尋.Location = new System.Drawing.Point(321, 17);
            this.btn搜尋.Name = "btn搜尋";
            this.btn搜尋.Size = new System.Drawing.Size(54, 29);
            this.btn搜尋.TabIndex = 4;
            this.btn搜尋.Text = "搜尋";
            this.btn搜尋.UseVisualStyleBackColor = false;
            this.btn搜尋.Click += new System.EventHandler(this.btn搜尋_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Indigo;
            this.label9.Location = new System.Drawing.Point(425, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 5;
            this.label9.Text = "更新品項";
            // 
            // cob更新品項
            // 
            this.cob更新品項.FormattingEnabled = true;
            this.cob更新品項.Location = new System.Drawing.Point(504, 19);
            this.cob更新品項.Name = "cob更新品項";
            this.cob更新品項.Size = new System.Drawing.Size(141, 27);
            this.cob更新品項.TabIndex = 6;
            this.cob更新品項.SelectedIndexChanged += new System.EventHandler(this.cob更新品項_SelectedIndexChanged);
            // 
            // btn訂單更新
            // 
            this.btn訂單更新.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn訂單更新.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn訂單更新.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn訂單更新.ForeColor = System.Drawing.Color.DarkMagenta;
            this.btn訂單更新.Location = new System.Drawing.Point(655, 18);
            this.btn訂單更新.Name = "btn訂單更新";
            this.btn訂單更新.Size = new System.Drawing.Size(102, 29);
            this.btn訂單更新.TabIndex = 7;
            this.btn訂單更新.Text = "訂單更新";
            this.btn訂單更新.UseVisualStyleBackColor = false;
            this.btn訂單更新.Click += new System.EventHandler(this.btn訂單更新_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.groupBox3.Controls.Add(this.txt日期關鍵字);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.btn訂單更新);
            this.groupBox3.Controls.Add(this.cob更新數量);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cob更新品項);
            this.groupBox3.Controls.Add(this.txt輸入搜尋);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.Cob搜尋選項);
            this.groupBox3.Controls.Add(this.btn搜尋);
            this.groupBox3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox3.Location = new System.Drawing.Point(48, 393);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(767, 87);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "訂單搜尋";
            // 
            // cob更新數量
            // 
            this.cob更新數量.FormattingEnabled = true;
            this.cob更新數量.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cob更新數量.Location = new System.Drawing.Point(506, 51);
            this.cob更新數量.Name = "cob更新數量";
            this.cob更新數量.Size = new System.Drawing.Size(64, 27);
            this.cob更新數量.TabIndex = 8;
            this.cob更新數量.SelectedIndexChanged += new System.EventHandler(this.cob更新數量_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.Indigo;
            this.label10.Location = new System.Drawing.Point(425, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 19);
            this.label10.TabIndex = 7;
            this.label10.Text = "更新數量";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.BackColor = System.Drawing.Color.LavenderBlush;
            this.lbl.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl.ForeColor = System.Drawing.Color.Crimson;
            this.lbl.Location = new System.Drawing.Point(658, 663);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 24);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "總計";
            // 
            // lbl總計
            // 
            this.lbl總計.AutoSize = true;
            this.lbl總計.BackColor = System.Drawing.Color.Red;
            this.lbl總計.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl總計.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl總計.Location = new System.Drawing.Point(726, 663);
            this.lbl總計.Name = "lbl總計";
            this.lbl總計.Size = new System.Drawing.Size(40, 24);
            this.lbl總計.TabIndex = 12;
            this.lbl總計.Text = "0元";
            this.lbl總計.Click += new System.EventHandler(this.lbl總計_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(17, 59);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 19);
            this.label12.TabIndex = 11;
            this.label12.Text = "日期關鍵字";
            // 
            // txt日期關鍵字
            // 
            this.txt日期關鍵字.Location = new System.Drawing.Point(107, 54);
            this.txt日期關鍵字.Name = "txt日期關鍵字";
            this.txt日期關鍵字.Size = new System.Drawing.Size(100, 27);
            this.txt日期關鍵字.TabIndex = 12;
            // 
            // Form1_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(850, 699);
            this.Controls.Add(this.lbl總計);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dvgshow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "訂便當系統-管理員介面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Manager_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgshow)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cob姓名;
        private System.Windows.Forms.ComboBox cob班級;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl總價;
        private System.Windows.Forms.Label lbl單價;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lbox菜單;
        private System.Windows.Forms.ComboBox cob店家;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn加入訂單;
        private System.Windows.Forms.Button btn送出訂單;
        private System.Windows.Forms.ListBox lbox店家資訊;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.ComboBox cob數量;
        private System.Windows.Forms.DataGridView dvgshow;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt輸入搜尋;
        private System.Windows.Forms.ComboBox Cob搜尋選項;
        private System.Windows.Forms.Button btn搜尋;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cob更新品項;
        private System.Windows.Forms.Button btn訂單更新;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cob更新數量;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn離開;
        private System.Windows.Forms.Button btn清空品項;
        private System.Windows.Forms.Button btn刪除所選;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lbl總計;
        private System.Windows.Forms.Button btn刪除菜色;
        private System.Windows.Forms.Button btn新增廠商;
        private System.Windows.Forms.Label lbldata;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt日期關鍵字;
    }
}

