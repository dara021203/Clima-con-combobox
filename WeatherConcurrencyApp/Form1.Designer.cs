
namespace WeatherConcurrencyApp
{
    partial class FrmMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnOk = new System.Windows.Forms.Button();
            this.lbtemperatura = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbtempmax = new System.Windows.Forms.Label();
            this.lbtempmin = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbhumidity = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbDetalle = new System.Windows.Forms.Label();
            this.lbamanecer = new System.Windows.Forms.Label();
            this.lbviento = new System.Windows.Forms.Label();
            this.lbpresion = new System.Windows.Forms.Label();
            this.lbpuestadelsol = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 73);
            this.panel1.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(496, 21);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(127, 37);
            this.btnOk.TabIndex = 0;
            this.btnOk.Text = "Aceptar";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lbtemperatura
            // 
            this.lbtemperatura.AutoSize = true;
            this.lbtemperatura.BackColor = System.Drawing.Color.Transparent;
            this.lbtemperatura.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtemperatura.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtemperatura.Location = new System.Drawing.Point(581, 269);
            this.lbtemperatura.Name = "lbtemperatura";
            this.lbtemperatura.Size = new System.Drawing.Size(49, 23);
            this.lbtemperatura.TabIndex = 58;
            this.lbtemperatura.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label6.Location = new System.Drawing.Point(333, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 23);
            this.label6.TabIndex = 57;
            this.label6.Text = "Temperatura";
            // 
            // lbtempmax
            // 
            this.lbtempmax.AutoSize = true;
            this.lbtempmax.BackColor = System.Drawing.Color.Transparent;
            this.lbtempmax.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtempmax.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtempmax.Location = new System.Drawing.Point(581, 318);
            this.lbtempmax.Name = "lbtempmax";
            this.lbtempmax.Size = new System.Drawing.Size(49, 23);
            this.lbtempmax.TabIndex = 56;
            this.lbtempmax.Text = "N/A";
            // 
            // lbtempmin
            // 
            this.lbtempmin.AutoSize = true;
            this.lbtempmin.BackColor = System.Drawing.Color.Transparent;
            this.lbtempmin.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbtempmin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbtempmin.Location = new System.Drawing.Point(584, 367);
            this.lbtempmin.Name = "lbtempmin";
            this.lbtempmin.Size = new System.Drawing.Size(49, 23);
            this.lbtempmin.TabIndex = 55;
            this.lbtempmin.Text = "N/A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(12, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 23);
            this.label3.TabIndex = 42;
            this.label3.Text = "Puesta del sol";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(333, 367);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(207, 23);
            this.label11.TabIndex = 54;
            this.label11.Text = "Temperatura Minima";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label10.Location = new System.Drawing.Point(333, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(210, 23);
            this.label10.TabIndex = 53;
            this.label10.Text = "Temperatura Maxima";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label7.Location = new System.Drawing.Point(333, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 23);
            this.label7.TabIndex = 43;
            this.label7.Text = "Presion";
            // 
            // lbhumidity
            // 
            this.lbhumidity.AutoSize = true;
            this.lbhumidity.BackColor = System.Drawing.Color.Transparent;
            this.lbhumidity.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhumidity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbhumidity.Location = new System.Drawing.Point(156, 241);
            this.lbhumidity.Name = "lbhumidity";
            this.lbhumidity.Size = new System.Drawing.Size(49, 23);
            this.lbhumidity.TabIndex = 52;
            this.lbhumidity.Text = "N/A";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(333, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(207, 23);
            this.label8.TabIndex = 44;
            this.label8.Text = "Velocidad del viento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(12, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 23);
            this.label5.TabIndex = 51;
            this.label5.Text = "Humedad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label9.Location = new System.Drawing.Point(12, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 23);
            this.label9.TabIndex = 45;
            this.label9.Text = "Amanecer";
            // 
            // lbDetalle
            // 
            this.lbDetalle.AutoSize = true;
            this.lbDetalle.BackColor = System.Drawing.Color.Transparent;
            this.lbDetalle.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDetalle.Location = new System.Drawing.Point(173, 116);
            this.lbDetalle.Name = "lbDetalle";
            this.lbDetalle.Size = new System.Drawing.Size(0, 23);
            this.lbDetalle.TabIndex = 50;
            // 
            // lbamanecer
            // 
            this.lbamanecer.AutoSize = true;
            this.lbamanecer.BackColor = System.Drawing.Color.Transparent;
            this.lbamanecer.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbamanecer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbamanecer.Location = new System.Drawing.Point(156, 147);
            this.lbamanecer.Name = "lbamanecer";
            this.lbamanecer.Size = new System.Drawing.Size(49, 23);
            this.lbamanecer.TabIndex = 46;
            this.lbamanecer.Text = "N/A";
            // 
            // lbviento
            // 
            this.lbviento.AutoSize = true;
            this.lbviento.BackColor = System.Drawing.Color.Transparent;
            this.lbviento.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbviento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbviento.Location = new System.Drawing.Point(581, 147);
            this.lbviento.Name = "lbviento";
            this.lbviento.Size = new System.Drawing.Size(49, 23);
            this.lbviento.TabIndex = 47;
            this.lbviento.Text = "N/A";
            // 
            // lbpresion
            // 
            this.lbpresion.AutoSize = true;
            this.lbpresion.BackColor = System.Drawing.Color.Transparent;
            this.lbpresion.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpresion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbpresion.Location = new System.Drawing.Point(581, 205);
            this.lbpresion.Name = "lbpresion";
            this.lbpresion.Size = new System.Drawing.Size(49, 23);
            this.lbpresion.TabIndex = 48;
            this.lbpresion.Text = "N/A";
            // 
            // lbpuestadelsol
            // 
            this.lbpuestadelsol.AutoSize = true;
            this.lbpuestadelsol.BackColor = System.Drawing.Color.Transparent;
            this.lbpuestadelsol.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbpuestadelsol.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbpuestadelsol.Location = new System.Drawing.Point(156, 194);
            this.lbpuestadelsol.Name = "lbpuestadelsol";
            this.lbpuestadelsol.Size = new System.Drawing.Size(49, 23);
            this.lbpuestadelsol.TabIndex = 49;
            this.lbpuestadelsol.Text = "N/A";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(40, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 507);
            this.Controls.Add(this.lbtemperatura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbtempmax);
            this.Controls.Add(this.lbtempmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbhumidity);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbDetalle);
            this.Controls.Add(this.lbamanecer);
            this.Controls.Add(this.lbviento);
            this.Controls.Add(this.lbpresion);
            this.Controls.Add(this.lbpuestadelsol);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMain";
            this.Text = "Weather Async App";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lbtemperatura;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbtempmax;
        private System.Windows.Forms.Label lbtempmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbhumidity;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbDetalle;
        private System.Windows.Forms.Label lbamanecer;
        private System.Windows.Forms.Label lbviento;
        private System.Windows.Forms.Label lbpresion;
        private System.Windows.Forms.Label lbpuestadelsol;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

