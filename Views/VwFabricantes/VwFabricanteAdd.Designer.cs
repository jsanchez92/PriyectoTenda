namespace Tienda.Views.VwFabricantes
{
    partial class VwFabricanteAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VwFabricanteAdd));
            BtnGuardar = new Button();
            BtnCancelar = new Button();
            TxtFabricante = new TextBox();
            label4 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(750, 352);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(188, 58);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.Location = new Point(944, 352);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(188, 58);
            BtnCancelar.TabIndex = 11;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // TxtFabricante
            // 
            TxtFabricante.Location = new Point(62, 217);
            TxtFabricante.Name = "TxtFabricante";
            TxtFabricante.Size = new Size(368, 47);
            TxtFabricante.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(62, 157);
            label4.Name = "label4";
            label4.Size = new Size(161, 41);
            label4.TabIndex = 9;
            label4.Text = "Fabricante:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(62, 43);
            label1.Name = "label1";
            label1.Size = new Size(431, 62);
            label1.TabIndex = 13;
            label1.Text = "Agregar Fabricante.";
            // 
            // VwFabricanteAdd
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 450);
            Controls.Add(label1);
            Controls.Add(BtnGuardar);
            Controls.Add(BtnCancelar);
            Controls.Add(TxtFabricante);
            Controls.Add(label4);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VwFabricanteAdd";
            Text = "Gestion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnGuardar;
        private Button BtnCancelar;
        private TextBox TxtFabricante;
        private Label label4;
        private Label label1;
    }
}