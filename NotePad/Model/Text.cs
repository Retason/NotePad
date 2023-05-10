using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotePad.Model
{
    internal class Text
    {
        private string textData = string.Empty;
        public string TextData
        {
            get => textData;
            set
            {
                textData = value ?? string.Empty;
                isEdited = true;
            }
        }
        public string FileName { get; private set; } = string.Empty;
        public bool isEdited { get; private set; }
        public bool Save()
        {
            if (FileName.Length > 0)
            {
                File.WriteAllText(FileName, textData, Encoding.Unicode);
                isEdited = false;
                return true;
            }
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Title = "Save text file",
                Filter = "Text file (*.txt)|*.txt",
                AddExtension = true,
            };

            if (dialog.ShowDialog().Value)
            {
                File.WriteAllText(dialog.FileName, textData, Encoding.Unicode);
                FileName = dialog.FileName;
                isEdited = false;
                return true;
            }
            return false;
        }
        public void SaveAs()
        {
            SaveFileDialog dialog = new SaveFileDialog()
            {
                Title = "Save text file",
                Filter = "Text file (*.txt)|*.txt",
                AddExtension = true,
            };
            if (dialog.ShowDialog().Value)
            {
                File.WriteAllText(dialog.FileName, textData, Encoding.Unicode);
                isEdited = false;
            }
        }

        internal void Open()
        {
            OpenFileDialog dialog = new OpenFileDialog()
            {
                Title = "Open text file",
                Filter = "Text file (*.txt)|*.txt",
                Multiselect = false,
            };
            if (dialog.ShowDialog().Value)
            {
                textData = File.ReadAllText(dialog.FileName);
                FileName = dialog.FileName;
                isEdited = false;
            }
        }
    }
}
