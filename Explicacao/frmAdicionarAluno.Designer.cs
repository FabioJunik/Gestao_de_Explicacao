namespace Explicacao
{
    partial class frmAdicionarAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarAluno));
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rdMasculino = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rdFemenino = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTelefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMunicipio = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtBairro = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtRua = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dtpDataNasc = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
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
            this.txtNome.Location = new System.Drawing.Point(81, 189);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.txtNome.Size = new System.Drawing.Size(715, 42);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNome.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            this.txtNome.Leave += new System.EventHandler(this.txtNome_Leave);
            // 
            // btnSalvar
            // 
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(230)))), ((int)(((byte)(119)))));
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(81, 568);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(247, 40);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar ";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(46, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Novo Aluno";
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
            this.btnVoltar.Location = new System.Drawing.Point(13, 10);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Parent = this.btnVoltar;
            this.btnVoltar.Size = new System.Drawing.Size(28, 26);
            this.btnVoltar.TabIndex = 14;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 22);
            this.label4.TabIndex = 16;
            this.label4.Text = "E-Mail";
            // 
            // txtEmail
            // 
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 1;
            this.txtEmail.Location = new System.Drawing.Point(81, 263);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 42);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // rdMasculino
            // 
            this.rdMasculino.AutoSize = true;
            this.rdMasculino.Checked = true;
            this.rdMasculino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMasculino.CheckedState.BorderThickness = 0;
            this.rdMasculino.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdMasculino.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdMasculino.CheckedState.InnerOffset = -4;
            this.rdMasculino.Location = new System.Drawing.Point(545, 279);
            this.rdMasculino.Name = "rdMasculino";
            this.rdMasculino.Size = new System.Drawing.Size(95, 26);
            this.rdMasculino.TabIndex = 17;
            this.rdMasculino.TabStop = true;
            this.rdMasculino.Text = "Masculino";
            this.rdMasculino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdMasculino.UncheckedState.BorderThickness = 2;
            this.rdMasculino.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdMasculino.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(541, 249);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 18;
            this.label5.Text = "Sexo*";
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemenino.CheckedState.BorderThickness = 0;
            this.rdFemenino.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemenino.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdFemenino.CheckedState.InnerOffset = -4;
            this.rdFemenino.Location = new System.Drawing.Point(702, 279);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(97, 26);
            this.rdFemenino.TabIndex = 19;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdFemenino.UncheckedState.BorderThickness = 2;
            this.rdFemenino.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdFemenino.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(547, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(158, 22);
            this.label6.TabIndex = 22;
            this.label6.Text = "Data de Nascimento*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 22);
            this.label7.TabIndex = 24;
            this.label7.Text = "Telefone1*/Telefone 2";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTelefone.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTelefone.HintForeColor = System.Drawing.Color.Empty;
            this.txtTelefone.HintText = "";
            this.txtTelefone.isPassword = false;
            this.txtTelefone.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtTelefone.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtTelefone.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtTelefone.LineThickness = 1;
            this.txtTelefone.Location = new System.Drawing.Point(81, 360);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(337, 42);
            this.txtTelefone.TabIndex = 23;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTelefone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefone_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(77, 445);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 22);
            this.label8.TabIndex = 26;
            this.label8.Text = "Municipio*";
            // 
            // txtMunicipio
            // 
            this.txtMunicipio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMunicipio.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMunicipio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMunicipio.HintForeColor = System.Drawing.Color.Empty;
            this.txtMunicipio.HintText = "";
            this.txtMunicipio.isPassword = false;
            this.txtMunicipio.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMunicipio.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtMunicipio.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMunicipio.LineThickness = 1;
            this.txtMunicipio.Location = new System.Drawing.Point(81, 461);
            this.txtMunicipio.Margin = new System.Windows.Forms.Padding(4);
            this.txtMunicipio.Name = "txtMunicipio";
            this.txtMunicipio.Size = new System.Drawing.Size(210, 42);
            this.txtMunicipio.TabIndex = 25;
            this.txtMunicipio.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMunicipio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(333, 445);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 22);
            this.label9.TabIndex = 28;
            this.label9.Text = "Bairro*";
            // 
            // txtBairro
            // 
            this.txtBairro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBairro.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBairro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBairro.HintForeColor = System.Drawing.Color.Empty;
            this.txtBairro.HintText = "";
            this.txtBairro.isPassword = false;
            this.txtBairro.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtBairro.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtBairro.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtBairro.LineThickness = 1;
            this.txtBairro.Location = new System.Drawing.Point(337, 461);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(210, 42);
            this.txtBairro.TabIndex = 27;
            this.txtBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 22);
            this.label10.TabIndex = 30;
            this.label10.Text = "Rua";
            // 
            // txtRua
            // 
            this.txtRua.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRua.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRua.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRua.HintForeColor = System.Drawing.Color.Empty;
            this.txtRua.HintText = "";
            this.txtRua.isPassword = false;
            this.txtRua.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRua.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtRua.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRua.LineThickness = 1;
            this.txtRua.Location = new System.Drawing.Point(597, 461);
            this.txtRua.Margin = new System.Windows.Forms.Padding(4);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(199, 42);
            this.txtRua.TabIndex = 29;
            this.txtRua.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dtpDataNasc
            // 
            this.dtpDataNasc.CheckedState.Parent = this.dtpDataNasc;
            this.dtpDataNasc.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.dtpDataNasc.ForeColor = System.Drawing.Color.White;
            this.dtpDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataNasc.HoverState.Parent = this.dtpDataNasc;
            this.dtpDataNasc.Location = new System.Drawing.Point(549, 375);
            this.dtpDataNasc.MaxDate = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            this.dtpDataNasc.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtpDataNasc.Name = "dtpDataNasc";
            this.dtpDataNasc.ShadowDecoration.Parent = this.dtpDataNasc;
            this.dtpDataNasc.Size = new System.Drawing.Size(247, 36);
            this.dtpDataNasc.TabIndex = 36;
            this.dtpDataNasc.Value = new System.DateTime(2020, 1, 1, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(549, 568);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(247, 40);
            this.btnCancelar.TabIndex = 37;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmAdicionarAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(885, 650);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dtpDataNasc);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMunicipio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rdFemenino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdMasculino);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtNome);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmAdicionarAluno";
            this.Text = "frmVerAluno";
            this.Load += new System.EventHandler(this.frmVerAluno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Guna.UI2.WinForms.Guna2RadioButton rdMasculino;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RadioButton rdFemenino;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefone;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMunicipio;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtBairro;
        private System.Windows.Forms.Label label10;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRua;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataNasc;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}