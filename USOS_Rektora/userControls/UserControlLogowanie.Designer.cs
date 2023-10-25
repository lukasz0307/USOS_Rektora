namespace USOS_Rektora.userControls
{
    partial class UserControlLogowanie
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
            labelLogin = new Label();
            textBoxLogin = new TextBox();
            labelHaslo = new Label();
            buttonprzypomnij = new Button();
            textBoxHaslo = new TextBox();
            buttonLogin = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.None;
            labelLogin.AutoSize = true;
            labelLogin.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelLogin.Location = new Point(543, 130);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(84, 37);
            labelLogin.TabIndex = 7;
            labelLogin.Text = "Login";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.None;
            textBoxLogin.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxLogin.Location = new Point(435, 170);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(313, 43);
            textBoxLogin.TabIndex = 6;
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // labelHaslo
            // 
            labelHaslo.Anchor = AnchorStyles.None;
            labelHaslo.AutoSize = true;
            labelHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHaslo.Location = new Point(543, 242);
            labelHaslo.Name = "labelHaslo";
            labelHaslo.Size = new Size(84, 37);
            labelHaslo.TabIndex = 9;
            labelHaslo.Text = "Hasło";
            // 
            // buttonprzypomnij
            // 
            buttonprzypomnij.Anchor = AnchorStyles.None;
            buttonprzypomnij.Location = new Point(579, 358);
            buttonprzypomnij.Margin = new Padding(3, 4, 3, 4);
            buttonprzypomnij.Name = "buttonprzypomnij";
            buttonprzypomnij.Size = new Size(217, 31);
            buttonprzypomnij.TabIndex = 11;
            buttonprzypomnij.Text = "ZMIEŃ/PRZYPOMNIJ HASŁO";
            buttonprzypomnij.UseVisualStyleBackColor = true;
            buttonprzypomnij.Click += buttonprzypomnij_Click;
            // 
            // textBoxHaslo
            // 
            textBoxHaslo.Anchor = AnchorStyles.None;
            textBoxHaslo.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxHaslo.Location = new Point(435, 283);
            textBoxHaslo.Margin = new Padding(3, 4, 3, 4);
            textBoxHaslo.Name = "textBoxHaslo";
            textBoxHaslo.Size = new Size(313, 42);
            textBoxHaslo.TabIndex = 8;
            // 
            // buttonLogin
            // 
            buttonLogin.Anchor = AnchorStyles.None;
            buttonLogin.Location = new Point(399, 358);
            buttonLogin.Margin = new Padding(3, 4, 3, 4);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(138, 31);
            buttonLogin.TabIndex = 10;
            buttonLogin.Text = "ZALOGUJ SIĘ";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // UserControlLogowanie
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(labelLogin);
            Controls.Add(textBoxLogin);
            Controls.Add(labelHaslo);
            Controls.Add(buttonprzypomnij);
            Controls.Add(textBoxHaslo);
            Controls.Add(buttonLogin);
            Name = "UserControlLogowanie";
            Size = new Size(1182, 518);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelLogin;
        private TextBox textBoxLogin;
        private Label labelHaslo;
        private Button buttonprzypomnij;
        private TextBox textBoxHaslo;
        private Button buttonLogin;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}
