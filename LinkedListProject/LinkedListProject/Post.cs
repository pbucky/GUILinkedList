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
    class Post
    {
        public Post reply;
        public String author;
        public String text;
        public Post(String a, String b)
        {
            author = a;
            text = b;
        }
    }
}
