namespace USOS_Rektora.userControls
{
    partial class dzien
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
            components = new System.ComponentModel.Container();
            nrDay = new Label();
            Wydarzenie = new Label();
            timer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // nrDay
            // 
            nrDay.AutoSize = true;
            nrDay.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            nrDay.Location = new Point(3, 0);
            nrDay.Name = "nrDay";
            nrDay.Size = new Size(28, 23);
            nrDay.TabIndex = 0;
            nrDay.Text = "00";
            // 
            // Wydarzenie
            // 
            Wydarzenie.Dock = DockStyle.Bottom;
            Wydarzenie.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Wydarzenie.Location = new Point(0, 23);
            Wydarzenie.Margin = new Padding(0);
            Wydarzenie.Name = "Wydarzenie";
            Wydarzenie.Size = new Size(128, 40);
            Wydarzenie.TabIndex = 1;
            Wydarzenie.Click += Wydarzenie_Click;
            // 
            // timer
            // 
            timer.Tick += timer1_Tick;
            // 
            // dzien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(Wydarzenie);
            Controls.Add(nrDay);
            ForeColor = Color.Black;
            Margin = new Padding(0);
            Name = "dzien";
            Size = new Size(128, 63);
            Load += dzien_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nrDay;
        private Label Wydarzenie;
        private System.Windows.Forms.Timer timer;
    }
}
