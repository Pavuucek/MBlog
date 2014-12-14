using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MarkdownDeep;

namespace MBlog.Forms
{
    /// <summary>
    /// Interakční logika pro MainForm.xaml
    /// </summary>
    public partial class MainForm
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private readonly Markdown _markdown=new Markdown();
        private string _markdownBuffer;

        private void UpdatePreview()
        {
            _markdown.ExtraMode = true;
            _markdown.SafeMode = false;
            _markdownBuffer = _markdown.Transform(AvalonTextEditor.Text).Replace("\n", "\r\n");
            PreviewWebBrowser.NavigateToString(_markdownBuffer);
        }

        private void TextEditor_TextChanged(object sender, System.EventArgs e)
        {
            UpdatePreview();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EventManager.RegisterClassHandler(typeof(FrameworkElement), ToolTipOpeningEvent, new ToolTipEventHandler(ToolTipHandler));
            EventManager.RegisterClassHandler(typeof(FrameworkElement),
                  MouseLeaveEvent, new MouseEventHandler(ClearText));
        }

        private void ClearText(object sender, MouseEventArgs e)
        {
            TooltipTextBlock.Text = string.Empty;
        }

        private void ToolTipHandler(object sender, ToolTipEventArgs e)
        {
            e.Handled = true;
            var source = e.Source as FrameworkElement;
            if (source != null)
            {
                TooltipTextBlock.Text = source.ToolTip.ToString();
            }
        }

    }
}
