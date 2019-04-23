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
        int minSpawnTime;
        int maxSpawnTime;
        public int hp;
        int speed;
        int attack;


        public BaseEnemy(Texture2D texture, Vector2 position, int minSpawnTime, int maxSpawnTime, int hp, int speed, int attack)
        {
            this.texture = texture;
            this.position = position;
            this.minSpawnTime = minSpawnTime;
            this.maxSpawnTime = maxSpawnTime;
            this.hp = hp;
            this.speed = speed;
            this.attack = attack;
        }

        // Ska ligga i Game1
        public virtual void SpawnEnemy()
        {
            float spawntime = 0;
            float timer = 0;
            spawntime -= 1f / 60;

            if (0 >= spawntime) { 
                Random random = new Random();
                spawntime = random.Next(minSpawnTime, maxSpawnTime + 1);
                List<BaseEnemy> Enemies = new List<BaseEnemy>();
                Enemies.Add(new BaseEnemy(null,Vector2.Zero,0,0,0,0,0));
            }
        }

        public override void Update(GameTime gametime)
        {
            // Ligga i Gam1
            SpawnEnemy();
        }

        public override void Draw(SpriteBatch spriteBatch)
        {
            base.Draw(spriteBatch);
        }
        
        public void EnemyDeath()
        {
            if (hp <= 0)
            {
                
            }

        }
    }
}
