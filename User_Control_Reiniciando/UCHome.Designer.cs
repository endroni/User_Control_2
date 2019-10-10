namespace User_Control_Reiniciando
{
    partial class UCHome
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btnProximaTela = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 73);
            this.label1.TabIndex = 0;
            this.label1.Text = "Essa é a Home";
            // 
            // btnProximaTela
            // 
            this.btnProximaTela.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximaTela.Location = new System.Drawing.Point(384, 270);
            this.btnProximaTela.Name = "btnProximaTela";
            this.btnProximaTela.Size = new System.Drawing.Size(153, 44);
            this.btnProximaTela.TabIndex = 1;
            this.btnProximaTela.Text = "Próxima Tela";
            this.btnProximaTela.UseVisualStyleBackColor = true;
            this.btnProximaTela.Click += new System.EventHandler(this.btnProximaTela_Click);
            // 
            // UCHome
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.btnProximaTela);
            this.Controls.Add(this.label1);
            this.Name = "UCHome";
            this.Size = new System.Drawing.Size(883, 449);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProximaTela;
    }
}
