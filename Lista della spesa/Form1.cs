using System.Runtime.CompilerServices;

namespace Lista_della_spesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string[] Lista_della_spesa = new string[20];
        private void Form1_Load(object sender, EventArgs e)
        {
            caricaNellaLista();

        }

        private void btn_Aggiungi_Click(object sender, EventArgs e)
        {
            nuovoElemento();
        }
        private void btn_Rimuovi_Click(object sender, EventArgs e)
        {
            rimuoviElemento();
        }

        private void caricaNellaLista()
        {
            string riga;
            string[] lineaTotale;
            int i = 0;
            // appena si carica il form io vado a leggermi i dati dal file e successivamente caricarli nella lista
            using (StreamReader rd = new StreamReader("lista.csv"))
            {
                while (!rd.EndOfStream)
                {
                    riga = rd.ReadLine();
                    Lista_della_spesa[i] = riga;
                    // splitto
                    lineaTotale = riga.Split(";");
                    // carico la riga nella lista
                    string itemFormatted = $"{lineaTotale[0].PadRight(15)} {lineaTotale[1].PadRight(15)} {lineaTotale[2]}";
                    lst_ListaDellaSpesa.Items.Add(itemFormatted);
                    i++;
                }
            }
        }

        private void nuovoElemento()
        {
            if (string.IsNullOrWhiteSpace(txt_NomeProdotto.Text) ||
                int.IsNegative(int.Parse(txt_CostoProdotto.Text)) ||
                int.IsNegative(int.Parse(txt_QuantitaProdotto.Text)))
            {
                MessageBox.Show("Inserisci dei valori validi!", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt_NomeProdotto.Text = "";
                txt_CostoProdotto.Text = "";
                txt_QuantitaProdotto.Text = "";
                return;
            }
            // qua l'elemento è valido quindi
            using (StreamWriter wr = new StreamWriter("lista.csv", true))  // Aggiungi 'true' per fare append
            {
                wr.WriteLine($"{txt_NomeProdotto.Text};{(int.Parse(txt_CostoProdotto.Text))};{(int.Parse(txt_QuantitaProdotto.Text))}");
            }
            caricaNellaLista();
        }

        private void rimuoviElemento()
        {
            if (lst_ListaDellaSpesa.SelectedItems.Count != 1)
            {
                MessageBox.Show("Seleziona solo un elemento!", "ERRORE!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (StreamReader reader = new StreamReader("lista.csv"))
            using (StreamWriter wr = new StreamWriter("lista_temp.csv"))
            {
                int currentLineIndex = 0;
                string line;

                // Scorri tutte le righe del file
                while ((line = reader.ReadLine()) != null)
                {
                    // Se non è la riga selezionata, scrivila nel nuovo file
                    if (currentLineIndex != lst_ListaDellaSpesa.SelectedIndex)
                    {
                        wr.WriteLine(line);
                    }

                    currentLineIndex++;
                }
            }
            File.Delete("lista.csv");
            File.Move("lista_temp.csv", "lista.csv");
            lst_ListaDellaSpesa.Items.Clear();
            caricaNellaLista();
        }
    }
}
