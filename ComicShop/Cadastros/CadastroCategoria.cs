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
    public partial class CadastroCategoria : CadastroBase
    {
        #region Declarações
        private readonly IBaseService<Categoria> _categoriaService;
        private List<Categoria> categoria;
        #endregion

        #region Construtor
        public CadastroCategoria(IBaseService<Categoria> categoriaService)
        {
            _categoriaService = categoriaService;
            InitializeComponent();
        }
        #endregion

        #region Métodos
        private void PreencheObjeto(Categoria categoria)
        {
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;
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
                        var categoria = _categoriaService.GetById<Categoria>(id);
                        PreencheObjeto(categoria);
                        categoria = _categoriaService.Update<Categoria, Categoria, CategoriaValidator>(categoria);
                    }
                }
                else
                {
                    var categoria = new Categoria();
                    PreencheObjeto(categoria);
                    _categoriaService.Add<Categoria, Categoria, CategoriaValidator>(categoria);
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
                _categoriaService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"ComicShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            categoria = _categoriaService.Get<Categoria>().ToList();
            dgvConsulta.DataSource = categoria;
            dgvConsulta.Columns["Id"].DisplayIndex = 0;
            dgvConsulta.Columns["Nome"].DisplayIndex = 1;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtDescricao.Text = linha?.Cells["Descricao"].Value.ToString();
        }
        #endregion
    }
}
