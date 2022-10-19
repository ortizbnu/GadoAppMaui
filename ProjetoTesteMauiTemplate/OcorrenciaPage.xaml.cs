namespace GadoAppMaui
{
    public partial class OcorrenciaPage : ContentPage
    {
        public OcorrenciaPage()
        {
            InitializeComponent();

        }

        private async void OnAddOcorrencia(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NewEventPage());
        }
    }
}
