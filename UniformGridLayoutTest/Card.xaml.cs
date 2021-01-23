using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace UniformGridLayoutTest
{
    public sealed partial class Card : UserControl
    {
        public Card()
        {
            InitializeComponent();
        }

        public string CardName
        {
            get => (string)GetValue(AppNameProperty);
            set => SetValue(AppNameProperty, value);
        }
        public static readonly DependencyProperty AppNameProperty = DependencyProperty.Register(
            nameof(CardName), typeof(string), typeof(Card), new PropertyMetadata(default(string)));
    }
}
