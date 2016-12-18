using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class Item
    {
        int id;
        int MaxStack;
        String name;
        public Item( int id, int MaxStack, String name)
        {
            this.id = id;
            this.MaxStack = MaxStack;
            this.name = name;
        }

        public int getId()
        {
            return this.id;
        }

        public int getMaxStack()
        {
            return this.MaxStack;
        }

        public String getName()
        {
            return this.name;
        }
    }
}
