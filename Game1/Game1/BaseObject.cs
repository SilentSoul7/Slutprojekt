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
        public static Texture2D standardTexture;
        protected Texture2D texture = standardTexture;
        protected Color color = Color.White;
        protected Rectangle rectangle = new Rectangle();
        protected Vector2 position = new Vector2();       
        protected string text;
        SpriteFont sprite_Font;

        public static void SetTexture(GraphicsDevice device)
        {
            Texture2D baseTex = new Texture2D(device, 10, 15);
            standardTexture = baseTex;

        }
        public Vector2 Position
        {
            get { return position; }
        }
        
        public virtual void Update(GameTime gametime)
        {
            
        }

        public virtual void Draw( SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, color);
            
        }
        public virtual void DrawString(SpriteBatch spriteFont)
        {
            spriteFont.DrawString(sprite_Font, text, position, color);
        }
    }
}






