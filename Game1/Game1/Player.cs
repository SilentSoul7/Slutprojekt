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
        public int hp = 100;
        float speed = 7f;       
        public int XP;
        int highscore = 0;
        double jumpVelocity = 5;
        double jumpMultiplyer = 0;
        double jumpChange = 1 / 20;
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

            base.Update(gametime);
        }


        public void levelUp()
        {
            List<int> levelThresholds = new List<int>();
        }
           
    }
}


