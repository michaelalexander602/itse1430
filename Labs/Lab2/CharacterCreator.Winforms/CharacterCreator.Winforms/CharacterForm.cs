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
    /// <summary>Allows adding or editing a character.</summary>
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the character being edited.</summary>
        public Character Character = new Character();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Init UI if editing a character
            if (Character != null)
                LoadData(Character);

            ValidateChildren();
        }

        //Loads UI with character
        private void LoadData(Character character)
        {
            _txtName.Text = character.Name;
            _comboRace.Text = character.Race;
            _comboProfession.Text = character.Profession;
            _txtStrength.Text = character.Strength.ToString();
            _txtIntelligence.Text = character.Intelligence.ToString();
            _txtAgility.Text = character.Agility.ToString();
            _txtConstitution.Text = character.Constitution.ToString();
            _txtCharisma.Text = character.Charisma.ToString();
            _txtDescription.Text = character.Description;
        }

        //Saves UI info into new character
        private Character SaveData()
        {
            var character = new Character();
            character.Name = _txtName.Text;
            character.Race = _comboRace.Text;
            character.Profession = _comboProfession.Text;
            character.Strength = ReadInt(_txtStrength);
            character.Intelligence = ReadInt(_txtIntelligence);
            character.Agility = ReadInt(_txtAgility);
            character.Constitution = ReadInt(_txtConstitution);
            character.Charisma = ReadInt(_txtCharisma);
            character.Description = _txtDescription.Text;

            return character;
        }

        //Called when the user saves the game
        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = SaveData();

            Character = character;
            DialogResult = DialogResult.OK;
            Close();
        }

        private int ReadInt(TextBox control)
        {
            if (control.Text.Length == 0)
                return 0;

            if (Int32.TryParse(control.Text, out var value))
                return value;

            return -1;
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

        private void OnValidateStat(object sender, CancelEventArgs e)
        {
            var tb = sender as TextBox;

            if (ReadInt(tb) < 1 || ReadInt(tb) > 100)
            {
                _errors.SetError(tb, "Stats must be between 1-100");
                e.Cancel = true;
            }
            else
                _errors.SetError(tb, "");
        }

        //Called when the user cancels the add/edit
        private void OnCancel(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void OnValidateRace(object sender, CancelEventArgs e)
        {
            var cb = sender as ComboBox;

            if(cb.Text == "")
            {
                _errors.SetError(cb, "You must select a race");
                e.Cancel = true;
            }
            else
                _errors.SetError(cb, "");
        }

        private void OnValidateProfession(object sender, CancelEventArgs e)
        {
            var cb = sender as ComboBox;

            if (cb.Text == "")
            {
                _errors.SetError(cb, "You must select a profession");
                e.Cancel = true;
            }
            else
                _errors.SetError(cb, "");
        }
    }

}
