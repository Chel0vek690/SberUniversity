using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace SberQ.ViewModel
{
    public partial class SliderVM : ObservableObject
    {
        [ObservableProperty]
        private double sliderValue;

        public string QuestionText { get; set; }
        public string Text1 { get; set; }
        public string Text2 { get; set; }
        public string Text3 { get; set; }
        
    }
}
