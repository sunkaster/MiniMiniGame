using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace minigame
{
    class Player : BaseClass  //ärv in här
    {
        public Player(Texture2D texture, Vector2 texturePos, float angle, Vector2 mousePos) : base(texture, texturePos, angle, mousePos) //referera här (Konstruktor)
        {

        }

        public override void Update()
        {
            //spelarens rörelser bla..
            KeyboardState kstate = Keyboard.GetState();
            if (kstate.IsKeyDown(Keys.W))
            {
                texturePos.Y -=2;
            }
            if (kstate.IsKeyDown(Keys.S))
            {
                texturePos.Y +=2;
            }
            if (kstate.IsKeyDown(Keys.D))
            {
                texturePos.X += 3;
            }
           if (kstate.IsKeyDown(Keys.A))
            {
                texturePos.X -= 3;
            }

            mousePos = Mouse.GetState().Position.ToVector2();
            angle = (float)Math.Atan2(texturePos.Y - mousePos.Y, texturePos.X - mousePos.X) + (float)(Math.PI*1.5);
        }

        
        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, new Rectangle((int)texturePos.X, (int)texturePos.Y, 100, 100), null, Color.White, angle, new Vector2(texture.Width / 2, texture.Height / 2), SpriteEffects.None, 0);     //spelarens tex och pos
        }

    }
}
