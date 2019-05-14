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
    public class BaseEnemy:BaseObject
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

        // Ska ligga i Game1
        public virtual void SpawnEnemy()
        {            
            float spawntime = 0;
            spawntime -= 1f / 60;

            if (0 >= spawntime) { 
                Random random = new Random();
                spawntime = random.Next(minSpawnTime, maxSpawnTime + 1);
                List<BaseEnemy> Enemies = new List<BaseEnemy>();
                Enemies.Add(new BaseEnemy(null,Vector2.Zero,0,0,0,0,0, EnemyType.Goblin));
            
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
