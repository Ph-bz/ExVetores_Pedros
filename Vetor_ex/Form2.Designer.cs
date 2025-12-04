namespace Vetor_ex
{
    partial class frmex1
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
            txtnum = new TextBox();
            btnadd = new Button();
            txtA = new TextBox();
            txtB = new TextBox();
            lblA = new Label();
            lblB = new Label();
            btnvoltar = new Button();
            btnmostrar = new Button();
            btnreset = new Button();
            txtaddnum = new TextBox();
            lbladdnum = new Label();
            SuspendLayout();
            // 
            // lblnum
            // 
            lblnum.AutoSize = true;
            lblnum.Location = new Point(24, 41);
            lblnum.Name = "lblnum";
            lblnum.Size = new Size(0, 25);
            lblnum.TabIndex = 4;
            // 
            // txtnum
            // 
            txtnum.Location = new Point(24, 76);
            txtnum.Name = "txtnum";
            txtnum.Size = new Size(155, 32);
            txtnum.TabIndex = 0;
            // 
            // btnadd
            // 
            btnadd.Location = new Point(24, 127);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(155, 31);
            btnadd.TabIndex = 1;
            btnadd.Text = "Adicionar Número";
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtA
            // 
            txtA.Location = new Point(249, 57);
            txtA.Multiline = true;
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.ScrollBars = ScrollBars.Both;
            txtA.Size = new Size(88, 157);
            txtA.TabIndex = 2;
            // 
            // txtB
            // 
            txtB.Location = new Point(364, 57);
            txtB.Multiline = true;
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.ScrollBars = ScrollBars.Both;
            txtB.Size = new Size(88, 157);
            txtB.TabIndex = 3;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(266, 34);
            lblA.Name = "lblA";
            lblA.Size = new Size(71, 25);
            lblA.TabIndex = 5;
            lblA.Text = "Lista A:";
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(385, 34);
            lblB.Name = "lblB";
            lblB.Size = new Size(70, 25);
            lblB.TabIndex = 6;
            lblB.Text = "Lista B:";
            // 
            // btnvoltar
            // 
            btnvoltar.Location = new Point(419, 356);
            btnvoltar.Name = "btnvoltar";
            btnvoltar.Size = new Size(91, 46);
            btnvoltar.TabIndex = 7;
            btnvoltar.Text = "Voltar";
            btnvoltar.UseVisualStyleBackColor = true;
            btnvoltar.Click += btnvoltar_Click;
            // 
            // btnmostrar
            // 
            btnmostrar.Enabled = false;
            btnmostrar.Location = new Point(24, 183);
            btnmostrar.Name = "btnmostrar";
            btnmostrar.Size = new Size(155, 31);
            btnmostrar.TabIndex = 8;
            btnmostrar.Text = "Mostrar Listas";
            btnmostrar.UseVisualStyleBackColor = true;
            btnmostrar.Click += btnmostrar_Click;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(315, 356);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(91, 46);
            btnreset.TabIndex = 9;
            btnreset.Text = "Resetar";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // txtaddnum
            // 
            txtaddnum.Location = new Point(24, 364);
            txtaddnum.Name = "txtaddnum";
            txtaddnum.ReadOnly = true;
            txtaddnum.Size = new Size(100, 32);
            txtaddnum.TabIndex = 32;
            // 
            // lbladdnum
            // 
            lbladdnum.AutoSize = true;
            lbladdnum.Location = new Point(24, 332);
            lbladdnum.Name = "lbladdnum";
            lbladdnum.Size = new Size(202, 25);
            lbladdnum.TabIndex = 33;
            lbladdnum.Text = "Números Adicionados:";
            // 
            // frmex1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 474);
            ControlBox = false;
            Controls.Add(lbladdnum);
            Controls.Add(txtaddnum);
            Controls.Add(btnreset);
            Controls.Add(btnmostrar);
            Controls.Add(btnvoltar);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblnum);
            Controls.Add(txtB);
            Controls.Add(txtA);
            Controls.Add(btnadd);
            Controls.Add(txtnum);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmex1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Exercício 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblnum;
        private TextBox txtnum;
        private Button btnadd;
        private TextBox txtA;
        private TextBox txtB;
        private Label lblA;
        private Label lblB;
        private Button btnvoltar;
        private Button btnmostrar;
        private Button btnreset;
        private TextBox txtaddnum;
        private Label lbladdnum;
    }
}