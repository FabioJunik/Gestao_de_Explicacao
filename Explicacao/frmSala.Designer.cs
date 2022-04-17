namespace Explicacao
{
    partial class frmSala
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSala));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.btnInseir = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvSala = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEditeNumero = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumero = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cmbEditeEstado = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(230)))), ((int)(((byte)(119)))));
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(487, 566);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(264, 40);
            this.btnSalvar.TabIndex = 102;
            this.btnSalvar.Text = "Salvar alteração";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(433, 54);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 573);
            this.guna2VSeparator1.TabIndex = 99;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(53, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 29);
            this.label3.TabIndex = 98;
            this.label3.Text = "Sala";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(357, 115);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(51, 36);
            this.btnPesquisar.TabIndex = 97;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.CheckedState.Parent = this.btnVoltar;
            this.btnVoltar.CustomImages.Parent = this.btnVoltar;
            this.btnVoltar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.btnVoltar.Font = new System.Drawing.Font("Trebuchet MS", 12F);
            this.btnVoltar.ForeColor = System.Drawing.Color.White;
            this.btnVoltar.HoverState.Parent = this.btnVoltar;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.ImageSize = new System.Drawing.Size(22, 22);
            this.btnVoltar.Location = new System.Drawing.Point(19, 28);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Parent = this.btnVoltar;
            this.btnVoltar.Size = new System.Drawing.Size(28, 26);
            this.btnVoltar.TabIndex = 96;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnInseir
            // 
            this.btnInseir.CheckedState.Parent = this.btnInseir;
            this.btnInseir.CustomImages.Parent = this.btnInseir;
            this.btnInseir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInseir.ForeColor = System.Drawing.Color.White;
            this.btnInseir.HoverState.Parent = this.btnInseir;
            this.btnInseir.Location = new System.Drawing.Point(487, 270);
            this.btnInseir.Name = "btnInseir";
            this.btnInseir.ShadowDecoration.Parent = this.btnInseir;
            this.btnInseir.Size = new System.Drawing.Size(264, 40);
            this.btnInseir.TabIndex = 95;
            this.btnInseir.Text = "Inseir";
            this.btnInseir.Click += new System.EventHandler(this.btnInseir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(483, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 22);
            this.label4.TabIndex = 94;
            this.label4.Text = "Numero";
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(21, 569);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(387, 40);
            this.btnEliminar.TabIndex = 92;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.BorderThickness = 0;
            this.txtPesquisar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPesquisar.DefaultText = "Pesquise pelo nome ou codigo";
            this.txtPesquisar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPesquisar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPesquisar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.DisabledState.Parent = this.txtPesquisar;
            this.txtPesquisar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPesquisar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisar.FocusedState.Parent = this.txtPesquisar;
            this.txtPesquisar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisar.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPesquisar.HoverState.Parent = this.txtPesquisar;
            this.txtPesquisar.Location = new System.Drawing.Point(22, 115);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionStart = 28;
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(386, 36);
            this.txtPesquisar.TabIndex = 91;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // dgvSala
            // 
            this.dgvSala.AllowUserToAddRows = false;
            this.dgvSala.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvSala.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvSala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSala.BackgroundColor = System.Drawing.Color.White;
            this.dgvSala.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSala.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSala.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSala.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvSala.ColumnHeadersHeight = 30;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSala.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvSala.EnableHeadersVisualStyles = false;
            this.dgvSala.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSala.Location = new System.Drawing.Point(21, 165);
            this.dgvSala.Name = "dgvSala";
            this.dgvSala.ReadOnly = true;
            this.dgvSala.RowHeadersVisible = false;
            this.dgvSala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSala.Size = new System.Drawing.Size(387, 381);
            this.dgvSala.TabIndex = 90;
            this.dgvSala.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvSala.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSala.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvSala.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvSala.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvSala.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvSala.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvSala.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSala.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvSala.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvSala.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSala.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvSala.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvSala.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvSala.ThemeStyle.ReadOnly = true;
            this.dgvSala.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvSala.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvSala.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvSala.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.dgvSala.ThemeStyle.RowsStyle.Height = 22;
            this.dgvSala.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvSala.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvSala.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSala_CellClick);
            this.dgvSala.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSala_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 103;
            this.label1.Text = "Estado";
            // 
            // cmbEstado
            // 
            this.cmbEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEstado.FocusedState.Parent = this.cmbEstado;
            this.cmbEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEstado.HoverState.Parent = this.cmbEstado;
            this.cmbEstado.ItemHeight = 30;
            this.cmbEstado.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cmbEstado.ItemsAppearance.Parent = this.cmbEstado;
            this.cmbEstado.Location = new System.Drawing.Point(487, 218);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.ShadowDecoration.Parent = this.cmbEstado;
            this.cmbEstado.Size = new System.Drawing.Size(264, 36);
            this.cmbEstado.TabIndex = 104;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(483, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 22);
            this.label2.TabIndex = 107;
            this.label2.Text = "Estado";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 106;
            this.label5.Text = "Numero";
            // 
            // txtEditeNumero
            // 
            this.txtEditeNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEditeNumero.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditeNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEditeNumero.HintForeColor = System.Drawing.Color.Empty;
            this.txtEditeNumero.HintText = "";
            this.txtEditeNumero.isPassword = false;
            this.txtEditeNumero.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEditeNumero.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtEditeNumero.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEditeNumero.LineThickness = 1;
            this.txtEditeNumero.Location = new System.Drawing.Point(487, 412);
            this.txtEditeNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditeNumero.Name = "txtEditeNumero";
            this.txtEditeNumero.Size = new System.Drawing.Size(264, 42);
            this.txtEditeNumero.TabIndex = 105;
            this.txtEditeNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(483, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 110;
            this.label6.Text = "Nova Sala";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label7.Location = new System.Drawing.Point(483, 337);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 111;
            this.label7.Text = "Editar Sala";
            // 
            // txtNumero
            // 
            this.txtNumero.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumero.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNumero.HintForeColor = System.Drawing.Color.Empty;
            this.txtNumero.HintText = "";
            this.txtNumero.isPassword = false;
            this.txtNumero.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNumero.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtNumero.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNumero.LineThickness = 1;
            this.txtNumero.Location = new System.Drawing.Point(487, 138);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(264, 42);
            this.txtNumero.TabIndex = 93;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cmbEditeEstado
            // 
            this.cmbEditeEstado.BackColor = System.Drawing.Color.Transparent;
            this.cmbEditeEstado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbEditeEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbEditeEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEditeEstado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbEditeEstado.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEditeEstado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbEditeEstado.FocusedState.Parent = this.cmbEditeEstado;
            this.cmbEditeEstado.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbEditeEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbEditeEstado.HoverState.Parent = this.cmbEditeEstado;
            this.cmbEditeEstado.ItemHeight = 30;
            this.cmbEditeEstado.Items.AddRange(new object[] {
            "Disponível",
            "Indisponível"});
            this.cmbEditeEstado.ItemsAppearance.Parent = this.cmbEditeEstado;
            this.cmbEditeEstado.Location = new System.Drawing.Point(487, 512);
            this.cmbEditeEstado.Name = "cmbEditeEstado";
            this.cmbEditeEstado.ShadowDecoration.Parent = this.cmbEditeEstado;
            this.cmbEditeEstado.Size = new System.Drawing.Size(264, 36);
            this.cmbEditeEstado.TabIndex = 112;
            // 
            // frmSala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(799, 656);
            this.Controls.Add(this.cmbEditeEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEditeNumero);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnInseir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvSala);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmSala";
            this.Text = "frmSala";
            this.Load += new System.EventHandler(this.frmSala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2Button btnInseir;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvSala;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEstado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEditeNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNumero;
        private Guna.UI2.WinForms.Guna2ComboBox cmbEditeEstado;
    }
}