
namespace T41N_DoTheEvolution
{
    partial class MenuCorridas
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
            this.btnEditarCorrida = new System.Windows.Forms.Button();
            this.btnFinalizarCorrida = new System.Windows.Forms.Button();
            this.btnExcluirCorrida = new System.Windows.Forms.Button();
            this.DGVcorridas = new System.Windows.Forms.DataGridView();
            this.btnBuscarSolicitante = new System.Windows.Forms.Button();
            this.txtSolicitanteCorrida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelarCorrida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVcorridas)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEditarCorrida
            // 
            this.btnEditarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditarCorrida.Location = new System.Drawing.Point(102, 410);
            this.btnEditarCorrida.Name = "btnEditarCorrida";
            this.btnEditarCorrida.Size = new System.Drawing.Size(84, 24);
            this.btnEditarCorrida.TabIndex = 20;
            this.btnEditarCorrida.Text = "EDITAR";
            this.btnEditarCorrida.UseVisualStyleBackColor = true;
            // 
            // btnFinalizarCorrida
            // 
            this.btnFinalizarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFinalizarCorrida.Location = new System.Drawing.Point(12, 410);
            this.btnFinalizarCorrida.Name = "btnFinalizarCorrida";
            this.btnFinalizarCorrida.Size = new System.Drawing.Size(84, 24);
            this.btnFinalizarCorrida.TabIndex = 19;
            this.btnFinalizarCorrida.Text = "FINALIZAR";
            this.btnFinalizarCorrida.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCorrida
            // 
            this.btnExcluirCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExcluirCorrida.Location = new System.Drawing.Point(192, 410);
            this.btnExcluirCorrida.Name = "btnExcluirCorrida";
            this.btnExcluirCorrida.Size = new System.Drawing.Size(84, 24);
            this.btnExcluirCorrida.TabIndex = 18;
            this.btnExcluirCorrida.Text = "EXCLUIR";
            this.btnExcluirCorrida.UseVisualStyleBackColor = true;
            // 
            // DGVcorridas
            // 
            this.DGVcorridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVcorridas.Location = new System.Drawing.Point(12, 55);
            this.DGVcorridas.Name = "DGVcorridas";
            this.DGVcorridas.RowTemplate.Height = 25;
            this.DGVcorridas.Size = new System.Drawing.Size(776, 333);
            this.DGVcorridas.TabIndex = 17;
            // 
            // btnBuscarSolicitante
            // 
            this.btnBuscarSolicitante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarSolicitante.Location = new System.Drawing.Point(478, 20);
            this.btnBuscarSolicitante.Name = "btnBuscarSolicitante";
            this.btnBuscarSolicitante.Size = new System.Drawing.Size(84, 24);
            this.btnBuscarSolicitante.TabIndex = 16;
            this.btnBuscarSolicitante.Text = "BUSCAR";
            this.btnBuscarSolicitante.UseVisualStyleBackColor = true;
            // 
            // txtSolicitanteCorrida
            // 
            this.txtSolicitanteCorrida.Location = new System.Drawing.Point(144, 20);
            this.txtSolicitanteCorrida.Name = "txtSolicitanteCorrida";
            this.txtSolicitanteCorrida.Size = new System.Drawing.Size(328, 23);
            this.txtSolicitanteCorrida.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "SOLICITANTE:";
            // 
            // btnCancelarCorrida
            // 
            this.btnCancelarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelarCorrida.Location = new System.Drawing.Point(704, 410);
            this.btnCancelarCorrida.Name = "btnCancelarCorrida";
            this.btnCancelarCorrida.Size = new System.Drawing.Size(84, 24);
            this.btnCancelarCorrida.TabIndex = 21;
            this.btnCancelarCorrida.Text = "CANCELAR";
            this.btnCancelarCorrida.UseVisualStyleBackColor = true;
            this.btnCancelarCorrida.Click += new System.EventHandler(this.btnCancelarCorrida_Click);
            // 
            // MenuCorridas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelarCorrida);
            this.Controls.Add(this.btnEditarCorrida);
            this.Controls.Add(this.btnFinalizarCorrida);
            this.Controls.Add(this.btnExcluirCorrida);
            this.Controls.Add(this.DGVcorridas);
            this.Controls.Add(this.btnBuscarSolicitante);
            this.Controls.Add(this.txtSolicitanteCorrida);
            this.Controls.Add(this.label1);
            this.Name = "MenuCorridas";
            this.Text = "MenuCorridas";
            ((System.ComponentModel.ISupportInitialize)(this.DGVcorridas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnEditarCorrida;
        public System.Windows.Forms.Button btnFinalizarCorrida;
        public System.Windows.Forms.Button btnExcluirCorrida;
        private System.Windows.Forms.DataGridView DGVcorridas;
        public System.Windows.Forms.Button btnBuscarSolicitante;
        private System.Windows.Forms.TextBox txtSolicitanteCorrida;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCancelarCorrida;
    }
}