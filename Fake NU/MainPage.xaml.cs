using System.Text;

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
        ConfigPage s = new ConfigPage();
        await Navigation.PushModalAsync(s);
        //espera o modal ser aberto
        while (s.Parent != null)
        {
            await Task.Delay(600);
        }
        UpdateInfo();
    }

}

