namespace ConsumodeAPIsLester
{
    partial class Form1
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
            label1 = new Label();
            txtPokemon = new TextBox();
            btnBuscarPokemon = new Button();
            picPokemon = new PictureBox();
            lblNombrePokemon = new Label();
            lblPesoPokemon = new Label();
            lblAlturaPokemon = new Label();
            btnLimpiarPokemon = new Button();
            btnGuardar = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lblRaza = new Label();
            picGato = new PictureBox();
            lblTemperamento = new Label();
            lblOrigenGato = new Label();
            btnGuardarGato = new Button();
            btnLimpiarIGato = new Button();
            btnBuscarGato = new Button();
            txtRaza = new TextBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)picPokemon).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picGato).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label1.Location = new Point(43, 46);
            label1.Name = "label1";
            label1.Size = new Size(164, 21);
            label1.TabIndex = 0;
            label1.Text = "Buscar Pokemon ";
            // 
            // txtPokemon
            // 
            txtPokemon.Location = new Point(204, 46);
            txtPokemon.Name = "txtPokemon";
            txtPokemon.Size = new Size(255, 27);
            txtPokemon.TabIndex = 1;
            // 
            // btnBuscarPokemon
            // 
            btnBuscarPokemon.Location = new Point(43, 204);
            btnBuscarPokemon.Name = "btnBuscarPokemon";
            btnBuscarPokemon.Size = new Size(126, 54);
            btnBuscarPokemon.TabIndex = 2;
            btnBuscarPokemon.Text = "Buscar";
            btnBuscarPokemon.UseVisualStyleBackColor = true;
            btnBuscarPokemon.Click += btnBuscarPokemon_Click;
            // 
            // picPokemon
            // 
            picPokemon.Location = new Point(143, 264);
            picPokemon.Name = "picPokemon";
            picPokemon.Size = new Size(206, 160);
            picPokemon.SizeMode = PictureBoxSizeMode.StretchImage;
            picPokemon.TabIndex = 3;
            picPokemon.TabStop = false;
            // 
            // lblNombrePokemon
            // 
            lblNombrePokemon.AutoSize = true;
            lblNombrePokemon.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblNombrePokemon.Location = new Point(43, 88);
            lblNombrePokemon.Name = "lblNombrePokemon";
            lblNombrePokemon.Size = new Size(80, 21);
            lblNombrePokemon.TabIndex = 4;
            lblNombrePokemon.Text = "Nombre";
            // 
            // lblPesoPokemon
            // 
            lblPesoPokemon.AutoSize = true;
            lblPesoPokemon.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblPesoPokemon.Location = new Point(43, 129);
            lblPesoPokemon.Name = "lblPesoPokemon";
            lblPesoPokemon.Size = new Size(54, 21);
            lblPesoPokemon.TabIndex = 5;
            lblPesoPokemon.Text = "Peso";
            // 
            // lblAlturaPokemon
            // 
            lblAlturaPokemon.AutoSize = true;
            lblAlturaPokemon.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblAlturaPokemon.Location = new Point(43, 166);
            lblAlturaPokemon.Name = "lblAlturaPokemon";
            lblAlturaPokemon.Size = new Size(62, 21);
            lblAlturaPokemon.TabIndex = 6;
            lblAlturaPokemon.Text = "Altura";
            // 
            // btnLimpiarPokemon
            // 
            btnLimpiarPokemon.Location = new Point(331, 204);
            btnLimpiarPokemon.Name = "btnLimpiarPokemon";
            btnLimpiarPokemon.Size = new Size(128, 52);
            btnLimpiarPokemon.TabIndex = 7;
            btnLimpiarPokemon.Text = "Limpiar ";
            btnLimpiarPokemon.UseVisualStyleBackColor = true;
            btnLimpiarPokemon.Click += btnLimpiarPokemon_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(195, 202);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(116, 54);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.Info;
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblRaza);
            groupBox1.Controls.Add(picGato);
            groupBox1.Controls.Add(lblTemperamento);
            groupBox1.Controls.Add(lblOrigenGato);
            groupBox1.Controls.Add(btnGuardarGato);
            groupBox1.Controls.Add(btnLimpiarIGato);
            groupBox1.Controls.Add(btnBuscarGato);
            groupBox1.Controls.Add(txtRaza);
            groupBox1.Location = new Point(553, 33);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(875, 443);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.Location = new Point(63, 45);
            label2.Name = "label2";
            label2.Size = new Size(152, 21);
            label2.TabIndex = 8;
            label2.Text = "Buscar por Raza";
            // 
            // lblRaza
            // 
            lblRaza.AutoSize = true;
            lblRaza.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblRaza.Location = new Point(63, 84);
            lblRaza.Name = "lblRaza";
            lblRaza.Size = new Size(80, 21);
            lblRaza.TabIndex = 7;
            lblRaza.Text = "Nombre";
            // 
            // picGato
            // 
            picGato.Location = new Point(351, 287);
            picGato.Name = "picGato";
            picGato.Size = new Size(184, 135);
            picGato.SizeMode = PictureBoxSizeMode.StretchImage;
            picGato.TabIndex = 6;
            picGato.TabStop = false;
            // 
            // lblTemperamento
            // 
            lblTemperamento.AutoSize = true;
            lblTemperamento.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblTemperamento.Location = new Point(63, 170);
            lblTemperamento.Name = "lblTemperamento";
            lblTemperamento.Size = new Size(143, 21);
            lblTemperamento.TabIndex = 5;
            lblTemperamento.Text = "Temperamento";
            // 
            // lblOrigenGato
            // 
            lblOrigenGato.AutoSize = true;
            lblOrigenGato.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            lblOrigenGato.Location = new Point(63, 125);
            lblOrigenGato.Name = "lblOrigenGato";
            lblOrigenGato.Size = new Size(74, 21);
            lblOrigenGato.TabIndex = 4;
            lblOrigenGato.Text = "Origen ";
            // 
            // btnGuardarGato
            // 
            btnGuardarGato.Location = new Point(367, 213);
            btnGuardarGato.Name = "btnGuardarGato";
            btnGuardarGato.Size = new Size(153, 61);
            btnGuardarGato.TabIndex = 3;
            btnGuardarGato.Text = "Guardar";
            btnGuardarGato.UseVisualStyleBackColor = true;
            btnGuardarGato.Click += btnGuardarGato_Click;
            // 
            // btnLimpiarIGato
            // 
            btnLimpiarIGato.Location = new Point(633, 213);
            btnLimpiarIGato.Name = "btnLimpiarIGato";
            btnLimpiarIGato.Size = new Size(160, 61);
            btnLimpiarIGato.TabIndex = 2;
            btnLimpiarIGato.Text = "Limpiar";
            btnLimpiarIGato.UseVisualStyleBackColor = true;
            btnLimpiarIGato.Click += btnLimpiarIGato_Click;
            // 
            // btnBuscarGato
            // 
            btnBuscarGato.Location = new Point(99, 213);
            btnBuscarGato.Name = "btnBuscarGato";
            btnBuscarGato.Size = new Size(175, 61);
            btnBuscarGato.TabIndex = 1;
            btnBuscarGato.Text = "Buscar";
            btnBuscarGato.UseVisualStyleBackColor = true;
            btnBuscarGato.Click += btnBuscarGato_Click;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(221, 45);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(290, 27);
            txtRaza.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.Info;
            groupBox2.Controls.Add(txtPokemon);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(lblAlturaPokemon);
            groupBox2.Controls.Add(btnGuardar);
            groupBox2.Controls.Add(lblPesoPokemon);
            groupBox2.Controls.Add(btnBuscarPokemon);
            groupBox2.Controls.Add(lblNombrePokemon);
            groupBox2.Controls.Add(btnLimpiarPokemon);
            groupBox2.Controls.Add(picPokemon);
            groupBox2.Location = new Point(24, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(500, 443);
            groupBox2.TabIndex = 10;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1440, 504);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picPokemon).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picGato).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtPokemon;
        private Button btnBuscarPokemon;
        private PictureBox picPokemon;
        private Label lblNombrePokemon;
        private Label lblPesoPokemon;
        private Label lblAlturaPokemon;
        private Button btnLimpiarPokemon;
        private Button btnGuardar;
        private GroupBox groupBox1;
        private Label lblOrigenGato;
        private Button btnGuardarGato;
        private Button btnLimpiarIGato;
        private Button btnBuscarGato;
        private TextBox txtRaza;
        private Label lblTemperamento;
        private PictureBox picGato;
        private Label lblRaza;
        private GroupBox groupBox2;
        private Label label2;
    }
}
