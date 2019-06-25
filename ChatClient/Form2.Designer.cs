namespace ChatClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.m_panelPortrait = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // m_panelPortrait
            // 
            this.m_panelPortrait.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.m_panelPortrait.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("m_panelPortrait.BackgroundImage")));
            this.m_panelPortrait.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.m_panelPortrait.Location = new System.Drawing.Point(0, 0);
            this.m_panelPortrait.Margin = new System.Windows.Forms.Padding(0);
            this.m_panelPortrait.Name = "m_panelPortrait";
            this.m_panelPortrait.Size = new System.Drawing.Size(125, 104);
            this.m_panelPortrait.TabIndex = 0;
            this.m_panelPortrait.Paint += new System.Windows.Forms.PaintEventHandler(this.m_panelPortrait_Paint);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 104);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(123, 408);
            this.panel1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 521);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_panelPortrait);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel m_panelPortrait;
        private System.Windows.Forms.Panel panel1;
    }
}