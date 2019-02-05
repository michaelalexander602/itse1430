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
        }
    }
}
