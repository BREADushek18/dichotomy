namespace dichotomy
{
    partial class SLAU
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.запуститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.очиститьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяНазадToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblIntervalStart = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.запуститьToolStripMenuItem,
            this.очиститьToolStripMenuItem,
            this.вернутьсяНазадToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1188, 24);
            this.menuStrip.TabIndex = 9;
            // 
            // запуститьToolStripMenuItem
            // 
            this.запуститьToolStripMenuItem.Name = "запуститьToolStripMenuItem";
            this.запуститьToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.запуститьToolStripMenuItem.Text = "Запустить";
            this.запуститьToolStripMenuItem.Click += new System.EventHandler(this.запуститьToolStripMenuItem_Click);
            // 
            // очиститьToolStripMenuItem
            // 
            this.очиститьToolStripMenuItem.Name = "очиститьToolStripMenuItem";
            this.очиститьToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.очиститьToolStripMenuItem.Text = "Очистить";
            this.очиститьToolStripMenuItem.Click += new System.EventHandler(this.очиститьToolStripMenuItem_Click);
            // 
            // вернутьсяНазадToolStripMenuItem
            // 
            this.вернутьсяНазадToolStripMenuItem.Name = "вернутьсяНазадToolStripMenuItem";
            this.вернутьсяНазадToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.вернутьсяНазадToolStripMenuItem.Text = "Вернуться назад";
            this.вернутьсяНазадToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяНазадToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(449, 104);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(685, 394);
            this.dataGridView1.TabIndex = 10;
            // 
            // lblIntervalStart
            // 
            this.lblIntervalStart.Location = new System.Drawing.Point(20, 100);
            this.lblIntervalStart.Name = "lblIntervalStart";
            this.lblIntervalStart.Size = new System.Drawing.Size(77, 20);
            this.lblIntervalStart.TabIndex = 11;
            this.lblIntervalStart.Text = "Число N =";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(103, 100);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(47, 20);
            this.textBoxN.TabIndex = 12;
            this.textBoxN.TextChanged += new System.EventHandler(this.textBoxN_TextChanged);
            // 
            // SLAU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 556);
            this.Controls.Add(this.lblIntervalStart);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SLAU";
            this.Text = "Form1";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem запуститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem очиститьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяНазадToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblIntervalStart;
        private System.Windows.Forms.TextBox textBoxN;
    }
}