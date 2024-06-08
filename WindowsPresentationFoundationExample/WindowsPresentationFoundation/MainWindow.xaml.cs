using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DemoLibrary;

namespace WindowsPresentationFoundation;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window, ISavePost
{
    private BindingList<PostModel> posts = new BindingList<PostModel>();

    public MainWindow()
    {
        InitializeComponent();
        postsList.ItemsSource = posts;
    }

    private void AddPost_OnClick(object sender, RoutedEventArgs e)
    {
        PostEntry postEntry = new PostEntry(this);
        postEntry.Show();
    }

    public void SavePost(PostModel post)
    {
        posts.Add(post);
    }
}