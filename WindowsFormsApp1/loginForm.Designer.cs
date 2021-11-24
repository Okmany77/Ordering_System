
namespace WindowsFormsApp1
{
    partial class loginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt帳號 = new System.Windows.Forms.TextBox();
            this.txt密碼 = new System.Windows.Forms.TextBox();
            this.btn學生登入 = new System.Windows.Forms.Button();
            this.btn班代登入 = new System.Windows.Forms.Button();
            this.btn管理員登入 = new System.Windows.Forms.Button();
            this.btn註冊 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn離開 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(26, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "帳號:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(26, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "密碼:";
            // 
            // txt帳號
            // 
            this.txt帳號.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt帳號.Location = new System.Drawing.Point(95, 40);
            this.txt帳號.Name = "txt帳號";
            this.txt帳號.Size = new System.Drawing.Size(157, 33);
            this.txt帳號.TabIndex = 1;
            this.txt帳號.TextChanged += new System.EventHandler(this.txt帳號_TextChanged);
            // 
            // txt密碼
            // 
            this.txt密碼.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt密碼.Location = new System.Drawing.Point(95, 105);
            this.txt密碼.Name = "txt密碼";
            this.txt密碼.PasswordChar = '*';
            this.txt密碼.Size = new System.Drawing.Size(157, 33);
            this.txt密碼.TabIndex = 2;
            // 
            // btn學生登入
            // 
            this.btn學生登入.BackColor = System.Drawing.Color.Teal;
            this.btn學生登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn學生登入.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn學生登入.Location = new System.Drawing.Point(79, 237);
            this.btn學生登入.Name = "btn學生登入";
            this.btn學生登入.Size = new System.Drawing.Size(244, 37);
            this.btn學生登入.TabIndex = 4;
            this.btn學生登入.Text = "學    生";
            this.btn學生登入.UseVisualStyleBackColor = false;
            this.btn學生登入.Click += new System.EventHandler(this.btn學生登入_Click);
            // 
            // btn班代登入
            // 
            this.btn班代登入.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn班代登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn班代登入.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn班代登入.Location = new System.Drawing.Point(79, 294);
            this.btn班代登入.Name = "btn班代登入";
            this.btn班代登入.Size = new System.Drawing.Size(244, 37);
            this.btn班代登入.TabIndex = 5;
            this.btn班代登入.Text = "班    代";
            this.btn班代登入.UseVisualStyleBackColor = false;
            this.btn班代登入.Click += new System.EventHandler(this.btn班代登入_Click);
            // 
            // btn管理員登入
            // 
            this.btn管理員登入.BackColor = System.Drawing.Color.DeepPink;
            this.btn管理員登入.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn管理員登入.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn管理員登入.Location = new System.Drawing.Point(79, 350);
            this.btn管理員登入.Name = "btn管理員登入";
            this.btn管理員登入.Size = new System.Drawing.Size(244, 37);
            this.btn管理員登入.TabIndex = 6;
            this.btn管理員登入.Text = "管 理 員";
            this.btn管理員登入.UseVisualStyleBackColor = false;
            this.btn管理員登入.Click += new System.EventHandler(this.btn管理員登入_Click);
            // 
            // btn註冊
            // 
            this.btn註冊.BackColor = System.Drawing.Color.DodgerBlue;
            this.btn註冊.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn註冊.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn註冊.Location = new System.Drawing.Point(35, 426);
            this.btn註冊.Name = "btn註冊";
            this.btn註冊.Size = new System.Drawing.Size(160, 37);
            this.btn註冊.TabIndex = 7;
            this.btn註冊.Text = "註    冊";
            this.btn註冊.UseVisualStyleBackColor = false;
            this.btn註冊.Click += new System.EventHandler(this.btn註冊_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSalmon;
            this.groupBox1.Controls.Add(this.txt密碼);
            this.groupBox1.Controls.Add(this.txt帳號);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(61, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(287, 165);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "請輸入號密";
            // 
            // btn離開
            // 
            this.btn離開.BackColor = System.Drawing.Color.Firebrick;
            this.btn離開.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btn離開.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn離開.Location = new System.Drawing.Point(211, 426);
            this.btn離開.Name = "btn離開";
            this.btn離開.Size = new System.Drawing.Size(160, 37);
            this.btn離開.TabIndex = 9;
            this.btn離開.Text = "離開系統";
            this.btn離開.UseVisualStyleBackColor = false;
            this.btn離開.Click += new System.EventHandler(this.btn離開_Click);
            // 
            // loginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(410, 488);
            this.Controls.Add(this.btn離開);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn註冊);
            this.Controls.Add(this.btn管理員登入);
            this.Controls.Add(this.btn班代登入);
            this.Controls.Add(this.btn學生登入);
            this.Name = "loginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登入介面-訂便當menu系統";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.loginForm_FormClosed);
            this.Load += new System.EventHandler(this.loginForm3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt帳號;
        private System.Windows.Forms.TextBox txt密碼;
        private System.Windows.Forms.Button btn學生登入;
        private System.Windows.Forms.Button btn班代登入;
        private System.Windows.Forms.Button btn管理員登入;
        private System.Windows.Forms.Button btn註冊;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn離開;
    }
}