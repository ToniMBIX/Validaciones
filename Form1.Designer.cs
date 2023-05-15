namespace Validaciones
{
    partial class Form1
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.maskedTextBoxHora = new System.Windows.Forms.MaskedTextBox();
            this.labelfecha = new System.Windows.Forms.Label();
            this.maskedTextBoxID = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxTelefono = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxMatricula = new System.Windows.Forms.MaskedTextBox();
            this.maskedTextBoxPrecio = new System.Windows.Forms.MaskedTextBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.labelID = new System.Windows.Forms.Label();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.labelMatricula = new System.Windows.Forms.Label();
            this.labelValorVenta = new System.Windows.Forms.Label();
            this.buttonValidar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "";
            this.dateTimePicker.Location = new System.Drawing.Point(158, 12);
            this.dateTimePicker.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1980, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(246, 22);
            this.dateTimePicker.TabIndex = 0;
            // 
            // maskedTextBoxHora
            // 
            this.maskedTextBoxHora.Location = new System.Drawing.Point(158, 56);
            this.maskedTextBoxHora.Mask = "00:00";
            this.maskedTextBoxHora.Name = "maskedTextBoxHora";
            this.maskedTextBoxHora.Size = new System.Drawing.Size(43, 22);
            this.maskedTextBoxHora.TabIndex = 1;
            this.maskedTextBoxHora.ValidatingType = typeof(System.DateTime);
            this.maskedTextBoxHora.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.maskedTextBoxHora_TypeValidationCompleted);
            // 
            // labelfecha
            // 
            this.labelfecha.AutoSize = true;
            this.labelfecha.Location = new System.Drawing.Point(12, 17);
            this.labelfecha.Name = "labelfecha";
            this.labelfecha.Size = new System.Drawing.Size(116, 16);
            this.labelfecha.TabIndex = 2;
            this.labelfecha.Text = "Fecha de la Venta";
            // 
            // maskedTextBoxID
            // 
            this.maskedTextBoxID.Location = new System.Drawing.Point(158, 102);
            this.maskedTextBoxID.Mask = "V00000000";
            this.maskedTextBoxID.Name = "maskedTextBoxID";
            this.maskedTextBoxID.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxID.TabIndex = 3;
            this.maskedTextBoxID.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxID_Validating);
            // 
            // maskedTextBoxTelefono
            // 
            this.maskedTextBoxTelefono.Location = new System.Drawing.Point(158, 153);
            this.maskedTextBoxTelefono.Mask = "000 000 000";
            this.maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            this.maskedTextBoxTelefono.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxTelefono.TabIndex = 4;
            this.maskedTextBoxTelefono.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxTelefono_Validating);
            // 
            // maskedTextBoxMatricula
            // 
            this.maskedTextBoxMatricula.Location = new System.Drawing.Point(158, 208);
            this.maskedTextBoxMatricula.Mask = "0000LLL";
            this.maskedTextBoxMatricula.Name = "maskedTextBoxMatricula";
            this.maskedTextBoxMatricula.Size = new System.Drawing.Size(83, 22);
            this.maskedTextBoxMatricula.TabIndex = 5;
            this.maskedTextBoxMatricula.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxMatricula_Validating);
            // 
            // maskedTextBoxPrecio
            // 
            this.maskedTextBoxPrecio.Location = new System.Drawing.Point(158, 261);
            this.maskedTextBoxPrecio.Mask = "00000000,00 €";
            this.maskedTextBoxPrecio.Name = "maskedTextBoxPrecio";
            this.maskedTextBoxPrecio.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxPrecio.TabIndex = 6;
            this.maskedTextBoxPrecio.Validating += new System.ComponentModel.CancelEventHandler(this.maskedTextBoxPrecio_Validating);
            // 
            // labelHora
            // 
            this.labelHora.AutoSize = true;
            this.labelHora.Location = new System.Drawing.Point(12, 56);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(108, 16);
            this.labelHora.TabIndex = 7;
            this.labelHora.Text = "Hora de la Venta";
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(12, 105);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(86, 16);
            this.labelID.TabIndex = 8;
            this.labelID.Text = "ID Empleado";
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.Location = new System.Drawing.Point(12, 156);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(61, 16);
            this.labelTelefono.TabIndex = 9;
            this.labelTelefono.Text = "Teléfono";
            // 
            // labelMatricula
            // 
            this.labelMatricula.AutoSize = true;
            this.labelMatricula.Location = new System.Drawing.Point(12, 208);
            this.labelMatricula.Name = "labelMatricula";
            this.labelMatricula.Size = new System.Drawing.Size(61, 16);
            this.labelMatricula.TabIndex = 10;
            this.labelMatricula.Text = "Matrícula";
            // 
            // labelValorVenta
            // 
            this.labelValorVenta.AutoSize = true;
            this.labelValorVenta.Location = new System.Drawing.Point(12, 264);
            this.labelValorVenta.Name = "labelValorVenta";
            this.labelValorVenta.Size = new System.Drawing.Size(110, 16);
            this.labelValorVenta.TabIndex = 11;
            this.labelValorVenta.Text = "Valor de la Venta";
            // 
            // buttonValidar
            // 
            this.buttonValidar.Location = new System.Drawing.Point(362, 300);
            this.buttonValidar.Name = "buttonValidar";
            this.buttonValidar.Size = new System.Drawing.Size(75, 23);
            this.buttonValidar.TabIndex = 12;
            this.buttonValidar.Text = "Validar";
            this.buttonValidar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 335);
            this.Controls.Add(this.buttonValidar);
            this.Controls.Add(this.labelValorVenta);
            this.Controls.Add(this.labelMatricula);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.labelHora);
            this.Controls.Add(this.maskedTextBoxPrecio);
            this.Controls.Add(this.maskedTextBoxMatricula);
            this.Controls.Add(this.maskedTextBoxTelefono);
            this.Controls.Add(this.maskedTextBoxID);
            this.Controls.Add(this.labelfecha);
            this.Controls.Add(this.maskedTextBoxHora);
            this.Controls.Add(this.dateTimePicker);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxHora;
        private System.Windows.Forms.Label labelfecha;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxID;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTelefono;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxMatricula;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPrecio;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.Label labelMatricula;
        private System.Windows.Forms.Label labelValorVenta;
        private System.Windows.Forms.Button buttonValidar;
    }
}

