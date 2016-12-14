using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class inventory
    {
        GameWindow Window;
        public int[,] inventoryArray = new int[,] { { 0, 0 }, { 0, 0 }, { 0, 0 }, { 0, 0 } };
        public inventory(GameWindow Window)
        {
            this.Window = Window;
        }

        public void draw(SpriteBatch sb)
        {
        }

        public void update(GameTime gt)
        {
        }
    }
}
