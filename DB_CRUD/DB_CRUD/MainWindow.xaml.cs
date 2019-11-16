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
using DB_CRUD.Mercado;
using SQLite;

namespace DB_CRUD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnAgregar_Click(object sender, RoutedEventArgs e)
        {
            Traspasos jugador = new Traspasos()
            {
                Jugador = txtBoxJugador.Text,
                Precio = txtBoxPrecio.Text,
                Equipo_Entrada = txtBoxEntrada.Text,
                Equipo_Salida = txtBoxSalida.Text
            };
            using (SQLiteConnection conexion = new SQLiteConnection(App.databasePath))
            {
                conexion.CreateTable<Traspasos>();
                conexion.Insert(jugador);
            }
            Close();
        }
    }
}
