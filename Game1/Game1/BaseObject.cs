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
    public class BaseObject
    {
        protected Texture2D texture;
        protected Color color = Color.White;
        protected Rectangle rectangle;
        protected Vector2 position;       
        protected string text;
        SpriteFont sprite_Font;

        public Vector2 Position
        {
            get { return position; }
        }
        
        public virtual void Update(GameTime gametime)
        {
            
        }

        public virtual void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, rectangle, color);
            
        }
        public virtual void DrawString(SpriteBatch spriteFont)
        {
            spriteFont.DrawString(sprite_Font, text, position, color);
        }
    }
}






