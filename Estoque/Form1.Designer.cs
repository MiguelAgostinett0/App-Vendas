
namespace Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_des = new System.Windows.Forms.Label();
            this.lbl_cod = new System.Windows.Forms.Label();
            this.lbl_uni = new System.Windows.Forms.Label();
            this.lbl_vv = new System.Windows.Forms.Label();
            this.lbl_qnt = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tb_des = new System.Windows.Forms.TextBox();
            this.tb_cod = new System.Windows.Forms.TextBox();
            this.tb_uni = new System.Windows.Forms.TextBox();
            this.tb_vv = new System.Windows.Forms.TextBox();
            this.tb_qnt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_des
            // 
            this.lbl_des.AutoSize = true;
            this.lbl_des.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_des.Location = new System.Drawing.Point(26, 28);
            this.lbl_des.Name = "lbl_des";
            this.lbl_des.Size = new System.Drawing.Size(70, 16);
            this.lbl_des.TabIndex = 0;
            this.lbl_des.Text = "Descrição";
            // 
            // lbl_cod
            // 
            this.lbl_cod.AutoSize = true;
            this.lbl_cod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_cod.Location = new System.Drawing.Point(224, 28);
            this.lbl_cod.Name = "lbl_cod";
            this.lbl_cod.Size = new System.Drawing.Size(52, 17);
            this.lbl_cod.TabIndex = 1;
            this.lbl_cod.Text = "Código";
            // 
            // lbl_uni
            // 
            this.lbl_uni.AutoSize = true;
            this.lbl_uni.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_uni.Location = new System.Drawing.Point(362, 28);
            this.lbl_uni.Name = "lbl_uni";
            this.lbl_uni.Size = new System.Drawing.Size(61, 17);
            this.lbl_uni.TabIndex = 2;
            this.lbl_uni.Text = "Unidade";
            // 
            // lbl_vv
            // 
            this.lbl_vv.AutoSize = true;
            this.lbl_vv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_vv.Location = new System.Drawing.Point(26, 113);
            this.lbl_vv.Name = "lbl_vv";
            this.lbl_vv.Size = new System.Drawing.Size(106, 17);
            this.lbl_vv.TabIndex = 3;
            this.lbl_vv.Text = "Valor da Venda";
            // 
            // lbl_qnt
            // 
            this.lbl_qnt.AutoSize = true;
            this.lbl_qnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.lbl_qnt.Location = new System.Drawing.Point(190, 113);
            this.lbl_qnt.Name = "lbl_qnt";
            this.lbl_qnt.Size = new System.Drawing.Size(160, 17);
            this.lbl_qnt.TabIndex = 4;
            this.lbl_qnt.Text = "Quantidade em estoque";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button1.Location = new System.Drawing.Point(29, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.button2.Location = new System.Drawing.Point(29, 234);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // tb_des
            // 
            this.tb_des.Location = new System.Drawing.Point(29, 48);
            this.tb_des.Multiline = true;
            this.tb_des.Name = "tb_des";
            this.tb_des.Size = new System.Drawing.Size(160, 20);
            this.tb_des.TabIndex = 7;
            // 
            // tb_cod
            // 
            this.tb_cod.Location = new System.Drawing.Point(227, 48);
            this.tb_cod.Name = "tb_cod";
            this.tb_cod.Size = new System.Drawing.Size(100, 20);
            this.tb_cod.TabIndex = 8;
            // 
            // tb_uni
            // 
            this.tb_uni.Location = new System.Drawing.Point(365, 48);
            this.tb_uni.Name = "tb_uni";
            this.tb_uni.Size = new System.Drawing.Size(100, 20);
            this.tb_uni.TabIndex = 9;
            // 
            // tb_vv
            // 
            this.tb_vv.Location = new System.Drawing.Point(29, 133);
            this.tb_vv.Name = "tb_vv";
            this.tb_vv.Size = new System.Drawing.Size(136, 20);
            this.tb_vv.TabIndex = 10;
            // 
            // tb_qnt
            // 
            this.tb_qnt.Location = new System.Drawing.Point(193, 133);
            this.tb_qnt.Name = "tb_qnt";
            this.tb_qnt.Size = new System.Drawing.Size(157, 20);
            this.tb_qnt.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 312);
            this.Controls.Add(this.tb_qnt);
            this.Controls.Add(this.tb_vv);
            this.Controls.Add(this.tb_uni);
            this.Controls.Add(this.tb_cod);
            this.Controls.Add(this.tb_des);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_qnt);
            this.Controls.Add(this.lbl_vv);
            this.Controls.Add(this.lbl_uni);
            this.Controls.Add(this.lbl_cod);
            this.Controls.Add(this.lbl_des);
            this.Name = "Form1";
            this.Text = "Cadastro de produtos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_des;
        private System.Windows.Forms.Label lbl_cod;
        private System.Windows.Forms.Label lbl_uni;
        private System.Windows.Forms.Label lbl_vv;
        private System.Windows.Forms.Label lbl_qnt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox tb_des;
        private System.Windows.Forms.TextBox tb_cod;
        private System.Windows.Forms.TextBox tb_uni;
        private System.Windows.Forms.TextBox tb_vv;
        private System.Windows.Forms.TextBox tb_qnt;
    }
}

