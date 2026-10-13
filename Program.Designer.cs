namespace Program
{
    partial class Form1
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
            this.linklabel1 = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Size = new System.Drawing.Size(600, 450);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.type = "Panel";
            this.TransparencyKey = "#a04646";
            this.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(-80, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 416);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            this.panel1.type = "Panel";
            this.panel1.ForeColor = System.Drawing.ColorTranslator.FromHtml("#ffffff");
            this.Controls.Add(this.panel1);
            
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(320, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hello World";
            this.label1.type = "Label";
            this.label1.Font = "new System.Drawing.Font(\"Microsoft Sans Serif\", 20F)";
            this.panel1.Controls.Add(this.label1);
            
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(200, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 232);
            this.panel2.TabIndex = 2;
            this.panel2.Text = "panel2";
            this.panel1.Controls.Add(this.panel2);
            
            // 
            // linklabel1
            // 
            this.linklabel1.Location = new System.Drawing.Point(48, 32);
            this.linklabel1.Name = "linklabel1";
            this.linklabel1.Size = new System.Drawing.Size(88, 40);
            this.linklabel1.TabIndex = 1;
            this.linklabel1.Text = "linklabel1";
            this.panel2.Controls.Add(this.linklabel1);
            this.ResumeLayout(false);
        }

        #endregion
    
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel linklabel1;}
}
