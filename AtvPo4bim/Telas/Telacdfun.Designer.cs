namespace AtvPo4bim
{
    partial class Telacdfun
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
            this.cadastrarf = new System.Windows.Forms.Button();
            this.deletarf = new System.Windows.Forms.Button();
            this.voltarcdf = new System.Windows.Forms.Button();
            this.IDfun = new System.Windows.Forms.TextBox();
            this.nomefun = new System.Windows.Forms.TextBox();
            this.cpffun = new System.Windows.Forms.MaskedTextBox();
            this.rgfun = new System.Windows.Forms.TextBox();
            this.telefonefun = new System.Windows.Forms.MaskedTextBox();
            this.emailfun = new System.Windows.Forms.TextBox();
            this.datanasfun = new System.Windows.Forms.MaskedTextBox();
            this.enderecofun = new System.Windows.Forms.TextBox();
            this.cidadefun = new System.Windows.Forms.TextBox();
            this.estadofun = new System.Windows.Forms.ComboBox();
            this.salariofun = new System.Windows.Forms.TextBox();
            this.funcaofun = new System.Windows.Forms.TextBox();
            this.cepfun = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cadastrarf
            // 
            this.cadastrarf.Location = new System.Drawing.Point(509, 420);
            this.cadastrarf.Name = "cadastrarf";
            this.cadastrarf.Size = new System.Drawing.Size(75, 23);
            this.cadastrarf.TabIndex = 0;
            this.cadastrarf.UseVisualStyleBackColor = true;
            this.cadastrarf.Click += new System.EventHandler(this.cadastrarf_Click);
            // 
            // deletarf
            // 
            this.deletarf.Location = new System.Drawing.Point(393, 420);
            this.deletarf.Name = "deletarf";
            this.deletarf.Size = new System.Drawing.Size(75, 23);
            this.deletarf.TabIndex = 1;
            this.deletarf.UseVisualStyleBackColor = true;
            this.deletarf.Click += new System.EventHandler(this.deletarf_Click);
            // 
            // voltarcdf
            // 
            this.voltarcdf.Location = new System.Drawing.Point(1, 2);
            this.voltarcdf.Name = "voltarcdf";
            this.voltarcdf.Size = new System.Drawing.Size(33, 23);
            this.voltarcdf.TabIndex = 2;
            this.voltarcdf.UseVisualStyleBackColor = true;
            this.voltarcdf.Click += new System.EventHandler(this.voltarcdf_Click);
            // 
            // IDfun
            // 
            this.IDfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IDfun.Location = new System.Drawing.Point(62, 62);
            this.IDfun.Name = "IDfun";
            this.IDfun.Size = new System.Drawing.Size(73, 15);
            this.IDfun.TabIndex = 3;
            // 
            // nomefun
            // 
            this.nomefun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nomefun.Location = new System.Drawing.Point(195, 64);
            this.nomefun.Name = "nomefun";
            this.nomefun.Size = new System.Drawing.Size(315, 15);
            this.nomefun.TabIndex = 4;
            // 
            // cpffun
            // 
            this.cpffun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cpffun.Location = new System.Drawing.Point(61, 123);
            this.cpffun.Mask = "000,000,000-00";
            this.cpffun.Name = "cpffun";
            this.cpffun.Size = new System.Drawing.Size(124, 15);
            this.cpffun.TabIndex = 5;
            // 
            // rgfun
            // 
            this.rgfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rgfun.Location = new System.Drawing.Point(245, 123);
            this.rgfun.Name = "rgfun";
            this.rgfun.Size = new System.Drawing.Size(121, 15);
            this.rgfun.TabIndex = 6;
            // 
            // telefonefun
            // 
            this.telefonefun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.telefonefun.Location = new System.Drawing.Point(432, 123);
            this.telefonefun.Mask = "(00) 00000-0000";
            this.telefonefun.Name = "telefonefun";
            this.telefonefun.Size = new System.Drawing.Size(100, 15);
            this.telefonefun.TabIndex = 7;
            // 
            // emailfun
            // 
            this.emailfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailfun.Location = new System.Drawing.Point(61, 188);
            this.emailfun.Name = "emailfun";
            this.emailfun.Size = new System.Drawing.Size(305, 15);
            this.emailfun.TabIndex = 8;
            // 
            // datanasfun
            // 
            this.datanasfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.datanasfun.Location = new System.Drawing.Point(432, 188);
            this.datanasfun.Mask = "0000-00-00";
            this.datanasfun.Name = "datanasfun";
            this.datanasfun.Size = new System.Drawing.Size(122, 15);
            this.datanasfun.TabIndex = 9;
            this.datanasfun.ValidatingType = typeof(System.DateTime);
            // 
            // enderecofun
            // 
            this.enderecofun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.enderecofun.Location = new System.Drawing.Point(61, 251);
            this.enderecofun.Name = "enderecofun";
            this.enderecofun.Size = new System.Drawing.Size(305, 15);
            this.enderecofun.TabIndex = 10;
            // 
            // cidadefun
            // 
            this.cidadefun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cidadefun.Location = new System.Drawing.Point(61, 315);
            this.cidadefun.Name = "cidadefun";
            this.cidadefun.Size = new System.Drawing.Size(124, 15);
            this.cidadefun.TabIndex = 11;
            // 
            // estadofun
            // 
            this.estadofun.FormattingEnabled = true;
            this.estadofun.Items.AddRange(new object[] {
            "Acre\t",
            "Alagoas\t",
            "Amapá\t",
            "Amazonas\t",
            "Bahia\t",
            "Ceará\t",
            "Espírito Santo\t",
            "Goiás\t",
            "Maranhão\t",
            "Mato Grosso\t",
            "Mato Grosso do Sul\t",
            "Minas Gerais\t",
            "Pará\t",
            "Paraíba\t",
            "Paraná\t",
            "Pernambuco\t",
            "Piauí\t",
            "Rio de Janeiro\t",
            "Rio Grande do Norte\t",
            "Rio Grande do Sul\t",
            "Rondônia\t",
            "Roraima\t",
            "Santa Catarina\t",
            "São Paulo\t",
            "Sergipe\t",
            "Tocantins"});
            this.estadofun.Location = new System.Drawing.Point(246, 310);
            this.estadofun.Name = "estadofun";
            this.estadofun.Size = new System.Drawing.Size(128, 24);
            this.estadofun.TabIndex = 12;
            // 
            // salariofun
            // 
            this.salariofun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salariofun.Location = new System.Drawing.Point(432, 251);
            this.salariofun.Name = "salariofun";
            this.salariofun.Size = new System.Drawing.Size(122, 15);
            this.salariofun.TabIndex = 13;
            // 
            // funcaofun
            // 
            this.funcaofun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.funcaofun.Location = new System.Drawing.Point(432, 315);
            this.funcaofun.Name = "funcaofun";
            this.funcaofun.Size = new System.Drawing.Size(122, 15);
            this.funcaofun.TabIndex = 14;
            // 
            // cepfun
            // 
            this.cepfun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cepfun.Location = new System.Drawing.Point(61, 376);
            this.cepfun.Name = "cepfun";
            this.cepfun.Size = new System.Drawing.Size(124, 15);
            this.cepfun.TabIndex = 15;
            this.cepfun.TextChanged += new System.EventHandler(this.cepfun_TextChanged);
            // 
            // Telacdfun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtvPo4bim.Properties.Resources.cadastroFUN__2_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(717, 469);
            this.Controls.Add(this.cepfun);
            this.Controls.Add(this.funcaofun);
            this.Controls.Add(this.salariofun);
            this.Controls.Add(this.estadofun);
            this.Controls.Add(this.cidadefun);
            this.Controls.Add(this.enderecofun);
            this.Controls.Add(this.datanasfun);
            this.Controls.Add(this.emailfun);
            this.Controls.Add(this.telefonefun);
            this.Controls.Add(this.rgfun);
            this.Controls.Add(this.cpffun);
            this.Controls.Add(this.nomefun);
            this.Controls.Add(this.IDfun);
            this.Controls.Add(this.voltarcdf);
            this.Controls.Add(this.deletarf);
            this.Controls.Add(this.cadastrarf);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Telacdfun";
            this.Text = "Telacdfun";
            this.Load += new System.EventHandler(this.Telacdfun_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarf;
        private System.Windows.Forms.Button deletarf;
        private System.Windows.Forms.Button voltarcdf;
        private System.Windows.Forms.TextBox IDfun;
        private System.Windows.Forms.TextBox nomefun;
        private System.Windows.Forms.MaskedTextBox cpffun;
        private System.Windows.Forms.TextBox rgfun;
        private System.Windows.Forms.MaskedTextBox telefonefun;
        private System.Windows.Forms.TextBox emailfun;
        private System.Windows.Forms.MaskedTextBox datanasfun;
        private System.Windows.Forms.TextBox enderecofun;
        private System.Windows.Forms.TextBox cidadefun;
        private System.Windows.Forms.ComboBox estadofun;
        private System.Windows.Forms.TextBox salariofun;
        private System.Windows.Forms.TextBox funcaofun;
        private System.Windows.Forms.TextBox cepfun;
    }
}