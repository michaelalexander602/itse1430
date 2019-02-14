using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUI();
        }

        void LoadUI ()
        {
            Game game = new Game();

            game.Name = "kh3";
            game.Price = 59.99M;

            var name = game.Name;
            if (name.Length == 0)
                /* is empty*/
                ;
            if (game.Name.Length == 0)
                /* is empty */
                ;

            game.Validate();

            _miGameAdd.Click += new EventHandler(OnGameAdd);
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnGameAdd( object sender, EventArgs e )
        {
            // display UI
            var form = new GameForm();

            // modeless
            // form.Show();

            // modal - locks out parent window
            if(form.ShowDialog(this) != DialogResult.OK)
                return;


            // if ok the "add" to system
            _game = form.Game;
        }

        private Game _game;

        private void OnGameEdit( object sender, EventArgs e )
        {
            var form = new GameForm();

            // game to edit
            form.Game = _game;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;

            _game = form.Game;
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            // get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            // display confirmation
            if (MessageBox.Show(this, $"Are you sure you want delete {selected.Name}?", "Confirm Delete", 
                            MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            //TODO: delete
            _game = null;
        }

        private Game GetSelectedGame()
        {
            return _game;
        }
    }
}
