
namespace marioNiquel
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPlay = new System.Windows.Forms.Button();
            this.pct1 = new System.Windows.Forms.PictureBox();
            this.pct2 = new System.Windows.Forms.PictureBox();
            this.pct3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Orange;
            this.btnPlay.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Orange;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Cooper Black", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.Location = new System.Drawing.Point(334, 361);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(139, 38);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "PLAY";
            this.btnPlay.UseVisualStyleBackColor = false;
            // 
            // pct1
            // 
            this.pct1.Image = global::marioNiquel.Properties.Resources.item1;
            this.pct1.Location = new System.Drawing.Point(87, 184);
            this.pct1.Name = "pct1";
            this.pct1.Size = new System.Drawing.Size(140, 140);
            this.pct1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct1.TabIndex = 1;
            this.pct1.TabStop = false;
            // 
            // pct2
            // 
            this.pct2.Image = global::marioNiquel.Properties.Resources.item2;
            this.pct2.Location = new System.Drawing.Point(336, 184);
            this.pct2.Name = "pct2";
            this.pct2.Size = new System.Drawing.Size(140, 140);
            this.pct2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct2.TabIndex = 2;
            this.pct2.TabStop = false;
            // 
            // pct3
            // 
            this.pct3.Image = global::marioNiquel.Properties.Resources.item4;
            this.pct3.Location = new System.Drawing.Point(581, 184);
            this.pct3.Name = "pct3";
            this.pct3.Size = new System.Drawing.Size(140, 140);
            this.pct3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct3.TabIndex = 3;
            this.pct3.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(797, 450);
            this.Controls.Add(this.pct3);
            this.Controls.Add(this.pct2);
            this.Controls.Add(this.pct1);
            this.Controls.Add(this.btnPlay);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Mario Níquel";
            ((System.ComponentModel.ISupportInitialize)(this.pct1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.PictureBox pct1;
        private System.Windows.Forms.PictureBox pct2;
        private System.Windows.Forms.PictureBox pct3;
    }
}

