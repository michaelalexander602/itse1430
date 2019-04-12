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
using Message = ContactManager.Business.Message;

namespace ContactManager.UI
{
    public partial class MainForm : Form , IMessageService
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
            // display UI
            var form = new ContactForm();
            form.Text = "New Contact";

            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                // add new contact
                try
                {
                    _contacts.Add(form.Contact);
                    break;
                } catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Name must be unique.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }

            BindContactList();
        }

        private void BindContactList()
        {
            // displays contacts on UI
            _listContacts.Items.Clear();
            _listContacts.DisplayMember = nameof(Contact.Name);

            _listContacts.Items.AddRange(_contacts.GetAll().OrderBy(GetName).ToArray());
        }

        private string GetName(Contact contact)
        {
            return contact.Name;
        }

        private IContactDatabase _contacts = new ContactDatabase();
        private List<Message> _messages = new List<Message>();

        private void OnContactsSendMessage(object sender, EventArgs e)
        {
            // display UI
            var form = new MessageForm();

            // gets contact onject from UI list
            var contact = _listContacts.SelectedItem as Contact;
            form.Contact = contact;

            if (contact == null)
                return;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                // add message from user input to the list 
                _messages.Add(form.Message);
                break;
            };

            Send(form.Message);
        }

        public void Send(Message message)
        {
            // displays list of messages to the UI
            _listMessages.Items.Clear();
            _listMessages.DisplayMember = nameof(Message.ToString);

            _listMessages.Items.AddRange(_messages.ToArray());
        }

        private void OnContactsEdit(object sender, EventArgs e)
        {
            // display UI
            var form = new ContactForm();
            // change from title
            form.Text = "Edit Contact";

            // get selected contact, if any
            var contact = _listContacts.SelectedItem as Contact;
            if (contact == null)
                return;

            form.Contact = contact;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _contacts.Update(contact.Id, form.Contact);
                    break;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Name must be unique.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            BindContactList();
        }

        private void OnContactsDelete(object sender, EventArgs e)
        {
            //Get selected contact, if any
            var selected = _listContacts.SelectedItem as Contact;
            if (selected == null)
                return;

            //Display confirmation message
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                _contacts.Remove(selected.Id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, ex.Message, "Contact not found.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };

            BindContactList();
        }
    }
}
