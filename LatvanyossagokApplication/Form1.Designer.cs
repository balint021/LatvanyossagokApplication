namespace LatvanyossagokApplication
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.num_varosLak = new System.Windows.Forms.NumericUpDown();
            this.btn_varosAdd = new System.Windows.Forms.Button();
            this.varosNev = new System.Windows.Forms.TextBox();
            this.txt_varosLak = new System.Windows.Forms.Label();
            this.txt_varosNev = new System.Windows.Forms.Label();
            this.varosBox = new System.Windows.Forms.ListBox();
            this.btn_varosTorol = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_LatvAdd = new System.Windows.Forms.Button();
            this.latvNev = new System.Windows.Forms.TextBox();
            this.latvLeir = new System.Windows.Forms.TextBox();
            this.num_latvAr = new System.Windows.Forms.NumericUpDown();
            this.latv_varosBox = new System.Windows.Forms.ListBox();
            this.latvBox = new System.Windows.Forms.ListBox();
            this.btn_latvDel = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btn_varosUpdate = new System.Windows.Forms.Button();
            this.btn_latvUpdate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_varosLak)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_latvAr)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.num_varosLak);
            this.groupBox1.Controls.Add(this.btn_varosAdd);
            this.groupBox1.Controls.Add(this.varosNev);
            this.groupBox1.Controls.Add(this.txt_varosLak);
            this.groupBox1.Controls.Add(this.txt_varosNev);
            this.groupBox1.Location = new System.Drawing.Point(438, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Varos Felvétel";
            // 
            // num_varosLak
            // 
            this.num_varosLak.Location = new System.Drawing.Point(83, 40);
            this.num_varosLak.Name = "num_varosLak";
            this.num_varosLak.Size = new System.Drawing.Size(100, 20);
            this.num_varosLak.TabIndex = 3;
            // 
            // btn_varosAdd
            // 
            this.btn_varosAdd.Location = new System.Drawing.Point(123, 77);
            this.btn_varosAdd.Name = "btn_varosAdd";
            this.btn_varosAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_varosAdd.TabIndex = 4;
            this.btn_varosAdd.Text = "Felvétel";
            this.btn_varosAdd.UseVisualStyleBackColor = true;
            this.btn_varosAdd.Click += new System.EventHandler(this.btn_varosAdd_Click);
            // 
            // varosNev
            // 
            this.varosNev.Location = new System.Drawing.Point(83, 17);
            this.varosNev.Name = "varosNev";
            this.varosNev.Size = new System.Drawing.Size(100, 20);
            this.varosNev.TabIndex = 5;
            // 
            // txt_varosLak
            // 
            this.txt_varosLak.AutoSize = true;
            this.txt_varosLak.Location = new System.Drawing.Point(22, 47);
            this.txt_varosLak.Name = "txt_varosLak";
            this.txt_varosLak.Size = new System.Drawing.Size(56, 13);
            this.txt_varosLak.TabIndex = 1;
            this.txt_varosLak.Text = "Lakosság:";
            // 
            // txt_varosNev
            // 
            this.txt_varosNev.AutoSize = true;
            this.txt_varosNev.Location = new System.Drawing.Point(48, 20);
            this.txt_varosNev.Name = "txt_varosNev";
            this.txt_varosNev.Size = new System.Drawing.Size(30, 13);
            this.txt_varosNev.TabIndex = 0;
            this.txt_varosNev.Text = "Név:";
            // 
            // varosBox
            // 
            this.varosBox.FormattingEnabled = true;
            this.varosBox.Location = new System.Drawing.Point(7, 19);
            this.varosBox.Name = "varosBox";
            this.varosBox.Size = new System.Drawing.Size(171, 264);
            this.varosBox.TabIndex = 1;
            this.varosBox.SelectedIndexChanged += new System.EventHandler(this.varosBox_SelectedIndexChanged);
            // 
            // btn_varosTorol
            // 
            this.btn_varosTorol.Location = new System.Drawing.Point(102, 289);
            this.btn_varosTorol.Name = "btn_varosTorol";
            this.btn_varosTorol.Size = new System.Drawing.Size(75, 23);
            this.btn_varosTorol.TabIndex = 2;
            this.btn_varosTorol.Text = "Törlés";
            this.btn_varosTorol.UseVisualStyleBackColor = true;
            this.btn_varosTorol.Click += new System.EventHandler(this.btn_varosTorol_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.latv_varosBox);
            this.groupBox2.Controls.Add(this.num_latvAr);
            this.groupBox2.Controls.Add(this.latvLeir);
            this.groupBox2.Controls.Add(this.latvNev);
            this.groupBox2.Controls.Add(this.btn_LatvAdd);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(438, 155);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(302, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Látványosság Felvétel";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ár:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leírás:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név:";
            // 
            // btn_LatvAdd
            // 
            this.btn_LatvAdd.Location = new System.Drawing.Point(54, 144);
            this.btn_LatvAdd.Name = "btn_LatvAdd";
            this.btn_LatvAdd.Size = new System.Drawing.Size(75, 23);
            this.btn_LatvAdd.TabIndex = 3;
            this.btn_LatvAdd.Text = "Felvétel";
            this.btn_LatvAdd.UseVisualStyleBackColor = true;
            this.btn_LatvAdd.Click += new System.EventHandler(this.btn_LatvAdd_Click);
            // 
            // latvNev
            // 
            this.latvNev.Location = new System.Drawing.Point(54, 20);
            this.latvNev.Name = "latvNev";
            this.latvNev.Size = new System.Drawing.Size(100, 20);
            this.latvNev.TabIndex = 4;
            // 
            // latvLeir
            // 
            this.latvLeir.Location = new System.Drawing.Point(54, 45);
            this.latvLeir.Name = "latvLeir";
            this.latvLeir.Size = new System.Drawing.Size(100, 20);
            this.latvLeir.TabIndex = 5;
            // 
            // num_latvAr
            // 
            this.num_latvAr.Location = new System.Drawing.Point(53, 72);
            this.num_latvAr.Name = "num_latvAr";
            this.num_latvAr.Size = new System.Drawing.Size(101, 20);
            this.num_latvAr.TabIndex = 6;
            // 
            // latv_varosBox
            // 
            this.latv_varosBox.FormattingEnabled = true;
            this.latv_varosBox.Location = new System.Drawing.Point(160, 20);
            this.latv_varosBox.Name = "latv_varosBox";
            this.latv_varosBox.Size = new System.Drawing.Size(126, 147);
            this.latv_varosBox.TabIndex = 7;
            // 
            // latvBox
            // 
            this.latvBox.FormattingEnabled = true;
            this.latvBox.Location = new System.Drawing.Point(9, 19);
            this.latvBox.Name = "latvBox";
            this.latvBox.Size = new System.Drawing.Size(189, 264);
            this.latvBox.TabIndex = 4;
            // 
            // btn_latvDel
            // 
            this.btn_latvDel.Location = new System.Drawing.Point(123, 289);
            this.btn_latvDel.Name = "btn_latvDel";
            this.btn_latvDel.Size = new System.Drawing.Size(75, 23);
            this.btn_latvDel.TabIndex = 6;
            this.btn_latvDel.Text = "Törlés";
            this.btn_latvDel.UseVisualStyleBackColor = true;
            this.btn_latvDel.Click += new System.EventHandler(this.btn_latvDel_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_latvUpdate);
            this.groupBox3.Controls.Add(this.latvBox);
            this.groupBox3.Controls.Add(this.btn_latvDel);
            this.groupBox3.Location = new System.Drawing.Point(217, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(208, 323);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Látványosságok";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btn_varosUpdate);
            this.groupBox4.Controls.Add(this.varosBox);
            this.groupBox4.Controls.Add(this.btn_varosTorol);
            this.groupBox4.Location = new System.Drawing.Point(12, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(184, 323);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Városok";
            // 
            // btn_varosUpdate
            // 
            this.btn_varosUpdate.Location = new System.Drawing.Point(7, 288);
            this.btn_varosUpdate.Name = "btn_varosUpdate";
            this.btn_varosUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_varosUpdate.TabIndex = 3;
            this.btn_varosUpdate.Text = "Modosítás";
            this.btn_varosUpdate.UseVisualStyleBackColor = true;
            this.btn_varosUpdate.Click += new System.EventHandler(this.btn_varosUpdate_Click);
            // 
            // btn_latvUpdate
            // 
            this.btn_latvUpdate.Location = new System.Drawing.Point(9, 289);
            this.btn_latvUpdate.Name = "btn_latvUpdate";
            this.btn_latvUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_latvUpdate.TabIndex = 7;
            this.btn_latvUpdate.Text = "Modosítás";
            this.btn_latvUpdate.UseVisualStyleBackColor = true;
            this.btn_latvUpdate.Click += new System.EventHandler(this.btn_latvUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 477);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_varosLak)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_latvAr)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox varosNev;
        private System.Windows.Forms.Label txt_varosLak;
        private System.Windows.Forms.Label txt_varosNev;
        private System.Windows.Forms.ListBox varosBox;
        private System.Windows.Forms.Button btn_varosAdd;
        private System.Windows.Forms.Button btn_varosTorol;
        private System.Windows.Forms.NumericUpDown num_varosLak;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown num_latvAr;
        private System.Windows.Forms.TextBox latvLeir;
        private System.Windows.Forms.TextBox latvNev;
        private System.Windows.Forms.Button btn_LatvAdd;
        private System.Windows.Forms.ListBox latv_varosBox;
        private System.Windows.Forms.ListBox latvBox;
        private System.Windows.Forms.Button btn_latvDel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btn_latvUpdate;
        private System.Windows.Forms.Button btn_varosUpdate;
    }
}

