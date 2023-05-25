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
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void LblCrear_Click(object sender, EventArgs e)
        {
            Frm_Registro_Usuario form1 = new Frm_Registro_Usuario();
            this.Hide();
            form1.ShowDialog();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            
        }

        private void BtnInciar_Click(object sender, EventArgs e)
        {
            Frm_Inicio frm_inicio = new Frm_Inicio();
            this.Hide();
            frm_inicio.ShowDialog();
        }
    }
}
