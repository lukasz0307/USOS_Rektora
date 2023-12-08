namespace USOS_Rektora.userControls
{
    partial class Kalendarz
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
            iconButtonNast = new FontAwesome.Sharp.IconButton();
            iconButtonPop = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            miesiac = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            niedz = new Label();
            sob = new Label();
            pia = new Label();
            czw = new Label();
            wt = new Label();
            sr = new Label();
            panel10 = new Panel();
            pon = new Label();
            kalendarzKomponenty = new FlowLayoutPanel();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // iconButtonNast
            // 
            iconButtonNast.Anchor = AnchorStyles.None;
            iconButtonNast.Flip = FontAwesome.Sharp.FlipOrientation.Horizontal;
            iconButtonNast.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButtonNast.IconColor = Color.Black;
            iconButtonNast.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonNast.IconSize = 30;
            iconButtonNast.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonNast.Location = new Point(394, 6);
            iconButtonNast.Name = "iconButtonNast";
            iconButtonNast.Size = new Size(96, 35);
            iconButtonNast.TabIndex = 1;
            iconButtonNast.Text = "Następny";
            iconButtonNast.TextAlign = ContentAlignment.MiddleLeft;
            iconButtonNast.UseVisualStyleBackColor = true;
            iconButtonNast.Click += iconButtonNast_Click;
            // 
            // iconButtonPop
            // 
            iconButtonPop.Anchor = AnchorStyles.None;
            iconButtonPop.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButtonPop.IconColor = Color.Black;
            iconButtonPop.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonPop.IconSize = 30;
            iconButtonPop.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPop.Location = new Point(292, 6);
            iconButtonPop.Name = "iconButtonPop";
            iconButtonPop.Size = new Size(96, 35);
            iconButtonPop.TabIndex = 2;
            iconButtonPop.Text = "Poprzedni";
            iconButtonPop.TextAlign = ContentAlignment.MiddleRight;
            iconButtonPop.UseVisualStyleBackColor = true;
            iconButtonPop.Click += iconButtonPop_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(miesiac);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(784, 38);
            panel1.TabIndex = 3;
            // 
            // miesiac
            // 
            miesiac.BackColor = Color.Gray;
            miesiac.Dock = DockStyle.Fill;
            miesiac.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            miesiac.ForeColor = Color.White;
            miesiac.Location = new Point(0, 0);
            miesiac.Margin = new Padding(0);
            miesiac.Name = "miesiac";
            miesiac.Size = new Size(784, 38);
            miesiac.TabIndex = 4;
            miesiac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(kalendarzKomponenty);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 38);
            panel2.Name = "panel2";
            panel2.Size = new Size(784, 275);
            panel2.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Gray;
            panel4.Controls.Add(niedz);
            panel4.Controls.Add(sob);
            panel4.Controls.Add(pia);
            panel4.Controls.Add(czw);
            panel4.Controls.Add(wt);
            panel4.Controls.Add(sr);
            panel4.Controls.Add(panel10);
            panel4.Controls.Add(pon);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(0);
            panel4.Name = "panel4";
            panel4.Size = new Size(784, 38);
            panel4.TabIndex = 7;
            // 
            // niedz
            // 
            niedz.BackColor = Color.Gray;
            niedz.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            niedz.ForeColor = Color.White;
            niedz.Location = new Point(672, 0);
            niedz.Margin = new Padding(0);
            niedz.Name = "niedz";
            niedz.Size = new Size(112, 38);
            niedz.TabIndex = 7;
            niedz.Text = "Niedziela";
            niedz.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sob
            // 
            sob.BackColor = Color.Gray;
            sob.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sob.ForeColor = Color.White;
            sob.Location = new Point(560, 0);
            sob.Margin = new Padding(0);
            sob.Name = "sob";
            sob.Size = new Size(112, 38);
            sob.TabIndex = 6;
            sob.Text = "Sobota";
            sob.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pia
            // 
            pia.BackColor = Color.Gray;
            pia.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pia.ForeColor = Color.White;
            pia.Location = new Point(448, 0);
            pia.Margin = new Padding(0);
            pia.Name = "pia";
            pia.Size = new Size(112, 38);
            pia.TabIndex = 5;
            pia.Text = "Piątek";
            pia.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // czw
            // 
            czw.BackColor = Color.Gray;
            czw.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            czw.ForeColor = Color.White;
            czw.Location = new Point(336, 0);
            czw.Margin = new Padding(0);
            czw.Name = "czw";
            czw.Size = new Size(112, 38);
            czw.TabIndex = 4;
            czw.Text = "Czwartek";
            czw.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wt
            // 
            wt.BackColor = Color.Gray;
            wt.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            wt.ForeColor = Color.White;
            wt.Location = new Point(112, 0);
            wt.Margin = new Padding(0);
            wt.Name = "wt";
            wt.Size = new Size(112, 38);
            wt.TabIndex = 3;
            wt.Text = "Wtorek";
            wt.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // sr
            // 
            sr.BackColor = Color.Gray;
            sr.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            sr.ForeColor = Color.White;
            sr.Location = new Point(224, 0);
            sr.Margin = new Padding(0);
            sr.Name = "sr";
            sr.Size = new Size(112, 38);
            sr.TabIndex = 2;
            sr.Text = "Środa";
            sr.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Location = new Point(460, 36);
            panel10.Margin = new Padding(0);
            panel10.Name = "panel10";
            panel10.Size = new Size(92, 35);
            panel10.TabIndex = 1;
            // 
            // pon
            // 
            pon.BackColor = Color.Gray;
            pon.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            pon.ForeColor = Color.White;
            pon.Location = new Point(0, 0);
            pon.Margin = new Padding(0);
            pon.Name = "pon";
            pon.Size = new Size(112, 38);
            pon.TabIndex = 0;
            pon.Text = "Poniedziałek";
            pon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // kalendarzKomponenty
            // 
            kalendarzKomponenty.BackColor = Color.FromArgb(224, 224, 224);
            kalendarzKomponenty.Location = new Point(0, 36);
            kalendarzKomponenty.Name = "kalendarzKomponenty";
            kalendarzKomponenty.Size = new Size(784, 239);
            kalendarzKomponenty.TabIndex = 6;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Gray;
            panel3.Controls.Add(iconButtonNast);
            panel3.Controls.Add(iconButtonPop);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 313);
            panel3.Name = "panel3";
            panel3.Size = new Size(784, 49);
            panel3.TabIndex = 5;
            // 
            // Kalendarz
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Kalendarz";
            Size = new Size(784, 362);
            Load += Kalendarz_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private FontAwesome.Sharp.IconButton iconButtonNast;
        private FontAwesome.Sharp.IconButton iconButtonPop;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Label pon;
        private Label miesiac;
        private FlowLayoutPanel kalendarzKomponenty;
        private Panel panel4;
        private Label pia;
        private Label czw;
        private Label wt;
        private Label sr;
        private Panel panel10;
        private Label niedz;
        private Label sob;
    }
}
