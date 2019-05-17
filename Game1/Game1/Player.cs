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
    class Player : BaseObject, ICollision
    {
        public double hp = 100;
        float speed = 7f;       
        public int XP;
        int highscore = 0;
        double jumpVelocity = 5;
        double jumpMultiplyer = 0;
        double jumpChange = 1 / 20;
        int [] levelThresholds = new int[] { 5, 12, 30, 80, 180, 420, 900, 2100, 5000, 12000 };
        int level = 1;
        int index;
        public Player(Texture2D texture, Vector2 position)

        {
            this.texture = texture;
            this.position = position;
        }
        public Rectangle Hitbox
        {   get { return new Rectangle(position.ToPoint(), Point.Zero); }

            set { Hitbox = value; }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        public void Collision(BaseObject col)
        {          
            KeyboardState jump = Keyboard.GetState();
            if (col is Ground && jump.IsKeyDown(Keys.Space))
            {
                jumpMultiplyer += jumpChange;
                position.Y += (float)jumpVelocity * (float)jumpMultiplyer;
                if (jumpMultiplyer >= 1)
                {
                    jumpChange = -1 / 20;
                }
            }
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


            if (XP >= 7*index && level < index)
            {
                levelUp();
            }

                base.Update(gametime);
          
        }


        public void levelUp()
        {
            int index = Array.IndexOf(levelThresholds, 5);
            hp = hp * 1.01 * level;

        }
           
    }
}


