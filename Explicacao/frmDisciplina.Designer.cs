namespace Explicacao
{
    partial class frmDisciplina
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDisciplina));
            this.btnInserir = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.txtPesquisar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDisciplina = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnPesquisar = new Guna.UI2.WinForms.Guna2Button();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDisciplina = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.CheckedState.Parent = this.btnInserir;
            this.btnInserir.CustomImages.Parent = this.btnInserir;
            this.btnInserir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.HoverState.Parent = this.btnInserir;
            this.btnInserir.Location = new System.Drawing.Point(503, 165);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ShadowDecoration.Parent = this.btnInserir;
            this.btnInserir.Size = new System.Drawing.Size(175, 40);
            this.btnInserir.TabIndex = 67;
            this.btnInserir.Text = "Inseir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Novo disciplina";
            // 
            // txtNome
            // 
            this.txtNome.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNome.HintForeColor = System.Drawing.Color.Empty;
            this.txtNome.HintText = "";
            this.txtNome.isPassword = false;
            this.txtNome.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtNome.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtNome.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtNome.LineThickness = 1;
            this.txtNome.Location = new System.Drawing.Point(503, 97);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(341, 42);
            this.txtNome.TabIndex = 65;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(17, 556);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(406, 40);
            this.btnEliminar.TabIndex = 64;
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
            this.txtPesquisar.Location = new System.Drawing.Point(18, 106);
            this.txtPesquisar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.PasswordChar = '\0';
            this.txtPesquisar.PlaceholderText = "";
            this.txtPesquisar.SelectedText = "";
            this.txtPesquisar.SelectionStart = 28;
            this.txtPesquisar.ShadowDecoration.Parent = this.txtPesquisar;
            this.txtPesquisar.Size = new System.Drawing.Size(405, 36);
            this.txtPesquisar.TabIndex = 62;
            this.txtPesquisar.Enter += new System.EventHandler(this.txtPesquisar_Enter);
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // dgvDisciplina
            // 
            this.dgvDisciplina.AllowUserToAddRows = false;
            this.dgvDisciplina.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvDisciplina.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvDisciplina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDisciplina.BackgroundColor = System.Drawing.Color.White;
            this.dgvDisciplina.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDisciplina.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDisciplina.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDisciplina.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvDisciplina.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDisciplina.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvDisciplina.EnableHeadersVisualStyles = false;
            this.dgvDisciplina.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDisciplina.Location = new System.Drawing.Point(17, 152);
            this.dgvDisciplina.Name = "dgvDisciplina";
            this.dgvDisciplina.ReadOnly = true;
            this.dgvDisciplina.RowHeadersVisible = false;
            this.dgvDisciplina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDisciplina.Size = new System.Drawing.Size(406, 381);
            this.dgvDisciplina.TabIndex = 61;
            this.dgvDisciplina.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvDisciplina.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDisciplina.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDisciplina.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDisciplina.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDisciplina.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDisciplina.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDisciplina.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDisciplina.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDisciplina.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDisciplina.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDisciplina.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDisciplina.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvDisciplina.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvDisciplina.ThemeStyle.ReadOnly = true;
            this.dgvDisciplina.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDisciplina.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDisciplina.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDisciplina.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDisciplina.ThemeStyle.RowsStyle.Height = 22;
            this.dgvDisciplina.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDisciplina.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDisciplina.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDisciplina_CellClick);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.CheckedState.Parent = this.btnPesquisar;
            this.btnPesquisar.CustomImages.Parent = this.btnPesquisar;
            this.btnPesquisar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.HoverState.Parent = this.btnPesquisar;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(373, 106);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.ShadowDecoration.Parent = this.btnPesquisar;
            this.btnPesquisar.Size = new System.Drawing.Size(51, 36);
            this.btnPesquisar.TabIndex = 69;
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
            this.btnVoltar.Location = new System.Drawing.Point(15, 15);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Parent = this.btnVoltar;
            this.btnVoltar.Size = new System.Drawing.Size(28, 26);
            this.btnVoltar.TabIndex = 68;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(49, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 29);
            this.label3.TabIndex = 70;
            this.label3.Text = "Disciplinas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(14, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 71;
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2VSeparator1.Location = new System.Drawing.Point(446, 42);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 573);
            this.guna2VSeparator1.TabIndex = 72;
            // 
            // btnSalvar
            // 
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(230)))), ((int)(((byte)(119)))));
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(503, 328);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(175, 40);
            this.btnSalvar.TabIndex = 75;
            this.btnSalvar.Text = "Salvar alteração";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(499, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 74;
            this.label2.Text = "Disciplina";
            // 
            // txtDisciplina
            // 
            this.txtDisciplina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDisciplina.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDisciplina.HintForeColor = System.Drawing.Color.Empty;
            this.txtDisciplina.HintText = "";
            this.txtDisciplina.isPassword = false;
            this.txtDisciplina.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDisciplina.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtDisciplina.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDisciplina.LineThickness = 1;
            this.txtDisciplina.Location = new System.Drawing.Point(503, 267);
            this.txtDisciplina.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisciplina.Name = "txtDisciplina";
            this.txtDisciplina.Size = new System.Drawing.Size(341, 42);
            this.txtDisciplina.TabIndex = 73;
            this.txtDisciplina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(885, 650);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDisciplina);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtPesquisar);
            this.Controls.Add(this.dgvDisciplina);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmDisciplina";
            this.Text = "frmDisciplina";
            this.Load += new System.EventHandler(this.frmDisciplina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisciplina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2TextBox txtPesquisar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDisciplina;
        private Guna.UI2.WinForms.Guna2Button btnPesquisar;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDisciplina;
    }
}