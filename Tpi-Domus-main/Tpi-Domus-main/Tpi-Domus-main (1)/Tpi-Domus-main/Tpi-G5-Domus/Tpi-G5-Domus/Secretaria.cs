using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tpi_G5_Domus
{
    public partial class Secretaria : Form
    {

        public static string idclient;
        public static string nombre;
        public static string apellido;
        public static string email;
        private Form padre;


        public Secretaria(Form padre)
        {
            InitializeComponent();
            this.padre = padre;
        }

        private void btnclientenuevo_Click(object sender, EventArgs e)
        {

            panelclientenuevo.Enabled = false;
            panelclienteregistrado.Enabled = false;
            panelsubclientenuevo.Enabled = false;
            panelsubclienteregistrado.Enabled = false;
            btnnuevoclientereg.Enabled = false;
            btnclientenuevo.Enabled = false;

            AbrirFormularioHijo(new AgendarCita("Cliente Nuevo","Apellido","Email"));
        
        }

        private void btnnuevoclientereg_Click(object sender, EventArgs e)
        {

            panelclientenuevo.Enabled = false;
            panelclienteregistrado.Enabled = false;
            panelsubclientenuevo.Enabled = false;
            panelsubclienteregistrado.Enabled = false;
            btnclientenuevo.Enabled = false;
            btnnuevoclientereg.Enabled = false;
            panelbuscarid.Visible = true;
        
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {

            SearchClientId();

        }

        private int idcliente;
        private void tbidcliente_TextChanged(object sender, EventArgs e)
        {
            
            Int32.TryParse(tbidcliente.Text, out idcliente);
        
        }

        private void tbidcliente_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                btnbuscar.Focus();
            }

        }
        public string connection = "Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb";

        public void SearchClientId()
        {

            MySqlConnection conn = new MySqlConnection(connection);
            conn.ConnectionString = connection;
            conn.Open();
            
            try
            {

                string consultausuario = "select * from cliente where idCliente='" + tbidcliente.Text + "'";
                MySqlCommand cmd = new MySqlCommand(consultausuario, conn);
                MySqlDataReader reader = cmd.ExecuteReader();



                if (reader.HasRows==true ) 
                {
                  
                    Secretaria.idclient = tbidcliente.Text;
                    while (reader.Read()) 
                    {
                        Secretaria.nombre = reader.GetString("Nombre");
                        Secretaria.apellido = reader.GetString("Apellido");
                        Secretaria.email = reader.GetString("email");
                    }

                    reader.Close();
                    MessageBox.Show("Cliente encontrado","Domus", MessageBoxButtons.OK);
                    AbrirFormularioHijo(new AgendarCita(Secretaria.nombre,Secretaria.apellido,Secretaria.email));

                }
             
            }

            catch (Exception e)
            {
                MessageBox.Show("Error: Cliente no encontrado!!" + e);
            }


        }

        private Form formularioActivo = null;
        private void AbrirFormularioHijo(Form formularioHijo) 
        {

            if (formularioActivo != null) 
                formularioActivo.Close();
            
            formularioActivo=formularioHijo;
            formularioHijo.TopLevel = false;
            formularioHijo.FormBorderStyle = FormBorderStyle.None;
            formularioHijo.Dock = DockStyle.Fill;
            panelcontenedor.Controls.Add(formularioHijo);
            panelcontenedor.Tag = formularioHijo;
            formularioHijo.BringToFront();
            formularioHijo.Show();

        }

        private void Secretaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Close();
        }
    }

}