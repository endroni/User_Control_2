using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace User_Control_Reiniciando
{
    public partial class TelaPrincipal : Form
    {
        static TelaPrincipal _obj;

        public static TelaPrincipal Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new TelaPrincipal();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return panelContainer; }
            set { panelContainer = value; }
        }

        public Button BotaoVoltar
        {
            get { return btnVoltar; }
            set { btnVoltar = value; }
        }

        public TelaPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnVoltar.Visible = false;
            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(uc);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            panelContainer.Controls["UCHome"].BringToFront();
            btnVoltar.Visible = false;
        }
    }
}
