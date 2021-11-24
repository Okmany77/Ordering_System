
namespace WindowsFormsApp1
{
    partial class 刪除菜單Form
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
            this.btn刪除 = new System.Windows.Forms.Button();
            this.btn取消 = new System.Windows.Forms.Button();
            this.cob店家 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cob菜名 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "選擇廠商:";
            // 
            // btn刪除
            // 
            this.btn刪除.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn刪除.Location = new System.Drawing.Point(54, 179);
            this.btn刪除.Name = "btn刪除";
            this.btn刪除.Size = new System.Drawing.Size(104, 42);
            this.btn刪除.TabIndex = 2;
            this.btn刪除.Text = "確認刪除";
            this.btn刪除.UseVisualStyleBackColor = true;
            this.btn刪除.Click += new System.EventHandler(this.btn刪除_Click);
            // 
            // btn取消
            // 
            this.btn取消.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn取消.Location = new System.Drawing.Point(205, 179);
            this.btn取消.Name = "btn取消";
            this.btn取消.Size = new System.Drawing.Size(104, 42);
            this.btn取消.TabIndex = 3;
            this.btn取消.Text = "離開";
            this.btn取消.UseVisualStyleBackColor = true;
            this.btn取消.Click += new System.EventHandler(this.btn取消_Click);
            // 
            // cob店家
            // 
            this.cob店家.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob店家.FormattingEnabled = true;
            this.cob店家.Location = new System.Drawing.Point(130, 26);
            this.cob店家.Name = "cob店家";
            this.cob店家.Size = new System.Drawing.Size(194, 28);
            this.cob店家.TabIndex = 4;
            this.cob店家.SelectedIndexChanged += new System.EventHandler(this.cob店家_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(30, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 22);
            this.label2.TabIndex = 5;
            this.label2.Text = "選擇品項:";
            // 
            // cob菜名
            // 
            this.cob菜名.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cob菜名.FormattingEnabled = true;
            this.cob菜名.Location = new System.Drawing.Point(130, 84);
            this.cob菜名.Name = "cob菜名";
            this.cob菜名.Size = new System.Drawing.Size(194, 28);
            this.cob菜名.TabIndex = 6;
            this.cob菜名.SelectedIndexChanged += new System.EventHandler(this.cob菜名_SelectedIndexChanged);
            // 
            // 刪除菜單Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 248);
            this.Controls.Add(this.cob菜名);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cob店家);
            this.Controls.Add(this.btn取消);
            this.Controls.Add(this.btn刪除);
            this.Controls.Add(this.label1);
            this.Name = "刪除菜單Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "刪除菜單表";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn刪除;
        private System.Windows.Forms.Button btn取消;
        private System.Windows.Forms.ComboBox cob店家;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cob菜名;
    }
}