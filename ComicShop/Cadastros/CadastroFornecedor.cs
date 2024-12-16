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
        public partial class CadastroFornecedor : CadastroBase
        {
            #region Declaração
            private readonly IBaseService<Fornecedor> _fornecedorService;
            private List<Fornecedor>? fornecedores;
            #endregion

            #region Construtor
            public CadastroFornecedor(IBaseService<Fornecedor> fornecedorService)
            {
                _fornecedorService = fornecedorService;
                InitializeComponent();
            }
            #endregion

            #region Métodos
            private void PreencheObjeto(Fornecedor fornecedor)
            {
                fornecedor.Nome = txtNome.Text;
                fornecedor.Endereco = txtEndereco.Text;
                fornecedor.Contato = txtContato.Text;
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
                            var fornecedor = _fornecedorService.GetById<Fornecedor>(id);
                            PreencheObjeto(fornecedor);
                            fornecedor = _fornecedorService.Update<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
                        }
                    }
                    else
                    {
                        var fornecedor = new Fornecedor();
                        PreencheObjeto(fornecedor);
                        _fornecedorService.Add<Fornecedor, Fornecedor, FornecedorValidator>(fornecedor);
                    }
                    CarregaGrid();
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
                    _fornecedorService.Delete(id);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"ComicShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            protected override void CarregaGrid()
            {
                fornecedores = _fornecedorService.Get<Fornecedor>().ToList();
                dgvConsulta.DataSource = fornecedores;
                dgvConsulta.Columns["Id"].DisplayIndex = 0;      
                dgvConsulta.Columns["Nome"].DisplayIndex = 1;     
                dgvConsulta.Columns["Contato"].DisplayIndex = 2;   
                dgvConsulta.Columns["Endereco"].DisplayIndex = 3;  

                   dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            protected override void CarregaRegistro(DataGridViewRow? linha)
            {
                txtId.Text = linha?.Cells["Id"].Value.ToString();
                txtNome.Text = linha?.Cells["Nome"].Value.ToString();
                txtContato.Text = linha?.Cells["Contato"].Value.ToString();
                txtEndereco.Text = linha?.Cells["Endereco"].Value.ToString();
        }

            #endregion
        }
    }
