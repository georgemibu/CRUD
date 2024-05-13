namespace Tienda
{
    partial class CarritoCompras
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listCarritoCompras = new ListBox();
            btnAgregar = new Button();
            btnCalcular = new Button();
            cboProductos = new ComboBox();
            label1 = new Label();
            txtCodigoDescuento = new TextBox();
            SuspendLayout();
            // 
            // listCarritoCompras
            // 
            listCarritoCompras.FormattingEnabled = true;
            listCarritoCompras.ItemHeight = 15;
            listCarritoCompras.Location = new Point(26, 39);
            listCarritoCompras.Name = "listCarritoCompras";
            listCarritoCompras.Size = new Size(184, 199);
            listCarritoCompras.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(261, 85);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(349, 84);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(119, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "Calcular Precio";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(261, 39);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(207, 23);
            cboProductos.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(261, 136);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 4;
            label1.Text = "Código de descuento";
            // 
            // txtCodigoDescuento
            // 
            txtCodigoDescuento.Location = new Point(387, 133);
            txtCodigoDescuento.Name = "txtCodigoDescuento";
            txtCodigoDescuento.Size = new Size(100, 23);
            txtCodigoDescuento.TabIndex = 5;
            txtCodigoDescuento.TextChanged += txtCodigoDescuento_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigoDescuento);
            Controls.Add(label1);
            Controls.Add(cboProductos);
            Controls.Add(btnCalcular);
            Controls.Add(btnAgregar);
            Controls.Add(listCarritoCompras);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listCarritoCompras;
        private Button btnAgregar;
        private Button btnCalcular;
        private ComboBox cboProductos;
        private Label label1;
        private TextBox txtCodigoDescuento;
    }
}
