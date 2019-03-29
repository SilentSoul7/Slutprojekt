using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Game1
{
    class Player : BaseObject
    {
        float hp;
        float speed = 7f;
        private SpriteFont font;
        public int XP;

        public Player(Texture2D texture, Vector2 position)
        {
            this.texture = texture;
            this.position = position;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }

        private void Move()
        {
            Keyboard.GetState();
        }
        private void Death()
        {
            SpriteBatch.DrawString(font, "File", new Vector2(300, 100), Color.Black);
            
        }

        public void levelUp()
        {
            List<int> levelThresholds = new List<int>();

        }



    }
}


