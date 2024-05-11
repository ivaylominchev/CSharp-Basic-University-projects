namespace Курсов_проект
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Намери = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.DGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(82, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(179, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Намери
            // 
            this.Намери.Location = new System.Drawing.Point(354, 35);
            this.Намери.Name = "Намери";
            this.Намери.Size = new System.Drawing.Size(126, 42);
            this.Намери.TabIndex = 2;
            this.Намери.Text = "Намери";
            this.Намери.UseVisualStyleBackColor = true;
            this.Намери.Click += new System.EventHandler(this.Намери_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Въведи вид на карта";
            // 
            // DGrid
            // 
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Location = new System.Drawing.Point(120, 230);
            this.DGrid.Name = "DGrid";
            this.DGrid.RowHeadersWidth = 51;
            this.DGrid.RowTemplate.Height = 24;
            this.DGrid.Size = new System.Drawing.Size(240, 150);
            this.DGrid.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Намери);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Търсене";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Намери;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGrid;
    }
}