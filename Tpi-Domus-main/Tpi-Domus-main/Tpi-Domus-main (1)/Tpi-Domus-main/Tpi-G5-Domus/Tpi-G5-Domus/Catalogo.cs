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
    public partial class Catalogo : Form
    {
        public Catalogo()
        {
            InitializeComponent();
        }
        MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;uid=root;port=3306;pwd=rendezvous;database=mydb");
        MySqlDataAdapter adapter;
        DataTable dt=new DataTable();
        string consulta;

        private void Catalogo_Load(object sender, EventArgs e)
        {
            consulta = "select * from propiedad";
            adapter=new MySqlDataAdapter(consulta,connection);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
