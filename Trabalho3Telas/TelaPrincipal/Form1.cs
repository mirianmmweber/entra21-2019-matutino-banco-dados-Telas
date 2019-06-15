using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaPrincipal
{
    public partial class TelaPrincipalForm : Form
    {
        public TelaPrincipalForm()
        {
            InitializeComponent();
        }

        private void btnPeixes_Click(object sender, EventArgs e)
        {
            PeixesForm from = new PeixesForm();
            from.Visible = true;

        }

        private void btnColaboradores_Click(object sender, EventArgs e)
        {
            ColaboradoresForm from = new ColaboradoresForm();
            from.Visible = true;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            ClientesForm from = new ClientesForm();
            from.Visible = true;
        }
    }
}
