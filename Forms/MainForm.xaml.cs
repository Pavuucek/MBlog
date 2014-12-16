using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Fluent;
using ICSharpCode.AvalonEdit;
using MarkdownDeep;
using MBlog.Model;
using Microsoft.Win32;

namespace MBlog.Forms
{
    /// <summary>
    ///     Interakční logika pro MainForm.xaml
    /// </summary>
    public partial class MainForm : RibbonWindow
    {
        private string _markdownBuffer;
        private readonly Markdown _markdown = new Markdown();

        public MainForm()
        {
            InitializeComponent();
            // somehow it doesn't set automatically.
            PostDateTimePicker.SelectedDate = DateTime.Now;
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

        private void SaveAsFileButton_Click(object sender, RoutedEventArgs e)
        {
            SavePost();
        }

        private void SavePost()
        {
            var saveDialog = new SaveFileDialog
            {
                Filter = "MBlog Posts (*.mbpost)|*.mbpost|Markdown files (*.md)|*.md|All Files (*.*)|*.*",
                DefaultExt = ".mbpost"
            };
            if (saveDialog.ShowDialog() ?? true)
            {
                switch (Path.GetExtension(saveDialog.FileName))
                {
                    case ".mbpost":
                        // saving as mbpost
                        var mbpost = new BlogPost
                        {
                            PostName = PostNameTextBox.Text,
                            PostDate = PostDateTimePicker.SelectedDate,
                            PostContent = AvalonTextEditor.Text
                        };
                        // trim tag spaces
                        var postTags = PostTagsTextBox.Text.Replace(" ,", ",");
                        postTags = postTags.Replace(", ", ",");
                        if (!string.IsNullOrEmpty(postTags))
                        {
                            foreach (var s in postTags.Split(','))
                            {
                                if (!string.IsNullOrEmpty(s)) mbpost.PostTags.Add(s);
                            }
                        }
                        mbpost.Save(saveDialog.FileName);
                        break;
                    default:
                        // saving as pure markdown
                        AvalonTextEditor.Save(saveDialog.FileName);
                        break;
                }
            }
        }

        private void ExitAppButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void NewPostButton_Click(object sender, RoutedEventArgs e)
        {
            AvalonTextEditor.Text = string.Empty;
            PreviewWebBrowser.NavigateToString(string.Empty);
        }

        private void OpenPostButton_Click(object sender, RoutedEventArgs e)
        {
            OpenPost();
        }

        private void OpenPost()
        {
            var openDialog = new OpenFileDialog
            {
                Filter = "MBlog Posts (*.mbpost)|*.mbpost|Markdown files (*.md)|*.md|All Files (*.*)|*.*",
                DefaultExt = ".mbpost"
            };
            if (openDialog.ShowDialog() ?? true)
            {
                switch (Path.GetExtension(openDialog.FileName))
                {
                    case".mbpost":
                        var mbpost = BlogPost.Load(openDialog.FileName);
                        AvalonTextEditor.Text = mbpost.PostContent;
                        PostDateTimePicker.SelectedDate = mbpost.PostDate;
                        PostNameTextBox.Text = mbpost.PostName;
                        PostTagsTextBox.Text = string.Join(",", mbpost.PostTags);
                        break;
                    default:
                        AvalonTextEditor.Load(openDialog.FileName);
                        break;
                }
            }
        }

        private void SaveToBlogButton_Click(object sender, RoutedEventArgs e)
        {
        }

        private void PublishBlogButton_Click(object sender, RoutedEventArgs e)
        {
            PublishBlog();
        }

        private void PublishBlog()
        {
            
        }
    }
}