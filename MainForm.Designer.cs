namespace CodeeloSR
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.codeeloTextBox1 = new CodeeloUI.Controls.CodeeloTextBox();
            this.codeeloGradientPanel1 = new CodeeloUI.Controls.CodeeloGradientPanel();
            this.codeeloFormDrag1 = new CodeeloUI.Components.CodeeloFormDrag(this.components);
            this.codeeloPictureBox1 = new CodeeloUI.Controls.CodeeloPictureBox();
            this.codeeloToggleButton1 = new CodeeloUI.Controls.CodeeloToggleButton();
            this.codeeloGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.codeeloPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // codeeloTextBox1
            // 
            this.codeeloTextBox1.BackColor = System.Drawing.Color.White;
            this.codeeloTextBox1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.codeeloTextBox1.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.codeeloTextBox1.BorderSize = 2;
            this.codeeloTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.codeeloTextBox1.Location = new System.Drawing.Point(293, 52);
            this.codeeloTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.codeeloTextBox1.Multiline = true;
            this.codeeloTextBox1.Name = "codeeloTextBox1";
            this.codeeloTextBox1.Padding = new System.Windows.Forms.Padding(7);
            this.codeeloTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.codeeloTextBox1.PlaceholderText = "";
            this.codeeloTextBox1.Size = new System.Drawing.Size(467, 270);
            this.codeeloTextBox1.TabIndex = 0;
            this.codeeloTextBox1.UnderlinedStyle = false;
            this.codeeloTextBox1.UsePasswordChar = false;
            // 
            // codeeloGradientPanel1
            // 
            this.codeeloGradientPanel1.AccessibleRole = null;
            this.codeeloGradientPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloGradientPanel1.CausesValidation = false;
            this.codeeloGradientPanel1.ColorFillFirst = System.Drawing.Color.FloralWhite;
            this.codeeloGradientPanel1.ColorFillSecond = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(152)))), ((int)(((byte)(255)))));
            this.codeeloGradientPanel1.Controls.Add(this.codeeloToggleButton1);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloPictureBox1);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloTextBox1);
            this.codeeloGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.codeeloGradientPanel1.DrawGradient = true;
            this.codeeloGradientPanel1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.codeeloGradientPanel1.Name = "codeeloGradientPanel1";
            this.codeeloGradientPanel1.Size = new System.Drawing.Size(804, 389);
            this.codeeloGradientPanel1.TabIndex = 1;
            // 
            // codeeloFormDrag1
            // 
            this.codeeloFormDrag1.SourceControl = this.codeeloGradientPanel1;
            // 
            // codeeloPictureBox1
            // 
            this.codeeloPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloPictureBox1.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Round;
            this.codeeloPictureBox1.BorderColorFirst = System.Drawing.Color.RoyalBlue;
            this.codeeloPictureBox1.BorderColorSecond = System.Drawing.Color.FloralWhite;
            this.codeeloPictureBox1.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.codeeloPictureBox1.BorderSize = 4;
            this.codeeloPictureBox1.DrawBorder = true;
            this.codeeloPictureBox1.DrawBorderInside = false;
            this.codeeloPictureBox1.DrawCircle = true;
            this.codeeloPictureBox1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("codeeloPictureBox1.Image")));
            this.codeeloPictureBox1.Location = new System.Drawing.Point(63, 52);
            this.codeeloPictureBox1.Name = "codeeloPictureBox1";
            this.codeeloPictureBox1.Size = new System.Drawing.Size(223, 223);
            this.codeeloPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.codeeloPictureBox1.TabIndex = 1;
            this.codeeloPictureBox1.TabStop = false;
            this.codeeloPictureBox1.UseGradient = true;
            // 
            // codeeloToggleButton1
            // 
            this.codeeloToggleButton1.AreaColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.codeeloToggleButton1.AreaColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(220)))), ((int)(((byte)(95)))));
            this.codeeloToggleButton1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloToggleButton1.DrawCircle = true;
            this.codeeloToggleButton1.Location = new System.Drawing.Point(136, 285);
            this.codeeloToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.codeeloToggleButton1.Name = "codeeloToggleButton1";
            this.codeeloToggleButton1.Size = new System.Drawing.Size(80, 37);
            this.codeeloToggleButton1.TabIndex = 2;
            this.codeeloToggleButton1.ToggleColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.codeeloToggleButton1.ToggleColorChecked = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.codeeloToggleButton1.UseTransparentBackColor = false;
            this.codeeloToggleButton1.UseVisualStyleBackColor = false;
            this.codeeloToggleButton1.CheckedChanged += new System.EventHandler(this.codeeloToggleButton1_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 389);
            this.Controls.Add(this.codeeloGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.codeeloGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.codeeloPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CodeeloUI.Controls.CodeeloTextBox codeeloTextBox1;
        private CodeeloUI.Controls.CodeeloGradientPanel codeeloGradientPanel1;
        private CodeeloUI.Controls.CodeeloToggleButton codeeloToggleButton1;
        private CodeeloUI.Controls.CodeeloPictureBox codeeloPictureBox1;
        private CodeeloUI.Components.CodeeloFormDrag codeeloFormDrag1;
    }
}

