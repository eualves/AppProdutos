
namespace AppProdutos.View
{
    partial class TelaCad
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
            this.tbCadDesc = new System.Windows.Forms.RichTextBox();
            this.tbCadQuant = new System.Windows.Forms.TextBox();
            this.tbCadNome = new System.Windows.Forms.TextBox();
            this.tbCadValor = new System.Windows.Forms.TextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbCadDesc
            // 
            this.tbCadDesc.Location = new System.Drawing.Point(182, 250);
            this.tbCadDesc.Name = "tbCadDesc";
            this.tbCadDesc.Size = new System.Drawing.Size(298, 96);
            this.tbCadDesc.TabIndex = 25;
            this.tbCadDesc.Text = "";
            // 
            // tbCadQuant
            // 
            this.tbCadQuant.Location = new System.Drawing.Point(458, 144);
            this.tbCadQuant.Name = "tbCadQuant";
            this.tbCadQuant.Size = new System.Drawing.Size(146, 23);
            this.tbCadQuant.TabIndex = 24;
            // 
            // tbCadNome
            // 
            this.tbCadNome.Location = new System.Drawing.Point(185, 144);
            this.tbCadNome.Name = "tbCadNome";
            this.tbCadNome.Size = new System.Drawing.Size(144, 23);
            this.tbCadNome.TabIndex = 23;
            // 
            // tbCadValor
            // 
            this.tbCadValor.Location = new System.Drawing.Point(517, 250);
            this.tbCadValor.Name = "tbCadValor";
            this.tbCadValor.Size = new System.Drawing.Size(87, 23);
            this.tbCadValor.TabIndex = 22;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(344, 396);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(120, 42);
            this.btnCadastrar.TabIndex = 21;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(514, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 32);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(182, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 32);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(450, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 32);
            this.label4.TabIndex = 16;
            this.label4.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(182, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(260, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 40);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cadastrar Produtos";
            // 
            // TelaCad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbCadDesc);
            this.Controls.Add(this.tbCadQuant);
            this.Controls.Add(this.tbCadNome);
            this.Controls.Add(this.tbCadValor);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TelaCad";
            this.Text = "TelaCad";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox tbCadDesc;
        private System.Windows.Forms.TextBox tbCadQuant;
        private System.Windows.Forms.TextBox tbCadNome;
        private System.Windows.Forms.TextBox tbCadValor;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}