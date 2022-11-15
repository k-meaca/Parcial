
namespace Parcial2POO.Windows
{
    partial class frmJugadores
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DisponiblesDataGridView = new System.Windows.Forms.DataGridView();
            this.colPersona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCamiseta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEsCapitan = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.colTipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAgregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.GuardarButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DisponiblesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DisponiblesDataGridView
            // 
            this.DisponiblesDataGridView.AllowUserToAddRows = false;
            this.DisponiblesDataGridView.AllowUserToDeleteRows = false;
            this.DisponiblesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DisponiblesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPersona,
            this.colCamiseta,
            this.colEsCapitan,
            this.colTipo,
            this.colAgregar});
            this.DisponiblesDataGridView.Location = new System.Drawing.Point(30, 33);
            this.DisponiblesDataGridView.MultiSelect = false;
            this.DisponiblesDataGridView.Name = "DisponiblesDataGridView";
            this.DisponiblesDataGridView.ReadOnly = true;
            this.DisponiblesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DisponiblesDataGridView.Size = new System.Drawing.Size(603, 477);
            this.DisponiblesDataGridView.TabIndex = 0;
            // 
            // colPersona
            // 
            this.colPersona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPersona.HeaderText = "Nombre";
            this.colPersona.Name = "colPersona";
            this.colPersona.ReadOnly = true;
            // 
            // colCamiseta
            // 
            this.colCamiseta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCamiseta.HeaderText = "Camiseta";
            this.colCamiseta.Name = "colCamiseta";
            this.colCamiseta.ReadOnly = true;
            // 
            // colEsCapitan
            // 
            this.colEsCapitan.HeaderText = "Capitán";
            this.colEsCapitan.Name = "colEsCapitan";
            this.colEsCapitan.ReadOnly = true;
            // 
            // colTipo
            // 
            this.colTipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colTipo.HeaderText = "Tipo";
            this.colTipo.Name = "colTipo";
            this.colTipo.ReadOnly = true;
            // 
            // colAgregar
            // 
            this.colAgregar.HeaderText = "";
            this.colAgregar.Name = "colAgregar";
            this.colAgregar.ReadOnly = true;
            // 
            // GuardarButton
            // 
            this.GuardarButton.Location = new System.Drawing.Point(661, 33);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(121, 69);
            this.GuardarButton.TabIndex = 1;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // frmJugadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 566);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.DisponiblesDataGridView);
            this.Name = "frmJugadores";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmJugadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisponiblesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DisponiblesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPersona;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCamiseta;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colEsCapitan;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipo;
        private System.Windows.Forms.DataGridViewButtonColumn colAgregar;
        private System.Windows.Forms.Button GuardarButton;
    }
}

