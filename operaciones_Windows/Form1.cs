using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace operaciones_Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btbMostrar_Click(object sender, EventArgs e)
        {
            Tarea_operaciones.Operaciones M = new Tarea_operaciones.Operaciones();
            double num;
            string s;
            num = double.Parse(this.txtingresar.Text);
            s = M.paroinpar(num,"");
            MessageBox.Show(s);
           
        }

        private void txtresultado_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtresultado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btbmostratmes_Click(object sender, EventArgs e)
        {
            Tarea_operaciones.Operaciones M = new Tarea_operaciones.Operaciones();
            double b;
            string v;
            b = double.Parse(this.txtmes.Text);
            v = M.mes(b, "");
            MessageBox.Show(v);
        }
    }
}
