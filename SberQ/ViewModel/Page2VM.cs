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
        private ObservableCollection<SberQ.ViewModel.SliderVM> sliders;

        public Page2VM(Frame frame)
        {
            this.frame = frame;
            sliders = new ObservableCollection<SberQ.ViewModel.SliderVM>
            {
                new() { QuestionText = "1. На какой срок у вас есть карьерная цель:", Text1 = "Нет Цели", Text2 = "1-3 года", Text3 = "3+ лет", SliderValue = 0 },
                new() { QuestionText = "2. Как часто вы занимаетесь собственным развитием:", Text1 = "Редко", Text2 = "Периодически", Text3 = "Постоянно", SliderValue = 0 },
                new() { QuestionText = "3. Как вы понимаете свои сильные стороны:", Text1 = "Не было мысли про это", Text2 = "Запрашиваю обратную связь", Text3 = "Прохожу ассесмент", SliderValue = 0 },
                new() { QuestionText = "4. Как вы понимаете, какие компетенции нужно развивать:", Text1 = "По мере столкновения с трудностями", Text2 = "По рекомендации руководства и коллег", Text3 = "На основе карьерных консультаций", SliderValue = 0 },
                new() { QuestionText = "5. Где вы берете вдохновение на развитие:", Text1 = "А что это?", Text2 = "Надо значит надо", Text3 = "Меня заряжает стремление к амбициозным целям", SliderValue = 0 }
            };

        }

        [RelayCommand]
        private void NavigateToPage3()
        {
            double sum = Sliders.Sum(slider => slider.SliderValue);
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
