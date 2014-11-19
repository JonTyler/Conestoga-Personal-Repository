using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace JoryClassLibrary
{
    /// <summary>
    /// This is a game component that implements IUpdateable.It also implements
    /// ICollidable.
    /// </summary>
    public class Asteroid : GameObject , ICollidable<Asteroid>
    {
        Random r = new Random();
        public Asteroid(Game game, SpriteBatch spriteBatch,
            Texture2D texture,
            Vector2 position,
            float scaleFactor)
            : base(game,spriteBatch, texture, position, scaleFactor)
        {
            // TODO: Construct any child components here
            //arbitrarily sets the asteroid's rotation factor.
            int defaultRotation = r.Next(1, 4);
            int direction = r.Next(1, 2);
            if (direction%2 == 0)
            {
                defaultRotation = -Math.Abs(defaultRotation);
            }
            this.rotationFactor = (float)defaultRotation;
            
        }

        /// <summary>
        /// Allows the game component to perform any initialization it needs to before starting
        /// to run.  This is where it can query for any required services and load content.
        /// </summary>
        public override void Initialize()
        {
            // TODO: Add your initialization code here

            base.Initialize();
        }

        /// <summary>
        /// Allows the game component to update itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        public override void Update(GameTime gameTime)
        {
            // TODO: Add your update code here

            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            Rectangle r = new Rectangle(0, 0, texture.Width, texture.Height);

            spriteBatch.Begin();
            spriteBatch.Draw(texture, position, r, Color.White,
                rotationFactor, origin, scaleFactor, SpriteEffects.None, 0f);
            spriteBatch.End();
            base.Draw(gameTime);
        }

        public Rectangle getBounds()
        {
            return new Rectangle((int)position.X, (int)position.Y,
                texture.Width, texture.Height);
        }
    }
}
