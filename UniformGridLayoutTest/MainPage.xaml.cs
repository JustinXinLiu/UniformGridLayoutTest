using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace UniformGridLayoutTest
{
    public class Entity
    {
        public Entity(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }

    public sealed partial class MainPage : Page
    {
        private readonly List<Entity> _entities = new List<Entity> 
        {
            new Entity(1),
            new Entity(2),
            new Entity(3),
            new Entity(4)
        };

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
