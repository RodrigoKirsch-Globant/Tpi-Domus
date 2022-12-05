namespace Tpi_G5_Domus
{
    partial class AgendarCita
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblcita = new System.Windows.Forms.Label();
            this.lblaginmob = new System.Windows.Forms.Label();
            this.lblidprop = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbaginmob = new System.Windows.Forms.ComboBox();
            this.tbidprop = new System.Windows.Forms.TextBox();
            this.btnagendarcita = new System.Windows.Forms.Button();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblapellido = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbapellido = new System.Windows.Forms.TextBox();
            this.tbemail = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcita
            // 
            this.lblcita.AutoSize = true;
            this.lblcita.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcita.Location = new System.Drawing.Point(378, 29);
            this.lblcita.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblcita.Name = "lblcita";
            this.lblcita.Size = new System.Drawing.Size(495, 38);
            this.lblcita.TabIndex = 0;
            this.lblcita.Text = "Seleccione un dia y horario para la cita";
            // 
            // lblaginmob
            // 
            this.lblaginmob.AutoSize = true;
            this.lblaginmob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblaginmob.Location = new System.Drawing.Point(428, 217);
            this.lblaginmob.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblaginmob.Name = "lblaginmob";
            this.lblaginmob.Size = new System.Drawing.Size(383, 32);
            this.lblaginmob.TabIndex = 1;
            this.lblaginmob.Text = "Seleccione un agente inmobiliario:";
            // 
            // lblidprop
            // 
            this.lblidprop.AutoSize = true;
            this.lblidprop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblidprop.Location = new System.Drawing.Point(428, 412);
            this.lblidprop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblidprop.Name = "lblidprop";
            this.lblidprop.Size = new System.Drawing.Size(378, 32);
            this.lblidprop.TabIndex = 2;
            this.lblidprop.Text = "Ingrese el codigo de la propiedad:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(458, 127);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(325, 31);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 5, 0, 0, 0, 0);
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // cbaginmob
            // 
            this.cbaginmob.FormattingEnabled = true;
            this.cbaginmob.Location = new System.Drawing.Point(468, 323);
            this.cbaginmob.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbaginmob.Name = "cbaginmob";
            this.cbaginmob.Size = new System.Drawing.Size(325, 33);
            this.cbaginmob.TabIndex = 4;
            this.cbaginmob.Text = "Seleccione un Agente Inmobiliario";
            this.cbaginmob.SelectedIndexChanged += new System.EventHandler(this.cbaginmob_SelectedIndexChanged);
            // 
            // tbidprop
            // 
            this.tbidprop.Location = new System.Drawing.Point(468, 500);
            this.tbidprop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbidprop.Name = "tbidprop";
            this.tbidprop.Size = new System.Drawing.Size(325, 31);
            this.tbidprop.TabIndex = 5;
            this.tbidprop.TextChanged += new System.EventHandler(this.tbidprop_TextChanged);
            // 
            // btnagendarcita
            // 
            this.btnagendarcita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.btnagendarcita.FlatAppearance.BorderSize = 0;
            this.btnagendarcita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagendarcita.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnagendarcita.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnagendarcita.Location = new System.Drawing.Point(555, 616);
            this.btnagendarcita.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnagendarcita.Name = "btnagendarcita";
            this.btnagendarcita.Size = new System.Drawing.Size(183, 62);
            this.btnagendarcita.TabIndex = 6;
            this.btnagendarcita.Text = "Agendar Cita";
            this.btnagendarcita.UseVisualStyleBackColor = false;
            this.btnagendarcita.Click += new System.EventHandler(this.btnagendarcita_Click);
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(28, 68);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(59, 25);
            this.lblnombre.TabIndex = 7;
            this.lblnombre.Text = "label1";
            // 
            // lblapellido
            // 
            this.lblapellido.AutoSize = true;
            this.lblapellido.Location = new System.Drawing.Point(32, 157);
            this.lblapellido.Name = "lblapellido";
            this.lblapellido.Size = new System.Drawing.Size(59, 25);
            this.lblapellido.TabIndex = 8;
            this.lblapellido.Text = "label2";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(28, 243);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(59, 25);
            this.lblemail.TabIndex = 9;
            this.lblemail.Text = "label3";
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(36, 107);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.PlaceholderText = "Ingrese el nombre del cliente";
            this.tbnombre.Size = new System.Drawing.Size(238, 31);
            this.tbnombre.TabIndex = 10;
            this.tbnombre.Visible = false;
            // 
            // tbapellido
            // 
            this.tbapellido.Location = new System.Drawing.Point(39, 201);
            this.tbapellido.Name = "tbapellido";
            this.tbapellido.PlaceholderText = "Ingrese el apellido del cliente";
            this.tbapellido.Size = new System.Drawing.Size(235, 31);
            this.tbapellido.TabIndex = 11;
            this.tbapellido.Visible = false;
            // 
            // tbemail
            // 
            this.tbemail.Location = new System.Drawing.Point(35, 285);
            this.tbemail.Name = "tbemail";
            this.tbemail.PlaceholderText = "Ingrese el email";
            this.tbemail.Size = new System.Drawing.Size(228, 31);
            this.tbemail.TabIndex = 12;
            this.tbemail.Visible = false;
            // 
            // AgendarCita
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(917, 720);
            this.Controls.Add(this.tbemail);
            this.Controls.Add(this.tbapellido);
            this.Controls.Add(this.tbnombre);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblapellido);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.btnagendarcita);
            this.Controls.Add(this.tbidprop);
            this.Controls.Add(this.cbaginmob);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblidprop);
            this.Controls.Add(this.lblaginmob);
            this.Controls.Add(this.lblcita);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AgendarCita";
            this.Text = "AgendarCita";
            this.Load += new System.EventHandler(this.AgendarCita_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblcita;
        private Label lblaginmob;
        private Label lblidprop;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbaginmob;
        private TextBox tbidprop;
        private Button btnagendarcita;
        private Label lblnombre;
        private Label lblapellido;
        private Label lblemail;
        private TextBox tbnombre;
        private TextBox tbapellido;
        private TextBox tbemail;
    }
}