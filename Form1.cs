namespace Dashboard_Cassa___Ordini
{
    public partial class Form1 : Form
    {
        List<string> listaOggetti = new List<string>();
        double prezzoTotale = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Aggiorna()
        {
            listBoxRiepilogo.Items.Clear();

            foreach (string s in listaOggetti)
            {
                listBoxRiepilogo.Items.Add(s);
            }
        }
        private void buttonAggiungi_Click(object sender, EventArgs e)
        {
            if (textBoxOggetto.Text.Trim() == "" || textBoxPrezzo.Text.Trim() == "" || textBoxQuantita.Text.Trim() == "")
            {
                return;
            }
            int quantita = int.Parse(textBoxQuantita.Text);
            string testoPrezzo = textBoxPrezzo.Text.Replace(".", ",");
            double prezzo = double.Parse(testoPrezzo);
            string nome = textBoxOggetto.Text.Trim();
            double totaleRiga = prezzo * quantita;
            prezzoTotale = prezzoTotale + totaleRiga;
            listaOggetti.Add("x" + quantita + " " + nome + " - €" + totaleRiga);
            textBoxQuantita.Clear();
            textBoxPrezzo.Clear();
            textBoxOggetto.Clear();
            labelImportoCassa.Text = "€ " + prezzoTotale;
            Aggiorna();
        }

        private void buttonRimuovi_Click(object sender, EventArgs e)
        {
            int count = listBoxRiepilogo.SelectedIndex;

            if (count != -1)
            {
                string rigaSelezionata = listaOggetti[count];
                string[] parti = rigaSelezionata.Split('-');
                string partePrezzo = parti[1].Trim().Replace("€", "");
                double prezzoDaRimuovere = double.Parse(partePrezzo);
                prezzoTotale = prezzoTotale - prezzoDaRimuovere;
                labelImportoCassa.Text = "€ " + prezzoTotale;
                listaOggetti.RemoveAt(count);
                Aggiorna();
            }
        }

        
    }
}
