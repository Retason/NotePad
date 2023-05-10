using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Model
{
    public static class Settings
    {
        public delegate void FontChange(uint size);
        public static event FontChange OnFontChange;
        private static uint fontSize = 12;

        public delegate void FontNameChange(string name);
        public static event FontNameChange OnFontNameChange;

        private static string font = "Arial";
        public static string Font
        {
            get => font;
            set
            {

                font = value;
                OnFontNameChange?.Invoke(font);

            }
        }

        public static uint FontSize
        {
            get => fontSize;
            set
            {
                if (value > 5)
                {
                    fontSize = value;
                    OnFontChange?.Invoke(fontSize);
                }
            }
        }
    }
}
