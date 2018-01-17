namespace WindowsFormsApp2
{
    partial class Startseite
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
            this.label4 = new System.Windows.Forms.Label();
            this.pmtools = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(729, 613);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "label4";
            // 
            // pmtools
            // 
            this.pmtools.AutoSize = true;
            this.pmtools.Location = new System.Drawing.Point(658, 613);
            this.pmtools.Name = "pmtools";
            this.pmtools.Size = new System.Drawing.Size(43, 13);
            this.pmtools.TabIndex = 1;
            this.pmtools.Text = "pmtools";
            // 
            // Startseite
            // 
            this.ClientSize = new System.Drawing.Size(788, 635);
            this.Controls.Add(this.pmtools);
            this.Controls.Add(this.label4);
            this.Name = "Startseite";
            this.Load += new System.EventHandler(this.Startseite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource newdbDataSetBindingSource1;
        private newdbDataSet newdbDataSet;
        private System.Windows.Forms.BindingSource newdbDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label pmtools;
    }
}