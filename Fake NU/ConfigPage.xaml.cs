namespace Fake_NU;

public partial class ConfigPage : ContentPage
{
	public ConfigPage()
	{
		InitializeComponent();
        DisplayAlert("Aten��o", "O intuito deste aplicativo � a cria��o de materiais no github para ajudar outros devs, e tambem ultilizar como uma brincadeira simulando um valor ficticio na conta.Este app n�o deve ser ultilizado para aplicar golpes.", "OK");
        DisplayAlert("Direitos autorais", "O layout foi inspirado no app nubank da playstore, os icones s�o do mesmo app e tambem de \"fonts.google.com/icons", "OK");
        lblConta.Text = Memory.debit.ToString("C");
        lblCredit.Text = Memory.credit.ToString("C");
        lblFatura.Text = Memory.fatura.ToString("C");
        slConta.Maximum = Memory.maxDebit;
        slCredit.Maximum = Memory.maxCredit;
        slFatura.Maximum = Memory.maxCredit;
        slConta.Value = Memory.debit;
        slCredit.Value = Memory.credit;
        slFatura.Value = Memory.fatura;
        slConta.ValueChanged += SlValueChanged;
        slCredit.ValueChanged += SlValueChanged;
        slFatura.ValueChanged += SlValueChanged;
    }

    private void SaveData()
    {
        Memory.debit = slConta.Value;
        Memory.credit = slCredit.Value;
        Memory.fatura = slFatura.Value;
        //await DisplayAlert("Sucesso", "Dados salvos com sucesso", "OK");
        //await Navigation.PopModalAsync();
    }
    private async void Updateform()
    {
        lblConta.Text = slConta.Value.ToString("C");
        lblCredit.Text = slCredit.Value.ToString("C");
        lblFatura.Text = slFatura.Value.ToString("C");
    }

    private void SlValueChanged(object sender, ValueChangedEventArgs e)
    {
        Updateform();
        SaveData();
    }

  
}