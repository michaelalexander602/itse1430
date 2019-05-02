using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameManager.FileSystem;
using GameManager.Sql;

namespace GameManager.Host.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            //LoadUI();
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            //Local variable
            var x = 10;

            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            //Load connection string from config
            var connString = ConfigurationManager.ConnectionStrings["database"];
            _games = new SqlGameDatabase(connString.ConnectionString);

            //Seed if database is empty
            //var games = _games.GetAll();
            //if (games.Count() == 0)
            //    //SeedDatabase.Seed(_games);
            //    _games.Seed();

            BindList();
        }

        private void BindList()
        {
            //Bind games to listbox
            _listGames.Items.Clear();
            _listGames.DisplayMember = nameof(Game.Name);

            //Can use AddRange now that we don't care about null items
            //var enumor = _games.GetAll();
            //var enumoror = enumor.GetEnumerator();
            //while (enumoror.MoveNext())
            //{
            //    var item = enumoror.Current;
            //};
            ////foreach (var item in enumor)
            //{
            //};

            var items = _games.GetAll();
            items = items.OrderBy(GetName);            
            _listGames.Items.AddRange(items.ToArray());
            //foreach (var game in _games)
            //{
            //    if (game != null)
            //        _listGames.Items.Add(game);
            //};
        }

        private string GetName ( Game game )
        {
            return game.Name;
        }

        private void OnGameAdd( object sender, EventArgs e )
        {
            //Display UI
            var form = new GameForm();

            while (true)
            {
                //Modal
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //Add
                try
                {
                    //Anything in here that raises an exception will
                    //be sent to the catch block

                    OnSafeAdd(form);
                    break;
                } catch (InvalidOperationException)
                {
                    MessageBox.Show(this, "Choose a better game.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( GameForm form )
        {
            try
            {
                //_games[GetNextEmptyGame()] = form.Game;
                _games.Add(form.Game);
            } catch (NotImplementedException e)
            {
                //Rewriting an exception
                throw new Exception("Not implemented yet", e);
            } catch (Exception e)
            {
                //Log a message 

                //Rethrow exception - wrong way
                //throw e;
                throw;
            };
        }

        private IGameDatabase _games;

        private void OnGameEdit( object sender, EventArgs e )
        {
            var form = new GameForm();

            var game = GetSelectedGame();
            if (game == null)
                return;

            //Game to edit
            form.Game = game;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    //UpdateGame(game, form.Game);            
                    _games.Update(game.Id, form.Game);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnGameDelete( object sender, EventArgs e )
        {
            //Get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete {selected.Name}?",
                               "Confirm Delete", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                //DeleteGame(selected);
                _games.Delete(selected.Id);
            } catch (Exception ex)
            {
                DisplayError(ex);  
            };
            BindList();
        }

        private Game GetSelectedGame()
        {
            var value = _listGames.SelectedItem;

            //Typesafe conversion to IEnumerable<T>
            //_listGames.Items.OfType<Game>(); //as
            //_listGames.Items.Cast<Game>(); //(T)

            //C-style cast - don't do this
            //var game = (Game)value;

            //Preferred - null if not valid
            var game = value as Game;

            //Type check
            var game2 = (value is Game) ? (Game)value : null;

            return _listGames.SelectedItem as Game;
        }

        private void OnGameSelected( object sender, EventArgs e )
        {
        }

        protected override void OnFormClosing( FormClosingEventArgs e )
        {
            if (MessageBox.Show(this, "Are you sure?", "Close", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
                return;
            };
            base.OnFormClosing(e);
        }

        #region Unused Code (Demo only)

        //void LoadUI ()
        //{
        //    Game game = new Game();

        //    game.Name = "DOOM";
        //    game.Price = 59.99M;

        //    var name = game.Name;
        //    if (name.Length == 0)
        //        /* is empty*/;

        //    //Checking for null - long way
        //    if (game.Name != null && game.Name.Length == 0)
        //        ;

        //    //Conditional - E ? Et : Ef
        //    var length = game.Name != null ? game.Name.Length : 0;

        //    //Short way - null conditional
        //    // game.Name.Length -> int
        //    // game.Name?.Length -> int?
        //    if ((game.Name?.Length ?? 0) == 0)
        //        ;
        //    if (game.Name.Length == 0)
        //        /* is empty */
        //        ;

        //    //var isCool = game.IsCoolGame;
        //    //game.IsCoolGame = false;

        //    //Validate(game)
        //    game.Validate();

        //    //var x = 10;
        //    //x.ToString();

        //    //var str = game.Publisher;            
        //    //Decimal.TryParse("45.99", out game.Price);

        //    //event EventHandler Click;
        //    //delegate EventHandler void ( Object, EventArgs )
        //    //_miGameAdd.Click += OnGameAdd;
        //}

        ////HACK: Find first spot in array with no game
        //private int GetNextEmptyGame ()
        //{
        //    for (var index = 0; index < _games.Length; ++index)
        //        if (_games[index] == null)
        //            return index;

        //    return -1;
        //}

        //private void UpdateGame ( Game oldGame, Game newGame )
        //{
        //    for (int index = 0; index < _games.Length; ++index)
        //    {
        //        if (_games[index] == oldGame)
        //        {
        //            _games[index] = newGame;
        //            break;
        //        };
        //    };
        //}

        //private void DeleteGame ( Game game )
        //{
        //    for (var index = 0; index < _games.Length; ++index)
        //    {
        //        if (_games[index] == game)
        //        {
        //            _games[index] = null;
        //            break;
        //        };
        //    };
        //}
        #endregion
    }
}
