namespace Proyecto_C
{
    partial class FrmHoteles
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Menu_Hoteles = new System.Windows.Forms.MenuStrip();
            this.donLaloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doñaLusiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_Nompre_Empresa = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtTelefono = new System.Windows.Forms.TextBox();
            this.LblTelefono = new System.Windows.Forms.Label();
            this.TxtCantidadPersonas = new System.Windows.Forms.TextBox();
            this.LblCantidadPersonas = new System.Windows.Forms.Label();
            this.TxtipoHabitacion = new System.Windows.Forms.ComboBox();
            this.LblTipoHabitacion = new System.Windows.Forms.Label();
            this.TxtCantidadHabitaciones = new System.Windows.Forms.TextBox();
            this.LblCantidadHabitaciones = new System.Windows.Forms.Label();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.TxtCalendario = new System.Windows.Forms.MonthCalendar();
            this.TxtHora = new System.Windows.Forms.TextBox();
            this.TxtIncio = new System.Windows.Forms.TextBox();
            this.LblFechaIncial = new System.Windows.Forms.Label();
            this.LblHora = new System.Windows.Forms.Label();
            this.TxtFinal = new System.Windows.Forms.TextBox();
            this.LblFechaFinal = new System.Windows.Forms.Label();
            this.TxtNota = new System.Windows.Forms.TextBox();
            this.LblNota = new System.Windows.Forms.Label();
            this.BtnSiguiente = new System.Windows.Forms.Button();
            this.atrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TxtPrecio = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.Menu_Hoteles.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atrasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 62);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Hoteles
            // 
            this.Menu_Hoteles.AutoSize = false;
            this.Menu_Hoteles.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Menu_Hoteles.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Hoteles.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.donLaloToolStripMenuItem,
            this.doñaLusiaToolStripMenuItem});
            this.Menu_Hoteles.Location = new System.Drawing.Point(0, 62);
            this.Menu_Hoteles.Name = "Menu_Hoteles";
            this.Menu_Hoteles.Size = new System.Drawing.Size(124, 388);
            this.Menu_Hoteles.TabIndex = 1;
            this.Menu_Hoteles.Text = "menuStrip2";
            // 
            // donLaloToolStripMenuItem
            // 
            this.donLaloToolStripMenuItem.Name = "donLaloToolStripMenuItem";
            this.donLaloToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.donLaloToolStripMenuItem.Text = "Don lalo";
            this.donLaloToolStripMenuItem.Click += new System.EventHandler(this.donLaloToolStripMenuItem_Click);
            // 
            // doñaLusiaToolStripMenuItem
            // 
            this.doñaLusiaToolStripMenuItem.Name = "doñaLusiaToolStripMenuItem";
            this.doñaLusiaToolStripMenuItem.Size = new System.Drawing.Size(117, 19);
            this.doñaLusiaToolStripMenuItem.Text = "Doña Lusia";
            this.doñaLusiaToolStripMenuItem.Click += new System.EventHandler(this.doñaLusiaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(284, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Reservaciones Hoteles";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Lbl_Nompre_Empresa
            // 
            this.Lbl_Nompre_Empresa.AutoSize = true;
            this.Lbl_Nompre_Empresa.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_Nompre_Empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Nompre_Empresa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Lbl_Nompre_Empresa.Location = new System.Drawing.Point(379, 78);
            this.Lbl_Nompre_Empresa.Name = "Lbl_Nompre_Empresa";
            this.Lbl_Nompre_Empresa.Size = new System.Drawing.Size(131, 20);
            this.Lbl_Nompre_Empresa.TabIndex = 4;
            this.Lbl_Nompre_Empresa.Text = "Nombre empresa";
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.BackColor = System.Drawing.SystemColors.Control;
            this.LblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombre.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNombre.Location = new System.Drawing.Point(140, 179);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 5;
            this.LblNombre.Text = "Nombre";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(211, 175);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(187, 26);
            this.TxtNombre.TabIndex = 6;
            // 
            // TxtTelefono
            // 
            this.TxtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTelefono.Location = new System.Drawing.Point(211, 221);
            this.TxtTelefono.Name = "TxtTelefono";
            this.TxtTelefono.Size = new System.Drawing.Size(187, 26);
            this.TxtTelefono.TabIndex = 8;
            // 
            // LblTelefono
            // 
            this.LblTelefono.AutoSize = true;
            this.LblTelefono.BackColor = System.Drawing.SystemColors.Control;
            this.LblTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTelefono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTelefono.Location = new System.Drawing.Point(140, 225);
            this.LblTelefono.Name = "LblTelefono";
            this.LblTelefono.Size = new System.Drawing.Size(71, 20);
            this.LblTelefono.TabIndex = 7;
            this.LblTelefono.Text = "Telefono";
            // 
            // TxtCantidadPersonas
            // 
            this.TxtCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadPersonas.Location = new System.Drawing.Point(288, 272);
            this.TxtCantidadPersonas.Name = "TxtCantidadPersonas";
            this.TxtCantidadPersonas.Size = new System.Drawing.Size(110, 26);
            this.TxtCantidadPersonas.TabIndex = 10;
            // 
            // LblCantidadPersonas
            // 
            this.LblCantidadPersonas.AutoSize = true;
            this.LblCantidadPersonas.BackColor = System.Drawing.SystemColors.Control;
            this.LblCantidadPersonas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadPersonas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCantidadPersonas.Location = new System.Drawing.Point(140, 276);
            this.LblCantidadPersonas.Name = "LblCantidadPersonas";
            this.LblCantidadPersonas.Size = new System.Drawing.Size(143, 20);
            this.LblCantidadPersonas.TabIndex = 9;
            this.LblCantidadPersonas.Text = "Cantidad personas";
            // 
            // TxtipoHabitacion
            // 
            this.TxtipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtipoHabitacion.FormattingEnabled = true;
            this.TxtipoHabitacion.Items.AddRange(new object[] {
            "Suit ",
            "Habitacion Premiu",
            "Normal ",
            "Economico"});
            this.TxtipoHabitacion.Location = new System.Drawing.Point(265, 315);
            this.TxtipoHabitacion.Name = "TxtipoHabitacion";
            this.TxtipoHabitacion.Size = new System.Drawing.Size(133, 28);
            this.TxtipoHabitacion.TabIndex = 11;
            // 
            // LblTipoHabitacion
            // 
            this.LblTipoHabitacion.AutoSize = true;
            this.LblTipoHabitacion.BackColor = System.Drawing.SystemColors.Control;
            this.LblTipoHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTipoHabitacion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblTipoHabitacion.Location = new System.Drawing.Point(140, 319);
            this.LblTipoHabitacion.Name = "LblTipoHabitacion";
            this.LblTipoHabitacion.Size = new System.Drawing.Size(119, 20);
            this.LblTipoHabitacion.TabIndex = 12;
            this.LblTipoHabitacion.Text = "Tipo Habitacion";
            // 
            // TxtCantidadHabitaciones
            // 
            this.TxtCantidadHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidadHabitaciones.Location = new System.Drawing.Point(310, 363);
            this.TxtCantidadHabitaciones.Name = "TxtCantidadHabitaciones";
            this.TxtCantidadHabitaciones.Size = new System.Drawing.Size(88, 26);
            this.TxtCantidadHabitaciones.TabIndex = 14;
            // 
            // LblCantidadHabitaciones
            // 
            this.LblCantidadHabitaciones.AutoSize = true;
            this.LblCantidadHabitaciones.BackColor = System.Drawing.SystemColors.Control;
            this.LblCantidadHabitaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCantidadHabitaciones.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblCantidadHabitaciones.Location = new System.Drawing.Point(140, 367);
            this.LblCantidadHabitaciones.Name = "LblCantidadHabitaciones";
            this.LblCantidadHabitaciones.Size = new System.Drawing.Size(170, 20);
            this.LblCantidadHabitaciones.TabIndex = 13;
            this.LblCantidadHabitaciones.Text = "Cantidad Habitaciones";
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.BackColor = System.Drawing.SystemColors.Control;
            this.LblPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrecio.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblPrecio.Location = new System.Drawing.Point(140, 414);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(130, 20);
            this.LblPrecio.TabIndex = 16;
            this.LblPrecio.Text = "Precio habitacion";
            // 
            // TxtCalendario
            // 
            this.TxtCalendario.FirstDayOfWeek = System.Windows.Forms.Day.Sunday;
            this.TxtCalendario.Location = new System.Drawing.Point(423, 130);
            this.TxtCalendario.MaxSelectionCount = 30;
            this.TxtCalendario.Name = "TxtCalendario";
            this.TxtCalendario.TabIndex = 17;
            this.TxtCalendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // TxtHora
            // 
            this.TxtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtHora.Location = new System.Drawing.Point(606, 304);
            this.TxtHora.Name = "TxtHora";
            this.TxtHora.Size = new System.Drawing.Size(131, 26);
            this.TxtHora.TabIndex = 19;
            // 
            // TxtIncio
            // 
            this.TxtIncio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIncio.Location = new System.Drawing.Point(564, 350);
            this.TxtIncio.Name = "TxtIncio";
            this.TxtIncio.Size = new System.Drawing.Size(173, 26);
            this.TxtIncio.TabIndex = 21;
            // 
            // LblFechaIncial
            // 
            this.LblFechaIncial.AutoSize = true;
            this.LblFechaIncial.BackColor = System.Drawing.SystemColors.Control;
            this.LblFechaIncial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaIncial.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblFechaIncial.Location = new System.Drawing.Point(466, 354);
            this.LblFechaIncial.Name = "LblFechaIncial";
            this.LblFechaIncial.Size = new System.Drawing.Size(98, 20);
            this.LblFechaIncial.TabIndex = 20;
            this.LblFechaIncial.Text = "Fecha Inicial";
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.BackColor = System.Drawing.SystemColors.Control;
            this.LblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblHora.Location = new System.Drawing.Point(479, 308);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(121, 20);
            this.LblHora.TabIndex = 18;
            this.LblHora.Text = "Hora de llegada";
            // 
            // TxtFinal
            // 
            this.TxtFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFinal.Location = new System.Drawing.Point(564, 395);
            this.TxtFinal.Name = "TxtFinal";
            this.TxtFinal.Size = new System.Drawing.Size(173, 26);
            this.TxtFinal.TabIndex = 23;
            // 
            // LblFechaFinal
            // 
            this.LblFechaFinal.AutoSize = true;
            this.LblFechaFinal.BackColor = System.Drawing.SystemColors.Control;
            this.LblFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaFinal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblFechaFinal.Location = new System.Drawing.Point(472, 399);
            this.LblFechaFinal.Name = "LblFechaFinal";
            this.LblFechaFinal.Size = new System.Drawing.Size(92, 20);
            this.LblFechaFinal.TabIndex = 22;
            this.LblFechaFinal.Text = "Fecha Final";
            // 
            // TxtNota
            // 
            this.TxtNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNota.Location = new System.Drawing.Point(696, 153);
            this.TxtNota.Multiline = true;
            this.TxtNota.Name = "TxtNota";
            this.TxtNota.Size = new System.Drawing.Size(198, 139);
            this.TxtNota.TabIndex = 24;
            // 
            // LblNota
            // 
            this.LblNota.AutoSize = true;
            this.LblNota.BackColor = System.Drawing.SystemColors.Control;
            this.LblNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.LblNota.Location = new System.Drawing.Point(692, 124);
            this.LblNota.Name = "LblNota";
            this.LblNota.Size = new System.Drawing.Size(43, 20);
            this.LblNota.TabIndex = 25;
            this.LblNota.Text = "Nota";
            // 
            // BtnSiguiente
            // 
            this.BtnSiguiente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguiente.Location = new System.Drawing.Point(773, 395);
            this.BtnSiguiente.Name = "BtnSiguiente";
            this.BtnSiguiente.Size = new System.Drawing.Size(96, 39);
            this.BtnSiguiente.TabIndex = 26;
            this.BtnSiguiente.Text = "Siguiente";
            this.BtnSiguiente.UseVisualStyleBackColor = true;
            this.BtnSiguiente.Click += new System.EventHandler(this.button1_Click);
            // 
            // atrasToolStripMenuItem
            // 
            this.atrasToolStripMenuItem.Name = "atrasToolStripMenuItem";
            this.atrasToolStripMenuItem.Size = new System.Drawing.Size(46, 58);
            this.atrasToolStripMenuItem.Text = "Atras";
            this.atrasToolStripMenuItem.Click += new System.EventHandler(this.atrasToolStripMenuItem_Click);
            // 
            // TxtPrecio
            // 
            this.TxtPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecio.Location = new System.Drawing.Point(276, 408);
            this.TxtPrecio.Name = "TxtPrecio";
            this.TxtPrecio.Size = new System.Drawing.Size(122, 26);
            this.TxtPrecio.TabIndex = 27;
            // 
            // FrmHoteles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 450);
            this.Controls.Add(this.TxtPrecio);
            this.Controls.Add(this.BtnSiguiente);
            this.Controls.Add(this.LblNota);
            this.Controls.Add(this.TxtNota);
            this.Controls.Add(this.TxtFinal);
            this.Controls.Add(this.LblFechaFinal);
            this.Controls.Add(this.TxtHora);
            this.Controls.Add(this.TxtIncio);
            this.Controls.Add(this.LblFechaIncial);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.TxtCalendario);
            this.Controls.Add(this.LblPrecio);
            this.Controls.Add(this.TxtCantidadHabitaciones);
            this.Controls.Add(this.LblCantidadHabitaciones);
            this.Controls.Add(this.LblTipoHabitacion);
            this.Controls.Add(this.TxtipoHabitacion);
            this.Controls.Add(this.TxtCantidadPersonas);
            this.Controls.Add(this.LblCantidadPersonas);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.TxtTelefono);
            this.Controls.Add(this.LblTelefono);
            this.Controls.Add(this.LblNombre);
            this.Controls.Add(this.Lbl_Nompre_Empresa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_Hoteles);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmHoteles";
            this.Text = "Hoteles";
            this.Load += new System.EventHandler(this.Hoteles_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Menu_Hoteles.ResumeLayout(false);
            this.Menu_Hoteles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip Menu_Hoteles;
        private System.Windows.Forms.ToolStripMenuItem donLaloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doñaLusiaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_Nompre_Empresa;
        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtTelefono;
        private System.Windows.Forms.Label LblTelefono;
        private System.Windows.Forms.TextBox TxtCantidadPersonas;
        private System.Windows.Forms.Label LblCantidadPersonas;
        private System.Windows.Forms.ComboBox TxtipoHabitacion;
        private System.Windows.Forms.Label LblTipoHabitacion;
        private System.Windows.Forms.TextBox TxtCantidadHabitaciones;
        private System.Windows.Forms.Label LblCantidadHabitaciones;
        private System.Windows.Forms.Label LblPrecio;
        private System.Windows.Forms.MonthCalendar TxtCalendario;
        private System.Windows.Forms.TextBox TxtHora;
        private System.Windows.Forms.TextBox TxtIncio;
        private System.Windows.Forms.Label LblFechaIncial;
        private System.Windows.Forms.Label LblHora;
        private System.Windows.Forms.TextBox TxtFinal;
        private System.Windows.Forms.Label LblFechaFinal;
        private System.Windows.Forms.TextBox TxtNota;
        private System.Windows.Forms.Label LblNota;
        private System.Windows.Forms.Button BtnSiguiente;
        private System.Windows.Forms.ToolStripMenuItem atrasToolStripMenuItem;
        private System.Windows.Forms.TextBox TxtPrecio;
    }
}