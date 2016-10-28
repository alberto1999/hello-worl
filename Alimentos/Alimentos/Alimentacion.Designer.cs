namespace Alimentos
{
    partial class Alimentacion
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
            this.bt4 = new System.Windows.Forms.Button();
            this.bt2 = new System.Windows.Forms.Button();
            this.bt3 = new System.Windows.Forms.Button();
            this.bt1 = new System.Windows.Forms.Button();
            this.Identificacion = new System.Windows.Forms.TextBox();
            this.lb1 = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lb3 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.Dat1 = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb5 = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.NUM1 = new System.Windows.Forms.NumericUpDown();
            this.bt5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt4
            // 
            this.bt4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt4.Location = new System.Drawing.Point(185, 158);
            this.bt4.Name = "bt4";
            this.bt4.Size = new System.Drawing.Size(203, 23);
            this.bt4.TabIndex = 0;
            this.bt4.Text = "Actualizar";
            this.bt4.UseVisualStyleBackColor = true;
            this.bt4.Click += new System.EventHandler(this.button1_Click);
            // 
            // bt2
            // 
            this.bt2.Location = new System.Drawing.Point(12, 158);
            this.bt2.Name = "bt2";
            this.bt2.Size = new System.Drawing.Size(167, 23);
            this.bt2.TabIndex = 2;
            this.bt2.Text = "Eliminar";
            this.bt2.UseVisualStyleBackColor = true;
            this.bt2.Click += new System.EventHandler(this.bt2_Click);
            // 
            // bt3
            // 
            this.bt3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bt3.Location = new System.Drawing.Point(394, 158);
            this.bt3.Name = "bt3";
            this.bt3.Size = new System.Drawing.Size(160, 23);
            this.bt3.TabIndex = 3;
            this.bt3.Text = "Insertar";
            this.bt3.UseVisualStyleBackColor = true;
            this.bt3.Click += new System.EventHandler(this.bt3_Click);
            // 
            // bt1
            // 
            this.bt1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bt1.BackColor = System.Drawing.Color.Maroon;
            this.bt1.Location = new System.Drawing.Point(394, 7);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(160, 23);
            this.bt1.TabIndex = 4;
            this.bt1.Text = "Consultar";
            this.bt1.UseVisualStyleBackColor = false;
            this.bt1.Click += new System.EventHandler(this.bt1_Click);
            // 
            // Identificacion
            // 
            this.Identificacion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Identificacion.Location = new System.Drawing.Point(79, 9);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(305, 20);
            this.Identificacion.TabIndex = 5;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new System.Drawing.Point(12, 16);
            this.lb1.Name = "lb1";
            this.lb1.Size = new System.Drawing.Size(40, 13);
            this.lb1.TabIndex = 6;
            this.lb1.Text = "Codigo";
            // 
            // txt3
            // 
            this.txt3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt3.Location = new System.Drawing.Point(79, 61);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(475, 20);
            this.txt3.TabIndex = 8;
            // 
            // txt2
            // 
            this.txt2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt2.Location = new System.Drawing.Point(79, 35);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(475, 20);
            this.txt2.TabIndex = 9;
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Location = new System.Drawing.Point(12, 68);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(31, 13);
            this.lb3.TabIndex = 11;
            this.lb3.Text = "Valor";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(9, 42);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(63, 13);
            this.lb2.TabIndex = 12;
            this.lb2.Text = "Descripcion";
            // 
            // Dat1
            // 
            this.Dat1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Dat1.BackgroundColor = System.Drawing.SystemColors.HotTrack;
            this.Dat1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dat1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Valor,
            this.Cantidad,
            this.Categoria});
            this.Dat1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.Dat1.Location = new System.Drawing.Point(12, 216);
            this.Dat1.Name = "Dat1";
            this.Dat1.Size = new System.Drawing.Size(542, 207);
            this.Dat1.TabIndex = 15;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Descripcion
            // 
            this.Descripcion.DataPropertyName = "Descripcion";
            this.Descripcion.HeaderText = "Descripción";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            // 
            // Valor
            // 
            this.Valor.DataPropertyName = "Valor";
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            this.Valor.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.DataPropertyName = "Cantidad";
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Categoria
            // 
            this.Categoria.DataPropertyName = "Categoria";
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            // 
            // lb5
            // 
            this.lb5.AutoSize = true;
            this.lb5.Location = new System.Drawing.Point(12, 120);
            this.lb5.Name = "lb5";
            this.lb5.Size = new System.Drawing.Size(52, 13);
            this.lb5.TabIndex = 13;
            this.lb5.Text = "Categoria";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new System.Drawing.Point(12, 94);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(49, 13);
            this.lb4.TabIndex = 10;
            this.lb4.Text = "Cantidad";
            // 
            // txt5
            // 
            this.txt5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt5.Location = new System.Drawing.Point(79, 113);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(475, 20);
            this.txt5.TabIndex = 14;
            // 
            // NUM1
            // 
            this.NUM1.Location = new System.Drawing.Point(79, 87);
            this.NUM1.Name = "NUM1";
            this.NUM1.Size = new System.Drawing.Size(67, 20);
            this.NUM1.TabIndex = 16;
            // 
            // bt5
            // 
            this.bt5.Location = new System.Drawing.Point(12, 187);
            this.bt5.Name = "bt5";
            this.bt5.Size = new System.Drawing.Size(542, 23);
            this.bt5.TabIndex = 17;
            this.bt5.Text = "Consultar Todo";
            this.bt5.UseVisualStyleBackColor = true;
            this.bt5.Click += new System.EventHandler(this.bt5_Click);
            // 
            // Alimentacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 435);
            this.Controls.Add(this.bt5);
            this.Controls.Add(this.NUM1);
            this.Controls.Add(this.Dat1);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.lb5);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.lb3);
            this.Controls.Add(this.lb4);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lb1);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.bt3);
            this.Controls.Add(this.bt2);
            this.Controls.Add(this.bt4);
            this.Name = "Alimentacion";
            this.Text = "Alimentación";
            ((System.ComponentModel.ISupportInitialize)(this.Dat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUM1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt4;
        private System.Windows.Forms.Button bt2;
        private System.Windows.Forms.Button bt3;
        private System.Windows.Forms.Button bt1;
        private System.Windows.Forms.TextBox Identificacion;
        private System.Windows.Forms.Label lb1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.DataGridView Dat1;
        private System.Windows.Forms.Label lb5;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.NumericUpDown NUM1;
        private System.Windows.Forms.Button bt5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
    }
}

