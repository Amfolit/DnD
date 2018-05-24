using DnDMaster.BackEnd.GameLogic;
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
    /// Interaction logic for StartScreen.xaml
    /// </summary>
    public partial class StartScreen : Window
    {
        public StartScreen()
        {
            InitializeComponent();
            Character test = new Character();
            test.SpecClass = BackEnd.Classes.Class.Despacito;
            test.Racial = BackEnd.Races.Race.BeastFolk;

            test.ToString();
            
        }

        private void StartBtn_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new CharacterCreationScreen();
            dialog.ShowDialog();
        }
    }
}
