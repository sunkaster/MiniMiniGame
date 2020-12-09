using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace minigame
{
    class BaseClass
    {
        //skapa här en textur och en position. Dessa kommer användas som bas till allt som har textur och position(spelare, fiende mm)
        protected Texture2D texture;
        protected Vector2 texturePos;
        protected float angle = 0;
        protected Vector2 mousePos;
        //en konstruktor.
        public BaseClass(Texture2D texture, Vector2 texturePos, float angle, Vector2 mousePos)
        {
            this.texture = texture;
            this.texturePos = texturePos;
            this.angle = angle;
            this.mousePos = mousePos;
        }
        //en virituell Update() metod.
        public virtual void Update()
        {

        }

    }
}
