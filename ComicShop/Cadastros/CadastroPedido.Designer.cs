namespace ComicShop.App.Cadastros
{
    partial class CadastroPedido
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
            txtDataPedido = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cboUsuario = new ReaLTaiizor.Controls.MaterialComboBox();
            txtId = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cboCliente = new ReaLTaiizor.Controls.MaterialComboBox();
            gbProdutos = new GroupBox();
            cboProduto = new ReaLTaiizor.Controls.MaterialComboBox();
            txtPrecoUnitario = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtQuantidade = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtValorTotal = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnAdicionar = new ReaLTaiizor.Controls.MaterialButton();
            dataGridView1 = new DataGridView();
            labelQuantidade = new Label();
            labelValorTotal = new Label();
            tabPageConsulta.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabControl.SuspendLayout();
            gbProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(gbProdutos);
            tabPageCadastro.Controls.Add(cboCliente);
            tabPageCadastro.Controls.Add(txtId);
            tabPageCadastro.Controls.Add(cboUsuario);
            tabPageCadastro.Controls.Add(txtDataPedido);
            tabPageCadastro.Size = new Size(772, 424);
            tabPageCadastro.Controls.SetChildIndex(btnCancelar, 0);
            tabPageCadastro.Controls.SetChildIndex(btnSalvar, 0);
            tabPageCadastro.Controls.SetChildIndex(txtDataPedido, 0);
            tabPageCadastro.Controls.SetChildIndex(cboUsuario, 0);
            tabPageCadastro.Controls.SetChildIndex(txtId, 0);
            tabPageCadastro.Controls.SetChildIndex(cboCliente, 0);
            tabPageCadastro.Controls.SetChildIndex(gbProdutos, 0);
            // 
            // tabControl
            // 
            tabControl.Size = new Size(780, 452);
            // 
            // txtDataPedido
            // 
            txtDataPedido.AllowPromptAsInput = true;
            txtDataPedido.AnimateReadOnly = false;
            txtDataPedido.AsciiOnly = false;
            txtDataPedido.BackgroundImageLayout = ImageLayout.None;
            txtDataPedido.BeepOnError = false;
            txtDataPedido.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPedido.Depth = 0;
            txtDataPedido.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtDataPedido.HidePromptOnLeave = false;
            txtDataPedido.HideSelection = true;
            txtDataPedido.Hint = "Data do Pedido";
            txtDataPedido.InsertKeyMode = InsertKeyMode.Default;
            txtDataPedido.LeadingIcon = null;
            txtDataPedido.Location = new Point(80, 8);
            txtDataPedido.Mask = "__/__/____";
            txtDataPedido.MaxLength = 32767;
            txtDataPedido.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtDataPedido.Name = "txtDataPedido";
            txtDataPedido.PasswordChar = '\0';
            txtDataPedido.PrefixSuffixText = null;
            txtDataPedido.PromptChar = '_';
            txtDataPedido.ReadOnly = false;
            txtDataPedido.RejectInputOnFirstFailure = false;
            txtDataPedido.ResetOnPrompt = true;
            txtDataPedido.ResetOnSpace = true;
            txtDataPedido.RightToLeft = RightToLeft.No;
            txtDataPedido.SelectedText = "";
            txtDataPedido.SelectionLength = 0;
            txtDataPedido.SelectionStart = 0;
            txtDataPedido.ShortcutsEnabled = true;
            txtDataPedido.Size = new Size(250, 48);
            txtDataPedido.SkipLiterals = true;
            txtDataPedido.TabIndex = 2;
            txtDataPedido.TabStop = false;
            txtDataPedido.Text = "__/__/____";
            txtDataPedido.TextAlign = HorizontalAlignment.Left;
            txtDataPedido.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtDataPedido.TrailingIcon = null;
            txtDataPedido.UseSystemPasswordChar = false;
            txtDataPedido.ValidatingType = null;
            // 
            // cboUsuario
            // 
            cboUsuario.AutoResize = false;
            cboUsuario.BackColor = Color.FromArgb(255, 255, 255);
            cboUsuario.Depth = 0;
            cboUsuario.DrawMode = DrawMode.OwnerDrawVariable;
            cboUsuario.DropDownHeight = 174;
            cboUsuario.DropDownStyle = ComboBoxStyle.DropDownList;
            cboUsuario.DropDownWidth = 121;
            cboUsuario.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboUsuario.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboUsuario.FormattingEnabled = true;
            cboUsuario.Hint = "Usuário";
            cboUsuario.IntegralHeight = false;
            cboUsuario.ItemHeight = 43;
            cboUsuario.Location = new Point(336, 7);
            cboUsuario.MaxDropDownItems = 4;
            cboUsuario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboUsuario.Name = "cboUsuario";
            cboUsuario.Size = new Size(414, 49);
            cboUsuario.StartIndex = 0;
            cboUsuario.TabIndex = 3;
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
            txtId.Location = new Point(20, 8);
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
            txtId.Size = new Size(54, 48);
            txtId.TabIndex = 4;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            // 
            // cboCliente
            // 
            cboCliente.AutoResize = false;
            cboCliente.BackColor = Color.FromArgb(255, 255, 255);
            cboCliente.Depth = 0;
            cboCliente.DrawMode = DrawMode.OwnerDrawVariable;
            cboCliente.DropDownHeight = 174;
            cboCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCliente.DropDownWidth = 121;
            cboCliente.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboCliente.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboCliente.FormattingEnabled = true;
            cboCliente.Hint = "Cliente";
            cboCliente.IntegralHeight = false;
            cboCliente.ItemHeight = 43;
            cboCliente.Location = new Point(20, 62);
            cboCliente.MaxDropDownItems = 4;
            cboCliente.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboCliente.Name = "cboCliente";
            cboCliente.Size = new Size(730, 49);
            cboCliente.StartIndex = 0;
            cboCliente.TabIndex = 5;
            // 
            // gbProdutos
            // 
            gbProdutos.Controls.Add(labelValorTotal);
            gbProdutos.Controls.Add(labelQuantidade);
            gbProdutos.Controls.Add(dataGridView1);
            gbProdutos.Controls.Add(btnAdicionar);
            gbProdutos.Controls.Add(txtValorTotal);
            gbProdutos.Controls.Add(txtQuantidade);
            gbProdutos.Controls.Add(txtPrecoUnitario);
            gbProdutos.Controls.Add(cboProduto);
            gbProdutos.Location = new Point(20, 117);
            gbProdutos.Name = "gbProdutos";
            gbProdutos.Size = new Size(730, 253);
            gbProdutos.TabIndex = 6;
            gbProdutos.TabStop = false;
            gbProdutos.Text = "Itens do Pedido";
            // 
            // cboProduto
            // 
            cboProduto.AutoResize = false;
            cboProduto.BackColor = Color.FromArgb(255, 255, 255);
            cboProduto.Depth = 0;
            cboProduto.DrawMode = DrawMode.OwnerDrawVariable;
            cboProduto.DropDownHeight = 174;
            cboProduto.DropDownStyle = ComboBoxStyle.DropDownList;
            cboProduto.DropDownWidth = 121;
            cboProduto.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cboProduto.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cboProduto.FormattingEnabled = true;
            cboProduto.Hint = "Produto";
            cboProduto.IntegralHeight = false;
            cboProduto.ItemHeight = 43;
            cboProduto.Location = new Point(6, 22);
            cboProduto.MaxDropDownItems = 4;
            cboProduto.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cboProduto.Name = "cboProduto";
            cboProduto.Size = new Size(224, 49);
            cboProduto.StartIndex = 0;
            cboProduto.TabIndex = 0;
            // 
            // txtPrecoUnitario
            // 
            txtPrecoUnitario.AnimateReadOnly = false;
            txtPrecoUnitario.AutoCompleteMode = AutoCompleteMode.None;
            txtPrecoUnitario.AutoCompleteSource = AutoCompleteSource.None;
            txtPrecoUnitario.BackgroundImageLayout = ImageLayout.None;
            txtPrecoUnitario.CharacterCasing = CharacterCasing.Normal;
            txtPrecoUnitario.Depth = 0;
            txtPrecoUnitario.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPrecoUnitario.HideSelection = true;
            txtPrecoUnitario.Hint = "Preço Uniário";
            txtPrecoUnitario.LeadingIcon = null;
            txtPrecoUnitario.Location = new Point(250, 23);
            txtPrecoUnitario.MaxLength = 32767;
            txtPrecoUnitario.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPrecoUnitario.Name = "txtPrecoUnitario";
            txtPrecoUnitario.PasswordChar = '\0';
            txtPrecoUnitario.PrefixSuffixText = null;
            txtPrecoUnitario.ReadOnly = false;
            txtPrecoUnitario.RightToLeft = RightToLeft.No;
            txtPrecoUnitario.SelectedText = "";
            txtPrecoUnitario.SelectionLength = 0;
            txtPrecoUnitario.SelectionStart = 0;
            txtPrecoUnitario.ShortcutsEnabled = true;
            txtPrecoUnitario.Size = new Size(169, 48);
            txtPrecoUnitario.TabIndex = 1;
            txtPrecoUnitario.TabStop = false;
            txtPrecoUnitario.TextAlign = HorizontalAlignment.Left;
            txtPrecoUnitario.TrailingIcon = null;
            txtPrecoUnitario.UseSystemPasswordChar = false;
            // 
            // txtQuantidade
            // 
            txtQuantidade.AnimateReadOnly = false;
            txtQuantidade.AutoCompleteMode = AutoCompleteMode.None;
            txtQuantidade.AutoCompleteSource = AutoCompleteSource.None;
            txtQuantidade.BackgroundImageLayout = ImageLayout.None;
            txtQuantidade.CharacterCasing = CharacterCasing.Normal;
            txtQuantidade.Depth = 0;
            txtQuantidade.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtQuantidade.HideSelection = true;
            txtQuantidade.Hint = "Qtd";
            txtQuantidade.LeadingIcon = null;
            txtQuantidade.Location = new Point(432, 23);
            txtQuantidade.MaxLength = 32767;
            txtQuantidade.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtQuantidade.Name = "txtQuantidade";
            txtQuantidade.PasswordChar = '\0';
            txtQuantidade.PrefixSuffixText = null;
            txtQuantidade.ReadOnly = false;
            txtQuantidade.RightToLeft = RightToLeft.No;
            txtQuantidade.SelectedText = "";
            txtQuantidade.SelectionLength = 0;
            txtQuantidade.SelectionStart = 0;
            txtQuantidade.ShortcutsEnabled = true;
            txtQuantidade.Size = new Size(82, 48);
            txtQuantidade.TabIndex = 2;
            txtQuantidade.TabStop = false;
            txtQuantidade.TextAlign = HorizontalAlignment.Left;
            txtQuantidade.TrailingIcon = null;
            txtQuantidade.UseSystemPasswordChar = false;
            // 
            // txtValorTotal
            // 
            txtValorTotal.AnimateReadOnly = false;
            txtValorTotal.AutoCompleteMode = AutoCompleteMode.None;
            txtValorTotal.AutoCompleteSource = AutoCompleteSource.None;
            txtValorTotal.BackgroundImageLayout = ImageLayout.None;
            txtValorTotal.CharacterCasing = CharacterCasing.Normal;
            txtValorTotal.Depth = 0;
            txtValorTotal.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtValorTotal.HideSelection = true;
            txtValorTotal.Hint = "V. Total";
            txtValorTotal.LeadingIcon = null;
            txtValorTotal.Location = new Point(528, 23);
            txtValorTotal.MaxLength = 32767;
            txtValorTotal.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtValorTotal.Name = "txtValorTotal";
            txtValorTotal.PasswordChar = '\0';
            txtValorTotal.PrefixSuffixText = null;
            txtValorTotal.ReadOnly = false;
            txtValorTotal.RightToLeft = RightToLeft.No;
            txtValorTotal.SelectedText = "";
            txtValorTotal.SelectionLength = 0;
            txtValorTotal.SelectionStart = 0;
            txtValorTotal.ShortcutsEnabled = true;
            txtValorTotal.Size = new Size(100, 48);
            txtValorTotal.TabIndex = 3;
            txtValorTotal.TabStop = false;
            txtValorTotal.TextAlign = HorizontalAlignment.Left;
            txtValorTotal.TrailingIcon = null;
            txtValorTotal.UseSystemPasswordChar = false;
            // 
            // btnAdicionar
            // 
            btnAdicionar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAdicionar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAdicionar.Depth = 0;
            btnAdicionar.HighEmphasis = true;
            btnAdicionar.Icon = null;
            btnAdicionar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAdicionar.Location = new Point(648, 29);
            btnAdicionar.Margin = new Padding(4, 6, 4, 6);
            btnAdicionar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAdicionar.Name = "btnAdicionar";
            btnAdicionar.NoAccentTextColor = Color.Empty;
            btnAdicionar.Size = new Size(64, 36);
            btnAdicionar.TabIndex = 4;
            btnAdicionar.Text = "+";
            btnAdicionar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAdicionar.UseAccentColor = false;
            btnAdicionar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(718, 150);
            dataGridView1.TabIndex = 5;
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.ForeColor = SystemColors.Desktop;
            labelQuantidade.Location = new Point(11, 232);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.RightToLeft = RightToLeft.No;
            labelQuantidade.Size = new Size(93, 15);
            labelQuantidade.TabIndex = 6;
            labelQuantidade.Text = "Qtd. Produtos: 0";
            // 
            // labelValorTotal
            // 
            labelValorTotal.AutoSize = true;
            labelValorTotal.ForeColor = SystemColors.Desktop;
            labelValorTotal.Location = new Point(622, 230);
            labelValorTotal.Name = "labelValorTotal";
            labelValorTotal.RightToLeft = RightToLeft.No;
            labelValorTotal.Size = new Size(107, 15);
            labelValorTotal.TabIndex = 7;
            labelValorTotal.Text = "Valor Total: R$ 0,00 ";
            // 
            // CadastroPedido
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(786, 519);
            Location = new Point(0, 0);
            Name = "CadastroPedido";
            Text = "Cadastro de Pedido";
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabControl.ResumeLayout(false);
            gbProdutos.ResumeLayout(false);
            gbProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cboUsuario;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtDataPedido;
        private ReaLTaiizor.Controls.MaterialComboBox cboCliente;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtId;
        private GroupBox gbProdutos;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtPrecoUnitario;
        private ReaLTaiizor.Controls.MaterialComboBox cboProduto;
        protected Label labelQuantidade;
        private DataGridView dataGridView1;
        private ReaLTaiizor.Controls.MaterialButton btnAdicionar;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtValorTotal;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtQuantidade;
        protected Label labelValorTotal;
    }
}