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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LB1 = new System.Windows.Forms.ListBox();
            this.BT1 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Azure;
            this.textBox1.Location = new System.Drawing.Point(36, 105);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(227, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Намери
            // 
            this.Намери.BackColor = System.Drawing.Color.Aqua;
            this.Намери.ForeColor = System.Drawing.Color.Black;
            this.Намери.Location = new System.Drawing.Point(338, 85);
            this.Намери.Name = "Намери";
            this.Намери.Size = new System.Drawing.Size(126, 42);
            this.Намери.TabIndex = 2;
            this.Намери.Text = "Намери";
            this.Намери.UseVisualStyleBackColor = false;
            this.Намери.Click += new System.EventHandler(this.Намери_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Въведи вид на карта";
            // 
            // DGrid
            // 
            this.DGrid.AllowUserToAddRows = false;
            this.DGrid.AllowUserToDeleteRows = false;
            this.DGrid.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.DGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGrid.Location = new System.Drawing.Point(36, 170);
            this.DGrid.Name = "DGrid";
            this.DGrid.ReadOnly = true;
            this.DGrid.RowHeadersWidth = 51;
            this.DGrid.RowTemplate.Height = 24;
            this.DGrid.Size = new System.Drawing.Size(428, 192);
            this.DGrid.TabIndex = 4;
            this.DGrid.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Номер на карта";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Вид на карта";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Салдо";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // LB1
            // 
            this.LB1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.LB1.FormattingEnabled = true;
            this.LB1.ItemHeight = 16;
            this.LB1.Location = new System.Drawing.Point(540, 166);
            this.LB1.Name = "LB1";
            this.LB1.Size = new System.Drawing.Size(348, 196);
            this.LB1.TabIndex = 5;
            // 
            // BT1
            // 
            this.BT1.BackColor = System.Drawing.Color.Aqua;
            this.BT1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT1.Location = new System.Drawing.Point(640, 85);
            this.BT1.Name = "BT1";
            this.BT1.Size = new System.Drawing.Size(174, 42);
            this.BT1.TabIndex = 6;
            this.BT1.Text = "Средна стойност";
            this.BT1.UseVisualStyleBackColor = false;
            this.BT1.Click += new System.EventHandler(this.BT1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Aqua;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(36, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 49);
            this.button1.TabIndex = 7;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(917, 480);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BT1);
            this.Controls.Add(this.LB1);
            this.Controls.Add(this.DGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Намери);
            this.Controls.Add(this.textBox1);
            this.Name = "Form2";
            this.Text = "Търсене на карти";
            ((System.ComponentModel.ISupportInitialize)(this.DGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Намери;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.ListBox LB1;
        private System.Windows.Forms.Button BT1;
        private System.Windows.Forms.Button button1;
    }
}