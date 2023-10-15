namespace Analizador_Lexico__Traductor_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Menu = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem1 = new ToolStripMenuItem();
            traducirToolStripMenuItem = new ToolStripMenuItem();
            limpiarToolStripMenuItem = new ToolStripMenuItem();
            TBCode = new TextBox();
            DGSintaxis = new DataGridView();
            DGErrores = new DataGridView();
            pictureBox1 = new PictureBox();
            textBox2 = new TextBox();
            Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGErrores).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Menu
            // 
            Menu.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Menu.ImageScalingSize = new Size(24, 24);
            Menu.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, traducirToolStripMenuItem, limpiarToolStripMenuItem });
            Menu.Location = new Point(0, 0);
            Menu.Name = "Menu";
            Menu.Padding = new Padding(11, 4, 0, 4);
            Menu.Size = new Size(1433, 40);
            Menu.TabIndex = 2;
            Menu.Text = "Menu";
            Menu.ItemClicked += Menu_ItemClicked;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { abrirToolStripMenuItem1 });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(95, 32);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem1
            // 
            abrirToolStripMenuItem1.Name = "abrirToolStripMenuItem1";
            abrirToolStripMenuItem1.Size = new Size(270, 36);
            abrirToolStripMenuItem1.Text = "Abrir";
            abrirToolStripMenuItem1.Click += abrirToolStripMenuItem1_Click;
            // 
            // traducirToolStripMenuItem
            // 
            traducirToolStripMenuItem.Name = "traducirToolStripMenuItem";
            traducirToolStripMenuItem.Size = new Size(98, 32);
            traducirToolStripMenuItem.Text = "Analizar";
            traducirToolStripMenuItem.Click += traducirToolStripMenuItem_Click;
            // 
            // limpiarToolStripMenuItem
            // 
            limpiarToolStripMenuItem.Name = "limpiarToolStripMenuItem";
            limpiarToolStripMenuItem.Size = new Size(93, 32);
            limpiarToolStripMenuItem.Text = "Limpiar";
            limpiarToolStripMenuItem.Click += limpiarToolStripMenuItem_Click;
            // 
            // TBCode
            // 
            TBCode.BackColor = Color.FromArgb(243, 243, 243);
            TBCode.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            TBCode.Location = new Point(20, 205);
            TBCode.Margin = new Padding(5, 6, 5, 6);
            TBCode.Multiline = true;
            TBCode.Name = "TBCode";
            TBCode.PlaceholderText = "Escribe el código aquí. . .";
            TBCode.Size = new Size(1095, 287);
            TBCode.TabIndex = 3;
            TBCode.TextChanged += TBCode_TextChanged;
            // 
            // DGSintaxis
            // 
            DGSintaxis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGSintaxis.BackgroundColor = Color.Gainsboro;
            DGSintaxis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGSintaxis.Location = new Point(20, 532);
            DGSintaxis.Margin = new Padding(5, 6, 5, 6);
            DGSintaxis.Name = "DGSintaxis";
            DGSintaxis.RowHeadersWidth = 62;
            DGSintaxis.RowTemplate.Height = 25;
            DGSintaxis.Size = new Size(573, 746);
            DGSintaxis.TabIndex = 4;
            // 
            // DGErrores
            // 
            DGErrores.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGErrores.BackgroundColor = Color.Gainsboro;
            DGErrores.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGErrores.Location = new Point(624, 532);
            DGErrores.Margin = new Padding(5, 6, 5, 6);
            DGErrores.Name = "DGErrores";
            DGErrores.RowHeadersWidth = 62;
            DGErrores.RowTemplate.Height = 25;
            DGErrores.Size = new Size(788, 746);
            DGErrores.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1175, 43);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(226, 303);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(222, 53, 76);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 35F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(423, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(384, 94);
            textBox2.TabIndex = 8;
            textBox2.Text = "Analizador";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 53, 76);
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1433, 1050);
            Controls.Add(textBox2);
            Controls.Add(pictureBox1);
            Controls.Add(DGErrores);
            Controls.Add(DGSintaxis);
            Controls.Add(TBCode);
            Controls.Add(Menu);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = Menu;
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Analizador Sintactico";
            Load += Form1_Load;
            Menu.ResumeLayout(false);
            Menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGSintaxis).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGErrores).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip Menu;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem1;
        private ToolStripMenuItem traducirToolStripMenuItem;
        private ToolStripMenuItem limpiarToolStripMenuItem;
        private TextBox TBCode;
        private DataGridView DGSintaxis;
        private DataGridView DGErrores;
        private PictureBox pictureBox1;
        private TextBox textBox2;
    }
}