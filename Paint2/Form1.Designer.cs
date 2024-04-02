namespace Paint2
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnLine = new System.Windows.Forms.Button();
            this.BtnRectangle = new System.Windows.Forms.Button();
            this.BtnElipse = new System.Windows.Forms.Button();
            this.BtnEraser = new System.Windows.Forms.Button();
            this.BtnPencil = new System.Windows.Forms.Button();
            this.BtnPaint = new System.Windows.Forms.Button();
            this.BtnColor = new System.Windows.Forms.Button();
            this.Pic = new System.Windows.Forms.PictureBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.btn_load);
            this.panel1.Controls.Add(this.BtnSave);
            this.panel1.Controls.Add(this.BtnClear);
            this.panel1.Controls.Add(this.BtnLine);
            this.panel1.Controls.Add(this.BtnRectangle);
            this.panel1.Controls.Add(this.BtnElipse);
            this.panel1.Controls.Add(this.BtnEraser);
            this.panel1.Controls.Add(this.BtnPencil);
            this.panel1.Controls.Add(this.BtnPaint);
            this.panel1.Controls.Add(this.BtnColor);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 86);
            this.panel1.TabIndex = 0;
            // 
            // BtnSave
            // 
            this.BtnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.Location = new System.Drawing.Point(702, 3);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(95, 38);
            this.BtnSave.TabIndex = 0;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.BtnClear.ForeColor = System.Drawing.Color.White;
            this.BtnClear.Location = new System.Drawing.Point(702, 45);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(95, 38);
            this.BtnClear.TabIndex = 0;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnLine
            // 
            this.BtnLine.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnLine.BackgroundImage")));
            this.BtnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnLine.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnLine.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLine.ForeColor = System.Drawing.Color.White;
            this.BtnLine.Location = new System.Drawing.Point(618, 3);
            this.BtnLine.Name = "BtnLine";
            this.BtnLine.Size = new System.Drawing.Size(78, 80);
            this.BtnLine.TabIndex = 0;
            this.BtnLine.UseVisualStyleBackColor = true;
            this.BtnLine.Click += new System.EventHandler(this.BtnLine_Click);
            // 
            // BtnRectangle
            // 
            this.BtnRectangle.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRectangle.BackgroundImage")));
            this.BtnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnRectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnRectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnRectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRectangle.ForeColor = System.Drawing.Color.White;
            this.BtnRectangle.Location = new System.Drawing.Point(534, 3);
            this.BtnRectangle.Name = "BtnRectangle";
            this.BtnRectangle.Size = new System.Drawing.Size(78, 80);
            this.BtnRectangle.TabIndex = 0;
            this.BtnRectangle.Text = "button1";
            this.BtnRectangle.UseVisualStyleBackColor = true;
            this.BtnRectangle.Click += new System.EventHandler(this.BtnRectangle_Click);
            // 
            // BtnElipse
            // 
            this.BtnElipse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnElipse.BackgroundImage")));
            this.BtnElipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnElipse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnElipse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnElipse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnElipse.ForeColor = System.Drawing.Color.White;
            this.BtnElipse.Location = new System.Drawing.Point(450, 3);
            this.BtnElipse.Name = "BtnElipse";
            this.BtnElipse.Size = new System.Drawing.Size(78, 80);
            this.BtnElipse.TabIndex = 0;
            this.BtnElipse.Text = "button1";
            this.BtnElipse.UseVisualStyleBackColor = true;
            this.BtnElipse.Click += new System.EventHandler(this.BtnElipse_Click);
            // 
            // BtnEraser
            // 
            this.BtnEraser.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnEraser.BackgroundImage")));
            this.BtnEraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEraser.ForeColor = System.Drawing.Color.White;
            this.BtnEraser.Location = new System.Drawing.Point(366, 3);
            this.BtnEraser.Name = "BtnEraser";
            this.BtnEraser.Size = new System.Drawing.Size(78, 80);
            this.BtnEraser.TabIndex = 0;
            this.BtnEraser.UseVisualStyleBackColor = true;
            this.BtnEraser.Click += new System.EventHandler(this.BtnEraser_Click);
            // 
            // BtnPencil
            // 
            this.BtnPencil.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPencil.BackgroundImage")));
            this.BtnPencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPencil.ForeColor = System.Drawing.Color.White;
            this.BtnPencil.Location = new System.Drawing.Point(282, 3);
            this.BtnPencil.Name = "BtnPencil";
            this.BtnPencil.Size = new System.Drawing.Size(78, 80);
            this.BtnPencil.TabIndex = 0;
            this.BtnPencil.UseVisualStyleBackColor = true;
            this.BtnPencil.Click += new System.EventHandler(this.BtnPencil_Click);
            // 
            // BtnPaint
            // 
            this.BtnPaint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPaint.BackgroundImage")));
            this.BtnPaint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnPaint.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnPaint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnPaint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPaint.ForeColor = System.Drawing.Color.White;
            this.BtnPaint.Location = new System.Drawing.Point(198, 3);
            this.BtnPaint.Name = "BtnPaint";
            this.BtnPaint.Size = new System.Drawing.Size(78, 80);
            this.BtnPaint.TabIndex = 0;
            this.BtnPaint.UseVisualStyleBackColor = true;
            this.BtnPaint.Click += new System.EventHandler(this.BtnPaint_Click);
            // 
            // BtnColor
            // 
            this.BtnColor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnColor.BackgroundImage")));
            this.BtnColor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BtnColor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnColor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Maroon;
            this.BtnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnColor.ForeColor = System.Drawing.Color.White;
            this.BtnColor.Location = new System.Drawing.Point(114, 3);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(78, 80);
            this.BtnColor.TabIndex = 0;
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Pic
            // 
            this.Pic.Location = new System.Drawing.Point(0, 89);
            this.Pic.Name = "Pic";
            this.Pic.Size = new System.Drawing.Size(800, 360);
            this.Pic.TabIndex = 1;
            this.Pic.TabStop = false;
            this.Pic.Paint += new System.Windows.Forms.PaintEventHandler(this.Pic_Paint);
            this.Pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseClick);
            this.Pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseDown);
            this.Pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseMove);
            this.Pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Pic_MouseUp);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(12, 3);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(96, 80);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Pic);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnColor;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnLine;
        private System.Windows.Forms.Button BtnRectangle;
        private System.Windows.Forms.Button BtnElipse;
        private System.Windows.Forms.Button BtnEraser;
        private System.Windows.Forms.Button BtnPencil;
        private System.Windows.Forms.Button BtnPaint;
        private System.Windows.Forms.PictureBox Pic;
        private System.Windows.Forms.Button btn_load;
    }
}

