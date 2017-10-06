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
    public class Post : DrawableGameComponent
    {
    	public Texture2D rect;
        public List<Post> replies;
        public String author;
        public Rectangle box;
        public String text;
        public Game1 g;
        public Post(Game1 game, String a, String b, Thread t) : base(game)
        {
            box = new Rectangle(t.backgroundBox.X + 15, t.backgroundBox.Y + 15, t.backgroundBox.Width - 30, t.backgroundBox.Height / 8);
            g = game;
            author = a;
            text = b;
            rect = new Texture2D(g.graphics.GraphicsDevice, 1, 1);
            rect.SetData(new[] { Color.White });
            replies = new List<Post>();
        }
        public void Reply(Post r)
        {
            replies.Add(r);
        }
        public override void Draw(GameTime gameTime)
        {
            g.spriteBatch.Draw(rect, box, Color.Black);
            g.spriteBatch.DrawString(g.font1, author, new Vector2(box.X + 15, box.Y + 15), Color.White);
            g.spriteBatch.DrawString(g.font1, text, new Vector2(box.X + 15, box.Y + 30), Color.White);
            for (int i = 0; i < replies.Count; i++)
            {
                replies.ElementAt(i).Draw(gameTime);
            }
            g.spriteBatch.End();
            base.Draw(gameTime);
           
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

    }
}
