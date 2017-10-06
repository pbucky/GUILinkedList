using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace LinkedListProject
{
    public class Thread : DrawableGameComponent
    {
        public Post head;
        public Rectangle backgroundBox;
        protected Texture2D tex;
        protected SpriteBatch spriteBat;
        public Thread(Game1 game, String a, String t) : base(game)
        {
            head = new Post(game, a, t, this);
            spriteBat = game.spriteBatch;
            backgroundBox = new Rectangle(0, 0, 300, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
            tex = new Texture2D(game.graphics.GraphicsDevice, 1, 1);
            tex.SetData(new[] { Color.White });
        }
        public override void Draw(GameTime gameTime)
        {
            spriteBat.Begin();
            spriteBat.Draw(tex, backgroundBox, Color.Tan);
            spriteBat.End();
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
