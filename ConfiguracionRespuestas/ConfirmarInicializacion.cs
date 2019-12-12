using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfiguracionRespuestas
{
    public partial class ConfirmarInicializacion : Form
    {
        public bool Respuesta = false;
        public ConfirmarInicializacion()
        {
            InitializeComponent();
        }

        private void buttonSi_Click(object sender, EventArgs e)
        {
            Respuesta = true;
            this.Close();
        }

        private void buttonNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
