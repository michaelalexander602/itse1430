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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        public Contact Contact { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Initialize textboxes if editing a contact
            if (Contact != null)
                LoadData(Contact);

            ValidateChildren();
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var contact = SaveData();

            Contact = contact;
            DialogResult = DialogResult.OK;
            Close();
        }

        private Contact SaveData()
        {
            var contact = new Contact();
            contact.Name = _txtName.Text;
            contact.Email = _txtEmail.Text;

            return contact;
        }

        private void LoadData(Contact contact)
        {
            _txtName.Text = contact.Name;
            _txtEmail.Text = contact.Email;
        }

        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnValidateName(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required");
                e.Cancel = true;
            }
            else
                _errors.SetError(tb, "");
        }

        private void OnValidateEmail(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Email is required");
                e.Cancel = true;
            }
            else if(!IsValidEmail(tb.Text))
            {
                _errors.SetError(tb, "Email is not valid");
                e.Cancel = true;
            }
            else
                _errors.SetError(tb, "");
        }

        private bool IsValidEmail(string source)
        {
            try
            {
                new System.Net.Mail.MailAddress(source);
                return true;
            }
            catch
            { };

            return false;
        }
    }
}
