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
    class Post : DrawableGameComponent
    {
    	public Texture2D rect;
        public List<Post> replies;
        public String author;
        public String text;
        public int replyInd;
        public Game1 g;
        public Post(Game1 game, String a, String b) : base(game)
        {
            g = game;
            author = a;
            text = b;
            rect = new Texture2D(g.graphics.GraphicsDevice, 1, 1);
            rect.SetData(new[] { Color.White });
            replies = new List<Post>();
        }
        public void Reply(Post r)
        {
            if (replies[0] == null)
            {
                replies[0] = r;
            }
            else
            {
                replies[replyInd] = r;
            }
            replyInd++;
        }
        public override void Draw(GameTime gameTime)
        {
            for (int i = 0; i < replyInd + 1; i++)
            {
                replies[i].Draw(gameTime);
            }
            base.Draw(gameTime);
        }
        public override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

    }
}
