using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Crosser
{
    public partial class ScoreScreen : UserControl
    {

        List<HighScore> leaderboard = new List<HighScore>(); 

        public ScoreScreen()
        {
            InitializeComponent();
            LoadScores();
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

        private void LoadScores()
        {
            string nickname;
            int score;

            XmlReader reader = XmlReader.Create("leaderboard.xml");

            while (reader.Read())
            {
                if (reader.NodeType == XmlNodeType.Text)
                {
                    nickname = reader.ReadString();

                    reader.ReadToNextSibling("score");
                    score = reader.ReadElementContentAsInt();

                    HighScore newScore = new HighScore(nickname, score);
                    leaderboard.Add(newScore);
                }
            }
            //leaderboard = leaderboard.OrderBy(x => x.score).ThenBy(x => x.nickname).ToList();
            leaderboard = leaderboard.OrderBy(x => x.score).Reverse().ToList();
            foreach (HighScore h in leaderboard)
            {
                leaderboardLabel.Text += $"\n {h.nickname} / {h.score}";
            }
            reader.Close();
        }
    }
}
