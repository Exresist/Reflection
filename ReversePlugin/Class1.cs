﻿using Reflection;
using System;
using System.Drawing;

namespace ReversePlugin
{
    [Version(1, 0)]
    public class ReversePlugin : IPlugin
    {
        public string Name
        {
            get
            {
                return "Переворот изображения";
            }

        }
        public string Author
        {
            get
            {
                return "Пахомов Герман";
            }
        }

        public void Transform(Bitmap bitmap)
        {
            for (int i = 0; i < bitmap.Width; ++i)
                for (int j = 0; j < bitmap.Height / 2; ++j)
                {
                    Color color = bitmap.GetPixel(i, j);
                    bitmap.SetPixel(i, j, bitmap.GetPixel(i, bitmap.Height - j - 1));
                    bitmap.SetPixel(i, bitmap.Height - j - 1, color);
                }

        }
    }
    }
