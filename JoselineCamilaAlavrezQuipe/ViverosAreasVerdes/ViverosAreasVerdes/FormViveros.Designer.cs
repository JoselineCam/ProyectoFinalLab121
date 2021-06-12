
namespace ViverosAreasVerdes
{
    partial class FormViveros
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
            this.textBoxCodVivero = new System.Windows.Forms.TextBox();
            this.textBoxUbicaVivero = new System.Windows.Forms.TextBox();
            this.TextBoxSuperficie = new System.Windows.Forms.TextBox();
            this.textBoxAltitudVive = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridViewViveros = new System.Windows.Forms.DataGridView();
            this.butCambDat = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonMostrarAlmacigueras = new System.Windows.Forms.Button();
            this.buttonMostrarCamasDeRepique = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.superficie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.altitud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nroAlmacigueras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.camasRepique = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botonLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViveros)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCodVivero
            // 
            this.textBoxCodVivero.BackColor = System.Drawing.Color.White;
            this.textBoxCodVivero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxCodVivero.Enabled = false;
            this.textBoxCodVivero.Location = new System.Drawing.Point(23, 96);
            this.textBoxCodVivero.Name = "textBoxCodVivero";
            this.textBoxCodVivero.Size = new System.Drawing.Size(221, 26);
            this.textBoxCodVivero.TabIndex = 0;
            this.textBoxCodVivero.TextChanged += new System.EventHandler(this.textBoxCodVivero_TextChanged);
            // 
            // textBoxUbicaVivero
            // 
            this.textBoxUbicaVivero.BackColor = System.Drawing.Color.White;
            this.textBoxUbicaVivero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxUbicaVivero.Location = new System.Drawing.Point(23, 161);
            this.textBoxUbicaVivero.Name = "textBoxUbicaVivero";
            this.textBoxUbicaVivero.Size = new System.Drawing.Size(221, 26);
            this.textBoxUbicaVivero.TabIndex = 1;
            this.textBoxUbicaVivero.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // TextBoxSuperficie
            // 
            this.TextBoxSuperficie.BackColor = System.Drawing.Color.White;
            this.TextBoxSuperficie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBoxSuperficie.Location = new System.Drawing.Point(23, 226);
            this.TextBoxSuperficie.Name = "TextBoxSuperficie";
            this.TextBoxSuperficie.Size = new System.Drawing.Size(221, 26);
            this.TextBoxSuperficie.TabIndex = 2;
            // 
            // textBoxAltitudVive
            // 
            this.textBoxAltitudVive.BackColor = System.Drawing.Color.White;
            this.textBoxAltitudVive.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAltitudVive.Location = new System.Drawing.Point(23, 291);
            this.textBoxAltitudVive.Name = "textBoxAltitudVive";
            this.textBoxAltitudVive.Size = new System.Drawing.Size(221, 26);
            this.textBoxAltitudVive.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ubicacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Superficie:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Altitud:";
            // 
            // dataGridViewViveros
            // 
            this.dataGridViewViveros.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewViveros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewViveros.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridViewViveros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViveros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.ubicacion,
            this.superficie,
            this.altitud,
            this.nroAlmacigueras,
            this.camasRepique});
            this.dataGridViewViveros.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridViewViveros.Location = new System.Drawing.Point(331, 88);
            this.dataGridViewViveros.Name = "dataGridViewViveros";
            this.dataGridViewViveros.RowHeadersWidth = 62;
            this.dataGridViewViveros.RowTemplate.Height = 28;
            this.dataGridViewViveros.Size = new System.Drawing.Size(575, 594);
            this.dataGridViewViveros.TabIndex = 8;
            this.dataGridViewViveros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViveros_CellClick);
            this.dataGridViewViveros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewViveros_CellContentClick);
            // 
            // butCambDat
            // 
            this.butCambDat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.butCambDat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.butCambDat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.butCambDat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.butCambDat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCambDat.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCambDat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.butCambDat.Location = new System.Drawing.Point(28, 359);
            this.butCambDat.Name = "butCambDat";
            this.butCambDat.Size = new System.Drawing.Size(116, 46);
            this.butCambDat.TabIndex = 9;
            this.butCambDat.Text = "Añadir";
            this.butCambDat.UseVisualStyleBackColor = false;
            this.butCambDat.Click += new System.EventHandler(this.butCambDat_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.BackColor = System.Drawing.Color.White;
            this.textBoxBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxBuscar.Location = new System.Drawing.Point(510, 33);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(251, 26);
            this.textBoxBuscar.TabIndex = 10;
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
            this.button1.Location = new System.Drawing.Point(784, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 11;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(184, 359);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 46);
            this.button2.TabIndex = 12;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(184, 422);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 46);
            this.button3.TabIndex = 13;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonMostrarAlmacigueras
            // 
            this.buttonMostrarAlmacigueras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMostrarAlmacigueras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarAlmacigueras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMostrarAlmacigueras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.buttonMostrarAlmacigueras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarAlmacigueras.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarAlmacigueras.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrarAlmacigueras.Location = new System.Drawing.Point(20, 502);
            this.buttonMostrarAlmacigueras.Name = "buttonMostrarAlmacigueras";
            this.buttonMostrarAlmacigueras.Size = new System.Drawing.Size(280, 46);
            this.buttonMostrarAlmacigueras.TabIndex = 14;
            this.buttonMostrarAlmacigueras.Text = "Mostrar Almacigueras";
            this.buttonMostrarAlmacigueras.UseVisualStyleBackColor = false;
            this.buttonMostrarAlmacigueras.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonMostrarCamasDeRepique
            // 
            this.buttonMostrarCamasDeRepique.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.buttonMostrarCamasDeRepique.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMostrarCamasDeRepique.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMostrarCamasDeRepique.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.buttonMostrarCamasDeRepique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMostrarCamasDeRepique.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMostrarCamasDeRepique.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonMostrarCamasDeRepique.Location = new System.Drawing.Point(23, 572);
            this.buttonMostrarCamasDeRepique.Name = "buttonMostrarCamasDeRepique";
            this.buttonMostrarCamasDeRepique.Size = new System.Drawing.Size(280, 50);
            this.buttonMostrarCamasDeRepique.TabIndex = 15;
            this.buttonMostrarCamasDeRepique.Text = "Mostrar Camas De Repique";
            this.buttonMostrarCamasDeRepique.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(419, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 29);
            this.label5.TabIndex = 16;
            this.label5.Text = "Codigo:";
            // 
            // codigo
            // 
            this.codigo.FillWeight = 50F;
            this.codigo.HeaderText = "CODIGO";
            this.codigo.Name = "codigo";
            this.codigo.Width = 120;
            // 
            // ubicacion
            // 
            this.ubicacion.FillWeight = 50F;
            this.ubicacion.HeaderText = "UBICACION";
            this.ubicacion.MinimumWidth = 8;
            this.ubicacion.Name = "ubicacion";
            this.ubicacion.Width = 120;
            // 
            // superficie
            // 
            this.superficie.FillWeight = 50F;
            this.superficie.HeaderText = "SUPERFICIE";
            this.superficie.MinimumWidth = 8;
            this.superficie.Name = "superficie";
            this.superficie.Width = 120;
            // 
            // altitud
            // 
            this.altitud.FillWeight = 50F;
            this.altitud.HeaderText = "ALTITUD";
            this.altitud.MinimumWidth = 8;
            this.altitud.Name = "altitud";
            this.altitud.Width = 120;
            // 
            // nroAlmacigueras
            // 
            this.nroAlmacigueras.FillWeight = 50F;
            this.nroAlmacigueras.HeaderText = "ALMACIGUERAS";
            this.nroAlmacigueras.MinimumWidth = 8;
            this.nroAlmacigueras.Name = "nroAlmacigueras";
            this.nroAlmacigueras.Width = 120;
            // 
            // camasRepique
            // 
            this.camasRepique.FillWeight = 50F;
            this.camasRepique.HeaderText = "CAMAS REPIQUE";
            this.camasRepique.MinimumWidth = 8;
            this.camasRepique.Name = "camasRepique";
            this.camasRepique.Width = 120;
            // 
            // botonLimpiar
            // 
            this.botonLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(130)))), ((int)(((byte)(0)))));
            this.botonLimpiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.botonLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.botonLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.botonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonLimpiar.Font = new System.Drawing.Font("Comic Sans MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonLimpiar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botonLimpiar.Location = new System.Drawing.Point(28, 422);
            this.botonLimpiar.Name = "botonLimpiar";
            this.botonLimpiar.Size = new System.Drawing.Size(116, 46);
            this.botonLimpiar.TabIndex = 17;
            this.botonLimpiar.Text = "Limpiar";
            this.botonLimpiar.UseVisualStyleBackColor = false;
            this.botonLimpiar.Click += new System.EventHandler(this.botonLimpiar_Click);
            // 
            // FormViveros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1158, 694);
            this.Controls.Add(this.botonLimpiar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonMostrarCamasDeRepique);
            this.Controls.Add(this.buttonMostrarAlmacigueras);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.butCambDat);
            this.Controls.Add(this.dataGridViewViveros);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxAltitudVive);
            this.Controls.Add(this.TextBoxSuperficie);
            this.Controls.Add(this.textBoxUbicaVivero);
            this.Controls.Add(this.textBoxCodVivero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormViveros";
            this.Text = "FormViveros";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViveros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxUbicaVivero;
        private System.Windows.Forms.TextBox TextBoxSuperficie;
        private System.Windows.Forms.TextBox textBoxAltitudVive;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewViveros;
        private System.Windows.Forms.Button butCambDat;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonMostrarAlmacigueras;
        private System.Windows.Forms.Button buttonMostrarCamasDeRepique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ubicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn superficie;
        private System.Windows.Forms.DataGridViewTextBoxColumn altitud;
        private System.Windows.Forms.DataGridViewTextBoxColumn nroAlmacigueras;
        private System.Windows.Forms.DataGridViewTextBoxColumn camasRepique;
        private System.Windows.Forms.Button botonLimpiar;
        public System.Windows.Forms.TextBox textBoxCodVivero;
    }
}