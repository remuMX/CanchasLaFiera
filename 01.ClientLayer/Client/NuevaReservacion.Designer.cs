namespace Client
{
    partial class NuevaReservacion
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
            this.checkBArbitro = new System.Windows.Forms.CheckBox();
            this.cbTipoCancha = new System.Windows.Forms.ComboBox();
            this.groupCancha = new System.Windows.Forms.GroupBox();
            this.cbHoras = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpHora = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tbRFC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHoras = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCostoArbitro = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCancha = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReservar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.groupCancha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBArbitro
            // 
            this.checkBArbitro.AutoSize = true;
            this.checkBArbitro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBArbitro.Location = new System.Drawing.Point(328, 95);
            this.checkBArbitro.Name = "checkBArbitro";
            this.checkBArbitro.Size = new System.Drawing.Size(74, 22);
            this.checkBArbitro.TabIndex = 0;
            this.checkBArbitro.Text = "Arbitro";
            this.checkBArbitro.UseVisualStyleBackColor = true;
            this.checkBArbitro.CheckedChanged += new System.EventHandler(this.checkBArbitro_CheckedChanged);
            // 
            // cbTipoCancha
            // 
            this.cbTipoCancha.FormattingEnabled = true;
            this.cbTipoCancha.Location = new System.Drawing.Point(130, 25);
            this.cbTipoCancha.Name = "cbTipoCancha";
            this.cbTipoCancha.Size = new System.Drawing.Size(398, 28);
            this.cbTipoCancha.TabIndex = 1;
            this.cbTipoCancha.ValueMemberChanged += new System.EventHandler(this.cbTipoCancha_ValueMemberChanged);
            this.cbTipoCancha.SelectedValueChanged += new System.EventHandler(this.cbTipoCancha_SelectedValueChanged);
            // 
            // groupCancha
            // 
            this.groupCancha.Controls.Add(this.checkBArbitro);
            this.groupCancha.Controls.Add(this.cbHoras);
            this.groupCancha.Controls.Add(this.label3);
            this.groupCancha.Controls.Add(this.dtpHora);
            this.groupCancha.Controls.Add(this.label2);
            this.groupCancha.Controls.Add(this.dtpFecha);
            this.groupCancha.Controls.Add(this.label1);
            this.groupCancha.Controls.Add(this.cbTipoCancha);
            this.groupCancha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupCancha.Location = new System.Drawing.Point(13, 13);
            this.groupCancha.Name = "groupCancha";
            this.groupCancha.Size = new System.Drawing.Size(534, 150);
            this.groupCancha.TabIndex = 2;
            this.groupCancha.TabStop = false;
            this.groupCancha.Text = "Cancha";
            // 
            // cbHoras
            // 
            this.cbHoras.FormattingEnabled = true;
            this.cbHoras.Location = new System.Drawing.Point(124, 91);
            this.cbHoras.Name = "cbHoras";
            this.cbHoras.Size = new System.Drawing.Size(166, 28);
            this.cbHoras.TabIndex = 8;
            this.cbHoras.SelectedIndexChanged += new System.EventHandler(this.cbHoras_SelectedIndexChanged);
            this.cbHoras.SelectedValueChanged += new System.EventHandler(this.cbHoras_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "Horas";
            // 
            // dtpHora
            // 
            this.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpHora.Location = new System.Drawing.Point(328, 59);
            this.dtpHora.Name = "dtpHora";
            this.dtpHora.ShowUpDown = true;
            this.dtpHora.Size = new System.Drawing.Size(200, 26);
            this.dtpHora.TabIndex = 6;
            this.dtpHora.ValueChanged += new System.EventHandler(this.dtpHora_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de Reservación";
            // 
            // dtpFecha
            // 
            this.dtpFecha.CustomFormat = "dd/MM/yyyy";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFecha.Location = new System.Drawing.Point(177, 59);
            this.dtpFecha.MinDate = new System.DateTime(2018, 9, 2, 0, 0, 0, 0);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(113, 26);
            this.dtpFecha.TabIndex = 4;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tipo de Cancha";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCliente);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.tbRFC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dgvClientes);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(534, 251);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(453, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbRFC
            // 
            this.tbRFC.Location = new System.Drawing.Point(106, 25);
            this.tbRFC.Name = "tbRFC";
            this.tbRFC.Size = new System.Drawing.Size(422, 26);
            this.tbRFC.TabIndex = 9;
            this.tbRFC.TextChanged += new System.EventHandler(this.tbRFC_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Buscar RFC";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(9, 57);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(519, 150);
            this.dgvClientes.TabIndex = 0;
            this.dgvClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHoras);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblCostoArbitro);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.lblCancha);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnReservar);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(565, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 363);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reservación";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(143, 156);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(48, 20);
            this.lblHoras.TabIndex = 7;
            this.lblHoras.Text = "0 hrs.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Horas";
            // 
            // lblCostoArbitro
            // 
            this.lblCostoArbitro.AutoSize = true;
            this.lblCostoArbitro.Location = new System.Drawing.Point(136, 111);
            this.lblCostoArbitro.Name = "lblCostoArbitro";
            this.lblCostoArbitro.Size = new System.Drawing.Size(58, 20);
            this.lblCostoArbitro.TabIndex = 5;
            this.lblCostoArbitro.Text = "$00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "Extra por Arbitro";
            // 
            // lblCancha
            // 
            this.lblCancha.AutoSize = true;
            this.lblCancha.Location = new System.Drawing.Point(136, 59);
            this.lblCancha.Name = "lblCancha";
            this.lblCancha.Size = new System.Drawing.Size(58, 20);
            this.lblCancha.TabIndex = 3;
            this.lblCancha.Text = "$00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Costo de la Cancha";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(45, 283);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(101, 20);
            this.lblTotal.TabIndex = 1;
            this.lblTotal.Text = "Total: $00.00";
            this.lblTotal.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnReservar
            // 
            this.btnReservar.Location = new System.Drawing.Point(6, 330);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(188, 27);
            this.btnReservar.TabIndex = 0;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            this.btnReservar.Click += new System.EventHandler(this.btnReservar_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(565, 393);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 27);
            this.button3.TabIndex = 1;
            this.button3.Text = "Cancelar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCliente.Location = new System.Drawing.Point(6, 217);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(42, 13);
            this.lblCliente.TabIndex = 11;
            this.lblCliente.Text = "Cliente:";
            this.lblCliente.Click += new System.EventHandler(this.lblCliente_Click);
            // 
            // NuevaReservacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 435);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupCancha);
            this.Name = "NuevaReservacion";
            this.Text = "Nueva Reservación";
            this.Load += new System.EventHandler(this.NuevaReservacion_Load);
            this.groupCancha.ResumeLayout(false);
            this.groupCancha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBArbitro;
        private System.Windows.Forms.ComboBox cbTipoCancha;
        private System.Windows.Forms.GroupBox groupCancha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbHoras;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbRFC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReservar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblCostoArbitro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCancha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCliente;
    }
}