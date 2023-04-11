
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
            btnEditarCorrida = new System.Windows.Forms.Button();
            btnFinalizarCorrida = new System.Windows.Forms.Button();
            btnExcluirCorrida = new System.Windows.Forms.Button();
            DGVcorridas = new System.Windows.Forms.DataGridView();
            btnBuscarSolicitante = new System.Windows.Forms.Button();
            txtSolicitanteCorrida = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            btnCancelarCorrida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)DGVcorridas).BeginInit();
            SuspendLayout();
            // 
            // btnEditarCorrida
            // 
            btnEditarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnEditarCorrida.Location = new System.Drawing.Point(102, 410);
            btnEditarCorrida.Name = "btnEditarCorrida";
            btnEditarCorrida.Size = new System.Drawing.Size(84, 24);
            btnEditarCorrida.TabIndex = 20;
            btnEditarCorrida.Text = "EDITAR";
            btnEditarCorrida.UseVisualStyleBackColor = true;
            btnEditarCorrida.Click += btnEditarCorrida_Click;
            // 
            // btnFinalizarCorrida
            // 
            btnFinalizarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnFinalizarCorrida.Location = new System.Drawing.Point(12, 410);
            btnFinalizarCorrida.Name = "btnFinalizarCorrida";
            btnFinalizarCorrida.Size = new System.Drawing.Size(84, 24);
            btnFinalizarCorrida.TabIndex = 19;
            btnFinalizarCorrida.Text = "FINALIZAR";
            btnFinalizarCorrida.UseVisualStyleBackColor = true;
            btnFinalizarCorrida.Click += btnFinalizarCorrida_Click;
            // 
            // btnExcluirCorrida
            // 
            btnExcluirCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnExcluirCorrida.Location = new System.Drawing.Point(192, 410);
            btnExcluirCorrida.Name = "btnExcluirCorrida";
            btnExcluirCorrida.Size = new System.Drawing.Size(84, 24);
            btnExcluirCorrida.TabIndex = 18;
            btnExcluirCorrida.Text = "EXCLUIR";
            btnExcluirCorrida.UseVisualStyleBackColor = true;
            btnExcluirCorrida.Click += btnExcluirCorrida_Click;
            // 
            // DGVcorridas
            // 
            DGVcorridas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVcorridas.Location = new System.Drawing.Point(12, 55);
            DGVcorridas.Name = "DGVcorridas";
            DGVcorridas.RowTemplate.Height = 25;
            DGVcorridas.Size = new System.Drawing.Size(776, 333);
            DGVcorridas.TabIndex = 17;
            DGVcorridas.CellClick += DGVcorridas_CellClick;
            // 
            // btnBuscarSolicitante
            // 
            btnBuscarSolicitante.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnBuscarSolicitante.Location = new System.Drawing.Point(478, 20);
            btnBuscarSolicitante.Name = "btnBuscarSolicitante";
            btnBuscarSolicitante.Size = new System.Drawing.Size(84, 24);
            btnBuscarSolicitante.TabIndex = 16;
            btnBuscarSolicitante.Text = "BUSCAR";
            btnBuscarSolicitante.UseVisualStyleBackColor = true;
            btnBuscarSolicitante.Click += btnBuscarSolicitante_Click;
            // 
            // txtSolicitanteCorrida
            // 
            txtSolicitanteCorrida.Location = new System.Drawing.Point(144, 20);
            txtSolicitanteCorrida.Name = "txtSolicitanteCorrida";
            txtSolicitanteCorrida.Size = new System.Drawing.Size(328, 23);
            txtSolicitanteCorrida.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(12, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(126, 25);
            label1.TabIndex = 14;
            label1.Text = "SOLICITANTE:";
            // 
            // btnCancelarCorrida
            // 
            btnCancelarCorrida.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnCancelarCorrida.Location = new System.Drawing.Point(704, 410);
            btnCancelarCorrida.Name = "btnCancelarCorrida";
            btnCancelarCorrida.Size = new System.Drawing.Size(84, 24);
            btnCancelarCorrida.TabIndex = 21;
            btnCancelarCorrida.Text = "CANCELAR";
            btnCancelarCorrida.UseVisualStyleBackColor = true;
            btnCancelarCorrida.Click += btnCancelarCorrida_Click;
            // 
            // MenuCorridas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(btnCancelarCorrida);
            Controls.Add(btnEditarCorrida);
            Controls.Add(btnFinalizarCorrida);
            Controls.Add(btnExcluirCorrida);
            Controls.Add(DGVcorridas);
            Controls.Add(btnBuscarSolicitante);
            Controls.Add(txtSolicitanteCorrida);
            Controls.Add(label1);
            Name = "MenuCorridas";
            Text = "MenuCorridas";
            Load += MenuCorridas_Load;
            ((System.ComponentModel.ISupportInitialize)DGVcorridas).EndInit();
            ResumeLayout(false);
            PerformLayout();
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