namespace Explicacao
{
    partial class frmAdicionarPropina
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdicionarPropina));
            this.label4 = new System.Windows.Forms.Label();
            this.btnInserir = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantMeses = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.btnFechar = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 14F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(50, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 24);
            this.label4.TabIndex = 138;
            this.label4.Text = "Registar Propinas";
            // 
            // btnInserir
            // 
            this.btnInserir.CheckedState.Parent = this.btnInserir;
            this.btnInserir.CustomImages.Parent = this.btnInserir;
            this.btnInserir.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.ForeColor = System.Drawing.Color.White;
            this.btnInserir.HoverState.Parent = this.btnInserir;
            this.btnInserir.Location = new System.Drawing.Point(54, 370);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.ShadowDecoration.Parent = this.btnInserir;
            this.btnInserir.Size = new System.Drawing.Size(376, 40);
            this.btnInserir.TabIndex = 137;
            this.btnInserir.Text = "Inseir";
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 22);
            this.label2.TabIndex = 143;
            this.label2.Text = "Valor";
            // 
            // txtValor
            // 
            this.txtValor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtValor.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtValor.HintForeColor = System.Drawing.Color.Empty;
            this.txtValor.HintText = "";
            this.txtValor.isPassword = false;
            this.txtValor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtValor.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtValor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtValor.LineThickness = 1;
            this.txtValor.Location = new System.Drawing.Point(54, 265);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(367, 42);
            this.txtValor.TabIndex = 142;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 22);
            this.label1.TabIndex = 145;
            this.label1.Text = "Quantidade de Meses*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtQuantMeses
            // 
            this.txtQuantMeses.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantMeses.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantMeses.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtQuantMeses.HintForeColor = System.Drawing.Color.Empty;
            this.txtQuantMeses.HintText = "";
            this.txtQuantMeses.isPassword = false;
            this.txtQuantMeses.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtQuantMeses.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtQuantMeses.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtQuantMeses.LineThickness = 1;
            this.txtQuantMeses.Location = new System.Drawing.Point(54, 161);
            this.txtQuantMeses.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantMeses.Name = "txtQuantMeses";
            this.txtQuantMeses.Size = new System.Drawing.Size(367, 42);
            this.txtQuantMeses.TabIndex = 144;
            this.txtQuantMeses.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtQuantMeses.OnValueChanged += new System.EventHandler(this.txtQuantMeses_OnValueChanged);
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
            this.pnlBarraTitulo.TabIndex = 146;
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
            // 
            // frmAdicionarPropina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.ClientSize = new System.Drawing.Size(494, 468);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantMeses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInserir);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "frmAdicionarPropina";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'";
            this.Load += new System.EventHandler(this.frmAdicionarPropina_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnFechar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button btnInserir;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtValor;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtQuantMeses;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox btnFechar;
    }
}