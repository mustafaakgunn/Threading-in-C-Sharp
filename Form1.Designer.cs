
namespace _171180002
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.prosesler_listbox = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sahipOlduğuİplikSayısıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bellekKullanımMiktarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemciKullanımYüzdesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buProsesiÖldürToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // prosesler_listbox
            // 
            this.prosesler_listbox.ContextMenuStrip = this.contextMenuStrip1;
            this.prosesler_listbox.FormattingEnabled = true;
            this.prosesler_listbox.ItemHeight = 16;
            this.prosesler_listbox.Location = new System.Drawing.Point(12, 41);
            this.prosesler_listbox.Name = "prosesler_listbox";
            this.prosesler_listbox.Size = new System.Drawing.Size(177, 452);
            this.prosesler_listbox.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sahipOlduğuİplikSayısıToolStripMenuItem,
            this.bellekKullanımMiktarıToolStripMenuItem,
            this.işlemciKullanımYüzdesiToolStripMenuItem,
            this.buProsesiÖldürToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(211, 128);
            // 
            // sahipOlduğuİplikSayısıToolStripMenuItem
            // 
            this.sahipOlduğuİplikSayısıToolStripMenuItem.Name = "sahipOlduğuİplikSayısıToolStripMenuItem";
            this.sahipOlduğuİplikSayısıToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.sahipOlduğuİplikSayısıToolStripMenuItem.Text = "Number of Threads";
            this.sahipOlduğuİplikSayısıToolStripMenuItem.Click += new System.EventHandler(this.sahipOlduğuİplikSayısıToolStripMenuItem_Click);
            // 
            // bellekKullanımMiktarıToolStripMenuItem
            // 
            this.bellekKullanımMiktarıToolStripMenuItem.Name = "bellekKullanımMiktarıToolStripMenuItem";
            this.bellekKullanımMiktarıToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.bellekKullanımMiktarıToolStripMenuItem.Text = "Memory Usage";
            this.bellekKullanımMiktarıToolStripMenuItem.Click += new System.EventHandler(this.bellekKullanımMiktarıToolStripMenuItem_Click);
            // 
            // işlemciKullanımYüzdesiToolStripMenuItem
            // 
            this.işlemciKullanımYüzdesiToolStripMenuItem.Name = "işlemciKullanımYüzdesiToolStripMenuItem";
            this.işlemciKullanımYüzdesiToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.işlemciKullanımYüzdesiToolStripMenuItem.Text = "Processor Usage";
            this.işlemciKullanımYüzdesiToolStripMenuItem.Click += new System.EventHandler(this.işlemciKullanımYüzdesiToolStripMenuItem_Click);
            // 
            // buProsesiÖldürToolStripMenuItem
            // 
            this.buProsesiÖldürToolStripMenuItem.Name = "buProsesiÖldürToolStripMenuItem";
            this.buProsesiÖldürToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
            this.buProsesiÖldürToolStripMenuItem.Text = "Kill this Process!";
            this.buProsesiÖldürToolStripMenuItem.Click += new System.EventHandler(this.buProsesiÖldürToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "PROCESSES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 538);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prosesler_listbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox prosesler_listbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sahipOlduğuİplikSayısıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bellekKullanımMiktarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem işlemciKullanımYüzdesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buProsesiÖldürToolStripMenuItem;
    }
}

