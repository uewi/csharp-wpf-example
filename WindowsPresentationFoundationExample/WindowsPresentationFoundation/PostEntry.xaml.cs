using System.Windows;
using DemoLibrary;

namespace WindowsPresentationFoundation;

public partial class PostEntry : Window
{
    private ISavePost _parent;

    public PostEntry(ISavePost parent)
    {
        InitializeComponent();
        _parent = parent;
    }

    private void SavePost_OnClick(object sender, RoutedEventArgs e)
    {
        PostModel postModel = new PostModel
        {
            Subject = subjectText.Text,
            Content = contentText.Text
        };
        _parent.SavePost(postModel);

        this.Close();
    }
}