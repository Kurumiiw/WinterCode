using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class itemList
    {
        public List<int> itemids = new List<int>();

        public void addItem(Texture2D texture, int id)
        {
            itemids.Add(id);
        }
    }
}
