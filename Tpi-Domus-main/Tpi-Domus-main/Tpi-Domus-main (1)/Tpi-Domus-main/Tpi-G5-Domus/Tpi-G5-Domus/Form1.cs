using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Tpi_G5_Domus
{
    public partial class Form1 : Form
    {
        public string connection="";
        public static string idusuario;
        public static string nombreUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btningreso_Click(object sender, EventArgs e)
        {
            panelder.BackgroundImage = null;
            lblTitulo.Visible= true;
            tbusuario.Visible= true;
            tbcontraseña.Visible= true;
            btniniciosesion.Visible= true;
            btnlupa.Visible = true;
        }

        private void btniniciosesion_Click(object sender, EventArgs e)
        {

            login();

        }

        private void login()
        {
            connection = "Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb";
            MySqlConnection conn = new MySqlConnection(connection);
            conn.ConnectionString = connection;
            conn.Open();
            try
            {

                string rol = "0";
                string consulta = "select nombreUsuario from usuario where nombreUsuario='"+tbusuario.Text+"'and password='"+tbcontraseña.Text+"'";
                MySqlCommand cmd = new MySqlCommand(consulta, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                //------
                //
                //------
                string consulta2 = "select idUsuario from  usuario where nombreUsuario='"+tbusuario.Text +"'";
                MySqlCommand comando2 = new MySqlCommand(consulta2, conn);

                if (reader.HasRows == true)
                {
                    reader.Close();
                    Form1.idusuario = Convert.ToString(comando2.ExecuteScalar());
                    Form1.nombreUsuario = tbusuario.Text;
                    rol = cmd.ExecuteScalar().ToString();
                    if (rol == "Secretaria")
                    {
                        Secretaria secretaria = new Secretaria(this);
                        secretaria.Show();
                        this.Hide();
                    }
                    if (rol == "Agente Inmobiliario")
                    {
                        AgenteInmobiliario agente = new AgenteInmobiliario(this);
                        agente.Show();
                        this.Hide();
                    }


                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                conn.Close();
            }
            catch (Exception e) 
            {
                MessageBox.Show("Error" + e);
            }
        
        }

        private int usuario=0;
        private int contraseña=0;

        private void tbusuario_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbusuario.Text, out usuario);
        }

        private void tbcontraseña_TextChanged(object sender, EventArgs e)
        {
            Int32.TryParse(tbcontraseña.Text,out contraseña);
        }

        private void tbusuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                tbcontraseña.Focus();
            }
        }

        private void tbcontraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter)) 
            {
                btniniciosesion.Focus();
            }
        }

        private void btnlupa_Click(object sender, EventArgs e)
        {
            //tbcontraseña.UseSystemPasswordChar = !tbcontraseña.UseSystemPasswordChar;
            if (tbcontraseña.PasswordChar == '*')
            {
                tbcontraseña.PasswordChar = '\0';
            }
            else
            {
                tbcontraseña.PasswordChar = '*';
            }
            tbcontraseña.Focus();

        }
    }
}