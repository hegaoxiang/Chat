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
            this.label1 = new System.Windows.Forms.Label();
            this.m_userInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.m_passInput = new System.Windows.Forms.TextBox();
            this.m_btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(156, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // m_userInput
            // 
            this.m_userInput.Location = new System.Drawing.Point(236, 139);
            this.m_userInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_userInput.Name = "m_userInput";
            this.m_userInput.Size = new System.Drawing.Size(132, 25);
            this.m_userInput.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码";
            // 
            // m_passInput
            // 
            this.m_passInput.Location = new System.Drawing.Point(236, 194);
            this.m_passInput.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_passInput.Name = "m_passInput";
            this.m_passInput.Size = new System.Drawing.Size(132, 25);
            this.m_passInput.TabIndex = 3;
            this.m_passInput.UseSystemPasswordChar = true;
            // 
            // m_btnLogin
            // 
            this.m_btnLogin.Location = new System.Drawing.Point(392, 249);
            this.m_btnLogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.m_btnLogin.Name = "m_btnLogin";
            this.m_btnLogin.Size = new System.Drawing.Size(100, 29);
            this.m_btnLogin.TabIndex = 4;
            this.m_btnLogin.Text = "登陆";
            this.m_btnLogin.UseVisualStyleBackColor = true;
            this.m_btnLogin.Click += new System.EventHandler(this.m_btnLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 466);
            this.Controls.Add(this.m_btnLogin);
            this.Controls.Add(this.m_passInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_userInput);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox m_userInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_passInput;
        private System.Windows.Forms.Button m_btnLogin;
    }
}

