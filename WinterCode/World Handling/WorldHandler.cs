using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterCode.World_Handling;

namespace WinterCode
{
    class WorldHandler
    {
        private static World[] worlds;
        private World world0;
        public static int[,] world0Map;
        public Tile[] tiles;

        public WorldHandler(Texture2D tileset, Tile[] tiles)
        {
            this.tiles = tiles;
            world0Map = IOHandler.loadLevelFromFile("World Handling/Levels/levelTest.txt");
            world0 = new World(world0Map, 80, 0, tileset, "Island World");
            worlds = new World[] { world0 };
        }

        public void draw(SpriteBatch sb, GameWindow w)
        {
            world0.drawWorld(sb, tiles, w);
        }
    }
}
