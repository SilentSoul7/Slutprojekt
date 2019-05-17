using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.IO;
namespace Game1
{
    class Highscore:BaseObject
    {
        private SpriteFont font;
        public int highscore;
        public int score;
        GameTime gt;
        string text;


        public void SaveHigh_score(int highscore)
        {
            int score = gt.ElapsedGameTime.Seconds;
            this.score = score;
            this.highscore = highscore;
            StreamWriter sw = new StreamWriter("Highscore.txt");
            sw.WriteLine(highscore);
            sw.Close();

        }
        public void LoadHigh_score()
        {
            StreamReader sr = new StreamReader("Highscore.txt");
            string file = sr.ReadToEnd();
            sr.Close();
        }
        public override void Update(GameTime gametime)
        {
            if (score > highscore)
            {
                SaveHigh_score(highscore);
            }
            score = (int)Convert.ToUInt32(text);
            base.Update(gametime);
        }
        public override void DrawString(SpriteBatch spriteBatch)
        {
           
                base.DrawString(spriteBatch);                                 
        }

    }
}

