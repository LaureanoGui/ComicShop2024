namespace ComicShop.App.Base
{
    partial class CadastroBase
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastroBase));
            tabControl = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPageCadastro = new TabPage();
            btnSalvar = new ReaLTaiizor.Controls.MaterialButton();
            btnCancelar = new ReaLTaiizor.Controls.MaterialButton();
            tabPageConsulta = new TabPage();
            dgvConsulta = new DataGridView();
            btnExcluir = new ReaLTaiizor.Controls.MaterialButton();
            btnEditar = new ReaLTaiizor.Controls.MaterialButton();
            btnNovo = new ReaLTaiizor.Controls.MaterialButton();
            imageList1 = new ImageList(components);
            tabControl.SuspendLayout();
            tabPageCadastro.SuspendLayout();
            tabPageConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).BeginInit();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageCadastro);
            tabControl.Controls.Add(tabPageConsulta);
            tabControl.Depth = 0;
            tabControl.Dock = DockStyle.Fill;
            tabControl.ImageList = imageList1;
            tabControl.Location = new Point(3, 64);
            tabControl.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControl.Multiline = true;
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(774, 457);
            tabControl.TabIndex = 0;
            // 
            // tabPageCadastro
            // 
            tabPageCadastro.Controls.Add(btnSalvar);
            tabPageCadastro.Controls.Add(btnCancelar);
            tabPageCadastro.ImageIndex = 0;
            tabPageCadastro.Location = new Point(4, 24);
            tabPageCadastro.Name = "tabPageCadastro";
            tabPageCadastro.Padding = new Padding(3);
            tabPageCadastro.Size = new Size(766, 429);
            tabPageCadastro.TabIndex = 0;
            tabPageCadastro.Text = "Cadastro";
            tabPageCadastro.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            btnSalvar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSalvar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSalvar.Depth = 0;
            btnSalvar.HighEmphasis = true;
            btnSalvar.Icon = null;
            btnSalvar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSalvar.Location = new Point(642, 379);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSalvar.Name = "btnSalvar";
            btnSalvar.NoAccentTextColor = Color.Empty;
            btnSalvar.Size = new Size(76, 36);
            btnSalvar.TabIndex = 1;
            btnSalvar.Text = "Salvar";
            btnSalvar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSalvar.UseAccentColor = false;
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnCancelar.BackColor = Color.Transparent;
            btnCancelar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnCancelar.Depth = 0;
            btnCancelar.HighEmphasis = true;
            btnCancelar.Icon = null;
            btnCancelar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnCancelar.Location = new Point(538, 379);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnCancelar.Name = "btnCancelar";
            btnCancelar.NoAccentTextColor = Color.Empty;
            btnCancelar.Size = new Size(96, 36);
            btnCancelar.TabIndex = 0;
            btnCancelar.Text = "Cancelar";
            btnCancelar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnCancelar.UseAccentColor = false;
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // tabPageConsulta
            // 
            tabPageConsulta.Controls.Add(dgvConsulta);
            tabPageConsulta.Controls.Add(btnExcluir);
            tabPageConsulta.Controls.Add(btnEditar);
            tabPageConsulta.Controls.Add(btnNovo);
            tabPageConsulta.ImageIndex = 1;
            tabPageConsulta.Location = new Point(4, 24);
            tabPageConsulta.Name = "tabPageConsulta";
            tabPageConsulta.Padding = new Padding(3);
            tabPageConsulta.Size = new Size(766, 429);
            tabPageConsulta.TabIndex = 1;
            tabPageConsulta.Text = "Consulta";
            tabPageConsulta.UseVisualStyleBackColor = true;
            tabPageConsulta.Enter += tabPageConsulta_Enter;
            // 
            // dgvConsulta
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.Window;
            dgvConsulta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.InfoText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dgvConsulta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvConsulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Control;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Window;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvConsulta.DefaultCellStyle = dataGridViewCellStyle1;
            dgvConsulta.Location = new Point(0, 0);
            dgvConsulta.Name = "dgvConsulta";
            dgvConsulta.Size = new Size(766, 348);
            dgvConsulta.TabIndex = 3;
            // 
            // btnExcluir
            // 
            btnExcluir.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnExcluir.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnExcluir.Depth = 0;
            btnExcluir.HighEmphasis = true;
            btnExcluir.Icon = null;
            btnExcluir.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnExcluir.Location = new Point(648, 376);
            btnExcluir.Margin = new Padding(4, 6, 4, 6);
            btnExcluir.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnExcluir.Name = "btnExcluir";
            btnExcluir.NoAccentTextColor = Color.Empty;
            btnExcluir.Size = new Size(80, 36);
            btnExcluir.TabIndex = 2;
            btnExcluir.Text = "Excluir";
            btnExcluir.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnExcluir.UseAccentColor = false;
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // btnEditar
            // 
            btnEditar.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnEditar.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnEditar.Depth = 0;
            btnEditar.HighEmphasis = true;
            btnEditar.Icon = null;
            btnEditar.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnEditar.Location = new Point(556, 376);
            btnEditar.Margin = new Padding(4, 6, 4, 6);
            btnEditar.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnEditar.Name = "btnEditar";
            btnEditar.NoAccentTextColor = Color.Empty;
            btnEditar.Size = new Size(71, 36);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnEditar.UseAccentColor = false;
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNovo
            // 
            btnNovo.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNovo.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNovo.Depth = 0;
            btnNovo.HighEmphasis = true;
            btnNovo.Icon = null;
            btnNovo.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNovo.Location = new Point(472, 376);
            btnNovo.Margin = new Padding(4, 6, 4, 6);
            btnNovo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNovo.Name = "btnNovo";
            btnNovo.NoAccentTextColor = Color.Empty;
            btnNovo.Size = new Size(64, 36);
            btnNovo.TabIndex = 0;
            btnNovo.Text = "Novo";
            btnNovo.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNovo.UseAccentColor = false;
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Forms - Icon.png");
            imageList1.Images.SetKeyName(1, "Search - Icon.png");
            // 
            // CadastroBase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(780, 524);
            Controls.Add(tabControl);
            DrawerTabControl = tabControl;
            ForeColor = SystemColors.Control;
            Name = "CadastroBase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Base de Cadastros";
            tabControl.ResumeLayout(false);
            tabPageCadastro.ResumeLayout(false);
            tabPageCadastro.PerformLayout();
            tabPageConsulta.ResumeLayout(false);
            tabPageConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsulta).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ImageList imageList1;
        protected TabPage tabPageConsulta;
        protected ReaLTaiizor.Controls.MaterialButton btnCancelar;
        protected ReaLTaiizor.Controls.MaterialButton btnSalvar;
        protected ReaLTaiizor.Controls.MaterialButton btnNovo;
        protected ReaLTaiizor.Controls.MaterialButton btnEditar;
        protected ReaLTaiizor.Controls.MaterialButton btnExcluir;
        protected TabPage tabPageCadastro;
        protected ReaLTaiizor.Controls.MaterialTabControl tabControl;
        protected DataGridView dgvConsulta;
    }
}