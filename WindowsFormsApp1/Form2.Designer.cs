
namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbox訂購品項 = new System.Windows.Forms.ListBox();
            this.btn移除所選品項 = new System.Windows.Forms.Button();
            this.btn清除所有品項 = new System.Windows.Forms.Button();
            this.lbl訂單總價 = new System.Windows.Forms.Label();
            this.btn關閉表單 = new System.Windows.Forms.Button();
            this.btn送出訂購 = new System.Windows.Forms.Button();
            this.班級 = new System.Windows.Forms.Label();
            this.lbl班級 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl值日生 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "訂購品項列表";
            // 
            // lbox訂購品項
            // 
            this.lbox訂購品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbox訂購品項.FormattingEnabled = true;
            this.lbox訂購品項.ItemHeight = 20;
            this.lbox訂購品項.Location = new System.Drawing.Point(29, 95);
            this.lbox訂購品項.Name = "lbox訂購品項";
            this.lbox訂購品項.Size = new System.Drawing.Size(483, 244);
            this.lbox訂購品項.TabIndex = 1;
            this.lbox訂購品項.SelectedIndexChanged += new System.EventHandler(this.lbox訂購品項_SelectedIndexChanged);
            // 
            // btn移除所選品項
            // 
            this.btn移除所選品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn移除所選品項.Location = new System.Drawing.Point(76, 400);
            this.btn移除所選品項.Name = "btn移除所選品項";
            this.btn移除所選品項.Size = new System.Drawing.Size(186, 33);
            this.btn移除所選品項.TabIndex = 2;
            this.btn移除所選品項.Text = "移除所選品項";
            this.btn移除所選品項.UseVisualStyleBackColor = true;
            this.btn移除所選品項.Click += new System.EventHandler(this.btn移除所選品項_Click);
            // 
            // btn清除所有品項
            // 
            this.btn清除所有品項.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn清除所有品項.Location = new System.Drawing.Point(306, 400);
            this.btn清除所有品項.Name = "btn清除所有品項";
            this.btn清除所有品項.Size = new System.Drawing.Size(186, 33);
            this.btn清除所有品項.TabIndex = 3;
            this.btn清除所有品項.Text = "清除所有品項";
            this.btn清除所有品項.UseVisualStyleBackColor = true;
            this.btn清除所有品項.Click += new System.EventHandler(this.btn清除所有品項_Click);
            // 
            // lbl訂單總價
            // 
            this.lbl訂單總價.AutoSize = true;
            this.lbl訂單總價.BackColor = System.Drawing.Color.Crimson;
            this.lbl訂單總價.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl訂單總價.ForeColor = System.Drawing.Color.White;
            this.lbl訂單總價.Location = new System.Drawing.Point(343, 358);
            this.lbl訂單總價.Name = "lbl訂單總價";
            this.lbl訂單總價.Size = new System.Drawing.Size(169, 27);
            this.lbl訂單總價.TabIndex = 4;
            this.lbl訂單總價.Text = "訂單總價XXXX元";
            this.lbl訂單總價.Click += new System.EventHandler(this.lbl訂單總價_Click);
            // 
            // btn關閉表單
            // 
            this.btn關閉表單.BackColor = System.Drawing.Color.Yellow;
            this.btn關閉表單.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn關閉表單.ForeColor = System.Drawing.Color.Purple;
            this.btn關閉表單.Location = new System.Drawing.Point(76, 454);
            this.btn關閉表單.Name = "btn關閉表單";
            this.btn關閉表單.Size = new System.Drawing.Size(186, 33);
            this.btn關閉表單.TabIndex = 5;
            this.btn關閉表單.Text = "關閉表單";
            this.btn關閉表單.UseVisualStyleBackColor = false;
            this.btn關閉表單.Click += new System.EventHandler(this.btn關閉表單_Click);
            // 
            // btn送出訂購
            // 
            this.btn送出訂購.BackColor = System.Drawing.Color.Yellow;
            this.btn送出訂購.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn送出訂購.ForeColor = System.Drawing.Color.Purple;
            this.btn送出訂購.Location = new System.Drawing.Point(306, 454);
            this.btn送出訂購.Name = "btn送出訂購";
            this.btn送出訂購.Size = new System.Drawing.Size(186, 33);
            this.btn送出訂購.TabIndex = 6;
            this.btn送出訂購.Text = "送出訂購單(存檔)";
            this.btn送出訂購.UseVisualStyleBackColor = false;
            this.btn送出訂購.Click += new System.EventHandler(this.btn送出訂購_Click);
            // 
            // 班級
            // 
            this.班級.AutoSize = true;
            this.班級.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.班級.ForeColor = System.Drawing.Color.White;
            this.班級.Location = new System.Drawing.Point(42, 61);
            this.班級.Name = "班級";
            this.班級.Size = new System.Drawing.Size(48, 22);
            this.班級.TabIndex = 7;
            this.班級.Text = "班級:";
            // 
            // lbl班級
            // 
            this.lbl班級.AutoSize = true;
            this.lbl班級.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl班級.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl班級.ForeColor = System.Drawing.Color.Indigo;
            this.lbl班級.Location = new System.Drawing.Point(98, 61);
            this.lbl班級.Name = "lbl班級";
            this.lbl班級.Size = new System.Drawing.Size(54, 22);
            this.lbl班級.TabIndex = 8;
            this.lbl班級.Text = "XXXX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(355, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "學生:";
            // 
            // lbl值日生
            // 
            this.lbl值日生.AutoSize = true;
            this.lbl值日生.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl值日生.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lbl值日生.ForeColor = System.Drawing.Color.Indigo;
            this.lbl值日生.Location = new System.Drawing.Point(426, 61);
            this.lbl值日生.Name = "lbl值日生";
            this.lbl值日生.Size = new System.Drawing.Size(43, 22);
            this.lbl值日生.TabIndex = 10;
            this.lbl值日生.Text = "XXX";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(540, 505);
            this.Controls.Add(this.lbl值日生);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl班級);
            this.Controls.Add(this.班級);
            this.Controls.Add(this.btn送出訂購);
            this.Controls.Add(this.btn關閉表單);
            this.Controls.Add(this.lbl訂單總價);
            this.Controls.Add(this.btn清除所有品項);
            this.Controls.Add(this.btn移除所選品項);
            this.Controls.Add(this.lbox訂購品項);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "訂購單列表";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbox訂購品項;
        private System.Windows.Forms.Button btn移除所選品項;
        private System.Windows.Forms.Button btn清除所有品項;
        private System.Windows.Forms.Label lbl訂單總價;
        private System.Windows.Forms.Button btn關閉表單;
        private System.Windows.Forms.Button btn送出訂購;
        private System.Windows.Forms.Label 班級;
        private System.Windows.Forms.Label lbl班級;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl值日生;
    }
}