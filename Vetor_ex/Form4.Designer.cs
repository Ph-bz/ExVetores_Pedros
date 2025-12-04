namespace Vetor_ex
{
    partial class frmex3
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
            lblnum = new Label();
            btnadd = new Button();
            txtnum = new TextBox();
            btnreset = new Button();
            btnvoltar = new Button();
            btnsearch = new Button();
            txtsearch = new TextBox();
            txtcubo = new TextBox();
            lblsearch = new Label();
            label1 = new Label();
            lbln = new Label();
            txtn = new TextBox();
            btnlimpar = new Button();
            txtaddnum = new TextBox();
            lbladdnum = new Label();
            SuspendLayout();
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Font = new Font("Segoe UI", 11.25F);
            lblnum.Location = new Point(45, 64);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(0, 25);
            lblnum.TabIndex = 17;
            // 
            // btnadd
            // 
            btnadd.Font = new Font("Segoe UI", 11.25F);
            btnadd.Location = new Point(45, 167);
            btnadd.Margin = new Padding(3, 4, 3, 4);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(165, 35);
            btnadd.TabIndex = 16;
            btnadd.Text = "Adicionar Número";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtnum
            // 
            txtnum.Font = new Font("Segoe UI", 11.25F);
            txtnum.Location = new Point(45, 111);
            txtnum.Margin = new Padding(3, 4, 3, 4);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(165, 32);
            txtnum.TabIndex = 15;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(305, 364);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(91, 32);
            btnreset.TabIndex = 21;
            btnreset.Text = "Resetar";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(409, 364);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(91, 32);
            btnvoltar.TabIndex = 20;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnsearch
            // 
            btnsearch.Location = new Point(448, 80);
            btnsearch.Name = "btnsearch";
            btnsearch.Size = new Size(31, 27);
            btnsearch.TabIndex = 22;
            btnsearch.Text = "🔎";
            btnsearch.UseVisualStyleBackColor = true;
            btnsearch.Click += btnsearch_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(342, 80);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(100, 32);
            txtsearch.TabIndex = 23;
            // 
            // txtcubo
            // 
            txtcubo.Location = new Point(379, 141);
            txtcubo.Name = "txtcubo";
            txtcubo.ReadOnly = true;
            txtcubo.Size = new Size(100, 32);
            txtcubo.TabIndex = 24;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(289, 45);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(250, 25);
            lblsearch.TabIndex = 25;
            lblsearch.Text = "Pesquise o cubo pelo índice:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(323, 144);
            label1.Name = "label1";
            label1.Size = new Size(61, 25);
            label1.TabIndex = 26;
            label1.Text = "Cubo:";
            // 
            // lbln
            // 
            lbln.AutoSize = true;
            lbln.Location = new Point(305, 205);
            lbln.Name = "lbln";
            lbln.Size = new Size(85, 25);
            lbln.TabIndex = 27;
            lbln.Text = "Número:";
            // 
            // txtn
            // 
            txtn.Location = new Point(379, 202);
            txtn.Name = "txtn";
            txtn.ReadOnly = true;
            txtn.Size = new Size(100, 32);
            txtn.TabIndex = 28;
            // 
            // btnlimpar
            // 
            btnlimpar.Location = new Point(395, 246);
            btnlimpar.Name = "btnlimpar";
            btnlimpar.Size = new Size(84, 37);
            btnlimpar.TabIndex = 29;
            btnlimpar.Text = "Limpar";
            btnlimpar.UseVisualStyleBackColor = true;
            btnlimpar.Click += btnlimpar_Click;
            // 
            // txtaddnum
            // 
            txtaddnum.Location = new Point(32, 364);
            txtaddnum.Name = "txtaddnum";
            txtaddnum.ReadOnly = true;
            txtaddnum.Size = new Size(100, 32);
            txtaddnum.TabIndex = 30;
            // 
            // lbladdnum
            // 
            lbladdnum.AutoSize = true;
            lbladdnum.Location = new Point(32, 332);
            lbladdnum.Name = "lbladdnum";
            lbladdnum.Size = new Size(202, 25);
            lbladdnum.TabIndex = 31;
            lbladdnum.Text = "Números Adicionados:";
            // 
            // frmex3
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 425);
            ControlBox = false;
            Controls.Add(lbladdnum);
            Controls.Add(txtaddnum);
            Controls.Add(btnlimpar);
            Controls.Add(txtn);
            Controls.Add(lbln);
            Controls.Add(label1);
            Controls.Add(lblsearch);
            Controls.Add(txtcubo);
            Controls.Add(txtsearch);
            Controls.Add(btnsearch);
            Controls.Add(btnreset);
            Controls.Add(btnvoltar);
            Controls.Add(lblnum);
            Controls.Add(btnadd);
            Controls.Add(txtnum);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmex3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblnum;
        private Button btnadd;
        private TextBox txtnum;
        private Button btnreset;
        private Button btnvoltar;
        private Button btnsearch;
        private TextBox txtsearch;
        private TextBox txtcubo;
        private Label lblsearch;
        private Label label1;
        private Label lbln;
        private TextBox txtn;
        private Button btnlimpar;
        private TextBox txtaddnum;
        private Label lbladdnum;
    }
}