namespace Tienda.Views
{
    partial class FrmFabricante
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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            label5 = new Label();
            TxtFabricante = new TextBox();
            label4 = new Label();
            TxtId = new TextBox();
            label3 = new Label();
            panel3 = new Panel();
            DtFabricante = new DataGridView();
            panel5 = new Panel();
            LblTotalRegistros = new Label();
            panel4 = new Panel();
            TxtBusqueda = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DtFabricante).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1881, 141);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(43, 33);
            label1.Name = "label1";
            label1.Size = new Size(601, 72);
            label1.TabIndex = 0;
            label1.Text = "Gestion de Fabricantes";
            // 
            // panel2
            // 
            panel2.Controls.Add(BtnGuardar);
            panel2.Controls.Add(BtnCancelar);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(TxtFabricante);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(TxtId);
            panel2.Controls.Add(label3);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(1437, 141);
            panel2.Name = "panel2";
            panel2.Size = new Size(444, 805);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(36, 617);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(188, 58);
            BtnGuardar.TabIndex = 8;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(230, 617);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(188, 58);
            BtnCancelar.TabIndex = 7;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.Location = new Point(36, 26);
            label5.Name = "label5";
            label5.Size = new Size(370, 62);
            label5.TabIndex = 6;
            label5.Text = "Nuevo registro:";
            // 
            // TxtFabricante
            // 
            TxtFabricante.Location = new Point(38, 409);
            TxtFabricante.Name = "TxtFabricante";
            TxtFabricante.Size = new Size(368, 47);
            TxtFabricante.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(38, 349);
            label4.Name = "label4";
            label4.Size = new Size(161, 41);
            label4.TabIndex = 4;
            label4.Text = "Fabricante:";
            // 
            // TxtId
            // 
            TxtId.Location = new Point(38, 256);
            TxtId.Name = "TxtId";
            TxtId.ReadOnly = true;
            TxtId.Size = new Size(198, 47);
            TxtId.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 196);
            label3.Name = "label3";
            label3.Size = new Size(51, 41);
            label3.TabIndex = 2;
            label3.Text = "Id:";
            // 
            // panel3
            // 
            panel3.Controls.Add(DtFabricante);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 141);
            panel3.Name = "panel3";
            panel3.Size = new Size(1437, 805);
            panel3.TabIndex = 2;
            // 
            // DtFabricante
            // 
            DtFabricante.AllowUserToAddRows = false;
            DtFabricante.AllowUserToDeleteRows = false;
            DtFabricante.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DtFabricante.Dock = DockStyle.Fill;
            DtFabricante.Location = new Point(0, 107);
            DtFabricante.Name = "DtFabricante";
            DtFabricante.ReadOnly = true;
            DtFabricante.RowHeadersWidth = 102;
            DtFabricante.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DtFabricante.Size = new Size(1437, 632);
            DtFabricante.TabIndex = 5;
            DtFabricante.CellContentDoubleClick += DtFabricante_CellContentDoubleClick;
            DtFabricante.DoubleClick += DtFabricante_DoubleClick;
            // 
            // panel5
            // 
            panel5.Controls.Add(LblTotalRegistros);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 739);
            panel5.Name = "panel5";
            panel5.Size = new Size(1437, 66);
            panel5.TabIndex = 4;
            // 
            // LblTotalRegistros
            // 
            LblTotalRegistros.AutoSize = true;
            LblTotalRegistros.Location = new Point(12, 16);
            LblTotalRegistros.Name = "LblTotalRegistros";
            LblTotalRegistros.Size = new Size(125, 41);
            LblTotalRegistros.TabIndex = 1;
            LblTotalRegistros.Text = "Buscar...";
            // 
            // panel4
            // 
            panel4.Controls.Add(TxtBusqueda);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(1437, 107);
            panel4.TabIndex = 3;
            // 
            // TxtBusqueda
            // 
            TxtBusqueda.Location = new Point(175, 26);
            TxtBusqueda.Name = "TxtBusqueda";
            TxtBusqueda.Size = new Size(469, 47);
            TxtBusqueda.TabIndex = 1;
            TxtBusqueda.TextChanged += TxtBusqueda_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 26);
            label2.Name = "label2";
            label2.Size = new Size(125, 41);
            label2.TabIndex = 0;
            label2.Text = "Buscar...";
            // 
            // FrmFabricante
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1881, 946);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FrmFabricante";
            Text = "FrmFabricante";
            Load += FrmFabricante_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DtFabricante).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private TextBox TxtId;
        private Label label3;
        private Panel panel5;
        private Label LblTotalRegistros;
        private Panel panel4;
        private TextBox TxtBusqueda;
        private Label label2;
        private TextBox TxtFabricante;
        private Label label4;
        private Button BtnGuardar;
        private Button BtnCancelar;
        private Label label5;
        private DataGridView DtFabricante;
    }
}