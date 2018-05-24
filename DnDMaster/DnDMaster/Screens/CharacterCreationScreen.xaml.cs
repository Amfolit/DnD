using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DnDMaster.Screens
{
    /// <summary>
    /// Interaction logic for CharacterCreationScreen.xaml
    /// </summary>
    public partial class CharacterCreationScreen : Window
    {
        public int NumberOfPlayers { get; set; }
        public int NumberOfCreatedPlayers {get;set;}
        public CharacterCreationScreen()
        {
            InitializeComponent();
            NumberOfPlayers = 4;
            NumberOfCreatedPlayers = 0;
        }
    }
}
