namespace Tpi_G5_Domus
{
    partial class Catalogo
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
            this.lbltitulocat = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btncerrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbltitulocat
            // 
            this.lbltitulocat.AutoSize = true;
            this.lbltitulocat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.lbltitulocat.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltitulocat.Location = new System.Drawing.Point(17, 15);
            this.lbltitulocat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitulocat.Name = "lbltitulocat";
            this.lbltitulocat.Size = new System.Drawing.Size(379, 45);
            this.lbltitulocat.TabIndex = 0;
            this.lbltitulocat.Text = "Catalogo de Propiedades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(40, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(665, 596);
            this.dataGridView1.TabIndex = 1;
            // 
            // btncerrar
            // 
            this.btncerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(238)))));
            this.btncerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncerrar.Location = new System.Drawing.Point(802, 23);
            this.btncerrar.Name = "btncerrar";
            this.btncerrar.Size = new System.Drawing.Size(112, 41);
            this.btncerrar.TabIndex = 2;
            this.btncerrar.Text = "Volver";
            this.btncerrar.UseVisualStyleBackColor = false;
            this.btncerrar.Click += new System.EventHandler(this.btncerrar_Click);
            // 
            // Catalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(250)))), ((int)(((byte)(249)))));
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btncerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbltitulocat);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Catalogo";
            this.Text = "Catalogo";
            this.Load += new System.EventHandler(this.Catalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbltitulocat;
        private DataGridView dataGridView1;
        private Button btncerrar;
    }
}