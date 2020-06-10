using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Operaciones_Web.Inicio
{
    public partial class Web_Operaciones : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btbidentificar_Click(object sender, EventArgs e)
        {
            

          
            Tarea_operaciones.Operaciones M = new Tarea_operaciones.Operaciones();
            double num;
            string s;
            num = double.Parse(this.Txtmostrar.Text);
            s = M.paroinpar(num, "");
            this.Txtmostrar3.Text = s;
        }

        protected void btbidentificar1_Click(object sender, EventArgs e)
        {
            Tarea_operaciones.Operaciones M = new Tarea_operaciones.Operaciones();
            double num;
            string s;
            num = double.Parse(this.Txtmostrar1.Text);
            s = M.mes(num, "");
            this.Txtmostrar2.Text = s;
        }
    }
}