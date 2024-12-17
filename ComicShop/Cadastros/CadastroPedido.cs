using ComicShop.App.Base;
using ComicShop.App.Models;
using ComicShop.Domain.Base;
using ComicShop.Domain.Entities;
using ComicShop.Repository.Mapping;
using ComicShop.Service.Validators;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace ComicShop.App.Cadastros
{
    public partial class CadastroPedido : CadastroBase
    {
        private List<ItensPedidoModel> _itensPedido;
        private readonly IBaseService<Pedido> _pedidoService;
        private readonly IBaseService<Usuario> _usuarioService;
        private readonly IBaseService<Cliente> _clienteService;
        private readonly IBaseService<Produto> _produtoService;

        private List<PedidoModel>? pedidos;

        public CadastroPedido(
            IBaseService<Pedido> pedidoService,
            IBaseService<Usuario> usuarioService,
            IBaseService<Cliente> clienteService,
            IBaseService<Produto> produtoService)
        {
            _pedidoService = pedidoService;
            _usuarioService = usuarioService;
            _clienteService = clienteService;
            _produtoService = produtoService;
            _itensPedido = new List<ItensPedidoModel>();

            InitializeComponent();
            CarregarCombo();
            CarregaGridItensVenda();
            Novo();
        }

        private void CarregarCombo()
        {
            cboUsuario.ValueMember = "Id";
            cboUsuario.DisplayMember = "Nome";
            cboUsuario.DataSource = _usuarioService.Get<Usuario>().ToList();

            cboCliente.ValueMember = "Id";
            cboCliente.DisplayMember = "Nome";
            cboCliente.DataSource = _clienteService.Get<Cliente>().ToList();

            cboProduto.ValueMember = "Id";
            cboProduto.DisplayMember = "Nome";
            cboProduto.DataSource = _produtoService.Get<Produto>().ToList();
        }

        private void PreencheObjeto(Pedido pedido)
        {
            if (DateTime.TryParse(txtDataPedido.Text, out var dataPedido))
            {
                pedido.DataPedido = dataPedido;
            }

            if (int.TryParse(cboUsuario.SelectedValue?.ToString(), out var idUsuario))
            {
                pedido.Usuario = _usuarioService.GetById<Usuario>(idUsuario);
            }

            if (int.TryParse(cboCliente.SelectedValue?.ToString(), out var idCliente))
            {
                pedido.Cliente = _clienteService.GetById<Cliente>(idCliente);
            }

            pedido.ValorTotal = _itensPedido.Sum(x => x.PrecoUnitario * x.Quantidade);

            foreach (var item in _itensPedido)
            {
                var itensPedido = new ItensPedido
                {
                    Pedido = pedido,
                    Produto = _produtoService.GetById<Produto>(item.IdProduto),
                    PrecoUnitario = item.PrecoUnitario,
                    Quantidade = item.Quantidade,
                };

                pedido.Itens.Add(itensPedido);
            }
        }
        protected override void Novo()
        {
            base.Novo();
            _itensPedido.Clear();
            CarregaGridItensVenda();
            txtDataPedido.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        protected override void Salvar()
        {
            try
            {
                Pedido pedido;

                if (IsAlteracao)
                {
                    // Verifica se o ID do pedido é válido para edição
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        pedido = _pedidoService.GetById<Pedido>(id);

                        if (pedido == null)
                        {
                            MessageBox.Show("Pedido não encontrado para alteração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("ID do pedido inválido para alteração.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // Cria um novo pedido para adição
                    pedido = new Pedido();
                }

                // Preenche o objeto pedido com os dados da interface
                PreencheObjeto(pedido);

                // Salva ou atualiza o pedido
                if (IsAlteracao)
                {
                    pedido = _pedidoService.Update<Pedido, Pedido, PedidoValidator>(pedido);
                }
                else
                {
                    pedido = _pedidoService.Add<Pedido, Pedido, PedidoValidator>(pedido);

                    // Verifica se o ID foi gerado corretamente
                    if (pedido.Id <= 0)
                    {
                        throw new Exception("Erro ao salvar o pedido: ID não gerado.");
                    }
                }

                MessageBox.Show("Pedido salvo com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                tabControl.SelectedIndex = 1; // Retorna para a aba de consulta
                CarregaGrid(); // Atualiza o grid
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar o pedido: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        protected override void Excluir(int id)
        {
            try
            {
                _pedidoService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ComicShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            var includes = new List<string> { "Cliente", "Usuario" };
            pedidos = _pedidoService.Get<PedidoModel>(false, includes).ToList();
            dgvConsulta.DataSource = pedidos;

            dgvConsulta.Columns["IdUsuario"]!.Visible = false;
            dgvConsulta.Columns["IdCliente"]!.Visible = false;
            dgvConsulta.Columns["ValorTotal"].DefaultCellStyle.Format = "C2";
            dgvConsulta.Columns["ValorTotal"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {

            int.TryParse(linha?.Cells["Id"].Value.ToString(), out var id);
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            cboUsuario.SelectedValue = linha?.Cells["IdUsuario"].Value;
            cboCliente.SelectedValue = linha?.Cells["IdCliente"].Value;

            txtDataPedido.Text = DateTime.TryParse(linha?.Cells["DataPedido"].Value?.ToString(), out var data)
                ? data.ToString("g")
                : string.Empty;

            var includes = new List<string> { "Cliente", "Usuario", "Itens", "Itens.Produto" };
            var pedido = _pedidoService.GetById<Pedido>(id, true, includes);

            _itensPedido = new List<ItensPedidoModel>();
            foreach (var item in pedido.Itens)
            {
                var vendaItem = new ItensPedidoModel
                {
                    Id = item.Id,
                    IdProduto = item.Produto!.Id,
                    Produto = item.Produto!.Nome,
                    Quantidade = item.Quantidade,
                    PrecoUnitario = item.PrecoUnitario
                };
                _itensPedido.Add(vendaItem);
            }

            CarregaGridItensVenda();
        }

        private void CarregaGridItensVenda()
        {
            var source = new BindingSource();
            source.DataSource = _itensPedido.ToArray();
            dataGridViewItens.DataSource = source;
            dataGridViewItens.Columns["Id"]!.Visible = false;
            dataGridViewItens.Columns["IdPedido"].Visible = false;
            dataGridViewItens.Columns["IdProduto"].HeaderText = "Id.Produto";
            dataGridViewItens.Columns["PrecoUnitario"].DefaultCellStyle.Format = "C2";
            dataGridViewItens.Columns["PrecoUnitario"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewItens.Columns["Quantidade"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (ValidaItem())
            {
                var itensPedido = new ItensPedidoModel();

                if (int.TryParse(cboProduto.SelectedValue?.ToString(), out var idProduto))
                {
                    var produto = _produtoService.GetById<Produto>(idProduto);
                    itensPedido.IdProduto = produto.Id;
                    itensPedido.Produto = produto.Nome;
                }

                if (float.TryParse(txtPrecoUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var precoUnitario))
                {
                    itensPedido.PrecoUnitario = precoUnitario;
                }

                if (int.TryParse(txtQuantidade.Text, out var quantidade))
                {
                    itensPedido.Quantidade = quantidade;
                }

                _itensPedido.Add(itensPedido);
                CalculaTotalItem();
                CarregaGridItensVenda();
            }
        }

        private bool ValidaItem()
        {
            // Adicione validações específicas para os itens, se necessário.
            return true;
        }

        

        private void CalculaTotalItem()
        {
            // Remove símbolos e formatação para converter os valores corretamente
            if (decimal.TryParse(txtPrecoUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture, out var precoUnitario)
                && int.TryParse(txtQuantidade.Text, out var quantidade))
            {
                // Calcula o valor total do item
                var valorTotal = quantidade * precoUnitario;

                // Exibe o valor total formatado
                txtValorTotal.Text = valorTotal.ToString("C2", CultureInfo.CurrentCulture);
            }
            else
            {
                txtValorTotal.Text = string.Empty; // Limpa caso não consiga calcular
            }
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem(); // Recalcula o valor total ao sair do campo quantidade
        }

        private void txtValorTotal_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrecoUnitario.Text, out var value))
            {
                txtPrecoUnitario.Text = string.Format(CultureInfo.CurrentCulture, @"{0:C2}", value);
            }
            else
            {
                txtPrecoUnitario.Text = string.Empty;
            }

            CalculaTotalItem();
        }

        /*
        private void CalculaTotalItem()
        {
            var convVlr = float.TryParse(txtPrecoUnitario.Text, NumberStyles.Currency, CultureInfo.CurrentCulture.NumberFormat, out float vlUnitario);
            var convQtd = int.TryParse(txtQuantidade.Text, out int quantidade);
            if (convVlr && convQtd)
            {
                var valorTotal = quantidade * vlUnitario;
                txtValorTotal.Text = string.Format(CultureInfo.CurrentCulture, "{0:C2}", valorTotal);
            }
        }
        private void CalculaTotalVenda()
        {
            labelQuantidade.Text = $"Qtd. Produtos: {_itensPedido.Sum(x => x.Quantidade)}";
            labelValorTotal.Text = $"Valor Total: {_itensPedido.Sum(x => x.PrecoUnitario*x.Quantidade)}";
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            CalculaTotalItem();
        }*/
    }
}
