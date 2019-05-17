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
     class BaseEnemy:BaseObject
    {
        public enum EnemyType {Goblin, Zombie, Boss };
        public int minSpawnTime;
        public int maxSpawnTime;
        public int hp;
        int speed;
        int attack;
        EnemyType enemyType;

        public BaseEnemy(Texture2D texture, Vector2 position, int minSpawnTime, int maxSpawnTime, int hp, int speed, int attack, EnemyType enemyType )
        {
            this.texture = texture;
            this.position = position;
            this.minSpawnTime = minSpawnTime;
            this.maxSpawnTime = maxSpawnTime;
            this.hp = hp;
            this.speed = speed;
            this.attack = attack;
            this.enemyType = enemyType;
        }
        Player player;
        public BaseEnemy(Player p)
        {
            player = p;
        }
        BaseEnemy BE;       
        public override void Update(GameTime gametime)
        {
            BE.position = BE.position + player.Position * gametime.ElapsedGameTime.Seconds;

            if (hp <= 0)
            {
                EnemyDeath();
            }
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        Game1 game;
        GameTime gt;
        public void EnemyDeath()
        {
            player.XP += 5;
            int index = game.gameObjects.FindIndex(BE.hp, hp => BE.hp == 0);
            game.gameObjects.RemoveAt(index);

        }

    }
}
