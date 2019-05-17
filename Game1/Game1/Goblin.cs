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
    class Goblin: BaseEnemy
    {
        /*Texture2D goblintex = Game1.Content.Load<Texture2D>("Knight.png");
        Vector2 pos = new Vector2(200, 100);
        BaseEnemy goblin = new BaseEnemy(goblintex, pos, 1, 2, 3, 4, 5, EnemyType.Goblin);
        Goblin goblin1 = new BaseEnemy();*/

        public Goblin(Texture2D texture, Vector2 position) : base(texture, position, 0, 1, 1, 1, 1, EnemyType.Goblin)
        {
            position = new Vector2(100, 200);
           
        }

    }
}
