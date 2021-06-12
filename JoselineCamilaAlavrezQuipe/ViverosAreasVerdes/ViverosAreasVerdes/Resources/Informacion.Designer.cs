
namespace ViverosAreasVerdes.Resources
{
    partial class Informacion
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.InfNombreVivero = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IDEmpre = new System.Windows.Forms.Label();
            this.cantidadViveros = new System.Windows.Forms.Label();
            this.municipioEmpr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // InfNombreVivero
            // 
            this.InfNombreVivero.AutoSize = true;
            this.InfNombreVivero.Font = new System.Drawing.Font("Showcard Gothic", 24F);
            this.InfNombreVivero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(115)))), ((int)(((byte)(107)))));
            this.InfNombreVivero.Location = new System.Drawing.Point(298, 60);
            this.InfNombreVivero.Name = "InfNombreVivero";
            this.InfNombreVivero.Size = new System.Drawing.Size(275, 60);
            this.InfNombreVivero.TabIndex = 0;
            this.InfNombreVivero.Text = "EMAVERDE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.IDEmpre);
            this.panel1.Controls.Add(this.cantidadViveros);
            this.panel1.Controls.Add(this.municipioEmpr);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(130, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 273);
            this.panel1.TabIndex = 1;
            // 
            // IDEmpre
            // 
            this.IDEmpre.AutoSize = true;
            this.IDEmpre.BackColor = System.Drawing.Color.Transparent;
            this.IDEmpre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDEmpre.ForeColor = System.Drawing.Color.Black;
            this.IDEmpre.Location = new System.Drawing.Point(375, 47);
            this.IDEmpre.Name = "IDEmpre";
            this.IDEmpre.Size = new System.Drawing.Size(180, 35);
            this.IDEmpre.TabIndex = 7;
            this.IDEmpre.Text = "___________";
            // 
            // cantidadViveros
            // 
            this.cantidadViveros.AutoSize = true;
            this.cantidadViveros.BackColor = System.Drawing.Color.Transparent;
            this.cantidadViveros.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadViveros.ForeColor = System.Drawing.Color.Black;
            this.cantidadViveros.Location = new System.Drawing.Point(525, 191);
            this.cantidadViveros.Name = "cantidadViveros";
            this.cantidadViveros.Size = new System.Drawing.Size(30, 35);
            this.cantidadViveros.TabIndex = 6;
            this.cantidadViveros.Text = "0";
            this.cantidadViveros.Click += new System.EventHandler(this.label6_Click);
            // 
            // municipioEmpr
            // 
            this.municipioEmpr.AutoSize = true;
            this.municipioEmpr.BackColor = System.Drawing.Color.Transparent;
            this.municipioEmpr.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.municipioEmpr.ForeColor = System.Drawing.Color.Black;
            this.municipioEmpr.Location = new System.Drawing.Point(375, 119);
            this.municipioEmpr.Name = "municipioEmpr";
            this.municipioEmpr.Size = new System.Drawing.Size(180, 35);
            this.municipioEmpr.TabIndex = 5;
            this.municipioEmpr.Text = "___________";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(54, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(333, 35);
            this.label2.TabIndex = 3;
            this.label2.Text = "CANTIDAD DE VIVEROS: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(54, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(180, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "MUNICIPIO: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID: ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(594, 455);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Cambiar Datos";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Informacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::ViverosAreasVerdes.Properties.Resources.fondo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.InfNombreVivero);
            this.Name = "Informacion";
            this.Size = new System.Drawing.Size(858, 555);
            this.Load += new System.EventHandler(this.Informacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label InfNombreVivero;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label IDEmpre;
        private System.Windows.Forms.Label cantidadViveros;
        private System.Windows.Forms.Label municipioEmpr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
