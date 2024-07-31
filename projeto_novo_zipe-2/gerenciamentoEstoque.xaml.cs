using Microsoft.Maui.Controls;

namespace projeto_novo_zipe_2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnGerenciamentoFornecedorClicked(object sender, EventArgs e)
        {
            FornecedorSection.IsVisible = true;
            MateriasSection.IsVisible = false;
            EstoqueSection.IsVisible = false;
        }

        private void OnGerenciamentoMateriasClicked(object sender, EventArgs e)
        {
            FornecedorSection.IsVisible = false;
            MateriasSection.IsVisible = true;
            EstoqueSection.IsVisible = false;
        }

        private void OnGerenciamentoEstoqueClicked(object sender, EventArgs e)
        {
            FornecedorSection.IsVisible = false;
            MateriasSection.IsVisible = false;
            EstoqueSection.IsVisible = true;
        }
    }
}
