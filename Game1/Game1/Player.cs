﻿using System;
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
    class Player : BaseObject
    {
        int hp = 100;
        float speed = 7f;
        private SpriteFont font;
        public int XP;
        int highscore = 0;

        public Player(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        public override void Update (GameTime gametime)
        {
            KeyboardState state = Keyboard.GetState();

            if(state.IsKeyDown(Keys.Right))
                position.X += 10;
            if(state.IsKeyDown(Keys.Left))
                position.X -= 10;
            if(state.IsKeyDown(Keys.Up))
                position.Y -= 10;
            if(state.IsKeyDown(Keys.Down))
                position.Y += 10;

            base.Update(gametime);
        }

        private void PlayerDeath()
        {
            SpriteBatch.DrawString(font, "File", new Vector2(300, 100), Color.Black);
            
        }

        public void levelUp()
        {
            List<int> levelThresholds = new List<int>();
        }

        public void Highscore( int highscore)
        {
            StreamWriter sw = new StreamWriter("Highscore.txt");
            sw.WriteLine(highscore);
            sw.Close();

            StreamReader sr = new StreamReader("Highscore.txt");
            string highscore = sr.ReadToEnd();
            sr.Close();
        }

    
       
    }
}


