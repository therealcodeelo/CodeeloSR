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
            this.codeeloToggleButton1 = new CodeeloUI.Controls.CodeeloToggleButton();
            this.codeeloPictureBox1 = new CodeeloUI.Controls.CodeeloPictureBox();
            this.codeeloFormDrag1 = new CodeeloUI.Components.CodeeloFormDrag(this.components);
            this.codeeloTextBox2 = new CodeeloUI.Controls.CodeeloTextBox();
            this.codeeloButton1 = new CodeeloUI.Controls.CodeeloButton();
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
            this.codeeloGradientPanel1.Controls.Add(this.codeeloButton1);
            this.codeeloGradientPanel1.Controls.Add(this.codeeloTextBox2);
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
            // codeeloFormDrag1
            // 
            this.codeeloFormDrag1.SourceControl = this.codeeloGradientPanel1;
            // 
            // codeeloTextBox2
            // 
            this.codeeloTextBox2.BackColor = System.Drawing.Color.White;
            this.codeeloTextBox2.BorderColor = System.Drawing.Color.DodgerBlue;
            this.codeeloTextBox2.BorderFocusColor = System.Drawing.Color.BlueViolet;
            this.codeeloTextBox2.BorderSize = 2;
            this.codeeloTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.codeeloTextBox2.Location = new System.Drawing.Point(293, 328);
            this.codeeloTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.codeeloTextBox2.Multiline = true;
            this.codeeloTextBox2.Name = "codeeloTextBox2";
            this.codeeloTextBox2.Padding = new System.Windows.Forms.Padding(7);
            this.codeeloTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.codeeloTextBox2.PlaceholderText = "";
            this.codeeloTextBox2.Size = new System.Drawing.Size(354, 35);
            this.codeeloTextBox2.TabIndex = 3;
            this.codeeloTextBox2.UnderlinedStyle = false;
            this.codeeloTextBox2.UsePasswordChar = false;
            // 
            // codeeloButton1
            // 
            this.codeeloButton1.AccessibleRole = null;
            this.codeeloButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.codeeloButton1.BackColor = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.BorderRadius = 10;
            this.codeeloButton1.BorderSize = 3;
            this.codeeloButton1.CausesValidation = false;
            this.codeeloButton1.ColorFill_1 = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(144)))), ((int)(((byte)(176)))));
            this.codeeloButton1.ColorFill_2 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(185)))), ((int)(((byte)(189)))));
            this.codeeloButton1.DialogResult = false;
            this.codeeloButton1.FlatAppearance.BorderSize = 0;
            this.codeeloButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.codeeloButton1.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.codeeloButton1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.codeeloButton1.GradientBorderDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloButton1.GradientDirection = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.codeeloButton1.Location = new System.Drawing.Point(654, 328);
            this.codeeloButton1.Name = "codeeloButton1";
            this.codeeloButton1.OnClick_BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnClick_BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnClick_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(184)))), ((int)(((byte)(216)))));
            this.codeeloButton1.OnClick_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(225)))), ((int)(((byte)(229)))));
            this.codeeloButton1.OnOver_BorderColor_1 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnOver_BorderColor_2 = System.Drawing.Color.Transparent;
            this.codeeloButton1.OnOver_FillColor_1 = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(164)))), ((int)(((byte)(196)))));
            this.codeeloButton1.OnOver_FillColor_2 = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(205)))), ((int)(((byte)(209)))));
            this.codeeloButton1.Size = new System.Drawing.Size(106, 37);
            this.codeeloButton1.TabIndex = 4;
            this.codeeloButton1.TabStop = false;
            this.codeeloButton1.Text = "Добавить +";
            this.codeeloButton1.TextAlign = CodeeloUI.Enums.TextPosition.Center;
            this.codeeloButton1.UseMnemonic = false;
            this.codeeloButton1.UseVisualStyleBackColor = false;
            this.codeeloButton1.Click += new System.EventHandler(this.codeeloButton1_Click);
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
        private CodeeloUI.Controls.CodeeloButton codeeloButton1;
        private CodeeloUI.Controls.CodeeloTextBox codeeloTextBox2;
    }
}

