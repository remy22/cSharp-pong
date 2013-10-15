using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Pong
{
    class Player : GameObject
    {
        public override void Move(Vector2 amount)
        {
            base.Move(amount);
            if (Position.Y <= 0)
                Position.Y = 0;
            if (Position.Y + Texture.Height >= Game1.ScreenHeight)
                Position.Y = Game1.ScreenHeight - Texture.Height;
        }
    }
}
