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
    	public Texture2D tex;
        public List<Post> replies;
        // Parent is first post, previous is reply before this
        public Post parent, previous;
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
            tex = new Texture2D(g.graphics.GraphicsDevice, 1, 1);
            tex.SetData(new[] { Color.White });
            replies = new List<Post>();
        }
        public void Reply(Post r)
        {
            replies.Add(r);
            replies.ElementAt(replies.Count - 1).parent = this;
            if (replies.Count - 2 >= 0)
            {
                replies.ElementAt(replies.Count - 1).previous = replies.ElementAt(replies.Count - 2);
            }
        }
        public override void Draw(GameTime gameTime)
        {
            if (!(this.parent == null))
            {
                if (this.previous == null)
                {
                    g.spriteBatch.Draw(tex, new Rectangle(parent.box.X + 30, parent.box.Y + parent.box.Height + 5, parent.box.Width, parent.box.Height), Color.LightGray);
                    Vector2 coord = new Vector2(parent.box.X + 45, parent.box.Y + parent.box.Height + 55);
                    g.spriteBatch.DrawString(g.font1, author + " replying to: " + parent.author, coord, Color.Black);
                    g.spriteBatch.DrawString(g.font1, text, new Vector2(coord.X, coord.Y + 20), Color.Black);
                } else
                {
                    g.spriteBatch.Draw(tex, new Rectangle(previous.box.X + 30, previous.box.Y + previous.box.Height + 5, previous.box.Width, previous.box.Height), Color.LightGray);
                    Vector2 coord = new Vector2(previous.box.X + 45, previous.box.Y + previous.box.Height + 55);
                    g.spriteBatch.DrawString(g.font1, author + " replying to: " + parent.author, coord, Color.Black);
                    g.spriteBatch.DrawString(g.font1, text, new Vector2(coord.X, coord.Y + 20), Color.Black);
                }
            } else
            {
                g.spriteBatch.Draw(tex, box, Color.Black);
                Vector2 coord = new Vector2(box.X + 15, box.Y + 15);
                g.spriteBatch.DrawString(g.font1, author, coord, Color.White);
                g.spriteBatch.DrawString(g.font1, text, new Vector2(coord.X, coord.Y + 20), Color.White);
            }
            for (int i = 0; i < replies.Count; i++)
            {
                replies.ElementAt(i).Draw(gameTime);
            }
            base.Draw(gameTime);
           
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

    }
}
