﻿namespace AtvPo4bim
{
    partial class TelaListaFun
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
            this.botcdfun = new System.Windows.Forms.Button();
            this.Botvoltarf = new System.Windows.Forms.Button();
            this.dtlistafuncionario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtlistafuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // botcdfun
            // 
            this.botcdfun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botcdfun.Location = new System.Drawing.Point(567, 342);
            this.botcdfun.Name = "botcdfun";
            this.botcdfun.Size = new System.Drawing.Size(92, 23);
            this.botcdfun.TabIndex = 0;
            this.botcdfun.UseVisualStyleBackColor = true;
            this.botcdfun.Click += new System.EventHandler(this.botcdfun_Click);
            // 
            // Botvoltarf
            // 
            this.Botvoltarf.Location = new System.Drawing.Point(3, -1);
            this.Botvoltarf.Name = "Botvoltarf";
            this.Botvoltarf.Size = new System.Drawing.Size(29, 23);
            this.Botvoltarf.TabIndex = 1;
            this.Botvoltarf.UseVisualStyleBackColor = true;
            this.Botvoltarf.Click += new System.EventHandler(this.Botvoltarf_Click);
            // 
            // dtlistafuncionario
            // 
            this.dtlistafuncionario.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtlistafuncionario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtlistafuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtlistafuncionario.Location = new System.Drawing.Point(23, 35);
            this.dtlistafuncionario.Name = "dtlistafuncionario";
            this.dtlistafuncionario.RowHeadersWidth = 51;
            this.dtlistafuncionario.RowTemplate.Height = 24;
            this.dtlistafuncionario.Size = new System.Drawing.Size(636, 288);
            this.dtlistafuncionario.TabIndex = 2;
            this.dtlistafuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtlistafuncionario_CellContentClick);
            // 
            // TelaListaFun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtvPo4bim.Properties.Resources.lista_funcd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 377);
            this.Controls.Add(this.dtlistafuncionario);
            this.Controls.Add(this.Botvoltarf);
            this.Controls.Add(this.botcdfun);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaListaFun";
            this.Text = "TelaListaFun";
            this.Load += new System.EventHandler(this.TelaListaFun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtlistafuncionario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botcdfun;
        private System.Windows.Forms.Button Botvoltarf;
        private System.Windows.Forms.DataGridView dtlistafuncionario;
    }
}