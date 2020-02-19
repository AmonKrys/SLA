namespace SLA
{
    partial class frm_Locacao
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
            this.pnl_Titulo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnl_Botoes = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.lbox_Locacoes = new System.Windows.Forms.ListBox();
            this.pnl_Detalhe = new System.Windows.Forms.Panel();
            this.tbox_Obs_Locacao = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbox_Cod_Locacao = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Inicio_Locacao = new System.Windows.Forms.TextBox();
            this.tbox_Fim_Locacao = new System.Windows.Forms.TextBox();
            this.pnl_Titulo.SuspendLayout();
            this.pnl_Botoes.SuspendLayout();
            this.pnl_Detalhe.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Titulo
            // 
            this.pnl_Titulo.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Titulo.Controls.Add(this.label4);
            this.pnl_Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Titulo.Location = new System.Drawing.Point(0, 0);
            this.pnl_Titulo.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Titulo.Name = "pnl_Titulo";
            this.pnl_Titulo.Size = new System.Drawing.Size(605, 52);
            this.pnl_Titulo.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(240, 9);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Locacão";
            // 
            // pnl_Botoes
            // 
            this.pnl_Botoes.BackColor = System.Drawing.Color.CadetBlue;
            this.pnl_Botoes.Controls.Add(this.btn_Cancelar);
            this.pnl_Botoes.Controls.Add(this.btn_Confirmar);
            this.pnl_Botoes.Controls.Add(this.btn_Excluir);
            this.pnl_Botoes.Controls.Add(this.btn_Alterar);
            this.pnl_Botoes.Controls.Add(this.btn_Novo);
            this.pnl_Botoes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Botoes.Location = new System.Drawing.Point(0, 276);
            this.pnl_Botoes.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Botoes.Name = "pnl_Botoes";
            this.pnl_Botoes.Size = new System.Drawing.Size(605, 40);
            this.pnl_Botoes.TabIndex = 11;
            this.pnl_Botoes.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cancelar.Location = new System.Drawing.Point(380, 9);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(67, 23);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Confirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Confirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Confirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Confirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Confirmar.Location = new System.Drawing.Point(301, 9);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(74, 23);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Excluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Excluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Excluir.Location = new System.Drawing.Point(137, 9);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(62, 23);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Alterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Alterar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Alterar.Location = new System.Drawing.Point(71, 9);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(62, 23);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.BurlyWood;
            this.btn_Novo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Novo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Novo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Novo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Novo.Location = new System.Drawing.Point(5, 9);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(62, 23);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // lbox_Locacoes
            // 
            this.lbox_Locacoes.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbox_Locacoes.FormattingEnabled = true;
            this.lbox_Locacoes.Location = new System.Drawing.Point(0, 52);
            this.lbox_Locacoes.Margin = new System.Windows.Forms.Padding(2);
            this.lbox_Locacoes.Name = "lbox_Locacoes";
            this.lbox_Locacoes.Size = new System.Drawing.Size(133, 224);
            this.lbox_Locacoes.TabIndex = 12;
            this.lbox_Locacoes.Click += new System.EventHandler(this.lbox_Locacoes_Click);
            // 
            // pnl_Detalhe
            // 
            this.pnl_Detalhe.BackColor = System.Drawing.Color.AliceBlue;
            this.pnl_Detalhe.Controls.Add(this.tbox_Fim_Locacao);
            this.pnl_Detalhe.Controls.Add(this.tbox_Inicio_Locacao);
            this.pnl_Detalhe.Controls.Add(this.tbox_Obs_Locacao);
            this.pnl_Detalhe.Controls.Add(this.label12);
            this.pnl_Detalhe.Controls.Add(this.label14);
            this.pnl_Detalhe.Controls.Add(this.tbox_Cod_Locacao);
            this.pnl_Detalhe.Controls.Add(this.label6);
            this.pnl_Detalhe.Controls.Add(this.label5);
            this.pnl_Detalhe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detalhe.Location = new System.Drawing.Point(133, 52);
            this.pnl_Detalhe.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detalhe.Name = "pnl_Detalhe";
            this.pnl_Detalhe.Size = new System.Drawing.Size(472, 224);
            this.pnl_Detalhe.TabIndex = 13;
            // 
            // tbox_Obs_Locacao
            // 
            this.tbox_Obs_Locacao.Location = new System.Drawing.Point(16, 147);
            this.tbox_Obs_Locacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Obs_Locacao.Multiline = true;
            this.tbox_Obs_Locacao.Name = "tbox_Obs_Locacao";
            this.tbox_Obs_Locacao.Size = new System.Drawing.Size(315, 73);
            this.tbox_Obs_Locacao.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label12.Location = new System.Drawing.Point(14, 132);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Obs_Locacao";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label14.Location = new System.Drawing.Point(14, 91);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 20;
            this.label14.Text = "Fim_locacao";
            // 
            // tbox_Cod_Locacao
            // 
            this.tbox_Cod_Locacao.Enabled = false;
            this.tbox_Cod_Locacao.Location = new System.Drawing.Point(16, 28);
            this.tbox_Cod_Locacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Locacao.Name = "tbox_Cod_Locacao";
            this.tbox_Cod_Locacao.Size = new System.Drawing.Size(52, 20);
            this.tbox_Cod_Locacao.TabIndex = 4;
            this.tbox_Cod_Locacao.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label6.Location = new System.Drawing.Point(14, 50);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Inicio_Locacao";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(14, 12);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código";
            // 
            // tbox_Inicio_Locacao
            // 
            this.tbox_Inicio_Locacao.Enabled = false;
            this.tbox_Inicio_Locacao.Location = new System.Drawing.Point(17, 69);
            this.tbox_Inicio_Locacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Inicio_Locacao.Name = "tbox_Inicio_Locacao";
            this.tbox_Inicio_Locacao.Size = new System.Drawing.Size(116, 20);
            this.tbox_Inicio_Locacao.TabIndex = 29;
            this.tbox_Inicio_Locacao.Tag = "0";
            this.tbox_Inicio_Locacao.TextChanged += new System.EventHandler(this.tbox_Inicio_Locacao_TextChanged);
            // 
            // tbox_Fim_Locacao
            // 
            this.tbox_Fim_Locacao.Enabled = false;
            this.tbox_Fim_Locacao.Location = new System.Drawing.Point(16, 110);
            this.tbox_Fim_Locacao.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Fim_Locacao.Name = "tbox_Fim_Locacao";
            this.tbox_Fim_Locacao.Size = new System.Drawing.Size(116, 20);
            this.tbox_Fim_Locacao.TabIndex = 30;
            this.tbox_Fim_Locacao.Tag = "0";
            // 
            // frm_Locacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 316);
            this.Controls.Add(this.pnl_Detalhe);
            this.Controls.Add(this.lbox_Locacoes);
            this.Controls.Add(this.pnl_Botoes);
            this.Controls.Add(this.pnl_Titulo);
            this.Name = "frm_Locacao";
            this.Text = "frm_Locacao";
            this.pnl_Titulo.ResumeLayout(false);
            this.pnl_Titulo.PerformLayout();
            this.pnl_Botoes.ResumeLayout(false);
            this.pnl_Detalhe.ResumeLayout(false);
            this.pnl_Detalhe.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Titulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnl_Botoes;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.ListBox lbox_Locacoes;
        private System.Windows.Forms.Panel pnl_Detalhe;
        private System.Windows.Forms.TextBox tbox_Obs_Locacao;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbox_Cod_Locacao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Fim_Locacao;
        private System.Windows.Forms.TextBox tbox_Inicio_Locacao;
    }
}