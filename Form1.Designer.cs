namespace integrall
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.verh = new System.Windows.Forms.TextBox();
            this.niz = new System.Windows.Forms.TextBox();
            this.epsil = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.function = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.прямоугльникToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.трапецияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.симпсонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.построитьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // verh
            // 
            resources.ApplyResources(this.verh, "verh");
            this.verh.Name = "verh";
            this.verh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verh_KeyPress);
            // 
            // niz
            // 
            resources.ApplyResources(this.niz, "niz");
            this.niz.Name = "niz";
            this.niz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verh_KeyPress);
            // 
            // epsil
            // 
            resources.ApplyResources(this.epsil, "epsil");
            this.epsil.Name = "epsil";
            this.epsil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.verh_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // zedGraph
            // 
            resources.ApplyResources(this.zedGraph, "zedGraph");
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            // 
            // function
            // 
            resources.ApplyResources(this.function, "function");
            this.function.Name = "function";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.прямоугльникToolStripMenuItem,
            this.трапецияToolStripMenuItem,
            this.симпсонToolStripMenuItem,
            this.построитьГрафикToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // прямоугльникToolStripMenuItem
            // 
            this.прямоугльникToolStripMenuItem.Name = "прямоугльникToolStripMenuItem";
            resources.ApplyResources(this.прямоугльникToolStripMenuItem, "прямоугльникToolStripMenuItem");
            this.прямоугльникToolStripMenuItem.Click += new System.EventHandler(this.прямоугльникToolStripMenuItem_Click);
            // 
            // трапецияToolStripMenuItem
            // 
            this.трапецияToolStripMenuItem.Name = "трапецияToolStripMenuItem";
            resources.ApplyResources(this.трапецияToolStripMenuItem, "трапецияToolStripMenuItem");
            this.трапецияToolStripMenuItem.Click += new System.EventHandler(this.трапецияToolStripMenuItem_Click);
            // 
            // симпсонToolStripMenuItem
            // 
            this.симпсонToolStripMenuItem.Name = "симпсонToolStripMenuItem";
            resources.ApplyResources(this.симпсонToolStripMenuItem, "симпсонToolStripMenuItem");
            this.симпсонToolStripMenuItem.Click += new System.EventHandler(this.симпсонToolStripMenuItem_Click);
            // 
            // построитьГрафикToolStripMenuItem
            // 
            this.построитьГрафикToolStripMenuItem.Name = "построитьГрафикToolStripMenuItem";
            resources.ApplyResources(this.построитьГрафикToolStripMenuItem, "построитьГрафикToolStripMenuItem");
            this.построитьГрафикToolStripMenuItem.Click += new System.EventHandler(this.построитьГрафикToolStripMenuItem_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList1, "imageList1");
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.function);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.epsil);
            this.Controls.Add(this.niz);
            this.Controls.Add(this.verh);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox verh;
        private System.Windows.Forms.TextBox niz;
        private System.Windows.Forms.TextBox epsil;
        private System.Windows.Forms.Label label4;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.TextBox function;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem прямоугльникToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem трапецияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem симпсонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem построитьГрафикToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

