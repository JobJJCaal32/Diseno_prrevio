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
    public partial class Frm_Registro_Usuario : Form
    {
        public Frm_Registro_Usuario()
        {
            InitializeComponent();
        }

        private void Frm_Registro_Usuario_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_Login frm_Login = new Frm_Login();
            frm_Login.Show();
            this.Close();
        }
    }
}
