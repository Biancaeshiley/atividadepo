namespace AtvPo4bim
{
    partial class TelaListaEmp
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
            this.botcdemp = new System.Windows.Forms.Button();
            this.voltarle = new System.Windows.Forms.Button();
            this.dgvEmpresa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).BeginInit();
            this.SuspendLayout();
            // 
            // botcdemp
            // 
            this.botcdemp.Location = new System.Drawing.Point(571, 341);
            this.botcdemp.Name = "botcdemp";
            this.botcdemp.Size = new System.Drawing.Size(100, 23);
            this.botcdemp.TabIndex = 0;
            this.botcdemp.UseVisualStyleBackColor = true;
            this.botcdemp.Click += new System.EventHandler(this.botcdemp_Click);
            // 
            // voltarle
            // 
            this.voltarle.Location = new System.Drawing.Point(2, 3);
            this.voltarle.Name = "voltarle";
            this.voltarle.Size = new System.Drawing.Size(35, 30);
            this.voltarle.TabIndex = 1;
            this.voltarle.UseVisualStyleBackColor = true;
            this.voltarle.Click += new System.EventHandler(this.voltarle_Click);
            // 
            // dgvEmpresa
            // 
            this.dgvEmpresa.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvEmpresa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpresa.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvEmpresa.Location = new System.Drawing.Point(17, 35);
            this.dgvEmpresa.Name = "dgvEmpresa";
            this.dgvEmpresa.RowHeadersWidth = 51;
            this.dgvEmpresa.RowTemplate.Height = 24;
            this.dgvEmpresa.Size = new System.Drawing.Size(650, 296);
            this.dgvEmpresa.TabIndex = 2;
            this.dgvEmpresa.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TelaListaEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::AtvPo4bim.Properties.Resources.lista_empcd;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 378);
            this.Controls.Add(this.dgvEmpresa);
            this.Controls.Add(this.voltarle);
            this.Controls.Add(this.botcdemp);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TelaListaEmp";
            this.Text = "TelaListaEmp";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmpresa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botcdemp;
        private System.Windows.Forms.Button voltarle;
        private System.Windows.Forms.DataGridView dgvEmpresa;
    }
}