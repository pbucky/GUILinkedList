﻿using System;
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
        protected Game1 game;
        public Thread(Game1 game, String a, String t) : base(game)
        {
            backgroundBox = new Rectangle(0, 0, 300, GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height);
            this.game = game;
            head = new Post(game, a, t, this);
            spriteBat = game.spriteBatch;
            tex = new Texture2D(game.graphics.GraphicsDevice, 1, 1);
            tex.SetData(new[] { Color.White });
        }
        public override void Draw(GameTime gameTime)
        {
            game.spriteBatch.Draw(tex, backgroundBox, Color.Tan);
            head.Draw(gameTime);
            //base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }
    }
}
