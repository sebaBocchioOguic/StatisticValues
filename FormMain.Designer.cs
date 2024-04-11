namespace ProyectoEstadistico
{
    partial class FormMain
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
            this.txtOriginalValues = new System.Windows.Forms.TextBox();
            this.lblOriginalValues = new System.Windows.Forms.Label();
            this.lblOriginalValuesDesc = new System.Windows.Forms.Label();
            this.lblAddNumber = new System.Windows.Forms.Label();
            this.txtAddNumber = new System.Windows.Forms.TextBox();
            this.btnAddNumber = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtOriginalValues
            // 
            this.txtOriginalValues.Location = new System.Drawing.Point(78, 111);
            this.txtOriginalValues.Multiline = true;
            this.txtOriginalValues.Name = "txtOriginalValues";
            this.txtOriginalValues.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginalValues.Size = new System.Drawing.Size(928, 168);
            this.txtOriginalValues.TabIndex = 0;
            // 
            // lblOriginalValues
            // 
            this.lblOriginalValues.AutoSize = true;
            this.lblOriginalValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOriginalValues.Location = new System.Drawing.Point(78, 9);
            this.lblOriginalValues.Name = "lblOriginalValues";
            this.lblOriginalValues.Size = new System.Drawing.Size(145, 25);
            this.lblOriginalValues.TabIndex = 1;
            this.lblOriginalValues.Text = "Original Values";
            this.lblOriginalValues.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblOriginalValuesDesc
            // 
            this.lblOriginalValuesDesc.AutoSize = true;
            this.lblOriginalValuesDesc.Location = new System.Drawing.Point(78, 47);
            this.lblOriginalValuesDesc.Name = "lblOriginalValuesDesc";
            this.lblOriginalValuesDesc.Size = new System.Drawing.Size(504, 16);
            this.lblOriginalValuesDesc.TabIndex = 2;
            this.lblOriginalValuesDesc.Text = "Here you can write every number from which you need to obtain final statistics va" +
    "lues";
            // 
            // lblAddNumber
            // 
            this.lblAddNumber.AutoSize = true;
            this.lblAddNumber.Location = new System.Drawing.Point(78, 74);
            this.lblAddNumber.Name = "lblAddNumber";
            this.lblAddNumber.Size = new System.Drawing.Size(83, 16);
            this.lblAddNumber.TabIndex = 3;
            this.lblAddNumber.Text = "Add Number";
            // 
            // txtAddNumber
            // 
            this.txtAddNumber.Location = new System.Drawing.Point(205, 71);
            this.txtAddNumber.Name = "txtAddNumber";
            this.txtAddNumber.Size = new System.Drawing.Size(100, 22);
            this.txtAddNumber.TabIndex = 4;
            this.txtAddNumber.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAddNumber
            // 
            this.btnAddNumber.Location = new System.Drawing.Point(334, 71);
            this.btnAddNumber.Name = "btnAddNumber";
            this.btnAddNumber.Size = new System.Drawing.Size(75, 23);
            this.btnAddNumber.TabIndex = 5;
            this.btnAddNumber.Text = "Add";
            this.btnAddNumber.UseVisualStyleBackColor = true;
            this.btnAddNumber.Click += new System.EventHandler(this.btnAddNumber_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(460, 74);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 637);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAddNumber);
            this.Controls.Add(this.txtAddNumber);
            this.Controls.Add(this.lblAddNumber);
            this.Controls.Add(this.lblOriginalValuesDesc);
            this.Controls.Add(this.lblOriginalValues);
            this.Controls.Add(this.txtOriginalValues);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtOriginalValues;
        private System.Windows.Forms.Label lblOriginalValues;
        private System.Windows.Forms.Label lblOriginalValuesDesc;
        private System.Windows.Forms.Label lblAddNumber;
        private System.Windows.Forms.TextBox txtAddNumber;
        private System.Windows.Forms.Button btnAddNumber;
        private System.Windows.Forms.Button btnClear;
    }
}

