namespace projCalculos
{
    partial class frmRDB
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
            this.grpRadios = new System.Windows.Forms.GroupBox();
            this.btnRParImpar = new System.Windows.Forms.RadioButton();
            this.btnRRestoInteiro = new System.Windows.Forms.RadioButton();
            this.btnRComparar = new System.Windows.Forms.RadioButton();
            this.btnRDividir = new System.Windows.Forms.RadioButton();
            this.btnRMultiplicar = new System.Windows.Forms.RadioButton();
            this.btnRSubtrair = new System.Windows.Forms.RadioButton();
            this.btnRSomar = new System.Windows.Forms.RadioButton();
            this.lblSinal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.btnLimp = new System.Windows.Forms.Button();
            this.btnFech = new System.Windows.Forms.Button();
            this.grpRadios.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpRadios
            // 
            this.grpRadios.Controls.Add(this.btnRParImpar);
            this.grpRadios.Controls.Add(this.btnRRestoInteiro);
            this.grpRadios.Controls.Add(this.btnRComparar);
            this.grpRadios.Controls.Add(this.btnRDividir);
            this.grpRadios.Controls.Add(this.btnRMultiplicar);
            this.grpRadios.Controls.Add(this.btnRSubtrair);
            this.grpRadios.Controls.Add(this.btnRSomar);
            this.grpRadios.Location = new System.Drawing.Point(165, 12);
            this.grpRadios.Name = "grpRadios";
            this.grpRadios.Size = new System.Drawing.Size(107, 190);
            this.grpRadios.TabIndex = 0;
            this.grpRadios.TabStop = false;
            this.grpRadios.Text = "Escolha uma Opção";
            this.grpRadios.Enter += new System.EventHandler(this.grpRadios_Enter);
            // 
            // btnRParImpar
            // 
            this.btnRParImpar.AutoSize = true;
            this.btnRParImpar.Location = new System.Drawing.Point(7, 168);
            this.btnRParImpar.Name = "btnRParImpar";
            this.btnRParImpar.Size = new System.Drawing.Size(70, 17);
            this.btnRParImpar.TabIndex = 6;
            this.btnRParImpar.TabStop = true;
            this.btnRParImpar.Text = "Par Ímpar";
            this.btnRParImpar.UseVisualStyleBackColor = true;
            this.btnRParImpar.CheckedChanged += new System.EventHandler(this.btnRParImpar_CheckedChanged);
            // 
            // btnRRestoInteiro
            // 
            this.btnRRestoInteiro.AutoSize = true;
            this.btnRRestoInteiro.Location = new System.Drawing.Point(6, 145);
            this.btnRRestoInteiro.Name = "btnRRestoInteiro";
            this.btnRRestoInteiro.Size = new System.Drawing.Size(85, 17);
            this.btnRRestoInteiro.TabIndex = 5;
            this.btnRRestoInteiro.TabStop = true;
            this.btnRRestoInteiro.Text = "Resto Inteiro";
            this.btnRRestoInteiro.UseVisualStyleBackColor = true;
            this.btnRRestoInteiro.CheckedChanged += new System.EventHandler(this.btnRRestoInteiro_CheckedChanged);
            // 
            // btnRComparar
            // 
            this.btnRComparar.AutoSize = true;
            this.btnRComparar.Location = new System.Drawing.Point(7, 122);
            this.btnRComparar.Name = "btnRComparar";
            this.btnRComparar.Size = new System.Drawing.Size(70, 17);
            this.btnRComparar.TabIndex = 4;
            this.btnRComparar.TabStop = true;
            this.btnRComparar.Text = "Comparar";
            this.btnRComparar.UseVisualStyleBackColor = true;
            this.btnRComparar.CheckedChanged += new System.EventHandler(this.btnRComparar_CheckedChanged);
            // 
            // btnRDividir
            // 
            this.btnRDividir.AutoSize = true;
            this.btnRDividir.Location = new System.Drawing.Point(7, 99);
            this.btnRDividir.Name = "btnRDividir";
            this.btnRDividir.Size = new System.Drawing.Size(54, 17);
            this.btnRDividir.TabIndex = 3;
            this.btnRDividir.TabStop = true;
            this.btnRDividir.Text = "Dividir";
            this.btnRDividir.UseVisualStyleBackColor = true;
            this.btnRDividir.CheckedChanged += new System.EventHandler(this.btnRDividir_CheckedChanged);
            // 
            // btnRMultiplicar
            // 
            this.btnRMultiplicar.AutoSize = true;
            this.btnRMultiplicar.Location = new System.Drawing.Point(7, 76);
            this.btnRMultiplicar.Name = "btnRMultiplicar";
            this.btnRMultiplicar.Size = new System.Drawing.Size(72, 17);
            this.btnRMultiplicar.TabIndex = 2;
            this.btnRMultiplicar.TabStop = true;
            this.btnRMultiplicar.Text = "Multiplicar";
            this.btnRMultiplicar.UseVisualStyleBackColor = true;
            this.btnRMultiplicar.CheckedChanged += new System.EventHandler(this.btnRMultiplicar_CheckedChanged);
            // 
            // btnRSubtrair
            // 
            this.btnRSubtrair.AutoSize = true;
            this.btnRSubtrair.Location = new System.Drawing.Point(7, 53);
            this.btnRSubtrair.Name = "btnRSubtrair";
            this.btnRSubtrair.Size = new System.Drawing.Size(61, 17);
            this.btnRSubtrair.TabIndex = 1;
            this.btnRSubtrair.TabStop = true;
            this.btnRSubtrair.Text = "Subtrair";
            this.btnRSubtrair.UseVisualStyleBackColor = true;
            this.btnRSubtrair.CheckedChanged += new System.EventHandler(this.btnRSubtrair_CheckedChanged);
            // 
            // btnRSomar
            // 
            this.btnRSomar.AutoSize = true;
            this.btnRSomar.Location = new System.Drawing.Point(7, 30);
            this.btnRSomar.Name = "btnRSomar";
            this.btnRSomar.Size = new System.Drawing.Size(55, 17);
            this.btnRSomar.TabIndex = 0;
            this.btnRSomar.TabStop = true;
            this.btnRSomar.Text = "Somar";
            this.btnRSomar.UseVisualStyleBackColor = true;
            this.btnRSomar.CheckedChanged += new System.EventHandler(this.btnRSomar_CheckedChanged);
            // 
            // lblSinal
            // 
            this.lblSinal.AutoSize = true;
            this.lblSinal.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblSinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinal.Location = new System.Drawing.Point(64, 75);
            this.lblSinal.MinimumSize = new System.Drawing.Size(40, 2);
            this.lblSinal.Name = "lblSinal";
            this.lblSinal.Size = new System.Drawing.Size(40, 33);
            this.lblSinal.TabIndex = 1;
            this.lblSinal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSinal.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "_______";
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(34, 128);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 20);
            this.txtNum2.TabIndex = 4;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum2.TextChanged += new System.EventHandler(this.txtNum2_TextChanged);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(19, 157);
            this.lblResultado.MaximumSize = new System.Drawing.Size(2, 20);
            this.lblResultado.MinimumSize = new System.Drawing.Size(130, 40);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(130, 40);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResultado.Click += new System.EventHandler(this.lblResultado_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Calculadora";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(29, 39);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 20);
            this.txtNum1.TabIndex = 7;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum1.TextChanged += new System.EventHandler(this.txtNum1_TextChanged);
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 216);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(75, 23);
            this.btnCalc.TabIndex = 8;
            this.btnCalc.Text = "&Calcular";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(98, 215);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(75, 23);
            this.btnLimp.TabIndex = 9;
            this.btnLimp.Text = "&Limpar";
            this.btnLimp.UseVisualStyleBackColor = true;
            this.btnLimp.Click += new System.EventHandler(this.btnLimp_Click);
            // 
            // btnFech
            // 
            this.btnFech.Location = new System.Drawing.Point(180, 214);
            this.btnFech.Name = "btnFech";
            this.btnFech.Size = new System.Drawing.Size(75, 23);
            this.btnFech.TabIndex = 10;
            this.btnFech.Text = "&Fechar";
            this.btnFech.UseVisualStyleBackColor = true;
            this.btnFech.Click += new System.EventHandler(this.btnFech_Click);
            // 
            // FrmRDB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnFech);
            this.Controls.Add(this.btnLimp);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSinal);
            this.Controls.Add(this.grpRadios);
            this.Name = "FrmRDB";
            this.Text = "FrmRDB";
            this.grpRadios.ResumeLayout(false);
            this.grpRadios.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpRadios;
        private System.Windows.Forms.RadioButton btnRParImpar;
        private System.Windows.Forms.RadioButton btnRRestoInteiro;
        private System.Windows.Forms.RadioButton btnRComparar;
        private System.Windows.Forms.RadioButton btnRDividir;
        private System.Windows.Forms.RadioButton btnRMultiplicar;
        private System.Windows.Forms.RadioButton btnRSubtrair;
        private System.Windows.Forms.RadioButton btnRSomar;
        private System.Windows.Forms.Label lblSinal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Button btnFech;
    }
}