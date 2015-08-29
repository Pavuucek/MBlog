using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;

namespace DTPicker
{
    // Adorners must subclass the abstract base class Adorner. 
    public class TextBoxUpDownAdorner : Adorner
    {
        private bool _shown;
        private double _x, _top, _bottom;
        public Brush Fill = Brushes.Black;
        public Pen Outline = new Pen(new SolidColorBrush(Color.FromArgb(64, 255, 255, 255)), 5);
        private readonly StreamGeometry _triangle = new StreamGeometry();

        public TextBoxUpDownAdorner(TextBox adornedBox)
            : base(adornedBox)
        {
            _triangle = new StreamGeometry();
            _triangle.FillRule = FillRule.Nonzero;
            using (var c = _triangle.Open())
            {
                c.BeginFigure(new Point(-10, 0), true /* filled */, true /* closed */);
                c.LineTo(new Point(10, 0), true, false);
                c.LineTo(new Point(0, 15), true, false);
            }
            _triangle.Freeze();

            MouseDown += (s, e) =>
            {
                if (Click != null)
                {
                    var up = e.GetPosition(AdornedElement).Y < (_top + _bottom)/2;
                    Click((TextBox) AdornedElement, up ? 1 : -1);
                }
            };

            adornedBox.LostFocus += RelevantEventOccurred;
            adornedBox.SelectionChanged += RelevantEventOccurred;
        }

        private void RelevantEventOccurred(object sender, RoutedEventArgs e)
        {
            // In OnRender, GetRectFromCharacterIndex may return Infinity values,
            // so measure the location of the selection here instead.
            var box = AdornedElement as TextBox;
            if (box.IsFocused)
            {
                int start = box.SelectionStart, len = box.SelectionLength;
                if (_shown = len > 0)
                {
                    var rect1 = box.GetRectFromCharacterIndex(start);
                    var rect2 = box.GetRectFromCharacterIndex(start + len);
                    _top = rect1.Top - 2;
                    _bottom = rect1.Bottom + 2;
                    _x = (rect1.Left + rect2.Left)/2;
                }
            }
            else
                _shown = false;

            InvalidateVisual();
        }

        public event Action<TextBox, int> Click;
        // A common way to implement an adorner's rendering behavior is to override the OnRender 
        // method, which is called by the layout system as part of a rendering pass. 
        protected override void OnRender(DrawingContext drawingContext)
        {
            if (_shown)
            {
                drawingContext.PushTransform(new TranslateTransform(_x, _top));
                drawingContext.PushTransform(new ScaleTransform(1, -1));
                drawingContext.DrawGeometry(Fill, Outline, _triangle);
                drawingContext.Pop();
                drawingContext.Pop();
                drawingContext.PushTransform(new TranslateTransform(_x, _bottom));
                drawingContext.DrawGeometry(Fill, Outline, _triangle);
                drawingContext.Pop();
            }
        }
    }
}