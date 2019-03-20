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

            _listCharacters.Items.AddRange(_characters.ToArray());
        }

        private List<Character> _characters = new List<Character>();

        private void OnCharacterNew(object sender, EventArgs e)
        {
            var form = new CharacterForm();
            
            while(true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                _characters.Add(form.Character);
                break;
            }

            BindList();
        }
    }
}
