using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataStruct
{
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();

            lbLogIn.Click += (s, e) => ShowFormInPanel(new LogIn(), panelHolder);
        }

        private void ShowFormInPanel(Form logIn, Panel panelHolder)
        {
            panelHolder.Controls.Clear();

            logIn.TopLevel = false;
            logIn.Dock = DockStyle.Fill;

            panelHolder.Controls.Add(logIn);
            logIn.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
