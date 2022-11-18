using System.Windows.Forms;

namespace Tpi_G5_Domus
{
    public partial class Form1 : Form
    {
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

            Label lblTitulo = new Label();
            lblTitulo.Size = new Size(140, 20);
            lblTitulo.Parent = panelder;
            lblTitulo.Text = "Oficina Virtual";
            lblTitulo.Font = new Font(Name = "Calibri", 14);
            lblTitulo.Location = new Point(130, 100);
            //lblTitulo.SendToBack();
            panelder.Controls.Add(lblTitulo);
            
            TextBox txtusuario = new TextBox();
            txtusuario.Size = new Size(125, 40);
            //txtusuario.BringToFront();
            txtusuario.Parent = panelder;
            txtusuario.PlaceholderText = "Ingrese su Usuario";
            txtusuario.Font = new Font(Name = "Calibri", 10);      
            txtusuario.Location = new Point(130, 130);
            txtusuario.BackColor= Color.FromArgb(237, 238, 239);
            txtusuario.PlaceholderText = "Ingrese su Usuario";
            panelder.Controls.Add (txtusuario);
            
            TextBox txtpassword = new TextBox();
            txtpassword.Size = new Size(125, 40);
            txtpassword.Parent = panelder;
            txtpassword.PlaceholderText = "Ingrese su Password";
            txtpassword.Font = new Font(Name = "Calibri", 10);
            txtpassword.Location = new Point(130, 160);
            txtpassword.BackColor = Color.FromArgb(237, 238, 239);
            txtpassword.PasswordChar = '*';
            panelder.Controls.Add(txtpassword);

            Button btniniciosesion= new Button();
            btniniciosesion.Size = new Size(125, 28);
            btniniciosesion.FlatStyle= FlatStyle.Flat;
            btniniciosesion.ForeColor = SystemColors.ButtonHighlight;
            btniniciosesion.Location = new Point(130, 195);
            btniniciosesion.BackColor = Color.FromArgb(54, 85, 184);
            btniniciosesion.Text = "Iniciar Sesion";
            btniniciosesion.UseVisualStyleBackColor = false;
        
            panelder.Controls.Add(btniniciosesion);
        }


    }
}