using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinterCode.World_Handling.Tiles
{
    public class Animation
    {
        public Texture2D spritesheet;
        public int frames;
        public float animationSpeed;
        private int frameIndex = 0;
        private float time = 0;

        public Animation(SpriteBatch sb, Texture2D spritesheet, int totalFrames, float animationSpeed)
        {
            this.spritesheet = spritesheet;
            this.frames = totalFrames;
            this.animationSpeed = animationSpeed;
        }

        public void updateAnimation(GameTime gt)
        {
            time += (float)gt.ElapsedGameTime.TotalSeconds;
            if (time > animationSpeed)
            {
                frameIndex++;
                time = 0;
            }
            if (this.frameIndex > (frames - 1))
                this.frameIndex = 0;
        }

        public void drawAnimation(SpriteBatch sb, Rectangle position)
        {
            Rectangle source = new Rectangle(frameIndex * 32, 0, 32, 32);
            sb.Draw(spritesheet, position, source, Color.White);
        }
    }
}
