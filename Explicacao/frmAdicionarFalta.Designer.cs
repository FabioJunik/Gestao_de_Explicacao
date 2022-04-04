namespace Explicacao
{
    partial class frmAdicionarFalta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarFalta));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCodTurma = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDataFalta = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSalvar = new Guna.UI2.WinForms.Guna2Button();
            this.cmbCodAluno = new Guna.UI2.WinForms.Guna2ComboBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.pnlBarraTitulo.Controls.Add(this.btnFechar);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(494, 30);
            this.pnlBarraTitulo.TabIndex = 87;
            // 
            // btnFechar
            // 
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFechar.Image = ((System.Drawing.Image)(resources.GetObject("btnFechar.Image")));
            this.btnFechar.Location = new System.Drawing.Point(464, 6);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(18, 18);
            this.btnFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnFechar.TabIndex = 1;
            this.btnFechar.TabStop = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 27);
            this.label3.TabIndex = 95;
            this.label3.Text = "Registrar Falta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(68, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 22);
            this.label7.TabIndex = 96;
            this.label7.Text = "Código do aluno*";
            // 
            // cmbCodTurma
            // 
            this.cmbCodTurma.BackColor = System.Drawing.Color.Transparent;
            this.cmbCodTurma.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbCodTurma.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCodTurma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodTurma.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbCodTurma.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCodTurma.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCodTurma.FocusedState.Parent = this.cmbCodTurma;
            this.cmbCodTurma.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCodTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCodTurma.HoverState.Parent = this.cmbCodTurma;
            this.cmbCodTurma.ItemHeight = 30;
            this.cmbCodTurma.ItemsAppearance.Parent = this.cmbCodTurma;
            this.cmbCodTurma.Location = new System.Drawing.Point(72, 237);
            this.cmbCodTurma.Name = "cmbCodTurma";
            this.cmbCodTurma.ShadowDecoration.Parent = this.cmbCodTurma;
            this.cmbCodTurma.Size = new System.Drawing.Size(339, 36);
            this.cmbCodTurma.TabIndex = 107;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 22);
            this.label1.TabIndex = 106;
            this.label1.Text = "Código da Turma*";
            // 
            // dtpDataFalta
            // 
            this.dtpDataFalta.CheckedState.Parent = this.dtpDataFalta;
            this.dtpDataFalta.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.dtpDataFalta.ForeColor = System.Drawing.Color.White;
            this.dtpDataFalta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFalta.HoverState.Parent = this.dtpDataFalta;
            this.dtpDataFalta.Location = new System.Drawing.Point(72, 333);
            this.dtpDataFalta.MaxDate = new System.DateTime(2022, 12, 31, 0, 0, 0, 0);
            this.dtpDataFalta.MinDate = new System.DateTime(1985, 1, 1, 0, 0, 0, 0);
            this.dtpDataFalta.Name = "dtpDataFalta";
            this.dtpDataFalta.ShadowDecoration.Parent = this.dtpDataFalta;
            this.dtpDataFalta.Size = new System.Drawing.Size(339, 36);
            this.dtpDataFalta.TabIndex = 108;
            this.dtpDataFalta.Value = new System.DateTime(2022, 3, 16, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 22);
            this.label2.TabIndex = 109;
            this.label2.Text = "Data da falta*";
            // 
            // btnSalvar
            // 
            this.btnSalvar.CheckedState.Parent = this.btnSalvar;
            this.btnSalvar.CustomImages.Parent = this.btnSalvar;
            this.btnSalvar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(230)))), ((int)(((byte)(119)))));
            this.btnSalvar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.Color.White;
            this.btnSalvar.HoverState.Parent = this.btnSalvar;
            this.btnSalvar.Location = new System.Drawing.Point(72, 395);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.ShadowDecoration.Parent = this.btnSalvar;
            this.btnSalvar.Size = new System.Drawing.Size(339, 40);
            this.btnSalvar.TabIndex = 110;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // cmbCodAluno
            // 
            this.cmbCodAluno.BackColor = System.Drawing.Color.Transparent;
            this.cmbCodAluno.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.cmbCodAluno.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCodAluno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCodAluno.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.cmbCodAluno.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCodAluno.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCodAluno.FocusedState.Parent = this.cmbCodAluno;
            this.cmbCodAluno.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCodAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbCodAluno.HoverState.Parent = this.cmbCodAluno;
            this.cmbCodAluno.ItemHeight = 30;
            this.cmbCodAluno.ItemsAppearance.Parent = this.cmbCodAluno;
            this.cmbCodAluno.Location = new System.Drawing.Point(72, 151);
            this.cmbCodAluno.Name = "cmbCodAluno";
            this.cmbCodAluno.ShadowDecoration.Parent = this.cmbCodAluno;
            this.cmbCodAluno.Size = new System.Drawing.Size(339, 36);
            this.cmbCodAluno.TabIndex = 105;
            // 
            // frmAdicionarFalta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 468);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpDataFalta);
            this.Controls.Add(this.cmbCodTurma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbCodAluno);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmAdicionarFalta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAdicionarFalta";
            this.Load += new System.EventHandler(this.frmAdicionarFalta_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCodTurma;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDataFalta;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSalvar;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCodAluno;
    }
}