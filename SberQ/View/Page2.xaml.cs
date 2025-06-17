using SberQ.ViewModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Media;
using System.Windows.Navigation;

namespace SberQ
{
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();

            var frame = ((MainWindow)Application.Current.MainWindow).toPage1;
            DataContext = new Page2VM(frame);

            Page2Slider2.ApplyTemplate();
            var track1 = Page2Slider2.Template.FindName("PART_Track", Page2Slider2) as Track;
            if (track1?.IncreaseRepeatButton != null)
            {
                IncreaseButtonClip(track1.IncreaseRepeatButton);
            }

            Page2_Slider2.ApplyTemplate();
            var track2 = Page2_Slider2.Template.FindName("PART_Track", Page2_Slider2) as Track;
            if (track2?.IncreaseRepeatButton != null)
            {
                IncreaseButtonClip(track2.IncreaseRepeatButton);
            }

            Page2_Slider3.ApplyTemplate();
            var track3 = Page2_Slider3.Template.FindName("PART_Track", Page2_Slider3) as Track;
            if (track3?.IncreaseRepeatButton != null)
            {
                IncreaseButtonClip(track3.IncreaseRepeatButton);
            }

            Page2_Slider4.ApplyTemplate();
            var track4 = Page2_Slider4.Template.FindName("PART_Track", Page2_Slider4) as Track;
            if (track4?.IncreaseRepeatButton != null)
            {
                IncreaseButtonClip(track4.IncreaseRepeatButton);
            }

            Page2_Slider5.ApplyTemplate();
            var track5 = Page2_Slider5.Template.FindName("PART_Track", Page2_Slider5) as Track;
            if (track5?.IncreaseRepeatButton != null)
            {
                IncreaseButtonClip(track5.IncreaseRepeatButton);
            }
        }

        private void IncreaseButtonClip(RepeatButton repeatButton)
        {
            repeatButton.SizeChanged += (s, e) =>
            {
                var height = repeatButton.ActualHeight;
                var width = repeatButton.ActualWidth;
                var radius = 20;
                var rectangle = new PathFigure
                {
                    StartPoint = new Point(0, 0),
                    IsClosed = true
                };
                rectangle.Segments.Add(new LineSegment(new Point(width - radius, 0), true));
                rectangle.Segments.Add(new ArcSegment(new Point(width - 7, radius), new Size(radius, radius), 0, false, SweepDirection.Clockwise, true));
                rectangle.Segments.Add(new LineSegment(new Point(width - 7, height - radius), true));
                rectangle.Segments.Add(new ArcSegment(new Point(width - radius, height), new Size(radius, radius), 0, false, SweepDirection.Clockwise, true));
                rectangle.Segments.Add(new LineSegment(new Point(0, height), true));
                rectangle.Segments.Add(new LineSegment(new Point(0, 0), true));
                PathGeometry geometry = new();
                geometry.Figures.Add(rectangle);
                repeatButton.Clip = geometry;
            };
        }
    }
}
