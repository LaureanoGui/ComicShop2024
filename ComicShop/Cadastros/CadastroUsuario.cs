using ComicShop.App.Base;
using ComicShop.App.Outros;
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
    public partial class CadastroUsuario : CadastroBase
    {

        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        private List<Usuario>? usuarios;
        #endregion

        #region Construtor
        public CadastroUsuario(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Método
        private void PreencheObjeto(Usuario usuario)
        {
            usuario.Nome = txtNome.Text;
            usuario.Login = txtLogin.Text;
            usuario.Senha = txtSenha.Text;
            usuario.Email = txtEmail.Text;
            usuario.DataCadastro = DateTime.Parse(txtDataCadastro.Text);
            usuario.DataLogin = DateTime.Parse(txtDataLogin.Text);
            usuario.Ativo = chAtivo.Checked;
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
                        var usuario = _usuarioService.GetById<Usuario>(id);
                        PreencheObjeto(usuario);
                        usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                    }
                }
                else
                {
                    var usuario = new Usuario();
                    PreencheObjeto(usuario);
                    _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
                }
                tabControl.SelectedIndex = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void Excluir(int id)
        {
            try
            {
                _usuarioService.Delete(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, @"IFSP Store", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        protected override void CarregaGrid()
        {
            usuarios = _usuarioService.Get<Usuario>().ToList();
            dgvConsulta.DataSource = usuarios;
            dgvConsulta.Columns["Senha"]!.Visible = false;
            dgvConsulta.Columns["Nome"]!.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        protected override void CarregaRegistro(DataGridViewRow? linha)
        {
            txtId.Text = linha?.Cells["Id"].Value.ToString();
            txtNome.Text = linha?.Cells["Nome"].Value.ToString();
            txtLogin.Text = linha?.Cells["Login"].Value.ToString();
            txtEmail.Text = linha?.Cells["Email"].Value.ToString();
            txtSenha.Text = linha?.Cells["Senha"].Value.ToString();
            chAtivo.Checked = (bool)(linha?.Cells["Ativo"].Value ?? false);

            txtDataCadastro.Text = DateTime.TryParse(linha?.Cells["DataCadastro"].Value.ToString(), out var dataC)
                ? dataC.ToString("g") : "";
            txtDataLogin.Text = DateTime.TryParse(linha?.Cells["DataLogin"].Value.ToString(), out var dataL)
                ? dataL.ToString("g") : "";
        }
        #endregion
    }
}
