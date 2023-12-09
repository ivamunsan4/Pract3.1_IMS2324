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
            cbUrgente = new CheckBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(375, 248);
            label1.Name = "label1";
            label1.Size = new Size(106, 30);
            label1.TabIndex = 0;
            label1.Text = "VERSION 2\r\nTelegrama Errores..";
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
            // cbUrgente
            // 
            cbUrgente.AutoSize = true;
            cbUrgente.Location = new Point(29, 221);
            cbUrgente.Name = "cbUrgente";
            cbUrgente.Size = new Size(73, 19);
            cbUrgente.TabIndex = 7;
            cbUrgente.Text = "Urgente?";
            cbUrgente.UseVisualStyleBackColor = true;
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
            // IMS_2324
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 330);
            Controls.Add(label2);
            Controls.Add(txtTelegrama);
            Controls.Add(label3);
            Controls.Add(txtPrecio);
            Controls.Add(cbUrgente);
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
        private CheckBox cbUrgente;
        private Button button1;
    }
}