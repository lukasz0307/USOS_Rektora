namespace USOS_Rektora
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            panelNawigacja = new Panel();
            iconButtonogloszenia = new FontAwesome.Sharp.IconButton();
            iconButtonKalendarz = new FontAwesome.Sharp.IconButton();
            iconButtonUczniowie = new FontAwesome.Sharp.IconButton();
            menuUczniowie = new ContextMenuStrip(components);
            ocenyToolStripMenuItem = new ToolStripMenuItem();
            frekwencjaToolStripMenuItem = new ToolStripMenuItem();
            płatnościToolStripMenuItem = new ToolStripMenuItem();
            iconButtonWyloguj = new FontAwesome.Sharp.IconButton();
            iconButtonKadra = new FontAwesome.Sharp.IconButton();
            menuKadra = new ContextMenuStrip(components);
            kontaktToolStripMenuItem = new ToolStripMenuItem();
            kontaktToolStripMenuItem1 = new ToolStripMenuItem();
            iconButtonWydzialy = new FontAwesome.Sharp.IconButton();
            menuWydzialy = new ContextMenuStrip(components);
            MenuItemKierunki = new ToolStripMenuItem();
            menuItemNawigacyjny = new ToolStripMenuItem();
            menuItemElektryczny = new ToolStripMenuItem();
            mechanicznyToolStripMenuItem = new ToolStripMenuItem();
            zarządzaniaINaukOJakościToolStripMenuItem = new ToolStripMenuItem();
            działArmatorskiToolStripMenuItem = new ToolStripMenuItem();
            pictureBox1 = new PictureBox();
            panelBanera = new Panel();
            labelTytulu = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panelBar = new Panel();
            iconButtonMin = new FontAwesome.Sharp.IconButton();
            iconButtonMaks = new FontAwesome.Sharp.IconButton();
            iconButtonZamknij = new FontAwesome.Sharp.IconButton();
            panelUserControl = new Panel();
            panelNawigacja.SuspendLayout();
            menuUczniowie.SuspendLayout();
            menuKadra.SuspendLayout();
            menuWydzialy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelBanera.SuspendLayout();
            panelBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelNawigacja
            // 
            panelNawigacja.BackColor = Color.FromArgb(64, 64, 64);
            panelNawigacja.Controls.Add(iconButtonogloszenia);
            panelNawigacja.Controls.Add(iconButtonKalendarz);
            panelNawigacja.Controls.Add(iconButtonUczniowie);
            panelNawigacja.Controls.Add(iconButtonWyloguj);
            panelNawigacja.Controls.Add(iconButtonKadra);
            panelNawigacja.Controls.Add(iconButtonWydzialy);
            panelNawigacja.Controls.Add(pictureBox1);
            panelNawigacja.Dock = DockStyle.Left;
            panelNawigacja.Location = new Point(0, 35);
            panelNawigacja.Name = "panelNawigacja";
            panelNawigacja.Size = new Size(250, 618);
            panelNawigacja.TabIndex = 0;
            // 
            // iconButtonogloszenia
            // 
            iconButtonogloszenia.Dock = DockStyle.Top;
            iconButtonogloszenia.FlatAppearance.BorderSize = 0;
            iconButtonogloszenia.FlatStyle = FlatStyle.Flat;
            iconButtonogloszenia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonogloszenia.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonogloszenia.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButtonogloszenia.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonogloszenia.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonogloszenia.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonogloszenia.Location = new Point(0, 363);
            iconButtonogloszenia.Margin = new Padding(0);
            iconButtonogloszenia.Name = "iconButtonogloszenia";
            iconButtonogloszenia.Size = new Size(250, 60);
            iconButtonogloszenia.TabIndex = 5;
            iconButtonogloszenia.Text = "Ogłoszenia";
            iconButtonogloszenia.UseVisualStyleBackColor = true;
            // 
            // iconButtonKalendarz
            // 
            iconButtonKalendarz.Dock = DockStyle.Top;
            iconButtonKalendarz.FlatAppearance.BorderSize = 0;
            iconButtonKalendarz.FlatStyle = FlatStyle.Flat;
            iconButtonKalendarz.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonKalendarz.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonKalendarz.IconChar = FontAwesome.Sharp.IconChar.CalendarDays;
            iconButtonKalendarz.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonKalendarz.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKalendarz.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKalendarz.Location = new Point(0, 303);
            iconButtonKalendarz.Margin = new Padding(0);
            iconButtonKalendarz.Name = "iconButtonKalendarz";
            iconButtonKalendarz.Size = new Size(250, 60);
            iconButtonKalendarz.TabIndex = 4;
            iconButtonKalendarz.Text = "Kalendarz";
            iconButtonKalendarz.UseVisualStyleBackColor = true;
            // 
            // iconButtonUczniowie
            // 
            iconButtonUczniowie.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonUczniowie.ContextMenuStrip = menuUczniowie;
            iconButtonUczniowie.Dock = DockStyle.Top;
            iconButtonUczniowie.FlatAppearance.BorderSize = 0;
            iconButtonUczniowie.FlatStyle = FlatStyle.Flat;
            iconButtonUczniowie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonUczniowie.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonUczniowie.IconChar = FontAwesome.Sharp.IconChar.GraduationCap;
            iconButtonUczniowie.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonUczniowie.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonUczniowie.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonUczniowie.Location = new Point(0, 243);
            iconButtonUczniowie.Margin = new Padding(0);
            iconButtonUczniowie.Name = "iconButtonUczniowie";
            iconButtonUczniowie.Size = new Size(250, 60);
            iconButtonUczniowie.TabIndex = 3;
            iconButtonUczniowie.Text = "Uczniowie";
            iconButtonUczniowie.UseVisualStyleBackColor = false;
            iconButtonUczniowie.Click += iconButtonUczniowie_Click;
            // 
            // menuUczniowie
            // 
            menuUczniowie.BackColor = Color.Gray;
            menuUczniowie.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuUczniowie.ImageScalingSize = new Size(20, 20);
            menuUczniowie.Items.AddRange(new ToolStripItem[] { ocenyToolStripMenuItem, frekwencjaToolStripMenuItem, płatnościToolStripMenuItem });
            menuUczniowie.Name = "menuUczniowie";
            menuUczniowie.Size = new Size(202, 112);
            // 
            // ocenyToolStripMenuItem
            // 
            ocenyToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            ocenyToolStripMenuItem.Name = "ocenyToolStripMenuItem";
            ocenyToolStripMenuItem.Size = new Size(201, 36);
            ocenyToolStripMenuItem.Text = "Oceny";
            // 
            // frekwencjaToolStripMenuItem
            // 
            frekwencjaToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            frekwencjaToolStripMenuItem.Name = "frekwencjaToolStripMenuItem";
            frekwencjaToolStripMenuItem.Size = new Size(201, 36);
            frekwencjaToolStripMenuItem.Text = "Frekwencja";
            // 
            // płatnościToolStripMenuItem
            // 
            płatnościToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            płatnościToolStripMenuItem.Name = "płatnościToolStripMenuItem";
            płatnościToolStripMenuItem.Size = new Size(201, 36);
            płatnościToolStripMenuItem.Text = "Płatności";
            // 
            // iconButtonWyloguj
            // 
            iconButtonWyloguj.Dock = DockStyle.Bottom;
            iconButtonWyloguj.FlatAppearance.BorderSize = 0;
            iconButtonWyloguj.FlatStyle = FlatStyle.Flat;
            iconButtonWyloguj.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonWyloguj.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonWyloguj.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            iconButtonWyloguj.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonWyloguj.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonWyloguj.ImageAlign = ContentAlignment.MiddleRight;
            iconButtonWyloguj.Location = new Point(0, 562);
            iconButtonWyloguj.Margin = new Padding(3, 4, 3, 4);
            iconButtonWyloguj.Name = "iconButtonWyloguj";
            iconButtonWyloguj.Size = new Size(250, 56);
            iconButtonWyloguj.TabIndex = 2;
            iconButtonWyloguj.Text = "Wyloguj";
            iconButtonWyloguj.UseVisualStyleBackColor = true;
            iconButtonWyloguj.Click += iconButtonWyloguj_Click;
            // 
            // iconButtonKadra
            // 
            iconButtonKadra.ContextMenuStrip = menuKadra;
            iconButtonKadra.Dock = DockStyle.Top;
            iconButtonKadra.FlatAppearance.BorderSize = 0;
            iconButtonKadra.FlatStyle = FlatStyle.Flat;
            iconButtonKadra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonKadra.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonKadra.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            iconButtonKadra.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonKadra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonKadra.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonKadra.Location = new Point(0, 183);
            iconButtonKadra.Margin = new Padding(0);
            iconButtonKadra.Name = "iconButtonKadra";
            iconButtonKadra.Size = new Size(250, 60);
            iconButtonKadra.TabIndex = 1;
            iconButtonKadra.Text = "Kadra";
            iconButtonKadra.UseVisualStyleBackColor = true;
            iconButtonKadra.Click += iconButtonKadra_Click;
            // 
            // menuKadra
            // 
            menuKadra.BackColor = Color.Gray;
            menuKadra.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuKadra.ImageScalingSize = new Size(20, 20);
            menuKadra.Items.AddRange(new ToolStripItem[] { kontaktToolStripMenuItem, kontaktToolStripMenuItem1 });
            menuKadra.Name = "menuKadra";
            menuKadra.Size = new Size(166, 76);
            // 
            // kontaktToolStripMenuItem
            // 
            kontaktToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            kontaktToolStripMenuItem.Size = new Size(165, 36);
            kontaktToolStripMenuItem.Text = "Lista";
            // 
            // kontaktToolStripMenuItem1
            // 
            kontaktToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
            kontaktToolStripMenuItem1.Name = "kontaktToolStripMenuItem1";
            kontaktToolStripMenuItem1.Size = new Size(165, 36);
            kontaktToolStripMenuItem1.Text = "Kontakt";
            // 
            // iconButtonWydzialy
            // 
            iconButtonWydzialy.ContextMenuStrip = menuWydzialy;
            iconButtonWydzialy.Dock = DockStyle.Top;
            iconButtonWydzialy.FlatAppearance.BorderSize = 0;
            iconButtonWydzialy.FlatStyle = FlatStyle.Flat;
            iconButtonWydzialy.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonWydzialy.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonWydzialy.IconChar = FontAwesome.Sharp.IconChar.Landmark;
            iconButtonWydzialy.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonWydzialy.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonWydzialy.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonWydzialy.Location = new Point(0, 123);
            iconButtonWydzialy.Margin = new Padding(0);
            iconButtonWydzialy.Name = "iconButtonWydzialy";
            iconButtonWydzialy.Size = new Size(250, 60);
            iconButtonWydzialy.TabIndex = 0;
            iconButtonWydzialy.Text = "Wydziały";
            iconButtonWydzialy.UseVisualStyleBackColor = true;
            iconButtonWydzialy.Click += iconButtonWydzialy_Click;
            // 
            // menuWydzialy
            // 
            menuWydzialy.BackColor = Color.Gray;
            menuWydzialy.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            menuWydzialy.ImageScalingSize = new Size(20, 20);
            menuWydzialy.Items.AddRange(new ToolStripItem[] { MenuItemKierunki });
            menuWydzialy.Name = "contextMenuStripWydzialy";
            menuWydzialy.Size = new Size(171, 40);
            // 
            // MenuItemKierunki
            // 
            MenuItemKierunki.BackColor = Color.Gray;
            MenuItemKierunki.DropDownItems.AddRange(new ToolStripItem[] { menuItemNawigacyjny, menuItemElektryczny, mechanicznyToolStripMenuItem, zarządzaniaINaukOJakościToolStripMenuItem, działArmatorskiToolStripMenuItem });
            MenuItemKierunki.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemKierunki.Name = "MenuItemKierunki";
            MenuItemKierunki.Size = new Size(170, 36);
            MenuItemKierunki.Text = "Kierunki";
            // 
            // menuItemNawigacyjny
            // 
            menuItemNawigacyjny.BackColor = SystemColors.ActiveBorder;
            menuItemNawigacyjny.ForeColor = Color.FromArgb(224, 224, 224);
            menuItemNawigacyjny.Name = "menuItemNawigacyjny";
            menuItemNawigacyjny.Size = new Size(385, 36);
            menuItemNawigacyjny.Text = "Nawigacyjny";
            // 
            // menuItemElektryczny
            // 
            menuItemElektryczny.BackColor = SystemColors.ActiveBorder;
            menuItemElektryczny.ForeColor = Color.FromArgb(224, 224, 224);
            menuItemElektryczny.Name = "menuItemElektryczny";
            menuItemElektryczny.Size = new Size(385, 36);
            menuItemElektryczny.Text = "Elektryczny";
            // 
            // mechanicznyToolStripMenuItem
            // 
            mechanicznyToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            mechanicznyToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            mechanicznyToolStripMenuItem.Name = "mechanicznyToolStripMenuItem";
            mechanicznyToolStripMenuItem.Size = new Size(385, 36);
            mechanicznyToolStripMenuItem.Text = "Mechaniczny";
            // 
            // zarządzaniaINaukOJakościToolStripMenuItem
            // 
            zarządzaniaINaukOJakościToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            zarządzaniaINaukOJakościToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            zarządzaniaINaukOJakościToolStripMenuItem.Name = "zarządzaniaINaukOJakościToolStripMenuItem";
            zarządzaniaINaukOJakościToolStripMenuItem.Size = new Size(385, 36);
            zarządzaniaINaukOJakościToolStripMenuItem.Text = "Zarządzania i nauk o jakości";
            // 
            // działArmatorskiToolStripMenuItem
            // 
            działArmatorskiToolStripMenuItem.BackColor = SystemColors.ActiveBorder;
            działArmatorskiToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            działArmatorskiToolStripMenuItem.Name = "działArmatorskiToolStripMenuItem";
            działArmatorskiToolStripMenuItem.Size = new Size(385, 36);
            działArmatorskiToolStripMenuItem.Text = "Dział armatorski";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlLightLight;
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 123);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelBanera
            // 
            panelBanera.BackColor = Color.Navy;
            panelBanera.Controls.Add(labelTytulu);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(250, 35);
            panelBanera.Margin = new Padding(0);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(932, 123);
            panelBanera.TabIndex = 2;
            // 
            // labelTytulu
            // 
            labelTytulu.Anchor = AnchorStyles.None;
            labelTytulu.AutoSize = true;
            labelTytulu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTytulu.ForeColor = SystemColors.Control;
            labelTytulu.Location = new Point(386, 30);
            labelTytulu.Name = "labelTytulu";
            labelTytulu.Size = new Size(160, 62);
            labelTytulu.TabIndex = 0;
            labelTytulu.Text = "Home";
            // 
            // iconMenuItem1
            // 
            iconMenuItem1.BackColor = SystemColors.ActiveBorder;
            iconMenuItem1.IconChar = FontAwesome.Sharp.IconChar.Compass;
            iconMenuItem1.IconColor = Color.Black;
            iconMenuItem1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconMenuItem1.IconSize = 80;
            iconMenuItem1.Name = "iconMenuItem1";
            iconMenuItem1.Size = new Size(385, 36);
            iconMenuItem1.Text = "iconMenuItem1";
            // 
            // panelBar
            // 
            panelBar.BackColor = Color.FromArgb(64, 64, 64);
            panelBar.Controls.Add(iconButtonMin);
            panelBar.Controls.Add(iconButtonMaks);
            panelBar.Controls.Add(iconButtonZamknij);
            panelBar.Dock = DockStyle.Top;
            panelBar.Location = new Point(0, 0);
            panelBar.Margin = new Padding(0);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(1182, 35);
            panelBar.TabIndex = 4;
            panelBar.MouseDown += panelBar_MouseDown;
            // 
            // iconButtonMin
            // 
            iconButtonMin.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonMin.Dock = DockStyle.Right;
            iconButtonMin.FlatAppearance.BorderSize = 0;
            iconButtonMin.FlatStyle = FlatStyle.Flat;
            iconButtonMin.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            iconButtonMin.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonMin.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonMin.IconSize = 30;
            iconButtonMin.ImageAlign = ContentAlignment.BottomCenter;
            iconButtonMin.Location = new Point(1002, 0);
            iconButtonMin.Name = "iconButtonMin";
            iconButtonMin.Size = new Size(60, 35);
            iconButtonMin.TabIndex = 2;
            iconButtonMin.UseVisualStyleBackColor = false;
            iconButtonMin.Click += iconButtonMin_Click;
            // 
            // iconButtonMaks
            // 
            iconButtonMaks.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonMaks.Dock = DockStyle.Right;
            iconButtonMaks.FlatAppearance.BorderSize = 0;
            iconButtonMaks.FlatStyle = FlatStyle.Flat;
            iconButtonMaks.IconChar = FontAwesome.Sharp.IconChar.Square;
            iconButtonMaks.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonMaks.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonMaks.IconSize = 30;
            iconButtonMaks.ImageAlign = ContentAlignment.TopCenter;
            iconButtonMaks.Location = new Point(1062, 0);
            iconButtonMaks.Name = "iconButtonMaks";
            iconButtonMaks.Size = new Size(60, 35);
            iconButtonMaks.TabIndex = 1;
            iconButtonMaks.UseVisualStyleBackColor = false;
            iconButtonMaks.Click += iconButtonMaks_Click;
            // 
            // iconButtonZamknij
            // 
            iconButtonZamknij.BackColor = Color.FromArgb(64, 64, 64);
            iconButtonZamknij.Dock = DockStyle.Right;
            iconButtonZamknij.FlatAppearance.BorderSize = 0;
            iconButtonZamknij.FlatStyle = FlatStyle.Flat;
            iconButtonZamknij.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            iconButtonZamknij.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonZamknij.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonZamknij.IconSize = 30;
            iconButtonZamknij.ImageAlign = ContentAlignment.TopCenter;
            iconButtonZamknij.Location = new Point(1122, 0);
            iconButtonZamknij.Name = "iconButtonZamknij";
            iconButtonZamknij.Size = new Size(60, 35);
            iconButtonZamknij.TabIndex = 0;
            iconButtonZamknij.UseVisualStyleBackColor = false;
            iconButtonZamknij.Click += iconButtonZamknij_Click;
            // 
            // panelUserControl
            // 
            panelUserControl.Dock = DockStyle.Fill;
            panelUserControl.Location = new Point(250, 158);
            panelUserControl.Name = "panelUserControl";
            panelUserControl.Size = new Size(932, 495);
            panelUserControl.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            ControlBox = false;
            Controls.Add(panelUserControl);
            Controls.Add(panelBanera);
            Controls.Add(panelNawigacja);
            Controls.Add(panelBar);
            Name = "Form2";
            panelNawigacja.ResumeLayout(false);
            menuUczniowie.ResumeLayout(false);
            menuKadra.ResumeLayout(false);
            menuWydzialy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelBanera.ResumeLayout(false);
            panelBanera.PerformLayout();
            panelBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelNawigacja;
        private Panel panelBanera;
        private Label labelTytulu;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton iconButtonWydzialy;
        private FontAwesome.Sharp.IconButton iconButtonKadra;
        private ContextMenuStrip menuWydzialy;
        private ToolStripMenuItem MenuItemKierunki;
        private ToolStripMenuItem menuItemNawigacyjny;
        private ToolStripMenuItem menuItemElektryczny;
        private ToolStripMenuItem mechanicznyToolStripMenuItem;
        private ToolStripMenuItem zarządzaniaINaukOJakościToolStripMenuItem;
        private ToolStripMenuItem działArmatorskiToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButtonWyloguj;
        private ContextMenuStrip menuKadra;
        private ToolStripMenuItem kontaktToolStripMenuItem;
        private ToolStripMenuItem kontaktToolStripMenuItem1;
        private FontAwesome.Sharp.IconButton iconButtonUczniowie;
        private FontAwesome.Sharp.IconButton iconButtonogloszenia;
        private FontAwesome.Sharp.IconButton iconButtonKalendarz;
        private ContextMenuStrip menuUczniowie;
        private ToolStripMenuItem ocenyToolStripMenuItem;
        private ToolStripMenuItem frekwencjaToolStripMenuItem;
        private ToolStripMenuItem płatnościToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private FontAwesome.Sharp.IconButton iconButtonMaks;
        private FontAwesome.Sharp.IconButton iconButtonZamknij;
        private Panel panelUserControl;
    }
}