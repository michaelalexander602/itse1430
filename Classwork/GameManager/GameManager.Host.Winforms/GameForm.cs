using System;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    /// <summary>Allows adding or editing a game.</summary>
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the property being edited.</summary>
        public Game Game { get; set; }

        //Called when the user saves the game
        private void OnSave( object sender, EventArgs e )
        {
            Game = SaveData();

            DialogResult = DialogResult.OK;
            Close();
        }

        //Called when the user cancels the add/edit
        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;             
            Close();
        }

        private decimal ReadDecimal ( TextBox control )
        {
            if (Decimal.TryParse(control.Text, out var value))
                return value;

            return -1;
        }

        //Loads UI with game
        private void LoadData ( Game game )
        {
            _txtName.Text = game.Name;
            _txtPublisher.Text = game.Publisher;
            _txtPrice.Text = game.Price.ToString();
            _cbOwned.Checked = game.Owned;
            _cbCompleted.Checked = game.Completed;
        }

        //Saves UI into new game
        private Game SaveData ()
        {
            var game = new Game();
            game.Name = _txtName.Text;
            game.Publisher = _txtPublisher.Text;
            game.Price = ReadDecimal(_txtPrice);
            game.Owned = _cbOwned.Checked;
            game.Completed = _cbCompleted.Checked;

            return game;
        }

        private void GameForm_Load( object sender, EventArgs e )
        {
            //Init UI if editing a game
            if (Game != null)
                LoadData(Game);
        }
    }
}
