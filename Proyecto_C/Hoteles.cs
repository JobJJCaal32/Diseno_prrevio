using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_C
{
    public partial class FrmHoteles : Form
    {
        public void invisibilidad()
        {
            Lbl_Nompre_Empresa.Visible = false;
            TxtNombre.Visible = false;
            LblNombre.Visible = false;
            LblTelefono.Visible = false;
            TxtTelefono.Visible = false;
            LblCantidadPersonas.Visible = false;
            TxtCantidadPersonas.Visible = false;
            LblTipoHabitacion.Visible = false;
            TxtipoHabitacion.Visible = false;
            LblCantidadHabitaciones.Visible = false;
            TxtCantidadHabitaciones.Visible = false;
            LblPrecio.Visible = false;
            TxtPrecio.Visible = false;
            TxtCalendario.Visible = false;
            LblHora.Visible = false;
            TxtHora.Visible = false;
            LblFechaIncial.Visible = false;
            TxtIncio.Visible = false;
            LblFechaFinal.Visible = false;
            TxtFinal.Visible = false;
            LblNota.Visible = false;
            TxtNota.Visible = false; 
            PictureLogo.Visible = false;
            BtnSiguiente.Visible = false;
        }

        public void visibles()
        {
            Lbl_Nompre_Empresa.Visible = true;
            TxtNombre.Visible = true;
            LblNombre.Visible = true;
            LblTelefono.Visible = true;
            TxtTelefono.Visible = true;
            LblCantidadPersonas.Visible = true;
            TxtCantidadPersonas.Visible = true;
            LblTipoHabitacion.Visible = true;
            TxtipoHabitacion.Visible = true;
            LblCantidadHabitaciones.Visible = true;
            TxtCantidadHabitaciones.Visible = true;
            LblPrecio.Visible = true;
            TxtPrecio.Visible = true;
            TxtCalendario.Visible = true;
            LblHora.Visible = true;
            TxtHora.Visible = true;
            LblFechaIncial.Visible = true;
            TxtIncio.Visible = true;
            LblFechaFinal.Visible = true;
            TxtFinal.Visible = true;
            LblNota.Visible = true;
            TxtNota.Visible = true;
            PictureLogo.Visible = true;
            BtnSiguiente.Visible = true;
        }
        public FrmHoteles()
        {
            InitializeComponent();
        }

        private void Hoteles_Load(object sender, EventArgs e)
        {
            invisibilidad(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void atrasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_Inicio frm_inicio = new Frm_Inicio();
            this.Dispose();
            frm_inicio.ShowDialog(); 

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime Inicio = TxtCalendario.SelectionStart;
            DateTime final = TxtCalendario.SelectionEnd; 

            TxtIncio.Text = Inicio.ToString();
            TxtFinal.Text = final.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmPago_Digital frmpago = new FrmPago_Digital(); 
            frmpago.Show();
            this.Dispose(); 

        }

        private void donLaloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visibles();
            Lbl_Nompre_Empresa.Text = "Restaurante Don Lalo";
            Image Miimagen = Image.FromFile("DonLalo.jpg");

            
        }

        private void doñaLusiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visibles();
            Lbl_Nompre_Empresa.Text = "Restaurante Dona Lusia";
            Image Miimagen = Image.FromFile("doñamaria.png");
        }
    }
}
