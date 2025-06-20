using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Controls;
using System.Linq;
using System.Windows;

namespace SberQ.ViewModel
{
    public partial class Page2VM : ObservableObject
    {

        private readonly Frame frame;

        [ObservableProperty]
        private int sliderValue1;

        [ObservableProperty]
        private int sliderValue2;

        [ObservableProperty]
        private int sliderValue3;

        [ObservableProperty]
        private int sliderValue4;

        [ObservableProperty]
        private int sliderValue5;

        [ObservableProperty]
        private ObservableCollection<SberQ.ViewModel.SliderItem> sliders;


        public Page2VM(Frame frame)
        {
            this.frame = frame;
            sliders = new ObservableCollection<SberQ.ViewModel.SliderItem>
            {
                new SberQ.ViewModel.SliderItem { QuestionText = "1. На какой срок у вас есть карьерная цель:", Text1 = "Нет Цели", Text2 = "1-3 года", Text3 = "3+ лет", SliderValue = 0 },
                new SberQ.ViewModel.SliderItem { QuestionText = "2. Как часто вы занимаетесь собственным развитием:", Text1 = "Редко", Text2 = "Переодически", Text3 = "Постоянно", SliderValue = 0 },
                new SberQ.ViewModel.SliderItem { QuestionText = "3. Как вы понимаете свои сильные стороны:", Text1 = "Не было мысли про это", Text2 = "Запрашиваю обратную связь", Text3 = "Прохожу ассессмент", SliderValue = 0 },
                new SberQ.ViewModel.SliderItem { QuestionText = "4. Как вы понимаете, какие компетенции нужно развивать:", Text1 = "По мере столкновения с трудностями", Text2 = "По рекомендации руководства и коллег", Text3 = "На основе карьерных консультаций", SliderValue = 0 },
                new SberQ.ViewModel.SliderItem { QuestionText = "5. Где вы берете вдохновение на развитие:", Text1 = "А что это?", Text2 = "Надо значит надо", Text3 = "Меня заряжает стремление к амбициозным целям", SliderValue = 0 }
            };

        }

        [RelayCommand]
        private void NavigateToPage3()
        {
            //int sum = SliderValue1 + SliderValue2 + SliderValue3 + SliderValue4 + SliderValue5;
            double sum = Sliders.Sum(slider => slider.SliderValue);
            //MessageBox.Show(sum.ToString());
            string answer = sum.ToString();
            frame.Navigate(new Page3(answer));
        }

        [RelayCommand]
        private void ReturnToPage1()
        {
            frame.Navigate(new Page1());
        }
    }
}
