using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewFlashCardApp
{
    public partial class HighScores : Form
    {
        public HighScores()
        {
            InitializeComponent();
        }

        private void btn_ReturnToMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            App.Current.MainWindow.Show();
        }
    }
}
