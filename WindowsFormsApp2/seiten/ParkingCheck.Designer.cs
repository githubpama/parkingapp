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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.newdbDataSet = new WindowsFormsApp2.newdbDataSet();
            this.newdbDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.newdbDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSetBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(350, 142);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Suchen";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(154, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(149, 20);
            this.textBox1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.newdbDataSetBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(154, 210);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // newdbDataSet
            // 
            this.newdbDataSet.DataSetName = "newdbDataSet";
            this.newdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // newdbDataSetBindingSource
            // 
            this.newdbDataSetBindingSource.DataSource = this.newdbDataSet;
            this.newdbDataSetBindingSource.Position = 0;
            // 
            // newdbDataSetBindingSource1
            // 
            this.newdbDataSetBindingSource1.DataSource = this.newdbDataSet;
            this.newdbDataSetBindingSource1.Position = 0;
            // 
            // Startseite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 694);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Startseite";
            this.Text = "Startseite";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newdbDataSetBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource newdbDataSetBindingSource1;
        private newdbDataSet newdbDataSet;
        private System.Windows.Forms.BindingSource newdbDataSetBindingSource;
    }
}