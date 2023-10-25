namespace USOS_Rektora.userControls
{
    partial class UserControlZmianaHasla
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
            labelmail = new Label();
            textBoxMail = new TextBox();
            pictureBoxWeryfikacja = new PictureBox();
            labelWeryfikacja = new Label();
            textBoxWeryfikacja = new TextBox();
            buttonDalej = new Button();
            buttonWroc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeryfikacja).BeginInit();
            SuspendLayout();
            // 
            // labelmail
            // 
            labelmail.Anchor = AnchorStyles.None;
            labelmail.AutoSize = true;
            labelmail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelmail.Location = new Point(515, 134);
            labelmail.Name = "labelmail";
            labelmail.Size = new Size(173, 37);
            labelmail.TabIndex = 1;
            labelmail.Text = "Adres e-mail:";
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.None;
            textBoxMail.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(445, 175);
            textBoxMail.Margin = new Padding(3, 4, 3, 4);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(313, 42);
            textBoxMail.TabIndex = 0;
            // 
            // pictureBoxWeryfikacja
            // 
            pictureBoxWeryfikacja.Anchor = AnchorStyles.None;
            pictureBoxWeryfikacja.Location = new Point(266, 319);
            pictureBoxWeryfikacja.Name = "pictureBoxWeryfikacja";
            pictureBoxWeryfikacja.Size = new Size(140, 42);
            pictureBoxWeryfikacja.TabIndex = 2;
            pictureBoxWeryfikacja.TabStop = false;
            // 
            // labelWeryfikacja
            // 
            labelWeryfikacja.Anchor = AnchorStyles.None;
            labelWeryfikacja.AutoSize = true;
            labelWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelWeryfikacja.Location = new Point(352, 258);
            labelWeryfikacja.Name = "labelWeryfikacja";
            labelWeryfikacja.Size = new Size(535, 37);
            labelWeryfikacja.TabIndex = 1;
            labelWeryfikacja.Text = "Wpisz znaki , które widzisz na obrazku obok";
            // 
            // textBoxWeryfikacja
            // 
            textBoxWeryfikacja.Anchor = AnchorStyles.None;
            textBoxWeryfikacja.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxWeryfikacja.Location = new Point(445, 319);
            textBoxWeryfikacja.Margin = new Padding(3, 4, 3, 4);
            textBoxWeryfikacja.Name = "textBoxWeryfikacja";
            textBoxWeryfikacja.Size = new Size(313, 42);
            textBoxWeryfikacja.TabIndex = 8;
            // 
            // buttonDalej
            // 
            buttonDalej.Anchor = AnchorStyles.None;
            buttonDalej.Location = new Point(445, 408);
            buttonDalej.Name = "buttonDalej";
            buttonDalej.Size = new Size(111, 36);
            buttonDalej.TabIndex = 9;
            buttonDalej.Text = "Dalej";
            buttonDalej.UseVisualStyleBackColor = true;
            // 
            // buttonWroc
            // 
            buttonWroc.Anchor = AnchorStyles.None;
            buttonWroc.Location = new Point(662, 408);
            buttonWroc.Name = "buttonWroc";
            buttonWroc.Size = new Size(96, 36);
            buttonWroc.TabIndex = 10;
            buttonWroc.Text = "Wróć";
            buttonWroc.UseVisualStyleBackColor = true;
            // 
            // UserControlZmianaHasla
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonWroc);
            Controls.Add(buttonDalej);
            Controls.Add(labelmail);
            Controls.Add(textBoxMail);
            Controls.Add(textBoxWeryfikacja);
            Controls.Add(pictureBoxWeryfikacja);
            Controls.Add(labelWeryfikacja);
            Name = "UserControlZmianaHasla";
            Size = new Size(1182, 644);
            ((System.ComponentModel.ISupportInitialize)pictureBoxWeryfikacja).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelmail;
        private TextBox textBoxMail;
        private PictureBox pictureBoxWeryfikacja;
        private Label labelWeryfikacja;
        private TextBox textBoxWeryfikacja;
        private Button buttonDalej;
        private Button buttonWroc;
    }
}
