namespace Explicacao
{
    partial class frmAdicionarTurma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarTurma));
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.btnInserir = new Guna.UI2.WinForms.Guna2Button();
            this.dtpDataInicio = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtQuantProvas = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label12 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtQuantMaxAlunos = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtPropina = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtCargaHoraria = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpDataFim = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cmbProfessor = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbDisciplina = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbNivel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cmbSala = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuspendLayout();
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
            this.btnVoltar.TabIndex = 16;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(65, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nova Turma";
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(496, 587);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(273, 40);
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.CheckedState.Parent = this.btnInserir;
            this.btnInserir.CustomImages.Parent = this.btnInserir;
            this.btnInserir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.HoverState.Parent = this.btnInserir;
            this.btnInserir.Location = new System.Drawing.Point(121, 587);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ShadowDecoration.Parent = this.btnInserir;
            this.btnInserir.Size = new System.Drawing.Size(276, 40);
            this.btnInserir.TabIndex = 27;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // dtpDataInicio
            // 
            this.dtpDataInicio.CheckedState.Parent = this.dtpDataInicio;
            this.dtpDataInicio.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.dtpDataInicio.ForeColor = System.Drawing.Color.White;
            this.dtpDataInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataInicio.HoverState.Parent = this.dtpDataInicio;
            this.dtpDataInicio.Location = new System.Drawing.Point(123, 506);
            this.dtpDataInicio.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpDataInicio.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtpDataInicio.Name = "dtpDataInicio";
            this.dtpDataInicio.ShadowDecoration.Parent = this.dtpDataInicio;
            this.dtpDataInicio.Size = new System.Drawing.Size(274, 36);
            this.dtpDataInicio.TabIndex = 40;
            this.dtpDataInicio.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(119, 468);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 22);
            this.label6.TabIndex = 39;
            this.label6.Text = "Data de Inicio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(119, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 22);
            this.label4.TabIndex = 38;
            this.label4.Text = "Professor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 22);
            this.label2.TabIndex = 42;
            this.label2.Text = "Nome";
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
            this.txtNome.Location = new System.Drawing.Point(123, 177);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(274, 42);
            this.txtNome.TabIndex = 41;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(119, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 22);
            this.label8.TabIndex = 46;
            this.label8.Text = "Disciplina";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(119, 316);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 22);
            this.label10.TabIndex = 50;
            this.label10.Text = "Sala";
            // 
            // txtQuantProvas
            // 
            this.txtQuantProvas.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantProvas.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantProvas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantProvas.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantProvas.HintText = "";
            this.txtQuantProvas.isPassword = false;
            this.txtQuantProvas.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantProvas.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtQuantProvas.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantProvas.LineThickness = 1;
            this.txtQuantProvas.Location = new System.Drawing.Point(123, 402);
            this.txtQuantProvas.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantProvas.Name = "txtQuantProvas";
            this.txtQuantProvas.Size = new System.Drawing.Size(274, 42);
            this.txtQuantProvas.TabIndex = 53;
            this.txtQuantProvas.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(119, 392);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 22);
            this.label12.TabIndex = 54;
            this.label12.Text = "Provas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 44;
            this.label5.Text = "Max. Alunos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(492, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 22);
            this.label7.TabIndex = 48;
            this.label7.Text = "Nivel";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(492, 316);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 22);
            this.label9.TabIndex = 52;
            this.label9.Text = "Proprina";
            // 
            // txtQuantMaxAlunos
            // 
            this.txtQuantMaxAlunos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantMaxAlunos.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantMaxAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantMaxAlunos.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantMaxAlunos.HintText = "";
            this.txtQuantMaxAlunos.isPassword = false;
            this.txtQuantMaxAlunos.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantMaxAlunos.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtQuantMaxAlunos.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantMaxAlunos.LineThickness = 1;
            this.txtQuantMaxAlunos.Location = new System.Drawing.Point(496, 177);
            this.txtQuantMaxAlunos.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantMaxAlunos.Name = "txtQuantMaxAlunos";
            this.txtQuantMaxAlunos.Size = new System.Drawing.Size(273, 42);
            this.txtQuantMaxAlunos.TabIndex = 43;
            this.txtQuantMaxAlunos.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtPropina
            // 
            this.txtPropina.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropina.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPropina.HintForeColor = System.Drawing.Color.Empty;
            this.txtPropina.HintText = "";
            this.txtPropina.isPassword = false;
            this.txtPropina.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPropina.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtPropina.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPropina.LineThickness = 1;
            this.txtPropina.Location = new System.Drawing.Point(496, 326);
            this.txtPropina.Margin = new System.Windows.Forms.Padding(4);
            this.txtPropina.Name = "txtPropina";
            this.txtPropina.Size = new System.Drawing.Size(273, 42);
            this.txtPropina.TabIndex = 51;
            this.txtPropina.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtCargaHoraria
            // 
            this.txtCargaHoraria.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCargaHoraria.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargaHoraria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCargaHoraria.HintForeColor = System.Drawing.Color.Empty;
            this.txtCargaHoraria.HintText = "";
            this.txtCargaHoraria.isPassword = false;
            this.txtCargaHoraria.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCargaHoraria.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtCargaHoraria.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCargaHoraria.LineThickness = 1;
            this.txtCargaHoraria.Location = new System.Drawing.Point(496, 402);
            this.txtCargaHoraria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCargaHoraria.Name = "txtCargaHoraria";
            this.txtCargaHoraria.Size = new System.Drawing.Size(273, 42);
            this.txtCargaHoraria.TabIndex = 55;
            this.txtCargaHoraria.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(492, 392);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 22);
            this.label11.TabIndex = 56;
            this.label11.Text = "Carga Horaria";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(492, 468);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 22);
            this.label13.TabIndex = 57;
            this.label13.Text = "Data de fim";
            // 
            // dtpDataFim
            // 
            this.dtpDataFim.CheckedState.Parent = this.dtpDataFim;
            this.dtpDataFim.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.dtpDataFim.ForeColor = System.Drawing.Color.White;
            this.dtpDataFim.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFim.HoverState.Parent = this.dtpDataFim;
            this.dtpDataFim.Location = new System.Drawing.Point(496, 506);
            this.dtpDataFim.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpDataFim.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtpDataFim.Name = "dtpDataFim";
            this.dtpDataFim.ShadowDecoration.Parent = this.dtpDataFim;
            this.dtpDataFim.Size = new System.Drawing.Size(273, 36);
            this.dtpDataFim.TabIndex = 58;
            this.dtpDataFim.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            // 
            // cmbProfessor
            // 
            this.cmbProfessor.BackColor = System.Drawing.Color.Transparent;
            this.cmbProfessor.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbProfessor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProfessor.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbProfessor.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProfessor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbProfessor.FocusedState.Parent = this.cmbProfessor;
            this.cmbProfessor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbProfessor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbProfessor.HoverState.Parent = this.cmbProfessor;
            this.cmbProfessor.ItemHeight = 30;
            this.cmbProfessor.ItemsAppearance.Parent = this.cmbProfessor;
            this.cmbProfessor.Location = new System.Drawing.Point(123, 119);
            this.cmbProfessor.Name = "cmbProfessor";
            this.cmbProfessor.ShadowDecoration.Parent = this.cmbProfessor;
            this.cmbProfessor.Size = new System.Drawing.Size(646, 36);
            this.cmbProfessor.TabIndex = 106;
            // 
            // cmbDisciplina
            // 
            this.cmbDisciplina.BackColor = System.Drawing.Color.Transparent;
            this.cmbDisciplina.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbDisciplina.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDisciplina.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbDisciplina.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisciplina.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbDisciplina.FocusedState.Parent = this.cmbDisciplina;
            this.cmbDisciplina.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbDisciplina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbDisciplina.HoverState.Parent = this.cmbDisciplina;
            this.cmbDisciplina.ItemHeight = 30;
            this.cmbDisciplina.ItemsAppearance.Parent = this.cmbDisciplina;
            this.cmbDisciplina.Location = new System.Drawing.Point(123, 261);
            this.cmbDisciplina.Name = "cmbDisciplina";
            this.cmbDisciplina.ShadowDecoration.Parent = this.cmbDisciplina;
            this.cmbDisciplina.Size = new System.Drawing.Size(274, 36);
            this.cmbDisciplina.TabIndex = 107;
            // 
            // cmbNivel
            // 
            this.cmbNivel.BackColor = System.Drawing.Color.Transparent;
            this.cmbNivel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbNivel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbNivel.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNivel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbNivel.FocusedState.Parent = this.cmbNivel;
            this.cmbNivel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbNivel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbNivel.HoverState.Parent = this.cmbNivel;
            this.cmbNivel.ItemHeight = 30;
            this.cmbNivel.ItemsAppearance.Parent = this.cmbNivel;
            this.cmbNivel.Location = new System.Drawing.Point(496, 261);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.ShadowDecoration.Parent = this.cmbNivel;
            this.cmbNivel.Size = new System.Drawing.Size(273, 36);
            this.cmbNivel.TabIndex = 108;
            // 
            // cmbSala
            // 
            this.cmbSala.BackColor = System.Drawing.Color.Transparent;
            this.cmbSala.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbSala.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSala.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSala.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbSala.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSala.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbSala.FocusedState.Parent = this.cmbSala;
            this.cmbSala.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbSala.HoverState.Parent = this.cmbSala;
            this.cmbSala.ItemHeight = 30;
            this.cmbSala.ItemsAppearance.Parent = this.cmbSala;
            this.cmbSala.Location = new System.Drawing.Point(125, 341);
            this.cmbSala.Name = "cmbSala";
            this.cmbSala.ShadowDecoration.Parent = this.cmbSala;
            this.cmbSala.Size = new System.Drawing.Size(272, 36);
            this.cmbSala.TabIndex = 109;
            // 
            // frmAdicionarTurma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(885, 650);
            this.Controls.Add(this.cmbSala);
            this.Controls.Add(this.cmbNivel);
            this.Controls.Add(this.cmbDisciplina);
            this.Controls.Add(this.cmbProfessor);
            this.Controls.Add(this.dtpDataFim);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCargaHoraria);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtQuantProvas);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtPropina);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantMaxAlunos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.dtpDataInicio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdicionarTurma";
            this.Text = "frmTurma";
            this.Load += new System.EventHandler(this.frmTurma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataInicio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantProvas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantMaxAlunos;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPropina;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCargaHoraria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFim;
        private Guna.UI2.WinForms.Guna2ComboBox cmbProfessor;
        private Guna.UI2.WinForms.Guna2ComboBox cmbDisciplina;
        private Guna.UI2.WinForms.Guna2ComboBox cmbNivel;
        private Guna.UI2.WinForms.Guna2ComboBox cmbSala;
    }
}