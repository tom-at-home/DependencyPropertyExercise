using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DependencyPropertyExercise
{
    class Library : DependencyObject
    {

        public static readonly DependencyProperty RoomnumberProperty;
        public static readonly DependencyProperty ContentDescProperty;
        public static readonly DependencyProperty LevelProperty;

        static Library()
        {
            RoomnumberProperty = DependencyProperty.Register("Roomnumber", typeof(int), typeof(Library));
            ContentDescProperty = DependencyProperty.Register("ContentDesc", typeof(string), typeof(Library));
            LevelProperty = DependencyProperty.Register("Level", typeof(int), typeof(Library));
        }

        public int Roomnumber
        {
            set { SetValue(RoomnumberProperty, value); }
            get { return (int)GetValue(RoomnumberProperty); }
        }

        public string ContentDesc
        {
            set { SetValue(ContentDescProperty, value); }
            get { return (string)GetValue(ContentDescProperty); }
        }

        public int Level
        {
            set { SetValue(LevelProperty, value); }
            get { return (int)GetValue(LevelProperty); }
        }

    }
}
