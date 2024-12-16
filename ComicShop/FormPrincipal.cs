using Microsoft.VisualBasic.Logging;
using ReaLTaiizor.Forms;
using ComicShop.Domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using ComicShop.App.Infra;
using ComicShop.App.Cadastros;
using ComicShop.App.Outros;
namespace ComicShop
{
    public partial class FormPrincipal : MaterialForm
    {
        public static Usuario Usuario { get; set; }
        public FormPrincipal()
        {
            InitializeComponent();
            CarregaLogin();
        }

        private void CarregaLogin()
        {
            var login = ConfigureDI.ServicesProvider!.GetService<Login>();
            if (login != null && !login.IsDisposed)
            {
                if (login.ShowDialog() != DialogResult.OK)
                {
                    Environment.Exit(0);
                }
                else
                {
                    lblUsuario.Text = $"Usuário: {Usuario.Nome}";
                }
            }
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroFornecedor>();
        }

        private void FecharForm(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall)
            {
                e.Cancel = true;
            }
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroUsuario>();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCategoria>();
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroProduto>();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroCliente>();
        }

        private void pedidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExibeFormulario<CadastroPedido>();
        }


        private void ExibeFormulario<TFormulario>() where TFormulario : Form
        {
            var cad = ConfigureDI.ServicesProvider!.GetService<TFormulario>();
            if (cad != null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}

