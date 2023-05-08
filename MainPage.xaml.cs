using System.Collections.ObjectModel;

namespace MaApp
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }
        public Card SingleCard { get; set; } = new Card();
        public ObservableCollection<Card> MultipleCards { get; set; } = new() { new Card(), new Card() };
    }

    public class Card
    {
        public string CardTitle { get; set; } = "The Card's Title";
    }

}