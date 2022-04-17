namespace Explicacao
{
    partial class frmVerNota
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVerNota));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVoltar = new Guna.UI2.WinForms.Guna2Button();
            this.dgvNota = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnEliminar = new Guna.UI2.WinForms.Guna2Button();
            this.btnInserir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.lblTurma = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 16F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(62, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 27);
            this.label3.TabIndex = 84;
            this.label3.Text = "Notas";
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
            this.btnVoltar.Location = new System.Drawing.Point(28, 26);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.ShadowDecoration.Parent = this.btnVoltar;
            this.btnVoltar.Size = new System.Drawing.Size(28, 26);
            this.btnVoltar.TabIndex = 83;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // dgvNota
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvNota.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvNota.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNota.BackgroundColor = System.Drawing.Color.White;
            this.dgvNota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNota.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNota.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNota.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvNota.ColumnHeadersHeight = 30;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNota.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvNota.EnableHeadersVisualStyles = false;
            this.dgvNota.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNota.Location = new System.Drawing.Point(42, 188);
            this.dgvNota.Name = "dgvNota";
            this.dgvNota.RowHeadersVisible = false;
            this.dgvNota.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNota.Size = new System.Drawing.Size(801, 374);
            this.dgvNota.TabIndex = 92;
            this.dgvNota.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvNota.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNota.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvNota.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvNota.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvNota.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvNota.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvNota.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNota.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvNota.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvNota.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNota.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvNota.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvNota.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvNota.ThemeStyle.ReadOnly = false;
            this.dgvNota.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvNota.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNota.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvNota.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvNota.ThemeStyle.RowsStyle.Height = 22;
            this.dgvNota.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvNota.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // btnEliminar
            // 
            this.btnEliminar.CheckedState.Parent = this.btnEliminar;
            this.btnEliminar.CustomImages.Parent = this.btnEliminar;
            this.btnEliminar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(97)))), ((int)(((byte)(129)))));
            this.btnEliminar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.HoverState.Parent = this.btnEliminar;
            this.btnEliminar.Location = new System.Drawing.Point(575, 598);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.ShadowDecoration.Parent = this.btnEliminar;
            this.btnEliminar.Size = new System.Drawing.Size(175, 40);
            this.btnEliminar.TabIndex = 93;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.CheckedState.Parent = this.btnInserir;
            this.btnInserir.CustomImages.Parent = this.btnInserir;
            this.btnInserir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.HoverState.Parent = this.btnInserir;
            this.btnInserir.Location = new System.Drawing.Point(132, 598);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ShadowDecoration.Parent = this.btnInserir;
            this.btnInserir.Size = new System.Drawing.Size(175, 40);
            this.btnInserir.TabIndex = 94;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.CheckedState.Parent = this.btnEditar;
            this.btnEditar.CustomImages.Parent = this.btnEditar;
            this.btnEditar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.Parent = this.btnEditar;
            this.btnEditar.Location = new System.Drawing.Point(356, 598);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.ShadowDecoration.Parent = this.btnEditar;
            this.btnEditar.Size = new System.Drawing.Size(175, 40);
            this.btnEditar.TabIndex = 95;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // lblTurma
            // 
            this.lblTurma.AutoSize = true;
            this.lblTurma.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurma.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTurma.Location = new System.Drawing.Point(108, 139);
            this.lblTurma.Name = "lblTurma";
            this.lblTurma.Size = new System.Drawing.Size(43, 22);
            this.lblTurma.TabIndex = 101;
            this.lblTurma.Text = "II12B";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(108, 96);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(245, 22);
            this.lblNome.TabIndex = 100;
            this.lblNome.Text = "Fábio madaleno simao dos santos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(40, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 99;
            this.label4.Text = "Turma : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(40, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 22);
            this.label5.TabIndex = 98;
            this.label5.Text = "Nome :";
            // 
            // frmVerNota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(885, 650);
            this.Controls.Add(this.lblTurma);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.dgvNota);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnVoltar);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmVerNota";
            this.Text = "c";
            this.Load += new System.EventHandler(this.frmVerNota_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button btnVoltar;
        private Guna.UI2.WinForms.Guna2DataGridView dgvNota;
        private Guna.UI2.WinForms.Guna2Button btnEliminar;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private System.Windows.Forms.Label lblTurma;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}