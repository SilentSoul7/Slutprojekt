using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    interface ICollision
    {
        Rectangle Hitbox
        {
            get;
            set;
        }
        void Collision(BaseObject obj);
    }
}
