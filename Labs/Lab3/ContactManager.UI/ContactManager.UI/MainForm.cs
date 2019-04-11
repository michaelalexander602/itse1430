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
            var form = new ContactForm();
            form.Text = "New Contact";

            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    _contacts.Add(form.Contact);
                    break;
                } catch (Exception ex)
                {
                    MessageBox.Show(this, ex.Message, "Name must be unique.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }

            BindList();
        }

        private void BindList()
        {
            _listContacts.Items.Clear();
            _listContacts.DisplayMember = nameof(Contact.Name);

            var items = _contacts.GetAll();
            items = items.OrderBy(GetName);

            _listContacts.Items.AddRange(_contacts.GetAll().ToArray());
        }

        private string GetName(Contact contact)
        {
            return contact.Name;
        }

        private IContactDatabase _contacts = new ContactDatabase();

        private void OnContactsSendMessage(object sender, EventArgs e)
        {
            var form = new MessageForm();

            var contact = _listContacts.SelectedItem as Contact;
            form.Contact = contact;

            if (contact == null)
                return;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //try
                //{
                //    //UpdateGame(game, form.Game);            
                //    _games.Update(game.Id, form.Game);
                //    break;
                //}
                //catch (Exception ex)
                //{
                //    DisplayError(ex);
                //};
            };
        }

        public void Send(Message message)
        {
            throw new NotImplementedException();
        }
    }
}
