namespace PapyBrossard
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.DiscordImg = new System.Windows.Forms.PictureBox();
            this.TwitterImg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DiscordImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitterImg)).BeginInit();
            this.SuspendLayout();
            // 
            // DiscordImg
            // 
            this.DiscordImg.BackColor = System.Drawing.Color.Transparent;
            this.DiscordImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DiscordImg.BackgroundImage")));
            this.DiscordImg.Location = new System.Drawing.Point(12, 419);
            this.DiscordImg.Name = "DiscordImg";
            this.DiscordImg.Size = new System.Drawing.Size(100, 100);
            this.DiscordImg.TabIndex = 0;
            this.DiscordImg.TabStop = false;
            this.DiscordImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TwitterImg
            // 
            this.TwitterImg.BackColor = System.Drawing.Color.Transparent;
            this.TwitterImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TwitterImg.BackgroundImage")));
            this.TwitterImg.Location = new System.Drawing.Point(118, 419);
            this.TwitterImg.Name = "TwitterImg";
            this.TwitterImg.Size = new System.Drawing.Size(100, 100);
            this.TwitterImg.TabIndex = 1;
            this.TwitterImg.TabStop = false;
            this.TwitterImg.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(664, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(247, 76);
            this.button1.TabIndex = 2;
            this.button1.Text = "Rejoindre le serveur !";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 531);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TwitterImg);
            this.Controls.Add(this.DiscordImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "PapyBrossard";
            ((System.ComponentModel.ISupportInitialize)(this.DiscordImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TwitterImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox DiscordImg;
        private System.Windows.Forms.PictureBox TwitterImg;
        private System.Windows.Forms.Button button1;
    }
}

