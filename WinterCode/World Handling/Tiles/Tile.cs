using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class Tile
    {
        public int id;
        public String name;
        public bool passable;

        public Tile(int id, String name, bool passable)
        {
            this.id = id;
            this.name = name;
            this.passable = passable;
        }

        public int getId()
        {
            return id;
        }

        public String getName()
        {
            return name;
        }

        public bool getPassable()
        {
            return passable;
        }
    }
}