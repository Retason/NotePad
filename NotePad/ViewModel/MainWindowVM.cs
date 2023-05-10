using NotePad.Model;
using NotePad.View;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace NotePad.ViewModel
{
    internal class MainWindowVM : ObservableObject
    {
        public uint FontSize { get => Settings.FontSize; }
        public string FontName
        {
            get => Settings.Font;
        }
        public MainWindowVM()
        {
            FontCommand = new RelayCommand(Font);
            StyleCommand = new RelayCommand(Style);
            SaveCommand = new RelayCommand(Save);
            SaveAsCommand = new RelayCommand(SaveAs);
            OpenCommand = new RelayCommand(Open);
            ExitCommand = new RelayCommand(Exit);

            Settings.OnFontChange += (uint size) => { OnPropertyChanged(nameof(FontSize));};
            Settings.OnFontNameChange += (string name) => { OnPropertyChanged(nameof(FontName));};
        }

        private void Exit(object obj)
        {
            if (MyText.isEdited)
            {
                var result = MessageBox.Show($"Сохранить изменения в {MyText.FileName.Split('\\').Last()} ?", "Сохранить?", MessageBoxButton.YesNoCancel, MessageBoxImage.Question);
                switch(result)
                {
                    case MessageBoxResult.Yes:
                        if (!MyText.Save())
                            return;
                        break;
                    case MessageBoxResult.No: break;
                    case MessageBoxResult.Cancel: return;
                }
                Process.GetCurrentProcess().Kill();
            }
            else
            {
                Process.GetCurrentProcess().Kill();
            }
        }
        private void Font(object obj)
        {
            new FontWindow().ShowDialog();
        }
        private void Style(object obj)
        {
            new StyleWindow().ShowDialog();
        }
        private void Open(object obj)
        {
            MyText.Open();
            OnPropertyChanged(nameof(FileName));
            OnPropertyChanged(nameof(Text));
        }

        public void SaveAs(object obj)
        {
            MyText.SaveAs();
            OnPropertyChanged(nameof(FileName));
        }
        private void Save(object obj)
        {
            MyText.Save();
            OnPropertyChanged(nameof(FileName));
        }

        public RelayCommand FontCommand { get; set; }
        public RelayCommand StyleCommand { get; set; }
        public RelayCommand ExitCommand { get; set; }
        public RelayCommand OpenCommand { get; set; }
        public RelayCommand SaveCommand { get; set; }
        public RelayCommand SaveAsCommand { get; set; }
        private Text MyText = new Text();
        public string Text
        {
            get=>MyText.TextData;
            set
            {
                MyText.TextData = value;
                OnPropertyChanged(nameof(Text));
                OnPropertyChanged(nameof(FileName));
            }
        }
        public string FileName 
        {
            get
            {
                if (MyText.isEdited)
                    if (MyText.FileName.Length > 0)
                        return $"{MyText.FileName.Split('\\').Last()}*";
                    else
                        return "Notepad*";
                if (MyText.FileName.Length > 0)
                    return MyText.FileName.Split('\\').Last();
                else
                    return "Notepad";
            }
        }
    }
}
