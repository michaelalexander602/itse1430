using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ContactManager.Business;

namespace ContactManager.UI
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnFileExit(object sender, EventArgs e)
        {
            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnContactsAdd(object sender, EventArgs e)
        {
            var form = new ContactForm();
            form.Text = "New Contact";

            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;


            }
        }

        private IContactDatabase _contacts = new ContactDatabase();
    }
}
