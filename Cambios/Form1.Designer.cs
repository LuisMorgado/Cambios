namespace Cambios
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_destino = new System.Windows.Forms.ComboBox();
            this.cb_origem = new System.Windows.Forms.ComboBox();
            this.btn_converter = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.lbl_status = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.btn_troca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Moeda de Origem:";
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(100, 12);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(221, 20);
            this.txt_valor.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Moeda de Destino:";
            // 
            // cb_destino
            // 
            this.cb_destino.FormattingEnabled = true;
            this.cb_destino.Location = new System.Drawing.Point(103, 133);
            this.cb_destino.Name = "cb_destino";
            this.cb_destino.Size = new System.Drawing.Size(218, 21);
            this.cb_destino.TabIndex = 4;
            // 
            // cb_origem
            // 
            this.cb_origem.FormattingEnabled = true;
            this.cb_origem.Location = new System.Drawing.Point(100, 75);
            this.cb_origem.Name = "cb_origem";
            this.cb_origem.Size = new System.Drawing.Size(221, 21);
            this.cb_origem.TabIndex = 5;
            // 
            // btn_converter
            // 
            this.btn_converter.Enabled = false;
            this.btn_converter.Location = new System.Drawing.Point(327, 9);
            this.btn_converter.Name = "btn_converter";
            this.btn_converter.Size = new System.Drawing.Size(75, 23);
            this.btn_converter.TabIndex = 6;
            this.btn_converter.Text = "Converter";
            this.btn_converter.UseVisualStyleBackColor = true;
            this.btn_converter.Click += new System.EventHandler(this.btn_converter_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(100, 177);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(221, 13);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Escolha um valor, moeda de origem e destino";
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(12, 214);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(37, 13);
            this.lbl_status.TabIndex = 8;
            this.lbl_status.Text = "Status";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(327, 201);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 23);
            this.progressBar1.TabIndex = 9;
            // 
            // btn_troca
            // 
            this.btn_troca.Enabled = false;
            this.btn_troca.Image = ((System.Drawing.Image)(resources.GetObject("btn_troca.Image")));
            this.btn_troca.Location = new System.Drawing.Point(349, 63);
            this.btn_troca.Name = "btn_troca";
            this.btn_troca.Size = new System.Drawing.Size(53, 43);
            this.btn_troca.TabIndex = 10;
            this.btn_troca.UseVisualStyleBackColor = true;
            this.btn_troca.Click += new System.EventHandler(this.btn_troca_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 236);
            this.Controls.Add(this.btn_troca);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_converter);
            this.Controls.Add(this.cb_origem);
            this.Controls.Add(this.cb_destino);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_valor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Cambios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_destino;
        private System.Windows.Forms.ComboBox cb_origem;
        private System.Windows.Forms.Button btn_converter;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button btn_troca;
    }
}

