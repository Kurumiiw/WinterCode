using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using WinterCode.UI.Text;

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

        static Item noItem, nullItem, test1, test2, test3;
        static Tile water, sand_top, sand_left, sand_right, sand_down, sand_TRcorner, sand_TLcorner, sand_BRcorner, sand_BLcorner, sand, sand_RTRcorner, sand_RTLcorner, sand_RBRcorner, sand_RBLcorner;
        static Tile[] tiles;
        public SpriteFont debug;

        WorldHandler worldHandler;
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            IsMouseVisible = true;
            Content.RootDirectory = "Content";
        }

        protected override void Initialize()
        {
            water = new Tile(0, "Water", false);
            sand_top = new Tile(1, "Sand", true);
            sand_TRcorner = new Tile(2, "Sand", true);
            sand_TLcorner = new Tile(3, "Sand", true);
            sand_left = new Tile(11, "Sand", true);
            sand_BLcorner = new Tile(12, "Sand", true);
            sand_BRcorner = new Tile(13, "Sand", true);
            sand_right = new Tile(21, "Sand", true);
            sand_down = new Tile(31, "Sand", true);
            sand = new Tile(6, "Sand", true);
            sand_RBLcorner = new Tile(15, "Sand", true);
            sand_RBRcorner = new Tile(16, "Sand", true);
            sand_RTRcorner = new Tile(4, "Sand", true);
            sand_RTLcorner = new Tile(5, "Sand", true);

            tiles = new Tile[] { water, sand_top, sand_TRcorner, sand_TLcorner, sand_left, sand_BLcorner, sand_BRcorner, sand_right, sand_down, sand, sand_RTLcorner, sand_RTRcorner, sand_RBLcorner, sand_RBRcorner};

            base.Initialize();
        }

        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            inv = new inventory(Window);
            noItem = new Item(Content.Load<Texture2D>("empty"), 0, 12, "NoItem");
            nullItem = new Item(Content.Load<Texture2D>("nullItem"), 1, 12, "nullItem");
            test1 = new Item(Content.Load<Texture2D>("test1"), 2, 12, "test item 1");
            test2 = new Item(Content.Load<Texture2D>("test2"), 3, 12, "test item 2");
            test3 = new Item(Content.Load<Texture2D>("test3"), 4, 12, "test item 3");

            Item[] items = { noItem, nullItem, test1, test2, test3 };

            hotbar = new hotbar(Content.Load<Texture2D>("hotbar"), new Rectangle((Window.ClientBounds.Width / 2 - 100), (Window.ClientBounds.Height - 44), 364, 44), false, Window, items);
            hotbarSel = new hotbar(Content.Load<Texture2D>("hotbarSelector"), new Rectangle((Window.ClientBounds.Width / 2 - 102), (Window.ClientBounds.Height - 46), 48, 48), true, Window, items);

            debug = Content.Load<SpriteFont>("debugfont");

            worldHandler = new WorldHandler(Content.Load<Texture2D>("tileset"), tiles);
        }

        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            hotbar.update(gameTime);
            hotbarSel.update(gameTime);
            inv.update(gameTime);
            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.I))
                hotbar.addItem(test1, 1);

            if (Keyboard.GetState().IsKeyDown(Keys.O))
                hotbar.addItem(test2, 1);

            if (Keyboard.GetState().IsKeyDown(Keys.P))
                hotbar.addItem(test3, 1);

            if (Keyboard.GetState().IsKeyDown(Keys.L))
                hotbar.removeItem(hotbar.selectPos, 1);

            base.Update(gameTime);
        }
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            worldHandler.draw(spriteBatch);

            hotbar.draw(spriteBatch, debug);
            hotbarSel.draw(spriteBatch, debug);
            inv.draw(spriteBatch);

            TextHandler.drawTextWithOutline(spriteBatch, debug, new Vector2(0, 0), 2, "dev release 03 - 'worldbuilding'");
            spriteBatch.End();
            base.Draw(gameTime);
        }
    }
}
