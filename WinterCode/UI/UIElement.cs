using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode
{
    class UIElement
    {
        public Texture2D texture;
        public Rectangle pos;
        public UIElement(Texture2D texture, Rectangle pos)
        {
            this.texture = texture;
            this.pos = pos;
        }

        public void draw(SpriteBatch sb)
        {
            sb.Draw(texture, pos, Color.White);
        }

        public void update(GameTime gt, Rectangle pos)
        {
            this.pos = pos;
        }
    }
}
