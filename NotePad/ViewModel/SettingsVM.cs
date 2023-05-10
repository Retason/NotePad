using NotePad.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace NotePad.ViewModel
{
    internal class SettingsVM : ObservableObject
    {
        #region lang
        private ListBoxItem selectedLanguage;
        public ListBoxItem SelectedLanguage
        {
            get => selectedLanguage;
            set
            {
                selectedLanguage = value;

                string str = selectedLanguage.Content.ToString();
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri($"Languages\\LANG_{str}.xaml", UriKind.Relative);
                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null && d.Source.OriginalString.StartsWith("Languages\\LANG_")
                                              select d).First();
                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
            }
        }
        public ObservableCollection<ListBoxItem> Languages { get; set; } = new ObservableCollection<ListBoxItem>();
        #endregion

        #region theme
        private ListBoxItem selectedTheme;
        public ListBoxItem SelectedTheme
        {
            get => selectedTheme;
            set
            {
                selectedTheme = value;

                string str = selectedTheme.Content.ToString();
                ResourceDictionary dict = new ResourceDictionary();
                dict.Source = new Uri($"Themes\\THEME_{str}.xaml", UriKind.Relative);
                ResourceDictionary oldDict = (from d in Application.Current.Resources.MergedDictionaries
                                              where d.Source != null && d.Source.OriginalString.StartsWith("Themes\\THEME_")
                                              select d).First();
                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
            }
        }
        public ObservableCollection<ListBoxItem> Themes { get; set; } = new ObservableCollection<ListBoxItem>();
        #endregion

        private ListBoxItem selectedFont;
        public ListBoxItem SelectedFont
        {
            get => selectedFont;
            set
            {
                selectedFont = value;
                Settings.Font = value.Content.ToString();
            }
        }
        public ObservableCollection<ListBoxItem> Fonts { get; set; } = new ObservableCollection<ListBoxItem>();

        public SettingsVM()
        {
            InstalledFontCollection fontCol = new InstalledFontCollection();
            for (int x = 0; x <= fontCol.Families.Length - 1; x++)
            {
                var v = new ListBoxItem() { Content = fontCol.Families[x].Name };
                Fonts.Add(v);
            }

            Themes.Add(new ListBoxItem() { Content = "Dark" });
            Themes.Add(new ListBoxItem() { Content = "Light" });

            Languages.Add(new ListBoxItem() { Content = "Russian" });
            Languages.Add(new ListBoxItem() { Content = "English" });

            selectedFont = Fonts[0];
            selectedTheme = Themes[0];
            selectedLanguage = Languages[0];
            FontUpCommand = new RelayCommand(FontUp);
            FontDownCommand = new RelayCommand(FontDown);
        }

        private void Language(object obj)
        {
            
        }

        private void FontDown(object obj)
        {
            Settings.FontSize--;
            OnPropertyChanged(nameof(FontSize));
        }

        private void FontUp(object obj)
        {
            Settings.FontSize++;
            OnPropertyChanged(nameof(FontSize));
        }

        public uint FontSize 
        { 
            get => Settings.FontSize;
            set
            {
                Settings.FontSize = value;
                OnPropertyChanged(nameof(FontSize));
            }
        }
        public RelayCommand FontUpCommand { get; set; }
        public RelayCommand FontDownCommand { get; set; }
        public RelayCommand LanguageCommand { get; set; }
    }
}
