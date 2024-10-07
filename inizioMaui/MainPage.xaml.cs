
namespace inizioMaui
{
    public partial class MainPage : ContentPage
    {

        int indovinaNumero;
        int counter;

        public MainPage()
        {
            InitializeComponent();
            Random numero = new Random();
            indovinaNumero = (int)numero.Next(1, 100);
            counter = 0;
        }

        private async void btnNumber_Click(object sender, EventArgs e)
        {
            try
            {
                counter++;
                int numeroIndovinato = int.Parse(entryNumber.Text);
                if (numeroIndovinato == indovinaNumero)
                {
                    lblHint.Text = "Hai Vinto in " + counter + " tentativi!";
                    lblTentativi.Text = ""; 
                    return;
                }
                else if (numeroIndovinato > indovinaNumero)
                {
                    if (numeroIndovinato > 100) { await DisplayAlert("Errore", "Il numero deve essere minore di 100", "OK, ne reinserisco un altro"); counter--; }
                    lblHint.Text = "Il numero da indovinare è più piccolo";
                }
                else
                {
                    lblHint.Text = "Il numero da indovinare è più grande";
                }
                lblTentativi.Text = "Hai fatto " + counter + " tentativi"; 
            }
            catch
            {
                await DisplayAlert("Errore", "Si inserisca un numero", "OK");
            }

        }

        private async void btnNuova_Click(object sender, EventArgs e)
        {

        }

        private async Task DisplayAlert(string v)
        {
            throw new NotImplementedException();
        }
    }

}
