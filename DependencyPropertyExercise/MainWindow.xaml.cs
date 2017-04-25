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

namespace DependencyPropertyExercise
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Library> libraries = new List<Library>();
        int index;
        public MainWindow()
        {
            InitializeComponent();
            this.libraries.Add(new Library() { Roomnumber = 101, ContentDesc = "Leseraum", Level = 1 });
            this.libraries.Add(new Library() { Roomnumber = 102, ContentDesc = "Zeitschriften", Level = 1 });
            this.libraries.Add(new Library() { Roomnumber = 201, ContentDesc = "Romane", Level = 2 });
            this.libraries.Add(new Library() { Roomnumber = 202, ContentDesc = "Krimis", Level = 2 });
            this.libraries.Add(new Library() { Roomnumber = 301, ContentDesc = "Reisen", Level = 3 });
            this.libraries.Add(new Library() { Roomnumber = 302, ContentDesc = "Kinderbücher", Level = 3 });
            this.index = 0;
            this.DataContext = this.libraries[this.index];
        }

        private void Prev_Click(object sender, RoutedEventArgs e)
        {
            this.index--;
            if (this.index < 0)
            {
                this.index = this.libraries.Count - 1;
            }
            this.DataContext = this.libraries[this.index];
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.index = (this.index + 1) % this.libraries.Count;
            this.DataContext = this.libraries[this.index];
        }

    }
}
