namespace Loja.UIWindows
{
    partial class ProdutosEmFaltaForm
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
            this.produtoEmFaltaLabel = new System.Windows.Forms.Label();
            this.produtoEmFaltaDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.produtoEmFaltaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoEmFaltaLabel
            // 
            this.produtoEmFaltaLabel.AutoSize = true;
            this.produtoEmFaltaLabel.Location = new System.Drawing.Point(9, 21);
            this.produtoEmFaltaLabel.Name = "produtoEmFaltaLabel";
            this.produtoEmFaltaLabel.Size = new System.Drawing.Size(154, 13);
            this.produtoEmFaltaLabel.TabIndex = 0;
            this.produtoEmFaltaLabel.Text = "Relatiorio de Produtos em Falta";
            // 
            // produtoEmFaltaDataGridView
            // 
            this.produtoEmFaltaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.produtoEmFaltaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoEmFaltaDataGridView.Location = new System.Drawing.Point(12, 58);
            this.produtoEmFaltaDataGridView.Name = "produtoEmFaltaDataGridView";
            this.produtoEmFaltaDataGridView.Size = new System.Drawing.Size(474, 206);
            this.produtoEmFaltaDataGridView.TabIndex = 1;
            // 
            // ProdutosEmFaltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 272);
            this.Controls.Add(this.produtoEmFaltaDataGridView);
            this.Controls.Add(this.produtoEmFaltaLabel);
            this.Name = "ProdutosEmFaltaForm";
            this.Text = "ProdutosEmFaltaForm";
            this.Load += new System.EventHandler(this.ProdutosEmFaltaForm_Load);
            this.Click += new System.EventHandler(this.ProdutosEmFaltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoEmFaltaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label produtoEmFaltaLabel;
        private System.Windows.Forms.DataGridView produtoEmFaltaDataGridView;
    }
}