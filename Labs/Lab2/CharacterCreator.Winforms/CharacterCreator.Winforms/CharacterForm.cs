﻿using System;
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
    public partial class CharacterForm : Form
    {
        public CharacterForm()
        {
            InitializeComponent();
        }

        public Character Character = new Character();

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            //Init UI if editing a character
            if (Character != null)
                LoadData(Character);

            ValidateChildren();
        }

        private void LoadData(Character character)
        {
            _txtName.Text = character.Name;
            //race
            _comboRace.Text = character.Race;
            //profession
            _comboProfession.Text = character.Profession;
            _txtStrength.Text = character.Strength.ToString();
            _txtIntelligence.Text = character.Intelligence.ToString();
            _txtAgility.Text = character.Agility.ToString();
            _txtConstitution.Text = character.Constitution.ToString();
            _txtCharisma.Text = character.Charisma.ToString();
        }

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

            return character;
        }

        private void OnSave(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            var character = SaveData();

            //if (!character.Validate())
            //{
            //    MessageBox.Show(this, "Game not valid.", "Error", MessageBoxButtons.OK);
            //    return;
            //};

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
    }

}