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
    class Death:BaseObject
    {
        Highscore hs;
        Player player;        
        string text = "Game Over, restart the game to try again";

        public Death(Player p)
        {
            player = p;
        }

        public override void DrawString(SpriteBatch spriteBatch)
        {
            if (player.hp <= 0)
            {
                base.DrawString(spriteBatch);
            }
        }
        Game1 game;
        public override void Update(GameTime gametime)
        {
            if(player.hp <= 0)
            {
                hs.LoadHigh_score();
                game.gameObjects.RemoveAt(1);
            }
            base.Update(gametime);
        }
    }
}
