using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtvPo4bim
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            BotaoFun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BotaoFun.FlatAppearance.BorderSize = 0;
            BotaoFun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotaoFun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotaoFun.BackColor = Color.Transparent;

            BotaoEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            BotaoEmp.FlatAppearance.BorderSize = 0;
            BotaoEmp.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BotaoEmp.FlatAppearance.MouseOverBackColor = Color.Transparent;
            BotaoEmp.BackColor = Color.Transparent;
            
            fechartd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            fechartd.FlatAppearance.BorderSize = 0;
            fechartd.FlatAppearance.MouseDownBackColor = Color.Transparent;
            fechartd.FlatAppearance.MouseOverBackColor = Color.Transparent;
            fechartd.BackColor = Color.Transparent;


        }

        private void BotaoFun_Click(object sender, EventArgs e)
        {
            TelaListaFun TLF = new TelaListaFun();
            TLF.ShowDialog();
        }

        private void fechartd_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
