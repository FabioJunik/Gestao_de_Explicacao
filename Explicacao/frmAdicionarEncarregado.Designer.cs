namespace Explicacao
{
    partial class frmAdicionarEncarregado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarEncarregado));
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNome = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rdFemenino = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.rbMasculino = new Guna.UI2.WinForms.Guna2RadioButton();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
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
            this.btnSalvar.Location = new System.Drawing.Point(75, 399);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(348, 40);
            this.btnSalvar.TabIndex = 91;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 22);
            this.label7.TabIndex = 93;
            this.label7.Text = "Nome*";
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
            this.txtNome.Location = new System.Drawing.Point(75, 137);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(348, 42);
            this.txtNome.TabIndex = 92;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(70, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(236, 27);
            this.label3.TabIndex = 94;
            this.label3.Text = "Adicionar Encarregado";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 22);
            this.label1.TabIndex = 96;
            this.label1.Text = "Telefone1*/Telefone 2";
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
            this.txtTelefone.Location = new System.Drawing.Point(75, 225);
            this.txtTelefone.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(348, 42);
            this.txtTelefone.TabIndex = 95;
            this.txtTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rdFemenino
            // 
            this.rdFemenino.AutoSize = true;
            this.rdFemenino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemenino.CheckedState.BorderThickness = 0;
            this.rdFemenino.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rdFemenino.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rdFemenino.CheckedState.InnerOffset = -4;
            this.rdFemenino.Location = new System.Drawing.Point(204, 321);
            this.rdFemenino.Name = "rdFemenino";
            this.rdFemenino.Size = new System.Drawing.Size(97, 26);
            this.rdFemenino.TabIndex = 99;
            this.rdFemenino.Text = "Femenino";
            this.rdFemenino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rdFemenino.UncheckedState.BorderThickness = 2;
            this.rdFemenino.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rdFemenino.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 22);
            this.label5.TabIndex = 98;
            this.label5.Text = "Sexo*";
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Checked = true;
            this.rbMasculino.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMasculino.CheckedState.BorderThickness = 0;
            this.rbMasculino.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rbMasculino.CheckedState.InnerColor = System.Drawing.Color.White;
            this.rbMasculino.CheckedState.InnerOffset = -4;
            this.rbMasculino.Location = new System.Drawing.Point(75, 321);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(95, 26);
            this.rbMasculino.TabIndex = 97;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.rbMasculino.UncheckedState.BorderThickness = 2;
            this.rbMasculino.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.rbMasculino.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.Transparent;
            this.pnlBarraTitulo.Controls.Add(this.btnFechar);
            this.pnlBarraTitulo.Location = new System.Drawing.Point(7, 7);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(482, 30);
            this.pnlBarraTitulo.TabIndex = 113;
            this.pnlBarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlBarraTitulo_MouseDown);
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(460, 3);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 1;
            this.btnFechar.TabStop = false;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Enabled = false;
            this.guna2Button1.FillColor = System.Drawing.Color.Transparent;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(1, 1);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.PressedColor = System.Drawing.Color.Transparent;
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(492, 466);
            this.guna2Button1.TabIndex = 164;
            // 
            // frmAdicionarEncarregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(494, 468);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.rdFemenino);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbMasculino);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTelefone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.guna2Button1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmAdicionarEncarregado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionarEncarregado";
            this.Load += new System.EventHandler(this.frmAdicionarEncarregado_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTelefone;
        private Guna.UI2.WinForms.Guna2RadioButton rdFemenino;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2RadioButton rbMasculino;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}