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
    public class GameObject : Microsoft.Xna.Framework.DrawableGameComponent
    {
        //the base class for all Jorystar game objects.
        protected SpriteBatch spriteBatch;
        protected Texture2D texture;
        protected Vector2 position;
        private Vector2 velocity;

        public Vector2 Velocity
        {
            get { return velocity; }
            set { velocity = value; }
        }
        protected Vector2 origin;
        protected float scaleFactor = 1.0f;
        protected float rotationFactor = 0f;
        private float rotationChange = 0.03f;

        public float RotationChange
        {
            get { return rotationChange; }
            set { rotationChange = value; }
        }

        private int hitPoints = 0;

        public int HitPoints
        {
            get { return hitPoints; }
            set { hitPoints = value; }
        }
        public GameObject(Game game,
            SpriteBatch spriteBatch,
            Texture2D texture,
            Vector2 position,
            float scaleFactor)
            : base(game)
        {
            this.spriteBatch = spriteBatch;
            this.texture = texture;
            this.position = position;
            this.scaleFactor = scaleFactor;

            this.origin = new Vector2(texture.Width / 2, texture.Height / 2);
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        public override void Update(GameTime gameTime)
        {
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
    }
}
