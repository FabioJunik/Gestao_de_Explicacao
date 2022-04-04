namespace Explicacao
{
    partial class frmCadastrarAdm02
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
            this.btnCriar = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMulta = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDataLimite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnCancelar = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // btnCriar
            // 
            this.btnCriar.CheckedState.Parent = this.btnCriar;
            this.btnCriar.CustomImages.Parent = this.btnCriar;
            this.btnCriar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCriar.ForeColor = System.Drawing.Color.White;
            this.btnCriar.HoverState.Parent = this.btnCriar;
            this.btnCriar.Location = new System.Drawing.Point(230, 433);
            this.btnCriar.Name = "btnCriar";
            this.btnCriar.ShadowDecoration.Parent = this.btnCriar;
            this.btnCriar.Size = new System.Drawing.Size(122, 40);
            this.btnCriar.TabIndex = 121;
            this.btnCriar.Text = "Criar";
            this.btnCriar.Click += new System.EventHandler(this.frmCriar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 22);
            this.label2.TabIndex = 118;
            this.label2.Text = "Multa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 22);
            this.label4.TabIndex = 119;
            this.label4.Text = "Data limite do pagamento";
            // 
            // txtMulta
            // 
            this.txtMulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtMulta.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMulta.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMulta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMulta.HintForeColor = System.Drawing.Color.Empty;
            this.txtMulta.HintText = "";
            this.txtMulta.isPassword = false;
            this.txtMulta.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtMulta.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtMulta.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtMulta.LineThickness = 1;
            this.txtMulta.Location = new System.Drawing.Point(52, 256);
            this.txtMulta.Margin = new System.Windows.Forms.Padding(4);
            this.txtMulta.Name = "txtMulta";
            this.txtMulta.Size = new System.Drawing.Size(300, 42);
            this.txtMulta.TabIndex = 115;
            this.txtMulta.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtMulta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMulta_KeyPress);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(121)))), ((int)(((byte)(126)))));
            this.label1.Location = new System.Drawing.Point(90, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 69);
            this.label1.TabIndex = 113;
            this.label1.Text = "Defina uma Norma de pagamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtDataLimite
            // 
            this.txtDataLimite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(241)))), ((int)(((byte)(241)))));
            this.txtDataLimite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDataLimite.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLimite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDataLimite.HintForeColor = System.Drawing.Color.Empty;
            this.txtDataLimite.HintText = "";
            this.txtDataLimite.isPassword = false;
            this.txtDataLimite.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtDataLimite.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(155)))), ((int)(((byte)(230)))));
            this.txtDataLimite.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtDataLimite.LineThickness = 1;
            this.txtDataLimite.Location = new System.Drawing.Point(50, 160);
            this.txtDataLimite.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataLimite.Name = "txtDataLimite";
            this.txtDataLimite.Size = new System.Drawing.Size(300, 42);
            this.txtDataLimite.TabIndex = 122;
            this.txtDataLimite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnCancelar
            // 
            this.btnCancelar.CheckedState.Parent = this.btnCancelar;
            this.btnCancelar.CustomImages.Parent = this.btnCancelar;
            this.btnCancelar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.HoverState.Parent = this.btnCancelar;
            this.btnCancelar.Location = new System.Drawing.Point(52, 433);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.ShadowDecoration.Parent = this.btnCancelar;
            this.btnCancelar.Size = new System.Drawing.Size(120, 40);
            this.btnCancelar.TabIndex = 123;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadastrarAdm02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 500);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.txtDataLimite);
            this.Controls.Add(this.btnCriar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMulta);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmCadastrarAdm02";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnCriar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMulta;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDataLimite;
        private Guna.UI2.WinForms.Guna2Button btnCancelar;
    }
}