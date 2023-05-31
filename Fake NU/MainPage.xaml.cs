namespace Fake_NU;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
        UpdateInfo();
    }

    private void UpdateInfo()
    {
        lblFatura.Text = Memory.fatura.ToString("C");
        lblConta.Text = Memory.debit.ToString("C");
        double credit = Memory.credit - Memory.fatura;
        lblCredit.Text = $"Limite disponivel de {credit.ToString("C")}";
        if (credit < 0)
        {
            lblCredit.TextColor = Colors.Red;
        }
        else
        {
            lblCredit.TextColor = Colors.DimGray;
        }
    }
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        await DisplayAlert("Atenção", "O intuito deste aplicativo é a criação de materiais no github para ajudar outros devs, e tambem ultilizar como uma brincadeira simulando um valor ficticio na conta.Este app não deve ser ultilizado para aplicar golpes.", "OK");
        await DisplayAlert("Direitos autorais", "O layout foi inspirado no app nubank da playstore, os icones são do mesmo app e tambem de \"fonts.google.com/icons", "OK");
        await Navigation.PushModalAsync(new ConfigPage());

        UpdateInfo();
    }
}

