using System.Windows.Forms;

namespace DataStruct
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();

            lbCreateAccount.Click += (s, e) => ShowFormInPanel(new CreateAccount(), panelHolder);
        }

        private void ShowFormInPanel(Form createAccount, Panel panelHolder)
        {
            panelHolder.Controls.Clear();

            createAccount.TopLevel = false;
            createAccount.Dock = DockStyle.Fill;

            panelHolder.Controls.Add(createAccount);
            createAccount.Show();
        }
    }
}
