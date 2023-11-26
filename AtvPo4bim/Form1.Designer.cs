namespace AtvPo4bim
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
            this.BotaoFun = new System.Windows.Forms.Button();
            this.BotaoEmp = new System.Windows.Forms.Button();
            this.fechartd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BotaoFun
            // 
            this.BotaoFun.Location = new System.Drawing.Point(186, 116);
            this.BotaoFun.Name = "BotaoFun";
            this.BotaoFun.Size = new System.Drawing.Size(141, 36);
            this.BotaoFun.TabIndex = 0;
            this.BotaoFun.UseVisualStyleBackColor = true;
            this.BotaoFun.Click += new System.EventHandler(this.BotaoFun_Click);
            // 
            // BotaoEmp
            // 
            this.BotaoEmp.Location = new System.Drawing.Point(186, 194);
            this.BotaoEmp.Name = "BotaoEmp";
            this.BotaoEmp.Size = new System.Drawing.Size(141, 40);
            this.BotaoEmp.TabIndex = 1;
            this.BotaoEmp.UseVisualStyleBackColor = true;
            // 
            // fechartd
            // 
            this.fechartd.Location = new System.Drawing.Point(487, 3);
            this.fechartd.Name = "fechartd";
            this.fechartd.Size = new System.Drawing.Size(32, 23);
            this.fechartd.TabIndex = 2;
            this.fechartd.UseVisualStyleBackColor = true;
            this.fechartd.Click += new System.EventHandler(this.fechartd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtvPo4bim.Properties.Resources.Frame_4__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(518, 302);
            this.Controls.Add(this.fechartd);
            this.Controls.Add(this.BotaoEmp);
            this.Controls.Add(this.BotaoFun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BotaoFun;
        private System.Windows.Forms.Button BotaoEmp;
        private System.Windows.Forms.Button fechartd;
    }
}

