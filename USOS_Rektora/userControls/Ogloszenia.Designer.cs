namespace USOS_Rektora.userControls
{
    partial class Ogloszenia
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
            textBoxNaglowek = new TextBox();
            label1 = new Label();
            label2 = new Label();
            richTextBoxTresc = new RichTextBox();
            buttonDod = new Button();
            SuspendLayout();
            // 
            // textBoxNaglowek
            // 
            textBoxNaglowek.Anchor = AnchorStyles.None;
            textBoxNaglowek.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNaglowek.Location = new Point(308, 73);
            textBoxNaglowek.Margin = new Padding(308, 3, 308, 3);
            textBoxNaglowek.Name = "textBoxNaglowek";
            textBoxNaglowek.Size = new Size(280, 38);
            textBoxNaglowek.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(3, 31);
            label1.Name = "label1";
            label1.Size = new Size(890, 39);
            label1.TabIndex = 1;
            label1.Text = "Nagłówek ogłoszenia";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(3, 124);
            label2.Name = "label2";
            label2.Size = new Size(890, 39);
            label2.TabIndex = 2;
            label2.Text = "Treść ogłoszenia";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // richTextBoxTresc
            // 
            richTextBoxTresc.Anchor = AnchorStyles.None;
            richTextBoxTresc.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxTresc.Location = new Point(53, 166);
            richTextBoxTresc.Margin = new Padding(53, 3, 53, 3);
            richTextBoxTresc.Name = "richTextBoxTresc";
            richTextBoxTresc.Size = new Size(790, 220);
            richTextBoxTresc.TabIndex = 3;
            richTextBoxTresc.Text = "";
            // 
            // buttonDod
            // 
            buttonDod.Anchor = AnchorStyles.None;
            buttonDod.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDod.ForeColor = SystemColors.ControlText;
            buttonDod.Location = new Point(378, 413);
            buttonDod.Margin = new Padding(378, 3, 378, 3);
            buttonDod.Name = "buttonDod";
            buttonDod.Size = new Size(140, 46);
            buttonDod.TabIndex = 4;
            buttonDod.Text = "Dodaj";
            buttonDod.UseVisualStyleBackColor = true;
            buttonDod.Click += buttonDod_Click;
            // 
            // Ogloszenia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDod);
            Controls.Add(richTextBoxTresc);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxNaglowek);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Ogloszenia";
            Size = new Size(896, 482);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNaglowek;
        private Label label1;
        private Label label2;
        private RichTextBox richTextBoxTresc;
        private Button buttonDod;
    }
}
