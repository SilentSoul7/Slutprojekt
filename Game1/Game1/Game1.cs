using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game1
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        BaseObject baseObject = new BaseObject();
        public  List<BaseObject> gameObjects = new List<BaseObject>();

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            gameObjects.Add(new BaseEnemy(Content.Load<Texture2D>("Goblin"), new Vector2(375, 220), 1, 3, 1, 0, 0, BaseEnemy.EnemyType.Goblin));
            Player player = new Player(Content.Load<Texture2D>("Knight"), new Vector2(100, 200));
            gameObjects.Add(player);
            gameObjects.Add(new Death(player));
            gameObjects.Add(new Ground(Content.Load<Texture2D>("Ground"), new Rectangle(400, 240, 800, 480)));
            base.Initialize();

        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            BaseObject.SetTexture(GraphicsDevice);
            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
            
        }
        BaseEnemy BE;
        public virtual void SpawnEnemy()
        {
            float spawntime = 1;
            spawntime -= 1f / 60;
            
            if (0 >= spawntime)
            {
                Random random = new Random();
                spawntime = random.Next(BE.minSpawnTime, BE.maxSpawnTime + 1);
                gameObjects.Add(new BaseEnemy(Content.Load<Texture2D>("Goblin"), new Vector2(375, 220), 1, 3, 1, 0, 0, BaseEnemy.EnemyType.Goblin));
            }
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            SpawnEnemy();
            // TODO: Add your update logic here


            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            spriteBatch.Begin();
            baseObject.Draw(spriteBatch);
            baseObject.DrawString(spriteBatch);
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
