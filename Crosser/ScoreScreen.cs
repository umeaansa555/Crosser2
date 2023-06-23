using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crosser
{
    public partial class ScoreScreen : UserControl
    {

        List<HighScore> leaderboard = new List<HighScore>(); 

        public ScoreScreen()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            
            string nickname = submitNameLabel.Text;
            int score = GameScreen.score;


            HighScore myScore = new HighScore(nickname, score);
            leaderboard.Add(myScore);

            leaderboardLabel.Text = "Name / Score"; //clear label
            leaderboard = leaderboard.OrderBy(x => x.score).Reverse().ToList();
            foreach (HighScore h in leaderboard)
            {
                leaderboardLabel.Text += $"\n {h.nickname} / {h.score}";
            }
        }
    }
}
