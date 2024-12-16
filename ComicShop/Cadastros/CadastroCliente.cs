using ComicShop.App.Base;
using ComicShop.Domain.Base;
using ComicShop.Domain.Entities;
using ComicShop.Service.Validators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicShop.App.Cadastros
{
    public partial class CadastroCliente : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Cliente> _clienteService;
        private List<Cliente>? clientes;
        #endregion

        #region Construtor
        public CadastroCliente(IBaseService<Cliente> clienteService)
        {
            _clienteService = clienteService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Cliente cliente)
        {
            cliente.Nome = txtNome.Text;
            cliente.Documento = txtDocumento.Text;
            cliente.Email = txtEmail.Text;
            cliente.Endereco = txtEndereco.Text;
            cliente.Telefone = txtTelefone.Text;
            if (DateTime.TryParse(txtDataCadastro.Text, out var dataCompra))
            {
                cliente.DataCadastro = dataCompra;
            }
        }
        #endregion

        #region Eventos CRUD
        protected override void Salvar()
        {
            try
            {
                if (IsAlteracao)
                {
                    if (int.TryParse(txtId.Text, out var id))
                    {
                        var cliente = _clienteService.GetById<Cliente>(id);
                        PreencheObjeto(cliente);
                        cliente = _clienteService.Update<Cliente, Cliente, ClienteValidator>(cliente);
                    }
                }
                else
                {
                    var cliente = new Cliente();
                    PreencheObjeto(cliente);
                    _clienteService.Add<Cliente, Cliente, ClienteValidator>(cliente);
                }
                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ComicShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _clienteService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ComicShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            clientes = _clienteService.Get<Cliente>().ToList();
            dgvConsulta.DataSource = clientes;
            dgvConsulta.Columns["Id"].DisplayIndex = 0;
            dgvConsulta.Columns["Nome"].DisplayIndex = 1;
            dgvConsulta.Columns["Documento"].DisplayIndex = 2;
            dgvConsulta.Columns["Email"].DisplayIndex = 3;
            dgvConsulta.Columns["Endereco"].DisplayIndex = 4;
            dgvConsulta.Columns["Telefone"].DisplayIndex = 5;
            dgvConsulta.Columns["DataCadastro"].DisplayIndex = 6;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDocumento.Text = linha?.Cells["Documento"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
            txtTelefone.Text = linha?.Cells["Telefone"].Value.ToString();
            txtDataCadastro.Text = DateTime.TryParse(linha?.Cells["DataCadastro"].Value.ToString(), out var dataC)
     ? dataC.ToString("g") : "";
        }
        #endregion
    }
}
