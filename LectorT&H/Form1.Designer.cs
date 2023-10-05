namespace LectorT_H
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            lblHumedad = new Label();
            lblTemp = new Label();
            groupBox1 = new GroupBox();
            btnCerrar = new Button();
            cmbBaud = new ComboBox();
            btnAbrir = new Button();
            cmbCom = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(297, 267);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblHumedad);
            panel1.Controls.Add(lblTemp);
            panel1.Location = new Point(315, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 54);
            panel1.TabIndex = 1;
            // 
            // lblHumedad
            // 
            lblHumedad.AutoSize = true;
            lblHumedad.Location = new Point(221, 20);
            lblHumedad.Name = "lblHumedad";
            lblHumedad.Size = new Size(109, 15);
            lblHumedad.TabIndex = 4;
            lblHumedad.Text = "Humedad=___%RH";
            // 
            // lblTemp
            // 
            lblTemp.AutoSize = true;
            lblTemp.Location = new Point(21, 20);
            lblTemp.Name = "lblTemp";
            lblTemp.Size = new Size(104, 15);
            lblTemp.TabIndex = 3;
            lblTemp.Text = "Temperatura=___C";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(cmbBaud);
            groupBox1.Controls.Add(btnAbrir);
            groupBox1.Controls.Add(cmbCom);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(297, 100);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Ajustes Puerto COM";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(205, 57);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 32);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cmbBaud
            // 
            cmbBaud.FormattingEnabled = true;
            cmbBaud.Location = new Point(85, 63);
            cmbBaud.Name = "cmbBaud";
            cmbBaud.Size = new Size(114, 23);
            cmbBaud.TabIndex = 3;
            // 
            // btnAbrir
            // 
            btnAbrir.Location = new Point(205, 18);
            btnAbrir.Name = "btnAbrir";
            btnAbrir.Size = new Size(75, 33);
            btnAbrir.TabIndex = 3;
            btnAbrir.Text = "Abrir";
            btnAbrir.UseVisualStyleBackColor = true;
            btnAbrir.Click += btnAbrir_Click;
            // 
            // cmbCom
            // 
            cmbCom.FormattingEnabled = true;
            cmbCom.Location = new Point(85, 24);
            cmbCom.Name = "cmbCom";
            cmbCom.Size = new Size(114, 23);
            cmbCom.TabIndex = 4;
            cmbCom.DropDown += cmbCom_DropDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "BAUD RATE";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 27);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Puerto COM";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(666, 393);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Button btnCerrar;
        private ComboBox cmbBaud;
        private Button btnAbrir;
        private ComboBox cmbCom;
        private Label label2;
        private Label label1;
        private Label lblHumedad;
        private Label lblTemp;
    }
}