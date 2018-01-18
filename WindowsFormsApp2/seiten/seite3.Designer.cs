namespace WindowsFormsApp2
{
    partial class seite3
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
    

        #endregion

        private void InitializeComponent()
        {
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.SuspendLayout();
            // 
            // ribbon1
            // 
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1177, 200);
            this.ribbon1.TabIndex = 0;
            this.ribbon1.Tabs.Add(this.ribbonTab1);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Blue;
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel1);
            this.ribbonTab1.Panels.Add(this.ribbonPanel2);
            this.ribbonTab1.Panels.Add(this.ribbonPanel3);
            this.ribbonTab1.Text = "Menu1";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "Eingabe";
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Text = "Datenbank";
            this.ribbonPanel2.Click += new System.EventHandler(this.ribbonPanel2_Click);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Text = "Einstellungen";
            // 
            // seite3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 989);
            this.Controls.Add(this.ribbon1);
            this.Name = "seite3";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
    }
}