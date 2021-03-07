
namespace Tekrarla
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
            this.arkaplanRengiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kırmızıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turuncuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.morToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sınavHesaplamaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bilgilerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.renkSeçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaplanRengiToolStripMenuItem,
            this.sınavHesaplamaToolStripMenuItem,
            this.bilgilerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1338, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arkaplanRengiToolStripMenuItem
            // 
            this.arkaplanRengiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.maviToolStripMenuItem,
            this.kırmızıToolStripMenuItem,
            this.turuncuToolStripMenuItem,
            this.morToolStripMenuItem,
            this.sarıToolStripMenuItem,
            this.renkSeçToolStripMenuItem});
            this.arkaplanRengiToolStripMenuItem.Name = "arkaplanRengiToolStripMenuItem";
            this.arkaplanRengiToolStripMenuItem.Size = new System.Drawing.Size(155, 29);
            this.arkaplanRengiToolStripMenuItem.Text = "Arkaplan Rengi";
            // 
            // maviToolStripMenuItem
            // 
            this.maviToolStripMenuItem.Name = "maviToolStripMenuItem";
            this.maviToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maviToolStripMenuItem.Text = "Mavi";
            this.maviToolStripMenuItem.Click += new System.EventHandler(this.maviToolStripMenuItem_Click);
            // 
            // kırmızıToolStripMenuItem
            // 
            this.kırmızıToolStripMenuItem.Name = "kırmızıToolStripMenuItem";
            this.kırmızıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.kırmızıToolStripMenuItem.Text = "Kırmızı";
            this.kırmızıToolStripMenuItem.Click += new System.EventHandler(this.kırmızıToolStripMenuItem_Click);
            // 
            // turuncuToolStripMenuItem
            // 
            this.turuncuToolStripMenuItem.Name = "turuncuToolStripMenuItem";
            this.turuncuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.turuncuToolStripMenuItem.Text = "Turuncu";
            this.turuncuToolStripMenuItem.Click += new System.EventHandler(this.turuncuToolStripMenuItem_Click);
            // 
            // morToolStripMenuItem
            // 
            this.morToolStripMenuItem.Name = "morToolStripMenuItem";
            this.morToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.morToolStripMenuItem.Text = "Mor";
            this.morToolStripMenuItem.Click += new System.EventHandler(this.morToolStripMenuItem_Click);
            // 
            // sarıToolStripMenuItem
            // 
            this.sarıToolStripMenuItem.Name = "sarıToolStripMenuItem";
            this.sarıToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sarıToolStripMenuItem.Text = "Sarı";
            this.sarıToolStripMenuItem.Click += new System.EventHandler(this.sarıToolStripMenuItem_Click);
            // 
            // sınavHesaplamaToolStripMenuItem
            // 
            this.sınavHesaplamaToolStripMenuItem.Name = "sınavHesaplamaToolStripMenuItem";
            this.sınavHesaplamaToolStripMenuItem.Size = new System.Drawing.Size(169, 29);
            this.sınavHesaplamaToolStripMenuItem.Text = "Sınav Hesaplama";
            this.sınavHesaplamaToolStripMenuItem.Click += new System.EventHandler(this.sınavHesaplamaToolStripMenuItem_Click);
            // 
            // bilgilerToolStripMenuItem
            // 
            this.bilgilerToolStripMenuItem.Name = "bilgilerToolStripMenuItem";
            this.bilgilerToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.bilgilerToolStripMenuItem.Text = "Bilgiler";
            this.bilgilerToolStripMenuItem.Click += new System.EventHandler(this.bilgilerToolStripMenuItem_Click);
            // 
            // renkSeçToolStripMenuItem
            // 
            this.renkSeçToolStripMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            this.renkSeçToolStripMenuItem.Name = "renkSeçToolStripMenuItem";
            this.renkSeçToolStripMenuItem.Size = new System.Drawing.Size(180, 30);
            this.renkSeçToolStripMenuItem.Text = "Renk Seç";
            this.renkSeçToolStripMenuItem.Click += new System.EventHandler(this.renkSeçToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1338, 686);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arkaplanRengiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maviToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kırmızıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turuncuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem morToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sınavHesaplamaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bilgilerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem renkSeçToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

