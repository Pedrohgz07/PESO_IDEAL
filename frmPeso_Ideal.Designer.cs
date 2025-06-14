namespace PESO_IDEAL
{
    partial class frmPeso_Ideal
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
            lblEstatura = new Label();
            txtEstatura = new TextBox();
            lblPeso = new Label();
            txtPeso = new TextBox();
            lblDistancia = new Label();
            txtDistancia = new TextBox();
            label1 = new Label();
            txtPasos = new TextBox();
            btnCalcular = new Button();
            txtIMC = new TextBox();
            txtEstado = new TextBox();
            txtRecomendado = new TextBox();
            lblIMC = new Label();
            lblEstado = new Label();
            lblRecomendacion = new Label();
            txtKm = new TextBox();
            lblKilometros = new Label();
            label2 = new Label();
            txtfaltante = new TextBox();
            SuspendLayout();
            // 
            // lblEstatura
            // 
            lblEstatura.AutoSize = true;
            lblEstatura.Location = new Point(45, 28);
            lblEstatura.Name = "lblEstatura";
            lblEstatura.Size = new Size(111, 15);
            lblEstatura.TabIndex = 0;
            lblEstatura.Text = "Ingresa la Estatura : ";
            // 
            // txtEstatura
            // 
            txtEstatura.Location = new Point(45, 57);
            txtEstatura.Name = "txtEstatura";
            txtEstatura.Size = new Size(106, 23);
            txtEstatura.TabIndex = 1;
            txtEstatura.KeyPress += txtEstatura_KeyPress;
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Location = new Point(45, 102);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(93, 15);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Ingresa tu peso :";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(45, 129);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(106, 23);
            txtPeso.TabIndex = 3;
            txtPeso.KeyPress += txtPeso_KeyPress;
            // 
            // lblDistancia
            // 
            lblDistancia.AutoSize = true;
            lblDistancia.Location = new Point(49, 169);
            lblDistancia.Name = "lblDistancia";
            lblDistancia.Size = new Size(114, 15);
            lblDistancia.TabIndex = 4;
            lblDistancia.Text = "Ingrese la sancadas :";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(45, 204);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(106, 23);
            txtDistancia.TabIndex = 5;
            txtDistancia.KeyPress += txtDistancia_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(49, 242);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 6;
            label1.Text = "Ingrese los pasos :";
            // 
            // txtPasos
            // 
            txtPasos.Location = new Point(45, 270);
            txtPasos.Name = "txtPasos";
            txtPasos.Size = new Size(106, 23);
            txtPasos.TabIndex = 7;
            txtPasos.KeyPress += txtPasos_KeyPress;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(248, 270);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtIMC
            // 
            txtIMC.Location = new Point(182, 344);
            txtIMC.Name = "txtIMC";
            txtIMC.Size = new Size(203, 23);
            txtIMC.TabIndex = 9;
            // 
            // txtEstado
            // 
            txtEstado.Location = new Point(182, 378);
            txtEstado.Name = "txtEstado";
            txtEstado.Size = new Size(203, 23);
            txtEstado.TabIndex = 10;
            // 
            // txtRecomendado
            // 
            txtRecomendado.Location = new Point(182, 413);
            txtRecomendado.Name = "txtRecomendado";
            txtRecomendado.Size = new Size(203, 23);
            txtRecomendado.TabIndex = 11;
            // 
            // lblIMC
            // 
            lblIMC.AutoSize = true;
            lblIMC.Location = new Point(45, 347);
            lblIMC.Name = "lblIMC";
            lblIMC.Size = new Size(29, 15);
            lblIMC.TabIndex = 12;
            lblIMC.Text = "IMC";
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.Location = new Point(45, 381);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(42, 15);
            lblEstado.TabIndex = 13;
            lblEstado.Text = "Estado";
            // 
            // lblRecomendacion
            // 
            lblRecomendacion.AutoSize = true;
            lblRecomendacion.Location = new Point(45, 416);
            lblRecomendacion.Name = "lblRecomendacion";
            lblRecomendacion.Size = new Size(93, 15);
            lblRecomendacion.TabIndex = 14;
            lblRecomendacion.Text = "Recomendacion";
            // 
            // txtKm
            // 
            txtKm.Location = new Point(182, 461);
            txtKm.Name = "txtKm";
            txtKm.Size = new Size(203, 23);
            txtKm.TabIndex = 15;
            // 
            // lblKilometros
            // 
            lblKilometros.AutoSize = true;
            lblKilometros.Location = new Point(49, 464);
            lblKilometros.Name = "lblKilometros";
            lblKilometros.Size = new Size(64, 15);
            lblKilometros.TabIndex = 16;
            lblKilometros.Text = "Kilometros";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 505);
            label2.Name = "label2";
            label2.Size = new Size(109, 15);
            label2.TabIndex = 17;
            label2.Text = "Kilometros Faltante";
            // 
            // txtfaltante
            // 
            txtfaltante.Location = new Point(183, 506);
            txtfaltante.Name = "txtfaltante";
            txtfaltante.Size = new Size(202, 23);
            txtfaltante.TabIndex = 18;
            // 
            // frmPeso_Ideal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 544);
            Controls.Add(txtfaltante);
            Controls.Add(label2);
            Controls.Add(lblKilometros);
            Controls.Add(txtKm);
            Controls.Add(lblRecomendacion);
            Controls.Add(lblEstado);
            Controls.Add(lblIMC);
            Controls.Add(txtRecomendado);
            Controls.Add(txtEstado);
            Controls.Add(txtIMC);
            Controls.Add(btnCalcular);
            Controls.Add(txtPasos);
            Controls.Add(label1);
            Controls.Add(txtDistancia);
            Controls.Add(lblDistancia);
            Controls.Add(txtPeso);
            Controls.Add(lblPeso);
            Controls.Add(txtEstatura);
            Controls.Add(lblEstatura);
            Name = "frmPeso_Ideal";
            Text = "frmPeso_Ideal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEstatura;
        private TextBox txtEstatura;
        private Label lblPeso;
        private TextBox txtPeso;
        private Label lblDistancia;
        private TextBox txtDistancia;
        private Label label1;
        private TextBox txtPasos;
        private Button btnCalcular;
        private TextBox txtIMC;
        private TextBox txtEstado;
        private TextBox txtRecomendado;
        private Label lblIMC;
        private Label lblEstado;
        private Label lblRecomendacion;
        private TextBox txtKm;
        private Label lblKilometros;
        private Label label2;
        private TextBox txtfaltante;
    }
}