using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Tpi_G5_Domus
{
    public partial class AgendarCita : Form
    {
        public static string idcita;
        public static string idcliente;
        private static string fecha;
        DateTime dateTime;

        public AgendarCita(String nombre, String Apellido, String email)
        {
            InitializeComponent();
            lblnombre.Text = "Nombre: " + nombre;
            lblapellido.Text = "Apellido: " + Apellido;
            lblemail.Text = "Email: " + email;
        }


        private void tbidprop_TextChanged(object sender, EventArgs e)
        {
            //MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
            //string querytb = "Select * from propiedad where idPropiedad='" +tbidprop.Text+"'";
            //conn.Open();
            //MySqlCommand command=new MySqlCommand(querytb,conn);

        }

        private void btnagendarcita_Click(object sender, EventArgs e)
        {
            checknullvalues();
            

 
        }

        private void checknullvalues()
        {

            if (cbaginmob.SelectedText == "" && tbidprop.Text == "" )
            {
                if (tbnombre.Visible == true && tbapellido.Visible == true && tbemail.Visible == true)
                {
                    if (tbnombre.Text == "" || tbapellido.Text == "" || tbemail.Text == "")
                    {
                        MessageBox.Show("Faltan por ingresar valores", "Domus", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                MessageBox.Show("Faltan por ingresar valores", "Domus", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else 
            {
                agendarCita();
            }
        }

        private void AgendarCita_Load(object sender, EventArgs e)
        {
            if (lblnombre.Text == "Nombre: Cliente Nuevo" && lblapellido.Text == "Apellido: Apellido" && lblemail.Text == "Email: Email")
            {
                lblnombre.Text = "Nombre: ";
                lblapellido.Text = "Apellido: ";
                lblemail.Text = "Email: ";
            }           
            cargarAgentes();
            StatusCheck();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           dateTime=dateTimePicker1.Value;
        }

        private void cargarAgentes()
        {
            try
            {
                //lblnombrecliente.Text = Secretaria.nombre;
                //lblapellidocliente.Text = Secretaria.apellido;
                //lblemailcliente.Text = Secretaria.email;
                MySqlConnection conn = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
                string query = "Select * from usuario where nombreUsuario='Agente Inmobiliario'";
                conn.Open();
                MySqlCommand command = new MySqlCommand(query, conn);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    cbaginmob.Items.Add(reader.GetString("Apellido") + " " + reader.GetString("Nombre"));
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void StatusCheck()
        {
            if (lblnombre.Text == "Nombre: " && lblapellido.Text == "Apellido: " && lblemail.Text == "Email: ")
            {
                tbnombre.Visible = true;
                tbapellido.Visible = true;
                tbemail.Visible = true;
            }
            else
            {
                tbnombre.Visible = false;
                tbapellido.Visible = false;
                tbemail.Visible = false;
            }
        }

        private  int idagenda = 0;
        private  static int iduser = 0;
        private void agendarCita()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
            try
            {
                insertacliente();
                insertacita();
                traerCliente();
                traercita();
                mySqlConnection.Open();
                DateTime dt2 = dateTimePicker1.Value;
                int userfk = AgendarCita.iduser;
                int clientfk=Int32.Parse(idcliente);
                int propfk=Int32.Parse(tbidprop.Text);
                int citafk=Int32.Parse(idcita);
                string query = @"insert into asigna (idclientefk,idusuariofk,idpropfk,idcitafk,f_asignacion) values ('" +clientfk + "','" + userfk + "','" +propfk + "','" +citafk  + "','"+dt2.ToString("yyyy/MM/dd")+"')";

                MySqlCommand mySqlCommand = new MySqlCommand(query, mySqlConnection);

                mySqlCommand.ExecuteNonQuery();

                MessageBox.Show("Se ha insertado la cita correctamente", "Domus", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }

        }

        private void insertacita()
        {
            try
            {
                MySqlConnection mySqlConnection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
                if (dateTime != null)
                {
                    DateTime datetime2 = dateTimePicker1.Value;
                    selectedAgin();
                    mySqlConnection.Open();
                    string consultacita = @"insert into cita (Id_agendafk,Fecha_hora) values ('" + idagenda + "','" + datetime2.ToString("yyyy/MM/dd") + "')";
                    MySqlCommand mySqlCommand = new MySqlCommand(consultacita, mySqlConnection);

                    mySqlCommand.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }

        }

        private void selectedAgin()
        {
            if (cbaginmob.SelectedIndex == 0)
            {
                AgendarCita.iduser = 4;
                idagenda = 1;
            }
            else if (cbaginmob.SelectedIndex == 1)
            {
                AgendarCita.iduser = 5;
                idagenda = 2;
            }
            else if (cbaginmob.SelectedIndex == 2)
            {
                AgendarCita.iduser = 6;
                idagenda=3;
            }
        }

        private void insertacliente()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
            if (tbnombre.Visible == true && tbapellido.Visible == true && tbemail.Visible == true)
            {
                try
                {
                    mySqlConnection.Open();
                    string consultainserta = @"insert into cliente (Nombre,Apellido,Email) values ('" + tbnombre.Text + "','" + tbapellido.Text + "','" + tbemail.Text + "')";
                    MySqlCommand cmd = new MySqlCommand(consultainserta, mySqlConnection);

                    cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error");
                }
            }
        }

        private void traerCliente()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
            try
            {
                if (tbnombre.Visible == true && tbapellido.Visible == true && tbemail.Visible == true)
                {

                    string consultacliente = @"Select idCliente from cliente where Nombre='" + tbnombre.Text + "' and Apellido='" + tbapellido.Text + "' and Email='" + tbemail.Text + "'";
                    mySqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(consultacliente, mySqlConnection);
                    MySqlDataReader mySqlDataReader = command.ExecuteReader();

                    while (mySqlDataReader.Read())
                    {
                        AgendarCita.idcliente = mySqlDataReader.GetString("idCliente");

                    }

                }
                else if (tbnombre.Visible == false && tbapellido.Visible == false && tbemail.Visible == false)
                {
                    string consultacliente = @"Select idCliente from cliente where Nombre='" + Secretaria.nombre + "' and Apellido='" + Secretaria.apellido + "' and Email='" + Secretaria.email + "'";
                    mySqlConnection.Open();
                    MySqlCommand command = new MySqlCommand(consultacliente, mySqlConnection);
                    MySqlDataReader mySqlDataReader = command.ExecuteReader();
                    while (mySqlDataReader.Read())
                    {
                        AgendarCita.idcliente = mySqlDataReader.GetString("idCliente");

                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error");
            }
        }

        private void traercita()
        {
            MySqlConnection mySqlConnection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
            try
            {
                string consultaprop = @"Select idCita from cita where Id_agendafk='" + idagenda.ToString() + "'";
                mySqlConnection.Open();
                MySqlCommand mySqlCommand = new MySqlCommand(consultaprop, mySqlConnection);
                MySqlDataReader mySqlDataReader = mySqlCommand.ExecuteReader();

                while (mySqlDataReader.Read())
                {
                    AgendarCita.idcita = mySqlDataReader.GetString("idCita");
                }
    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void cbaginmob_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedAgin();
        }
    }
}