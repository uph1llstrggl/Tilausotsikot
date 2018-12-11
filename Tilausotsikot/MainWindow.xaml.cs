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
using System.Collections;

namespace Tilausotsikot
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            DateTime tänään = DateTime.Today;

            InitializeComponent();

            DPTilauspvm.SelectedDate = tänään;
            DPToimituspvm.SelectedDate = tänään;

            DataGridTextColumn textColumn1 = new DataGridTextColumn();
            textColumn1.Binding = new Binding("tilausID");
            DataGridTextColumn textColumn2 = new DataGridTextColumn();
            textColumn2.Binding = new Binding("pakkausmaara");
            DataGridTextColumn textColumn3 = new DataGridTextColumn();
            textColumn3.Binding = new Binding("yksikkohinta");
            DataGridTextColumn textColumn4 = new DataGridTextColumn();
            textColumn4.Binding = new Binding("varastomaara");
            DataGridTextColumn textColumn5 = new DataGridTextColumn();
            textColumn5.Binding = new Binding("varastoarvo");
            DataGridTextColumn textColumn6 = new DataGridTextColumn();
            textColumn6.Binding = new Binding("tilausnimi");

            textColumn1.Header = "Tuote ID";
            dgList.Columns.Add(textColumn1);
            textColumn2.Header = "Pakkausmäärä";
            dgList.Columns.Add(textColumn2);
            textColumn3.Header = "Yksikkö hinta";
            dgList.Columns.Add(textColumn3);
            textColumn4.Header = "Varastomäärä";
            dgList.Columns.Add(textColumn4);
            textColumn5.Header = "Varastoarvo";
            dgList.Columns.Add(textColumn5);
            textColumn6.Header = "Tilausnimi";
            dgList.Columns.Add(textColumn6);
        }

        private void TextTilausnumero_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        //Tallennus
        private void BtnIN_Click(object sender, RoutedEventArgs e)
        {

            Tilausotsikko Tilaus = new Tilausotsikko();

            Tilaus.tuotenumero = int.Parse(textTuotenumero.Text);
            Tilaus.tilausnumero = int.Parse(textTilausnumero.Text);
            Tilaus.asiakasNimi = textAsiakasnimi.Text;
            Tilaus.tilauspvm = DPTilauspvm.SelectedDate.Value;
            Tilaus.toimituspvm = DPToimituspvm.SelectedDate.Value;
            Tilaus.toimitusosoite = textOsoite.Text;

            MessageBox.Show("Tilaus tallennettu!");

            textTilausnumero.Text = " ";
            textTuotenumero.Text = " ";
            textAsiakasnimi.Text = " ";
            DPTilauspvm.SelectedDate = DateTime.Today;
            DPToimituspvm.SelectedDate = DateTime.Today;
            textOsoite.Text = " ";

        }

        private void BtnOUT_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Tilausotsikko Tilaus = new Tilausotsikko();

                Tilaus.tuotenumero = int.Parse(textTuotenumero.Text);
                Tilaus.tilausnumero = int.Parse(textTilausnumero.Text);
                Tilaus.asiakasNimi = textAsiakasnimi.Text;
                Tilaus.tilauspvm = DPTilauspvm.SelectedDate.Value;
                Tilaus.toimituspvm = DPToimituspvm.SelectedDate.Value;
                Tilaus.toimitusosoite = textOsoite.Text;


            }
            catch
            {
                MessageBox.Show("NO SUCH ORDER");
            }
        }

        private void Btn3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                TilausRivi Rivi = new TilausRivi();

                Rivi.tilausID = int.Parse(dataTuoteid.Text);
                Rivi.tilausnimi = dataNimi.Text;
                Rivi.pakkausmaara = int.Parse(dataPakkausmaara.Text);
                Rivi.yksikkohinta = int.Parse(dataHinta.Text);
                Rivi.varastoarvo = int.Parse(dataVarastoarvo.Text);
                Rivi.varastomaara = int.Parse(dataMäärä.Text);

                dgList.Items.Add(Rivi);
            }
            catch
            {
                MessageBox.Show("CRASH AND BURN!");
            }
        }
    }
}
