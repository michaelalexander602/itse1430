using ContactManager.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            _txtTo.Text = Contact.Name + " - " + Contact.Email;

            ValidateChildren();
        }

        private void OnValidateSubject(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "A subject is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(tb, "");
        }

        private void OnSend(object sender, EventArgs e)
        {

        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
