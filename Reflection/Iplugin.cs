using System;
using System.Drawing;

namespace Reflection
{
    


        public interface IPlugin
        {
            string Name { get; }
            string Author { get; }
            void Transform(Bitmap app);
        }
}
