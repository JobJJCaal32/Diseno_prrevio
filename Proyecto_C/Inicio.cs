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
    public partial class Frm_Inicio : Form
    {
        public Frm_Inicio()
        {
            InitializeComponent();
        }

        private void BtnRegresar_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
            this.Dispose();
        }

        private void BtnHoteles_Click(object sender, EventArgs e)
        {
            FrmHoteles frm_hotel = new FrmHoteles();
            frm_hotel.Show();
            this.Dispose();
        }
    }
}
