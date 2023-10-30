using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;
using System.IO;

namespace Lab4_Zakshevskij_UTS_22
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void menuOpen_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Текстовые файлы | *.txt";
            var result = dialog.ShowDialog();
            if (result == true)
            {
                Tb.Text = File.ReadAllText(dialog.FileName);
            }
        }
        public bool checkSave = false;
        public string justDialogSave;
        public void menuSave_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.Filter = "Текстовые файлы | *.txt";
            var result = dialog.ShowDialog();
            if (result == true)
            {
                checkSave = true;
                justDialogSave = dialog.FileName;
                File.WriteAllText(dialog.FileName, Tb.Text);
            }
        }
        private void menuJustSave_Click(object sender, RoutedEventArgs e)
        {
            if (checkSave)
            {
                File.WriteAllText(justDialogSave, Tb.Text);
            }
        }
        private void MenuUndo_Click(object sender, RoutedEventArgs e)
        {
            Tb.Undo();
        }

        private void MenuRedo_Click(object sender, RoutedEventArgs e)
        {
            Tb.Redo();
        }
        private void MenuAbout_Click(object sender, RoutedEventArgs e)
        {
            var about = new About();
            about.Show();
        }

        private void menuCreate_Click(object sender, RoutedEventArgs e)
        {
            Tb.Text = "";
        }
        private void TbEditor_SelectionChanged(object sender, TextChangedEventArgs e)
        { 
            string text = Tb.Text;
            if (text != "")
            {
                text = text.Trim(new char[] { ',', '.' });
                string[] textArray = text.Split(new char[] { ' ' });
                WordCheck.Text = "Количество слов: " + (textArray.Length-1).ToString();
            }
            else
            {
                WordCheck.Text = "Количество слов: 0";
            }
        }
    }
}
