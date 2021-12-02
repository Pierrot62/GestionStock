using GestionStock.Controller;
using GestionStock.Data;
using GestionStock.Data.Services;
using GestionStock.Pages;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GestionStock
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenFormSelect(object sender, RoutedEventArgs e)
        {
            var _context = new MyDbContext();
            string senderValue = (string)((Button)sender).Content;
            switch (senderValue)
            {
                case "Gestion des Articles":
                    FormSelectProduit selectArt = new FormSelectProduit();
                    selectArt.ShowDialog();
                    break;
                case "Gestion des Categories":
                    FormSelectCategorie selectCat = new FormSelectCategorie();
                    selectCat.ShowDialog();
                    break;
                case "Gestion des Types Produits":
                    FormSelectTypesProduit selectTypesProd = new FormSelectTypesProduit();
                    selectTypesProd.ShowDialog();
                    break;
            }
        }
    }
}