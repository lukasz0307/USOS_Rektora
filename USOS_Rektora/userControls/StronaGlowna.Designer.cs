namespace USOS_Rektora.userControls
{
    partial class StronaGlowna
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

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            Slider = new Panel();
            trescOgl = new Label();
            naglowekOgl = new Label();
            poprz = new FontAwesome.Sharp.IconButton();
            nast = new FontAwesome.Sharp.IconButton();
            label1 = new Label();
            Slider.SuspendLayout();
            SuspendLayout();
            // 
            // Slider
            // 
            Slider.Anchor = AnchorStyles.None;
            Slider.Controls.Add(trescOgl);
            Slider.Controls.Add(naglowekOgl);
            Slider.Controls.Add(poprz);
            Slider.Controls.Add(nast);
            Slider.Location = new Point(3, 142);
            Slider.Margin = new Padding(3, 142, 3, 3);
            Slider.Name = "Slider";
            Slider.Size = new Size(890, 213);
            Slider.TabIndex = 1;
            // 
            // trescOgl
            // 
            trescOgl.Anchor = AnchorStyles.None;
            trescOgl.BackColor = Color.Silver;
            trescOgl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            trescOgl.ForeColor = Color.White;
            trescOgl.Location = new Point(56, 58);
            trescOgl.Margin = new Padding(0);
            trescOgl.Name = "trescOgl";
            trescOgl.Size = new Size(778, 155);
            trescOgl.TabIndex = 3;
            trescOgl.Text = "treść";
            // 
            // naglowekOgl
            // 
            naglowekOgl.Anchor = AnchorStyles.None;
            naglowekOgl.BackColor = Color.Gray;
            naglowekOgl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            naglowekOgl.ForeColor = Color.White;
            naglowekOgl.Location = new Point(56, 0);
            naglowekOgl.Margin = new Padding(0);
            naglowekOgl.Name = "naglowekOgl";
            naglowekOgl.Size = new Size(778, 58);
            naglowekOgl.TabIndex = 2;
            naglowekOgl.Text = "Nagłówek";
            naglowekOgl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // poprz
            // 
            poprz.BackColor = Color.Navy;
            poprz.Dock = DockStyle.Left;
            poprz.FlatStyle = FlatStyle.Flat;
            poprz.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            poprz.IconColor = Color.White;
            poprz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            poprz.IconSize = 50;
            poprz.Location = new Point(0, 0);
            poprz.Margin = new Padding(0);
            poprz.Name = "poprz";
            poprz.Size = new Size(56, 213);
            poprz.TabIndex = 1;
            poprz.UseVisualStyleBackColor = false;
            poprz.Click += poprz_Click;
            // 
            // nast
            // 
            nast.BackColor = Color.Navy;
            nast.Dock = DockStyle.Right;
            nast.FlatStyle = FlatStyle.Flat;
            nast.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleRight;
            nast.IconColor = Color.White;
            nast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            nast.IconSize = 50;
            nast.Location = new Point(834, 0);
            nast.Margin = new Padding(0);
            nast.Name = "nast";
            nast.Size = new Size(56, 213);
            nast.TabIndex = 0;
            nast.UseVisualStyleBackColor = false;
            nast.Click += nast_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 74);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(890, 44);
            label1.TabIndex = 2;
            label1.Text = "Ogłoszenia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // StronaGlowna
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(Slider);
            Name = "StronaGlowna";
            Size = new Size(896, 482);
            Load += StronaGlowna_Load;
            Slider.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel Slider;
        private Label trescOgl;
        private Label naglowekOgl;
        private FontAwesome.Sharp.IconButton poprz;
        private FontAwesome.Sharp.IconButton nast;
        private Label label1;
    }
}
