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

namespace SberQ.View.UC
{
    /// <summary>
    /// Логика взаимодействия для UCSlider.xaml
    /// </summary>
    public partial class UCSlider : UserControl
    {
        public UCSlider()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty SliderValueProperty =
        DependencyProperty.Register("SliderValue", typeof(double), typeof(UCSlider), new PropertyMetadata(0.0));

        public double SliderValue
        {
            get { return (double)GetValue(SliderValueProperty); }
            set { SetValue(SliderValueProperty, value); }
        }

        public static readonly DependencyProperty QuestionProperty =
            DependencyProperty.Register("Question", typeof(string), typeof(UCSlider), new PropertyMetadata(string.Empty));

        public string Question
        {
            get { return (string)GetValue(QuestionProperty); }
            set { SetValue(QuestionProperty, value); }
        }

        public static readonly DependencyProperty Text1Property =
            DependencyProperty.Register("Text1", typeof(string), typeof(UCSlider), new PropertyMetadata(string.Empty));

        public string Text1
        {
            get { return (string)GetValue(Text1Property); }
            set { SetValue(Text1Property, value); }
        }

        public static readonly DependencyProperty Text2Property =
            DependencyProperty.Register("Text2", typeof(string), typeof(UCSlider), new PropertyMetadata(string.Empty));

        public string Text2
        {
            get { return (string)GetValue(Text2Property); }
            set { SetValue(Text2Property, value); }
        }

        public static readonly DependencyProperty Text3Property =
            DependencyProperty.Register("Text3", typeof(string), typeof(UCSlider), new PropertyMetadata(string.Empty));

        public string Text3
        {
            get { return (string)GetValue(Text3Property); }
            set { SetValue(Text3Property, value); }
        }

    }
}
