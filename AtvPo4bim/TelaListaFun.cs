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
    public partial class TelaListaFun : Form
    {
        public TelaListaFun()
        {
            InitializeComponent();

            botcdfun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            botcdfun.FlatAppearance.BorderSize = 0;
            botcdfun.FlatAppearance.MouseDownBackColor = Color.Transparent;
            botcdfun.FlatAppearance.MouseOverBackColor = Color.Transparent;
            botcdfun.BackColor = Color.Transparent; 

            Botvoltarf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            Botvoltarf.FlatAppearance.BorderSize = 0;
            Botvoltarf.FlatAppearance.MouseDownBackColor = Color.Transparent;
            Botvoltarf.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Botvoltarf.BackColor = Color.Transparent;
        }

        private void botcdfun_Click(object sender, EventArgs e)
        {
            Telacdfun TCDF = new Telacdfun();
            TCDF.ShowDialog();
        }

        private void Botvoltarf_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
