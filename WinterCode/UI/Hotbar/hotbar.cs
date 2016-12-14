using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinterCode.UI.Text;

namespace WinterCode
{
    class hotbar
    {
        public Texture2D texture;
        public Rectangle pos;

        private bool isSelector;

        public UIElement elem;

        GameWindow Window;

        public Item[] items;
        public int[] slots = new int[9];
        public int[] counts = new int[9];

        public int selectPos;
        public hotbar(Texture2D texture, Rectangle pos, bool isSelector, GameWindow Window, Item[] items)
        {
            this.texture = texture;
            this.pos = pos;
            this.isSelector = isSelector;
            this.elem = new UIElement(texture, pos);
            this.Window = Window;
            this.items = items;
        }

        public void addItem(Item item, int count)
        {
            if (isSelector == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    if (slots[i] == 0)
                    {
                        slots[i] = item.getId();
                        counts[i] = count;
                        Console.WriteLine("Inserted item '" + item.getName() + "' : '" + item.getId() + "' into slot " + i);
                        break;
                    }
                }
            }
        }

        public void removeItem(int slot, int count)
        {
            if (isSelector == false)
            {
                if (slots[slot] != 0)
                {
                    if(counts[slot] > 0)
                    {
                        counts[slot] = counts[slot] - count;
                    }else
                    {
                        slots[slot] = 0;
                    }
                }
            }
        }

        public void draw(SpriteBatch sb, SpriteFont ft)
        {
            elem.draw(sb);

            if(isSelector == false)
            {
                for (int i = 0; i < 9; i++)
                {
                    sb.Draw(items[slots[i]].getTexture(), new Rectangle((Window.ClientBounds.Width / 2 - 174) + 40 * i, Window.ClientBounds.Height - 38, 32, 32), Color.White);
                }

                TextHandler.drawTextWithOutline(sb, ft, new Vector2(0, Window.ClientBounds.Height - 30), 1, "Count:" + counts[selectPos]);
                TextHandler.drawTextWithOutline(sb, ft, new Vector2(0, Window.ClientBounds.Height - 15), 1, "item.ID:" + items[slots[selectPos]].getId());
                TextHandler.drawTextWithOutline(sb, ft, new Vector2((Window.ClientBounds.Width / 2) - 185 + (40 * selectPos), Window.ClientBounds.Height - 64), 1, items[slots[selectPos]].getName());
            }
        }

        public void drawItem(SpriteBatch sb, int id, int slot)
        {
            if(isSelector == false)
            {
                sb.Draw(items[id].getTexture(), new Rectangle((Window.ClientBounds.Width / 2 - 174) + 40 * slot, Window.ClientBounds.Height - 38, 32, 32), Color.White);
                
            }
        }

        public void update(GameTime gt)
        {
            if(isSelector == true)
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D1))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 0)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D2))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 1)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D3))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 2)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D4))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 3)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D5))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 4)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D6))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 5)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D7))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 6)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D8))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 7)), (Window.ClientBounds.Height - 46), 48, 48);
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D9))
                {
                    pos = new Rectangle((Window.ClientBounds.Width / 2 - 182 + (40 * 8)), (Window.ClientBounds.Height - 46), 48, 48);
                }

               elem.update(gt, pos);
            } else
            {
                if (Keyboard.GetState().IsKeyDown(Keys.D1))
                {
                    selectPos = 0;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D2))
                {
                    selectPos = 1;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D3))
                {
                    selectPos = 2;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D4))
                {
                    selectPos = 3;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D5))
                {
                    selectPos = 4;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D6))
                {
                    selectPos = 5;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D7))
                {
                    selectPos = 6;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D8))
                {
                    selectPos = 7;
                }

                if (Keyboard.GetState().IsKeyDown(Keys.D9))
                {
                    selectPos = 8;
                }
                elem.update(gt, pos);
            }
        }
    }
}
