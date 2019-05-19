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

        public Goblin(Texture2D texture, Vector2 position) : base(texture, position, 0, 1, 1, 1, 1, EnemyType.Goblin)
        {
            position = new Vector2(100, 200);
           
        }

    }
}
