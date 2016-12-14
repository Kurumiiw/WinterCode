using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class World
    {
        public Tile[,] map;
        public int mapSize;
        public int id;
        public Texture2D tileset;
        public String name;

        public World(Tile[,] map, int mapSize, int id, Texture2D tileset, String name)
        {
            this.map = map;
            this.mapSize = mapSize;
            this.id = id;
            this.tileset = tileset;
            this.name = name;
        }

        public void drawWorld(SpriteBatch sb, Tile[] tiles)
        {
            for (int x = 0; x < mapSize; x++)
            {
                for (int y = 0; y < mapSize; y++)
                {
                    if (map[y, x] == tiles[0])
                    {
                        sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(0, 0), Color.White);
                    }
                    else
                    {
                        if (map[y, x] == tiles[1])
                        {
                            sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 0), Color.White);
                        }
                        else
                        {
                            if (map[y, x] == tiles[2])
                            {
                                sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(2, 0), Color.White);
                            }
                            else
                            {
                                if (map[y, x] == tiles[3])
                                {
                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(3, 0), Color.White);
                                }
                                else
                                {
                                    if (map[y, x] == tiles[4])
                                    {
                                        sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 1), Color.White);
                                    }else
                                    {
                                        if(map[y, x] == tiles[5])
                                        {
                                            sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(2, 1), Color.White);
                                        }else
                                        {
                                            if (map[y, x] == tiles[6])
                                            {
                                                sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(3, 1), Color.White);
                                            }else
                                            {
                                                if (map[y, x] == tiles[7])
                                                {
                                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 2), Color.White);
                                                }else
                                                {
                                                    if (map[y, x] == tiles[8])
                                                    {
                                                        sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(1, 3), Color.White);
                                                    }else
                                                    {
                                                        if (map[y, x] == tiles[9])
                                                        {
                                                            sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(6, 0), Color.White);
                                                        }else
                                                        {
                                                            if (map[y, x] == tiles[10])
                                                            {
                                                                sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(5, 0), Color.White);
                                                            }else
                                                            {
                                                                if (map[y, x] == tiles[11])
                                                                {
                                                                    sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(5, 0), Color.White);
                                                                }else
                                                                {
                                                                    if (map[y, x] == tiles[12])
                                                                    {
                                                                        sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(4, 1), Color.White);
                                                                    }else
                                                                    {
                                                                        if (map[y, x] == tiles[13])
                                                                        {
                                                                            sb.Draw(tileset, new Rectangle(x * 32, y * 32, 32, 32), Tilesheets.getFromCoords(5, 1), Color.White);
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public Tile[,] getMap()
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
