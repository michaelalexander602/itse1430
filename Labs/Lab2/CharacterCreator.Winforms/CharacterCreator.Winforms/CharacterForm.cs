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

            //Init UI if editing a game
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

        private int ReadInt(TextBox control)
        {
            if (control.Text.Length == 0)
                return 0;

            if (Int32.TryParse(control.Text, out var value))
                return value;

            return -1;
        }
    }

}
