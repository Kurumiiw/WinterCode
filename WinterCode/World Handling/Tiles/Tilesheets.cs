using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class Tilesheets
    {
        public static Rectangle getFromTilesheet(int tileId, int tilesheet)
        {
            switch (tilesheet)
            {
                default:
                    return new Rectangle(32 * 6, 32 * 9, 32, 32);
                case 0: //island tilesheet
                    if(tileId < 9)
                    {
                        return new Rectangle(32 * tileId, 32 * 0, 32, 32);
                    }else
                    {
                        if(tileId < 19)
                        {
                            return new Rectangle(32 * (tileId - 10), 32 * 1, 32, 32);
                        }else
                        {
                            if(tileId < 29)
                            {
                                return new Rectangle(32 * (tileId - 20), 32 * 2, 32, 32);
                            }else
                            {
                                if (tileId < 39)
                                {
                                    return new Rectangle(32 * (tileId - 30), 32 * 3, 32, 32);
                                }else
                                {
                                    if (tileId < 49)
                                    {
                                        return new Rectangle(32 * (tileId - 40), 32 * 4, 32, 32);
                                    }else
                                    {
                                        if (tileId < 59)
                                        {
                                            return new Rectangle(32 * (tileId - 50), 32 * 5, 32, 32);
                                        }else
                                        {
                                            if (tileId < 69)
                                            {
                                                return new Rectangle(32 * (tileId - 60), 32 * 6, 32, 32);
                                            }else
                                            {
                                                if (tileId < 79)
                                                {
                                                    return new Rectangle(32 * (tileId - 70), 32 * 7, 32, 32);
                                                }else
                                                {
                                                    if (tileId < 89)
                                                    {
                                                        return new Rectangle(32 * (tileId - 80), 32 * 8, 32, 32);
                                                    }else
                                                    {
                                                        if (tileId < 96)
                                                        {
                                                            return new Rectangle(32 * (tileId - 90), 32 * 9, 32, 32);
                                                        }
                                                        else
                                                        {
                                                            return new Rectangle(32 * 6, 32 * 9, 32, 32);
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
                case 1:
                    return new Rectangle(32 * tileId, 32 * tileId, 32, 32);
              }
         }

        public static Rectangle getFromCoords(int x, int y)
        {
           return new Rectangle(32 * x, 32 * y, 32, 32);
        }
    }
}
