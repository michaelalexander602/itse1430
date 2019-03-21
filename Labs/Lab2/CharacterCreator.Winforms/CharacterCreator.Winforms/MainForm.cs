/*
 * Michael Alexander
 * ITSE 1430-21722
 * 3-16-19
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CharacterCreator.Winforms
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

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            BindList();
        }

        private void BindList()
        {
            //Bind characters to listbox
            _listCharacters.Items.Clear();
            _listCharacters.DisplayMember = nameof(Character.Name);

            _listCharacters.Items.AddRange(_roster.GetAll().ToArray());
        }

        private Roster _roster = new Roster();

        private void OnCharacterNew(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            
            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                _roster.Add(form.Character);
                break;
            }

            BindList();
        }

        private void OnCharacterEdit(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            form.Text = "Edit Character";
            var character = _listCharacters.SelectedItem as Character;

            if (character == null)
                return;
            form.Character = character;

            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                _roster.Update(character.Id, form.Character);

                break;
            }

            BindList();
        }

        private void OnCharacterDelete(object sender, EventArgs e)
        {
            var selected = _listCharacters.SelectedItem as Character;
            if (selected == null)
                return;

            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _roster.Delete(selected.Id);
            BindList();
        }
    }
}
