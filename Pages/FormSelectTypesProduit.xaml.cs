using GestionStock.Controller;
using GestionStock.Data;
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

namespace GestionStock.Pages
{
    /// <summary>
    /// Logique d'interaction pour FormSelectTypesProduit.xaml
    /// </summary>
    public partial class FormSelectTypesProduit : Window
    {
        public FormSelectTypesProduit()
        {
            InitializeComponent();
            var _context = new MyDbContext();
            var _controllerTypesProduit = new TypesProduitController(_context);
            DgArticles.ItemsSource = _controllerTypesProduit.GetAllTypesProduit();
        }
    }
}
