using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using WinterCode.UI;
using WinterCode.UI.Text;
using WinterCode.World_Handling;
using WinterCode.World_Handling.Tiles;

namespace WinterCode
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        hotbar hotbar;
        hotbar hotbarSel;

        inventory inv;

        static Item noItem, test1, test2, test3;
        static Tile water, sand_top, sand_left, sand_right, sand_down, sand_TRcorner, sand_TLcorner, sand_BRcorner, sand_BLcorner, sand, sand_RTRcorner, sand_RTLcorner, sand_RBRcorner, sand_RBLcorner;
        static Tile[] tiles;
        public SpriteFont debug;

        WorldHandler worldHandler;
        IOHandler IOHandler = new IOHandler();

        public static Camera2D _camera;

        public static Animation waterAnimation;
        public static Animation grassAnimation;

        public static Texture2D itemSpritesheet;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
            Content.RootDirectory = "Content";
            this.Window.AllowUserResizing = true;
        }

        protected override void Initialize()
        {
            _camera = new Camera2D(GraphicsDevice.Viewport);

            water = new Tile(0, "water", false);
            sand_top = new Tile(1, "sand_top", true);
            sand_TRcorner = new Tile(2, "sand_topright_corner", true);
            sand_TLcorner = new Tile(3, "sand_topleft_corner", true);
            sand_left = new Tile(11, "sand_left", true);
            sand_BLcorner = new Tile(12, "sand_bottomleft_corner", true);
            sand_BRcorner = new Tile(13, "sand_bottomright_corner", true);
            sand_right = new Tile(21, "sand_right", true);
            sand_down = new Tile(31, "sand_down", true);
            sand = new Tile(6, "sand", true);
            sand_RBLcorner = new Tile(15, "sand_revered_bottomleft_corner", true);
            sand_RBRcorner = new Tile(16, "sand_revered_bottomright_corner", true);
            sand_RTRcorner = new Tile(4, "sand_revered_topright_corner", true);
            sand_RTLcorner = new Tile(5, "sand_revered_topleft_corner", true);

            tiles = new Tile[] { water, sand_top, sand_TRcorner, sand_TLcorner, sand_left, sand_BLcorner, sand_BRcorner, sand_right, sand_down, sand, sand_RTLcorner, sand_RTRcorner, sand_RBLcorner, sand_RBRcorner};


            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            itemSpritesheet = Content.Load<Texture2D>("Spritesheets/items");
            inv = new inventory(Window);
            noItem = new Item(0, 12, "NoItem");
            test1 = new Item(1, 12, "test item 1");
            test2 = new Item(2, 12, "test item 2");
            test3 = new Item(3, 12, "test item 3");

            Item[] items = { noItem, test1, test2, test3 };

            hotbar = new hotbar(Content.Load<Texture2D>("Spritesheets/ui"), new Rectangle((Window.ClientBounds.Width / 2 - 100), (Window.ClientBounds.Height - 44), 364, 44), false, Window, items);
            hotbarSel = new hotbar(Content.Load<Texture2D>("Spritesheets/ui"), new Rectangle((Window.ClientBounds.Width / 2 - 102), (Window.ClientBounds.Height - 46), 48, 48), true, Window, items);

            debug = Content.Load<SpriteFont>("Fonts/debugfont");
            waterAnimation = new Animation(spriteBatch, Content.Load<Texture2D>("Animations/water_animation"), 8, 0.2f);
            grassAnimation = new Animation(spriteBatch, Content.Load<Texture2D>("Animations/grass_animation"), 8, 0.3f);
            worldHandler = new WorldHandler(Content.Load<Texture2D>("Spritesheets/tileset"), tiles);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            var deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            hotbar.update(gameTime);
            hotbarSel.update(gameTime);
            inv.update(gameTime);
            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.I))
                hotbar.addItem(test1, 5);

            if (Keyboard.GetState().IsKeyDown(Keys.P))
                hotbar.addItem(test3, 1);

            if (Keyboard.GetState().IsKeyDown(Keys.K))
                hotbar.addItemOnto(test2, 1);

            if (Keyboard.GetState().IsKeyDown(Keys.L))
                hotbar.removeItem(hotbar.selectPos, 1);

            int boost = 1;
            //cameradebugging
            if (Keyboard.GetState().IsKeyDown(Keys.LeftShift))
            {
                boost = 3;
            }else
            {
                boost = 1;
            }

                

            if (Keyboard.GetState().IsKeyDown(Keys.W))
                _camera.Position -= new Vector2(0, 50 * boost) * deltaTime;

            if (Keyboard.GetState().IsKeyDown(Keys.A))
                _camera.Position -= new Vector2(50 * boost, 0) * deltaTime;

            if (Keyboard.GetState().IsKeyDown(Keys.S))
                _camera.Position += new Vector2(0, 50 * boost) * deltaTime;

            if (Keyboard.GetState().IsKeyDown(Keys.D))
                _camera.Position += new Vector2(50 * boost, 0) * deltaTime;

            waterAnimation.updateAnimation(gameTime);
            grassAnimation.updateAnimation(gameTime);
            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            var viewMatrix = _camera.GetViewMatrix();
            //NonUI things, like World
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise, null, transformMatrix: viewMatrix);

            worldHandler.draw(spriteBatch, Window, gameTime);

            spriteBatch.End();
            //UI
            spriteBatch.Begin(SpriteSortMode.Deferred, BlendState.AlphaBlend, SamplerState.PointClamp, DepthStencilState.None, RasterizerState.CullCounterClockwise);
            hotbar.draw(spriteBatch, debug);
            hotbarSel.draw(spriteBatch, debug);
            inv.draw(spriteBatch);

            TextHandler.drawTextWithOutline(spriteBatch, debug, new Vector2(0, 0), 2, "FPS:" + Math.Round(1/((float)gameTime.ElapsedGameTime.TotalSeconds)));
            TextHandler.drawTextWithOutline(spriteBatch, debug, new Vector2(0, 15), 2, "dev release 06 - 'animatronic images'");
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
