namespace BilkentKafe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ürünlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.geçmişSiparişlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lvvMasalar = new System.Windows.Forms.ListView();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ürünlerToolStripMenuItem,
            this.geçmişSiparişlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ürünlerToolStripMenuItem
            // 
            this.ürünlerToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ürünlerToolStripMenuItem.Name = "ürünlerToolStripMenuItem";
            this.ürünlerToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.ürünlerToolStripMenuItem.Text = "Ürünler";
            // 
            // geçmişSiparişlerToolStripMenuItem
            // 
            this.geçmişSiparişlerToolStripMenuItem.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.geçmişSiparişlerToolStripMenuItem.Name = "geçmişSiparişlerToolStripMenuItem";
            this.geçmişSiparişlerToolStripMenuItem.Size = new System.Drawing.Size(118, 21);
            this.geçmişSiparişlerToolStripMenuItem.Text = "Geçmiş Siparişler";
            // 
            // lvvMasalar
            // 
            this.lvvMasalar.BackColor = System.Drawing.Color.LightCyan;
            this.lvvMasalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvvMasalar.Location = new System.Drawing.Point(0, 25);
            this.lvvMasalar.Name = "lvvMasalar";
            this.lvvMasalar.Size = new System.Drawing.Size(800, 425);
            this.lvvMasalar.TabIndex = 1;
            this.lvvMasalar.UseCompatibleStateImageBehavior = false;
            this.lvvMasalar.DoubleClick += new System.EventHandler(this.lvvMasalar_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvvMasalar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Bilkent Kafe";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ürünlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem geçmişSiparişlerToolStripMenuItem;
        private System.Windows.Forms.ListView lvvMasalar;
    }
}

