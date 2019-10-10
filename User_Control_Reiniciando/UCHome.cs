using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Reiniciando
{
    public partial class UCHome : UserControl
    {
        public UCHome()
        {
            InitializeComponent();
        }

        private void btnProximaTela_Click(object sender, EventArgs e)
        {
            if(!TelaPrincipal.Instance.PnlContainer.Controls.ContainsKey("UCNext"))
            {
                UCNext un = new UCNext();
                un.Dock = DockStyle.Fill;                
                TelaPrincipal.Instance.PnlContainer.Controls.Add(un); // Tinha errado essa linha e não estava carregando a tela destino
            }

            TelaPrincipal.Instance.PnlContainer.Controls["UCNext"].BringToFront();
            TelaPrincipal.Instance.BotaoVoltar.Visible = true;
        }
    }
}
