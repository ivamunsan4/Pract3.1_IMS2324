namespace GitHubTelegrama_IMS_2324
{
    partial class IMS_2324
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
            label2 = new Label();
            txtTelegrama = new TextBox();
            label3 = new Label();
            txtPrecio = new TextBox();
            button1 = new Button();
            rbOrdinario = new RadioButton();
            rbUrgente = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 248);
            label1.Name = "label1";
            label1.Size = new Size(130, 30);
            label1.TabIndex = 0;
            label1.Text = "VERSION 3 principal\r\nTelegrama radio button";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 19);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 11;
            label2.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(29, 43);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(449, 172);
            txtTelegrama.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 264);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 9;
            label3.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(75, 256);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(160, 23);
            txtPrecio.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(241, 231);
            button1.Name = "button1";
            button1.Size = new Size(126, 48);
            button1.TabIndex = 6;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // rbOrdinario
            // 
            rbOrdinario.AutoSize = true;
            rbOrdinario.Checked = true;
            rbOrdinario.Location = new Point(16, 227);
            rbOrdinario.Name = "rbOrdinario";
            rbOrdinario.Size = new Size(75, 19);
            rbOrdinario.TabIndex = 12;
            rbOrdinario.TabStop = true;
            rbOrdinario.Text = "Ordinario";
            rbOrdinario.UseVisualStyleBackColor = true;
            // 
            // rbUrgente
            // 
            rbUrgente.AutoSize = true;
            rbUrgente.Checked = true;
            rbUrgente.Location = new Point(97, 227);
            rbUrgente.Name = "rbUrgente";
            rbUrgente.Size = new Size(67, 19);
            rbUrgente.TabIndex = 13;
            rbUrgente.TabStop = true;
            rbUrgente.Text = "Urgente";
            rbUrgente.UseVisualStyleBackColor = true;
            // 
            // IMS_2324
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 330);
            Controls.Add(rbUrgente);
            Controls.Add(rbOrdinario);
            Controls.Add(label2);
            Controls.Add(txtTelegrama);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "IMS_2324";
            Text = "IMS_2324";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtTelegrama;
        private Label label3;
        private TextBox txtPrecio;
        private Button button1;
        private RadioButton rbOrdinario;
        private RadioButton rbUrgente;
    }
}