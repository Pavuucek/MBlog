using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using MarkdownDeep;
using Microsoft.Win32;

namespace MBlog.Forms
{
    /// <summary>
    ///     Interakční logika pro MainForm.xaml
    /// </summary>
    public partial class MainForm
    {
        private string _markdownBuffer;
        private readonly Markdown _markdown = new Markdown();

        public MainForm()
        {
            InitializeComponent();
        }

        private void UpdatePreview()
        {
            _markdown.ExtraMode = true;
            _markdown.SafeMode = false;
            _markdownBuffer = _markdown.Transform(AvalonTextEditor.Text).Replace("\n", "\r\n");
            PreviewWebBrowser.NavigateToString(_markdownBuffer);
        }

        private void TextEditor_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            EventManager.RegisterClassHandler(typeof (FrameworkElement), ToolTipOpeningEvent,
                new ToolTipEventHandler(ToolTipHandler));
            EventManager.RegisterClassHandler(typeof (FrameworkElement),
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

        private void NewPostMenuItem_Click(object sender, RoutedEventArgs e)
        {
            AvalonTextEditor.Text = string.Empty;
            PreviewWebBrowser.NavigateToString(string.Empty);
        }

        private void OpenPostMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var openDialog = new OpenFileDialog
            {
                Filter = "MBlog Posts (*.mbpost)|*.mbpost|Markdown files (*.md)|*.md|All Files (*.*)|*.*",
                DefaultExt = ".mbpost"
            };
            if (openDialog.ShowDialog() ?? true)
            {
                // TODO: do stuff here.
            }
        }

        private void SaveAsFileMenuItem_Click(object sender, RoutedEventArgs e)
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "MBlog Posts (*.mbpost)|*.mbpost|Markdown files (*.md)|*.md|All Files (*.*)|*.*",
                DefaultExt = ".mbpost"
            };
            if (saveDialog.ShowDialog() ?? true)
            {
                // TODO: do stuff here
            }
        }

        private void ExitAppMenuItem_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}