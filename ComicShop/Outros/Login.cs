using ComicShop.Domain.Base;
using ComicShop.Domain.Entities;
using ComicShop.Service.Validators;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComicShop.App.Outros
{
    public partial class Login : MaterialForm
    {
        #region Declarações
        private readonly IBaseService<Usuario> _usuarioService;
        #endregion

        #region Construtor
        public Login(IBaseService<Usuario> usuarioService)
        {
            _usuarioService = usuarioService;
            InitializeComponent();
        }
        #endregion

        #region Eventos

        private void btnOk_Click(object sender, EventArgs e)
        {
            Usuario usuario = ObterUsuario(txtUsuario.Text, txtSenha.Text);

            if (usuario == null)
            {
                MessageBox.Show("Usuário e/ou senha inválida@", "ComicShop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!usuario.Ativo)
            {
                MessageBox.Show("Usuário inativo!", "ComicShop",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                usuario.DataLogin = DateTime.Now;
                usuario = _usuarioService.Update<Usuario, Usuario, UsuarioValidator>(usuario);
                FormPrincipal.Usuario = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        #endregion

        private Usuario? ObterUsuario(string login, string senha)
        {
            ChecaExistenciaDeUsuarioCadastrado();
            var usuario = _usuarioService.Get<Usuario>().Where(x => x.Login == login).FirstOrDefault();
            if (usuario == null)
                return null;
            return usuario.Senha != senha ? null : usuario;
        }

        private void ChecaExistenciaDeUsuarioCadastrado()
        {
            var usuarios = _usuarioService.Get<Usuario>().ToList();
            if (!usuarios.Any())
            {
                var usuario = new Usuario
                {
                    Login = "admin",
                    Nome = "Administrador do Sistema",
                    Senha = "admin",
                    Ativo = true,
                    DataCadastro = DateTime.Now,
                    DataLogin = DateTime.Now,
                    Email = "admin@gmail.com",
                };
                _usuarioService.Add<Usuario, Usuario, UsuarioValidator>(usuario);
            }
        } 
    }
}
