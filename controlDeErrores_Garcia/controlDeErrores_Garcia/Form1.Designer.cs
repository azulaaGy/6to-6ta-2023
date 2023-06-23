namespace controlDeErrores_Garcia
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
            LoadingGIF = new PictureBox();
            BtnIniciar = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)LoadingGIF).BeginInit();
            SuspendLayout();
            // 
            // LoadingGIF
            // 
            LoadingGIF.Image = Properties.Resources.loading;
            LoadingGIF.Location = new Point(211, 170);
            LoadingGIF.Name = "LoadingGIF";
            LoadingGIF.Size = new Size(144, 159);
            LoadingGIF.SizeMode = PictureBoxSizeMode.Zoom;
            LoadingGIF.TabIndex = 0;
            LoadingGIF.TabStop = false;
            // 
            // BtnIniciar
            // 
            BtnIniciar.Location = new Point(159, 106);
            BtnIniciar.Name = "BtnIniciar";
            BtnIniciar.Size = new Size(237, 27);
            BtnIniciar.TabIndex = 1;
            BtnIniciar.Text = "Iniciar";
            BtnIniciar.UseVisualStyleBackColor = true;
            BtnIniciar.Click += BtnIniciar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(159, 60);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 2;
            label1.Text = "Nombre:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(233, 57);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(163, 23);
            textBox1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 387);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(BtnIniciar);
            Controls.Add(LoadingGIF);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)LoadingGIF).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox LoadingGIF;
        private Button BtnIniciar;
        private Label label1;
        private TextBox textBox1;
    }
}