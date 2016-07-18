namespace Loja.UIWindows
{
    partial class VendasRealizadas
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
            this.vendasDataGridView = new System.Windows.Forms.DataGridView();
            this.btFiltro = new System.Windows.Forms.Button();
            this.excluirButton = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.produtoTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.codigoTextBox = new System.Windows.Forms.TextBox();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.codigoLabel = new System.Windows.Forms.Label();
            this.dataLabel = new System.Windows.Forms.Label();
            this.dataTextBox = new System.Windows.Forms.TextBox();
            this.valorTotalLabel = new System.Windows.Forms.Label();
            this.valorTotalTextBox = new System.Windows.Forms.TextBox();
            this.precoLabel = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // vendasDataGridView
            // 
            this.vendasDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vendasDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.vendasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendasDataGridView.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vendasDataGridView.Location = new System.Drawing.Point(1, 258);
            this.vendasDataGridView.Name = "vendasDataGridView";
            this.vendasDataGridView.Size = new System.Drawing.Size(417, 204);
            this.vendasDataGridView.TabIndex = 29;
            this.vendasDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendasDataGridView_CellContentClick);
            // 
            // btFiltro
            // 
            this.btFiltro.Location = new System.Drawing.Point(14, 229);
            this.btFiltro.Name = "btFiltro";
            this.btFiltro.Size = new System.Drawing.Size(75, 23);
            this.btFiltro.TabIndex = 28;
            this.btFiltro.Text = "Filtrar";
            this.btFiltro.UseVisualStyleBackColor = true;
            this.btFiltro.Click += new System.EventHandler(this.btFiltro_Click);
            // 
            // excluirButton
            // 
            this.excluirButton.Location = new System.Drawing.Point(288, 229);
            this.excluirButton.Name = "excluirButton";
            this.excluirButton.Size = new System.Drawing.Size(75, 23);
            this.excluirButton.TabIndex = 27;
            this.excluirButton.Text = "Excluir";
            this.excluirButton.UseVisualStyleBackColor = true;
            this.excluirButton.Click += new System.EventHandler(this.excluirButton_Click);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtFiltro.Location = new System.Drawing.Point(105, 232);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(123, 20);
            this.txtFiltro.TabIndex = 23;
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(105, 144);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantidadeTextBox.TabIndex = 22;
            // 
            // produtoTextBox
            // 
            this.produtoTextBox.Location = new System.Drawing.Point(105, 81);
            this.produtoTextBox.Name = "produtoTextBox";
            this.produtoTextBox.Size = new System.Drawing.Size(200, 20);
            this.produtoTextBox.TabIndex = 21;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(105, 49);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(200, 20);
            this.clienteTextBox.TabIndex = 20;
            // 
            // codigoTextBox
            // 
            this.codigoTextBox.Location = new System.Drawing.Point(105, 17);
            this.codigoTextBox.Name = "codigoTextBox";
            this.codigoTextBox.ReadOnly = true;
            this.codigoTextBox.Size = new System.Drawing.Size(70, 20);
            this.codigoTextBox.TabIndex = 19;
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(12, 144);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(62, 13);
            this.quantidadeLabel.TabIndex = 18;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(11, 88);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(44, 13);
            this.emailLabel.TabIndex = 17;
            this.emailLabel.Text = "Produto";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(11, 52);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 16;
            this.clienteLabel.Text = "Cliente";
            // 
            // codigoLabel
            // 
            this.codigoLabel.AutoSize = true;
            this.codigoLabel.Location = new System.Drawing.Point(11, 20);
            this.codigoLabel.Name = "codigoLabel";
            this.codigoLabel.Size = new System.Drawing.Size(40, 13);
            this.codigoLabel.TabIndex = 15;
            this.codigoLabel.Text = "Código";
            // 
            // dataLabel
            // 
            this.dataLabel.AutoSize = true;
            this.dataLabel.Location = new System.Drawing.Point(12, 170);
            this.dataLabel.Name = "dataLabel";
            this.dataLabel.Size = new System.Drawing.Size(30, 13);
            this.dataLabel.TabIndex = 30;
            this.dataLabel.Text = "Data";
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(105, 170);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(200, 20);
            this.dataTextBox.TabIndex = 31;
            // 
            // valorTotalLabel
            // 
            this.valorTotalLabel.AutoSize = true;
            this.valorTotalLabel.Location = new System.Drawing.Point(11, 196);
            this.valorTotalLabel.Name = "valorTotalLabel";
            this.valorTotalLabel.Size = new System.Drawing.Size(58, 13);
            this.valorTotalLabel.TabIndex = 32;
            this.valorTotalLabel.Text = "Valor Total";
            // 
            // valorTotalTextBox
            // 
            this.valorTotalTextBox.Location = new System.Drawing.Point(105, 196);
            this.valorTotalTextBox.Name = "valorTotalTextBox";
            this.valorTotalTextBox.ReadOnly = true;
            this.valorTotalTextBox.Size = new System.Drawing.Size(84, 20);
            this.valorTotalTextBox.TabIndex = 33;
            // 
            // precoLabel
            // 
            this.precoLabel.AutoSize = true;
            this.precoLabel.Location = new System.Drawing.Point(11, 119);
            this.precoLabel.Name = "precoLabel";
            this.precoLabel.Size = new System.Drawing.Size(74, 13);
            this.precoLabel.TabIndex = 34;
            this.precoLabel.Text = "Preço Unitario";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(105, 116);
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(84, 20);
            this.precoTextBox.TabIndex = 35;
            // 
            // VendasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 474);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.precoLabel);
            this.Controls.Add(this.valorTotalTextBox);
            this.Controls.Add(this.valorTotalLabel);
            this.Controls.Add(this.dataTextBox);
            this.Controls.Add(this.dataLabel);
            this.Controls.Add(this.vendasDataGridView);
            this.Controls.Add(this.btFiltro);
            this.Controls.Add(this.excluirButton);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.produtoTextBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.codigoTextBox);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.codigoLabel);
            this.Name = "VendasRealizadas";
            this.Text = "VendasRealizadas";
            this.Load += new System.EventHandler(this.VendasRealizadasForm_load);
            ((System.ComponentModel.ISupportInitialize)(this.vendasDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vendasDataGridView;
        private System.Windows.Forms.Button btFiltro;
        private System.Windows.Forms.Button excluirButton;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.TextBox produtoTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.TextBox codigoTextBox;
        private System.Windows.Forms.Label quantidadeLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label codigoLabel;
        private System.Windows.Forms.Label dataLabel;
        private System.Windows.Forms.TextBox dataTextBox;
        private System.Windows.Forms.Label valorTotalLabel;
        private System.Windows.Forms.TextBox valorTotalTextBox;
        private System.Windows.Forms.Label precoLabel;
        private System.Windows.Forms.TextBox precoTextBox;
    }
}