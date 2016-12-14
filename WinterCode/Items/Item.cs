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
        Texture2D texture;
        int id;
        int MaxStack;
        String name;
        public Item(Texture2D texture, int id, int MaxStack, String name)
        {
            this.texture = texture;
            this.id = id;
            this.MaxStack = MaxStack;
            this.name = name;
        }


        public Texture2D getTexture()
        {
            return this.texture;
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
