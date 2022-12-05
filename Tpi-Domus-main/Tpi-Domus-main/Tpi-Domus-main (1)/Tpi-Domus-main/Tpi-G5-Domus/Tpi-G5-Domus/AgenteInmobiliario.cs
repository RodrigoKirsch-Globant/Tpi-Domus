using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpi_G5_Domus
{
    public partial class AgenteInmobiliario : Form
    {
        private Form padre;
        public AgenteInmobiliario(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btncatalogo_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Catalogo());
        }

        private Form formularioActivo = null;

        private void AbrirFormularioHijo(Form FormularioHijo) 
        {

            if (formularioActivo != null)
                formularioActivo.Close();

            formularioActivo = FormularioHijo;
            FormularioHijo.TopLevel = false;
            FormularioHijo.FormBorderStyle= FormBorderStyle.None;
            FormularioHijo.Dock = DockStyle.Fill;
            panel1.Controls.Add(FormularioHijo);
            panel1.Tag = FormularioHijo;
            FormularioHijo.BringToFront();
            FormularioHijo.Show();

        }

        private void AgenteInmobiliario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Close();
        }

    }

}