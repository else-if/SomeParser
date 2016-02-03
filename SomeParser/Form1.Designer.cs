namespace SomeParser
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonDisplayDevTools = new System.Windows.Forms.Button();
            this.buttonSourceCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 371);
            this.panel1.TabIndex = 0;
            // 
            // buttonDisplayDevTools
            // 
            this.buttonDisplayDevTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDisplayDevTools.Location = new System.Drawing.Point(704, 12);
            this.buttonDisplayDevTools.Name = "buttonDisplayDevTools";
            this.buttonDisplayDevTools.Size = new System.Drawing.Size(110, 30);
            this.buttonDisplayDevTools.TabIndex = 1;
            this.buttonDisplayDevTools.Text = "Display dev tools";
            this.buttonDisplayDevTools.UseVisualStyleBackColor = true;
            this.buttonDisplayDevTools.Click += new System.EventHandler(this.buttonDisplayDevTools_Click);
            // 
            // buttonSourceCode
            // 
            this.buttonSourceCode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSourceCode.Location = new System.Drawing.Point(704, 48);
            this.buttonSourceCode.Name = "buttonSourceCode";
            this.buttonSourceCode.Size = new System.Drawing.Size(110, 32);
            this.buttonSourceCode.TabIndex = 2;
            this.buttonSourceCode.Text = "View source code";
            this.buttonSourceCode.UseVisualStyleBackColor = true;
            this.buttonSourceCode.Click += new System.EventHandler(this.buttonSourceCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 395);
            this.Controls.Add(this.buttonSourceCode);
            this.Controls.Add(this.buttonDisplayDevTools);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonDisplayDevTools;
        private System.Windows.Forms.Button buttonSourceCode;
    }
}

