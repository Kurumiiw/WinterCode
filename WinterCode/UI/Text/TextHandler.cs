using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode.UI.Text
{
    class TextHandler
    {
        public static void drawTextWithOutline(SpriteBatch sb, SpriteFont font, Vector2 position, int thickness, String text) {
            sb.DrawString(font, text, new Vector2(position.X + thickness, position.Y), Color.Black);
            sb.DrawString(font, text, new Vector2(position.X, position.Y + thickness), Color.Black);
            sb.DrawString(font, text, new Vector2(position.X - thickness, position.Y), Color.Black);
            sb.DrawString(font, text, new Vector2(position.X, position.Y - thickness), Color.Black);
            sb.DrawString(font, text, position, Color.White);
        }
    }
}
