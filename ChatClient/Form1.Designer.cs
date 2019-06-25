namespace ChatClient
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.m_userInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_passInput = new System.Windows.Forms.TextBox();
            this.m_btnLogin = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.m_btnInfo = new System.Windows.Forms.Button();
            this.m_panelLoginInfo = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.m_panelLoginInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(374, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // m_userInput
            // 
            this.m_userInput.Location = new System.Drawing.Point(141, 194);
            this.m_userInput.Margin = new System.Windows.Forms.Padding(4);
            this.m_userInput.Multiline = true;
            this.m_userInput.Name = "m_userInput";
            this.m_userInput.Size = new System.Drawing.Size(227, 40);
            this.m_userInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 254);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // m_passInput
            // 
            this.m_passInput.Location = new System.Drawing.Point(141, 230);
            this.m_passInput.Margin = new System.Windows.Forms.Padding(4);
            this.m_passInput.Multiline = true;
            this.m_passInput.Name = "m_passInput";
            this.m_passInput.Size = new System.Drawing.Size(227, 39);
            this.m_passInput.TabIndex = 3;
            this.m_passInput.UseSystemPasswordChar = true;
            // 
            // m_btnLogin
            // 
            this.m_btnLogin.Location = new System.Drawing.Point(141, 315);
            this.m_btnLogin.Margin = new System.Windows.Forms.Padding(4);
            this.m_btnLogin.Name = "m_btnLogin";
            this.m_btnLogin.Size = new System.Drawing.Size(227, 36);
            this.m_btnLogin.TabIndex = 4;
            this.m_btnLogin.Text = "登陆";
            this.m_btnLogin.UseVisualStyleBackColor = true;
            this.m_btnLogin.Click += new System.EventHandler(this.m_btnLogin_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(171, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "记住密码";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(141, 276);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(271, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 7;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(301, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "自动登陆";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // m_btnInfo
            // 
            this.m_btnInfo.Location = new System.Drawing.Point(373, 242);
            this.m_btnInfo.Name = "m_btnInfo";
            this.m_btnInfo.Size = new System.Drawing.Size(75, 52);
            this.m_btnInfo.TabIndex = 10;
            this.m_btnInfo.Text = "确定";
            this.m_btnInfo.UseVisualStyleBackColor = true;
            // 
            // m_panelLoginInfo
            // 
            this.m_panelLoginInfo.Controls.Add(this.label6);
            this.m_panelLoginInfo.Controls.Add(this.m_btnInfo);
            this.m_panelLoginInfo.Location = new System.Drawing.Point(1, 12);
            this.m_panelLoginInfo.Name = "m_panelLoginInfo";
            this.m_panelLoginInfo.Size = new System.Drawing.Size(520, 352);
            this.m_panelLoginInfo.TabIndex = 11;
            this.m_panelLoginInfo.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(49, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(381, 160);
            this.label6.TabIndex = 12;
            this.label6.Text = "        你输入的用户名或密码不正确，原因可能是：\r\n            1，账户名输入有误；\r\n            2，忘记密码；\r\n      " +
    "      3，未区分字母大小写；\r\n            4，未开启小键盘；\r\n            5，账户名未绑定QQ号。\r\n\r\n          " +
    "  如果你的密码丢失或者遗忘，可访问QQ安全中心\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 364);
            this.Controls.Add(this.m_panelLoginInfo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.m_btnLogin);
            this.Controls.Add(this.m_passInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_userInput);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.m_panelLoginInfo.ResumeLayout(false);
            this.m_panelLoginInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_userInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_passInput;
        private System.Windows.Forms.Button m_btnLogin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button m_btnInfo;
        private System.Windows.Forms.Panel m_panelLoginInfo;
        private System.Windows.Forms.Label label6;
    }
}

