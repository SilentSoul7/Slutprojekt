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
    class BaseWeapon :BaseObject
    {
        float attackDmg;
        float attackSpeed;
        float range;

        public BaseWeapon (Texture2D texture, Vector2 position, float attackDmg, float attackSpeed, float range)
        {
            this.texture = texture;
            this.position = position;
            this.attackDmg = attackDmg;
            this.attackSpeed = attackSpeed;
            this.range = range;
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }


    }
}
