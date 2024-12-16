namespace ComicShop.App.Cadastros
{
    partial class CadastroUsuario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtNome = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtLogin = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataCadastro = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtDataLogin = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtSenha = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            chAtivo = new ReaLTaiizor.Controls.MaterialCheckBox();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabControl.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(chAtivo);
            tabPageCadastro.Controls.Add(txtSenha);
            tabPageCadastro.Controls.Add(txtDataLogin);
            tabPageCadastro.Controls.Add(txtEmail);
            tabPageCadastro.Controls.Add(txtDataCadastro);
            tabPageCadastro.Controls.Add(txtLogin);
            tabPageCadastro.Controls.Add(txtNome);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Size = new Size(771, 427);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(txtNome, 0);
            tabPageCadastro.Controls.SetChildIndex(txtLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataCadastro, 0);
            tabPageCadastro.Controls.SetChildIndex(txtEmail, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataLogin, 0);
            tabPageCadastro.Controls.SetChildIndex(txtSenha, 0);
            tabPageCadastro.Controls.SetChildIndex(chAtivo, 0);
            // 
            // tabControl
            // 
            tabControl.Size = new Size(779, 455);
            // 
            // txtId
            // 
            txtId.AnimateReadOnly = false;
            txtId.AutoCompleteMode = AutoCompleteMode.None;
            txtId.AutoCompleteSource = AutoCompleteSource.None;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.CharacterCasing = CharacterCasing.Normal;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HideSelection = true;
            txtId.Hint = "ID";
            txtId.LeadingIcon = null;
            txtId.Location = new Point(13, 34);
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.ReadOnly = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(135, 48);
            txtId.TabIndex = 2;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // txtNome
            // 
            txtNome.AnimateReadOnly = false;
            txtNome.AutoCompleteMode = AutoCompleteMode.None;
            txtNome.AutoCompleteSource = AutoCompleteSource.None;
            txtNome.BackgroundImageLayout = ImageLayout.None;
            txtNome.CharacterCasing = CharacterCasing.Normal;
            txtNome.Depth = 0;
            txtNome.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtNome.HideSelection = true;
            txtNome.Hint = "Nome";
            txtNome.LeadingIcon = null;
            txtNome.Location = new Point(154, 34);
            txtNome.MaxLength = 32767;
            txtNome.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtNome.Name = "txtNome";
            txtNome.PasswordChar = '\0';
            txtNome.PrefixSuffixText = null;
            txtNome.ReadOnly = false;
            txtNome.RightToLeft = RightToLeft.No;
            txtNome.SelectedText = "";
            txtNome.SelectionLength = 0;
            txtNome.SelectionStart = 0;
            txtNome.ShortcutsEnabled = true;
            txtNome.Size = new Size(602, 48);
            txtNome.TabIndex = 3;
            txtNome.TabStop = false;
            txtNome.TextAlign = HorizontalAlignment.Left;
            txtNome.TrailingIcon = null;
            txtNome.UseSystemPasswordChar = false;
            // 
            // txtLogin
            // 
            txtLogin.AnimateReadOnly = false;
            txtLogin.AutoCompleteMode = AutoCompleteMode.None;
            txtLogin.AutoCompleteSource = AutoCompleteSource.None;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.CharacterCasing = CharacterCasing.Normal;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HideSelection = true;
            txtLogin.Hint = "login";
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(13, 99);
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.ReadOnly = false;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(476, 48);
            txtLogin.TabIndex = 4;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            // 
            // txtDataCadastro
            // 
            txtDataCadastro.AllowPromptAsInput = true;
            txtDataCadastro.AnimateReadOnly = false;
            txtDataCadastro.AsciiOnly = false;
            txtDataCadastro.BackgroundImageLayout = ImageLayout.None;
            txtDataCadastro.BeepOnError = false;
            txtDataCadastro.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCadastro.Depth = 0;
            txtDataCadastro.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataCadastro.HidePromptOnLeave = false;
            txtDataCadastro.HideSelection = true;
            txtDataCadastro.Hint = "Data de Cadastro";
            txtDataCadastro.InsertKeyMode = InsertKeyMode.Default;
            txtDataCadastro.LeadingIcon = null;
            txtDataCadastro.Location = new Point(495, 99);
            txtDataCadastro.Mask = "99/99/9999";
            txtDataCadastro.MaxLength = 32767;
            txtDataCadastro.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataCadastro.Name = "txtDataCadastro";
            txtDataCadastro.PasswordChar = '\0';
            txtDataCadastro.PrefixSuffixText = null;
            txtDataCadastro.PromptChar = '_';
            txtDataCadastro.ReadOnly = false;
            txtDataCadastro.RejectInputOnFirstFailure = false;
            txtDataCadastro.ResetOnPrompt = true;
            txtDataCadastro.ResetOnSpace = true;
            txtDataCadastro.RightToLeft = RightToLeft.No;
            txtDataCadastro.SelectedText = "";
            txtDataCadastro.SelectionLength = 0;
            txtDataCadastro.SelectionStart = 0;
            txtDataCadastro.ShortcutsEnabled = true;
            txtDataCadastro.Size = new Size(261, 48);
            txtDataCadastro.SkipLiterals = true;
            txtDataCadastro.TabIndex = 5;
            txtDataCadastro.TabStop = false;
            txtDataCadastro.Text = "  /  /";
            txtDataCadastro.TextAlign = HorizontalAlignment.Left;
            txtDataCadastro.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataCadastro.TrailingIcon = null;
            txtDataCadastro.UseSystemPasswordChar = false;
            txtDataCadastro.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AnimateReadOnly = false;
            txtEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.CharacterCasing = CharacterCasing.Normal;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(13, 162);
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.ReadOnly = false;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(476, 48);
            txtEmail.TabIndex = 6;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtDataLogin
            // 
            txtDataLogin.AllowPromptAsInput = true;
            txtDataLogin.AnimateReadOnly = false;
            txtDataLogin.AsciiOnly = false;
            txtDataLogin.BackgroundImageLayout = ImageLayout.None;
            txtDataLogin.BeepOnError = false;
            txtDataLogin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataLogin.Depth = 0;
            txtDataLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataLogin.HidePromptOnLeave = false;
            txtDataLogin.HideSelection = true;
            txtDataLogin.Hint = "Data de Último Login";
            txtDataLogin.InsertKeyMode = InsertKeyMode.Default;
            txtDataLogin.LeadingIcon = null;
            txtDataLogin.Location = new Point(495, 162);
            txtDataLogin.Mask = "99/99/9999";
            txtDataLogin.MaxLength = 32767;
            txtDataLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataLogin.Name = "txtDataLogin";
            txtDataLogin.PasswordChar = '\0';
            txtDataLogin.PrefixSuffixText = null;
            txtDataLogin.PromptChar = '_';
            txtDataLogin.ReadOnly = false;
            txtDataLogin.RejectInputOnFirstFailure = false;
            txtDataLogin.ResetOnPrompt = true;
            txtDataLogin.ResetOnSpace = true;
            txtDataLogin.RightToLeft = RightToLeft.No;
            txtDataLogin.SelectedText = "";
            txtDataLogin.SelectionLength = 0;
            txtDataLogin.SelectionStart = 0;
            txtDataLogin.ShortcutsEnabled = true;
            txtDataLogin.Size = new Size(261, 48);
            txtDataLogin.SkipLiterals = true;
            txtDataLogin.TabIndex = 7;
            txtDataLogin.TabStop = false;
            txtDataLogin.Text = "  /  /";
            txtDataLogin.TextAlign = HorizontalAlignment.Left;
            txtDataLogin.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataLogin.TrailingIcon = null;
            txtDataLogin.UseSystemPasswordChar = false;
            txtDataLogin.ValidatingType = null;
            // 
            // txtSenha
            // 
            txtSenha.AnimateReadOnly = false;
            txtSenha.AutoCompleteMode = AutoCompleteMode.None;
            txtSenha.AutoCompleteSource = AutoCompleteSource.None;
            txtSenha.BackgroundImageLayout = ImageLayout.None;
            txtSenha.CharacterCasing = CharacterCasing.Normal;
            txtSenha.Depth = 0;
            txtSenha.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSenha.HideSelection = true;
            txtSenha.Hint = "Senha";
            txtSenha.LeadingIcon = Properties.Resources.Senha___icon;
            txtSenha.Location = new Point(106, 221);
            txtSenha.MaxLength = 32767;
            txtSenha.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSenha.Name = "txtSenha";
            txtSenha.PasswordChar = '*';
            txtSenha.PrefixSuffixText = null;
            txtSenha.ReadOnly = false;
            txtSenha.RightToLeft = RightToLeft.No;
            txtSenha.SelectedText = "";
            txtSenha.SelectionLength = 0;
            txtSenha.SelectionStart = 0;
            txtSenha.ShortcutsEnabled = true;
            txtSenha.Size = new Size(476, 48);
            txtSenha.TabIndex = 8;
            txtSenha.TabStop = false;
            txtSenha.TextAlign = HorizontalAlignment.Left;
            txtSenha.TrailingIcon = null;
            txtSenha.UseSystemPasswordChar = false;
            // 
            // chAtivo
            // 
            chAtivo.AutoSize = true;
            chAtivo.Depth = 0;
            chAtivo.Location = new Point(262, 286);
            chAtivo.Margin = new Padding(0);
            chAtivo.MouseLocation = new Point(-1, -1);
            chAtivo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chAtivo.Name = "chAtivo";
            chAtivo.ReadOnly = false;
            chAtivo.Ripple = true;
            chAtivo.Size = new Size(129, 37);
            chAtivo.TabIndex = 9;
            chAtivo.Text = "Usuário Ativo";
            chAtivo.UseAccentColor = false;
            chAtivo.UseVisualStyleBackColor = true;
            // 
            // CadastroUsuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 522);
            Location = new Point(0, 0);
            Name = "CadastroUsuario";
            Text = "Cadastro de Usuário";
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtNome;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataCadastro;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataLogin;
        private ReaLTaiizor.Controls.MaterialCheckBox chAtivo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSenha;
    }
}