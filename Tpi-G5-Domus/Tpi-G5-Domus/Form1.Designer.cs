namespace Tpi_G5_Domus
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelizq = new System.Windows.Forms.Panel();
            this.btningreso = new System.Windows.Forms.Button();
            this.lblfrase = new System.Windows.Forms.Label();
            this.lbltittle = new System.Windows.Forms.Label();
            this.panelder = new System.Windows.Forms.Panel();
            this.panelizq.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelizq
            // 
            this.panelizq.Controls.Add(this.btningreso);
            this.panelizq.Controls.Add(this.lblfrase);
            this.panelizq.Controls.Add(this.lbltittle);
            this.panelizq.Location = new System.Drawing.Point(3, 1);
            this.panelizq.Name = "panelizq";
            this.panelizq.Size = new System.Drawing.Size(383, 449);
            this.panelizq.TabIndex = 0;
            // 
            // btningreso
            // 
            this.btningreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(85)))), ((int)(((byte)(184)))));
            this.btningreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btningreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btningreso.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btningreso.Location = new System.Drawing.Point(257, 215);
            this.btningreso.Name = "btningreso";
            this.btningreso.Size = new System.Drawing.Size(75, 28);
            this.btningreso.TabIndex = 2;
            this.btningreso.Text = "Ingresar";
            this.btningreso.UseVisualStyleBackColor = false;
            this.btningreso.Click += new System.EventHandler(this.btningreso_Click);
            // 
            // lblfrase
            // 
            this.lblfrase.AutoSize = true;
            this.lblfrase.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblfrase.Location = new System.Drawing.Point(40, 168);
            this.lblfrase.Name = "lblfrase";
            this.lblfrase.Size = new System.Drawing.Size(279, 17);
            this.lblfrase.TabIndex = 1;
            this.lblfrase.Text = "Propiedad exclusiva , acesoramiento personal.";
            // 
            // lbltittle
            // 
            this.lbltittle.AutoSize = true;
            this.lbltittle.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbltittle.Location = new System.Drawing.Point(37, 77);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(139, 50);
            this.lbltittle.TabIndex = 0;
            this.lbltittle.Text = "Domus";
            // 
            // panelder
            // 
            this.panelder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelder.BackgroundImage")));
            this.panelder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelder.Location = new System.Drawing.Point(392, 1);
            this.panelder.Name = "panelder";
            this.panelder.Size = new System.Drawing.Size(409, 449);
            this.panelder.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(237)))), ((int)(((byte)(239)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelder);
            this.Controls.Add(this.panelizq);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Domus";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelizq.ResumeLayout(false);
            this.panelizq.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelizq;
        private Button btningreso;
        private Label lblfrase;
        private Label lbltittle;
        private Panel panelder;
        private TextBox tbprueba;
    }
}