using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterCode.World_Handling.Tiles;

namespace WinterCode
{
    class World
    {
        public int[,] map;
        public int mapSize;
        public int id;
        public Texture2D tileset;
        public String name;
        public World(int[,] map, int mapSize, int id, Texture2D tileset, String name)
        {
            this.map = map;
            this.mapSize = mapSize;
            this.id = id;
            this.tileset = tileset;
            this.name = name;
        }

        public void drawWorld(SpriteBatch sb, Tile[] tiles, GameWindow Window, GameTime gt)
        {
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    if (x * 32 < Window.ClientBounds.Width + Game1._camera.Position.X)
                    {
                        if (y * 32 < Window.ClientBounds.Height + Game1._camera.Position.Y)
                        {
                            switch(map[y, x])
                            {
                                case 0:
                                    Game1.waterAnimation.drawAnimation(sb, new Rectangle(x * 32, y * 32, 32, 32));
                                    break;
                                case 1:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 0), Color.White);
                                    break;
                                case 2:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(2, 0), Color.White);
                                    break;
                                case 3:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(3, 0), Color.White);
                                    break;
                                case 4:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(4, 0), Color.White);
                                    break;
                                case 5:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(5, 0), Color.White);
                                    break;
                                case 6:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(6, 0), Color.White);
                                    break;
                                case 11:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 1), Color.White);
                                    break;
                                case 12:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(2, 1), Color.White);
                                    break;
                                case 13:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(3, 1), Color.White);
                                    break;
                                case 14:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(4, 1), Color.White);
                                    break;
                                case 15:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(5, 1), Color.White);
                                    break;
                                case 21:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 2), Color.White);
                                    break;
                                case 25:
                                    Game1.grassAnimation.drawAnimation(sb, new Rectangle(x * 32, y * 32, 32, 32));
                                    break;
                                case 31:
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 3), Color.White);
                                    break;

                            }
                        }
                    }
                }
            }
        }

        public int[,] getMap()
        {
            return map;
        }

        public int getId()
        {
            return id;
        }

        public Texture2D getTileset()
        {
            return tileset;
        }

        public String getName()
        {
            return name;
        }
    }
}
