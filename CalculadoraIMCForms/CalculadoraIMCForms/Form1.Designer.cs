namespace CalculadoraIMCForms
{
    partial class lbl_Tutulo1
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
            btm_Calcular = new Button();
            text_Altura = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            text_Peso = new TextBox();
            SuspendLayout();
            // 
            // btm_Calcular
            // 
            btm_Calcular.Location = new Point(152, 246);
            btm_Calcular.Margin = new Padding(5, 6, 5, 6);
            btm_Calcular.Name = "btm_Calcular";
            btm_Calcular.Size = new Size(152, 46);
            btm_Calcular.TabIndex = 0;
            btm_Calcular.Text = "Calcular IMC";
            btm_Calcular.UseVisualStyleBackColor = true;
            btm_Calcular.Click += btm_Calcular_Click;
            // 
            // text_Altura
            // 
            text_Altura.Location = new Point(31, 190);
            text_Altura.Margin = new Padding(5, 6, 5, 6);
            text_Altura.Name = "text_Altura";
            text_Altura.Size = new Size(152, 35);
            text_Altura.TabIndex = 1;
            text_Altura.TextChanged += text_Altura_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 9);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(388, 30);
            label1.TabIndex = 2;
            label1.Text = "Calculadora de Indice de massa corporal";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 154);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 30);
            label2.TabIndex = 3;
            label2.Text = "Altura: (Metros)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(261, 154);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(158, 30);
            label3.TabIndex = 4;
            label3.Text = "Peso Atual: (Kg)";
            // 
            // text_Peso
            // 
            text_Peso.Location = new Point(261, 190);
            text_Peso.Margin = new Padding(5, 6, 5, 6);
            text_Peso.Name = "text_Peso";
            text_Peso.Size = new Size(158, 35);
            text_Peso.TabIndex = 5;
            text_Peso.TextChanged += text_Peso_TextChanged;
            // 
            // lbl_Tutulo1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(460, 480);
            Controls.Add(text_Peso);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(text_Altura);
            Controls.Add(btm_Calcular);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "lbl_Tutulo1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btm_Calcular;
        private TextBox text_Altura;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox text_Peso;
    }
}