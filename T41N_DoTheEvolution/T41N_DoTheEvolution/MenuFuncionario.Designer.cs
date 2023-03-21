
namespace T41N_DoTheEvolution
{
    partial class MenuFuncionario
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCpfFuncionario = new System.Windows.Forms.TextBox();
            this.btnBuscarFuncionario = new System.Windows.Forms.Button();
            this.DGVfuncionario = new System.Windows.Forms.DataGridView();
            this.btnDeletarFuncionario = new System.Windows.Forms.Button();
            this.btnAtualizarFuncionario = new System.Windows.Forms.Button();
            this.btnNovoFuncionario = new System.Windows.Forms.Button();
            this.btnVoltarFuncionario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGVfuncionario)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "CPF:";
            // 
            // txtCpfFuncionario
            // 
            this.txtCpfFuncionario.Location = new System.Drawing.Point(56, 20);
            this.txtCpfFuncionario.Name = "txtCpfFuncionario";
            this.txtCpfFuncionario.Size = new System.Drawing.Size(328, 23);
            this.txtCpfFuncionario.TabIndex = 5;
            // 
            // btnBuscarFuncionario
            // 
            this.btnBuscarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBuscarFuncionario.Location = new System.Drawing.Point(390, 20);
            this.btnBuscarFuncionario.Name = "btnBuscarFuncionario";
            this.btnBuscarFuncionario.Size = new System.Drawing.Size(84, 24);
            this.btnBuscarFuncionario.TabIndex = 6;
            this.btnBuscarFuncionario.Text = "BUSCAR";
            this.btnBuscarFuncionario.UseVisualStyleBackColor = true;
            this.btnBuscarFuncionario.Click += new System.EventHandler(this.btnBuscarFuncionario_Click);
            // 
            // DGVfuncionario
            // 
            this.DGVfuncionario.AllowUserToAddRows = false;
            this.DGVfuncionario.AllowUserToDeleteRows = false;
            this.DGVfuncionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVfuncionario.Location = new System.Drawing.Point(12, 59);
            this.DGVfuncionario.Name = "DGVfuncionario";
            this.DGVfuncionario.ReadOnly = true;
            this.DGVfuncionario.RowTemplate.Height = 25;
            this.DGVfuncionario.Size = new System.Drawing.Size(776, 333);
            this.DGVfuncionario.TabIndex = 7;
            this.DGVfuncionario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVfuncionario_CellContentClick);
            // 
            // btnDeletarFuncionario
            // 
            this.btnDeletarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeletarFuncionario.Location = new System.Drawing.Point(12, 414);
            this.btnDeletarFuncionario.Name = "btnDeletarFuncionario";
            this.btnDeletarFuncionario.Size = new System.Drawing.Size(84, 24);
            this.btnDeletarFuncionario.TabIndex = 8;
            this.btnDeletarFuncionario.Text = "DELETAR";
            this.btnDeletarFuncionario.UseVisualStyleBackColor = true;
            this.btnDeletarFuncionario.Click += new System.EventHandler(this.btnDeletarFuncionario_Click);
            // 
            // btnAtualizarFuncionario
            // 
            this.btnAtualizarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAtualizarFuncionario.Location = new System.Drawing.Point(102, 414);
            this.btnAtualizarFuncionario.Name = "btnAtualizarFuncionario";
            this.btnAtualizarFuncionario.Size = new System.Drawing.Size(84, 24);
            this.btnAtualizarFuncionario.TabIndex = 9;
            this.btnAtualizarFuncionario.Text = "ATUALIZAR";
            this.btnAtualizarFuncionario.UseVisualStyleBackColor = true;
            this.btnAtualizarFuncionario.Click += new System.EventHandler(this.btnAtualizarFuncionario_Click);
            // 
            // btnNovoFuncionario
            // 
            this.btnNovoFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNovoFuncionario.Location = new System.Drawing.Point(704, 414);
            this.btnNovoFuncionario.Name = "btnNovoFuncionario";
            this.btnNovoFuncionario.Size = new System.Drawing.Size(84, 24);
            this.btnNovoFuncionario.TabIndex = 10;
            this.btnNovoFuncionario.Text = "NOVO";
            this.btnNovoFuncionario.UseVisualStyleBackColor = true;
            this.btnNovoFuncionario.Click += new System.EventHandler(this.btnNovoFuncionario_Click);
            // 
            // btnVoltarFuncionario
            // 
            this.btnVoltarFuncionario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVoltarFuncionario.Location = new System.Drawing.Point(192, 414);
            this.btnVoltarFuncionario.Name = "btnVoltarFuncionario";
            this.btnVoltarFuncionario.Size = new System.Drawing.Size(84, 24);
            this.btnVoltarFuncionario.TabIndex = 11;
            this.btnVoltarFuncionario.Text = "VOLTAR";
            this.btnVoltarFuncionario.UseVisualStyleBackColor = true;
            this.btnVoltarFuncionario.Click += new System.EventHandler(this.btnVoltarFuncionario_Click);
            // 
            // MenuFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVoltarFuncionario);
            this.Controls.Add(this.btnNovoFuncionario);
            this.Controls.Add(this.btnAtualizarFuncionario);
            this.Controls.Add(this.btnDeletarFuncionario);
            this.Controls.Add(this.DGVfuncionario);
            this.Controls.Add(this.btnBuscarFuncionario);
            this.Controls.Add(this.txtCpfFuncionario);
            this.Controls.Add(this.label1);
            this.Name = "MenuFuncionario";
            this.Text = "MenuFuncionario";
            this.Load += new System.EventHandler(this.MenuFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVfuncionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnBuscarFuncionario;
        public System.Windows.Forms.Button btnDeletarFuncionario;
        public System.Windows.Forms.Button btnNovoFuncionario;
        public System.Windows.Forms.Button btnVoltarFuncionario;
        public System.Windows.Forms.TextBox txtCpfFuncionario;
        private System.Windows.Forms.DataGridView DGVfuncionario;
        private System.Windows.Forms.Button btnAtualizarFuncionario;
    }
}