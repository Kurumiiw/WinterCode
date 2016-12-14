using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class WorldHandler
    {
        private static World[] worlds;
        private World world0;
        public static Tile[,] world0Map;
        public Tile[] tiles;

        public WorldHandler(Texture2D tileset, Tile[] tiles)
        {
            this.tiles = tiles;
            world0Map = new Tile[,] { 
                { tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0] },
                { tiles[0], tiles[2], tiles[1], tiles[1], tiles[1], tiles[1], tiles[1], tiles[1], tiles[3], tiles[0] },
                { tiles[0], tiles[4], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[7], tiles[0] },
                { tiles[0], tiles[4], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[7], tiles[0] },
                { tiles[0], tiles[4], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[7], tiles[0] },
                { tiles[0], tiles[4], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[9], tiles[12], tiles[1] },
                { tiles[0], tiles[5], tiles[8], tiles[8], tiles[8], tiles[8], tiles[8], tiles[8], tiles[8], tiles[8] },
                { tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0] },
                { tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0] },
                { tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0], tiles[0] },
            };
            world0 = new World(world0Map, 10, 0, tileset, "Island World");
            worlds = new World[] { world0 };
        }

        public void draw(SpriteBatch sb)
        {
            world0.drawWorld(sb, tiles);
        }
    }
}
