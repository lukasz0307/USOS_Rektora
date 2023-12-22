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
            panelMenu = new Panel();
            iconButtonPlany = new FontAwesome.Sharp.IconButton();
            iconButtonOgloszenia = new FontAwesome.Sharp.IconButton();
            iconButtonKalendarz = new FontAwesome.Sharp.IconButton();
            iconButtonUczniowie = new FontAwesome.Sharp.IconButton();
            menuUczniowie = new ContextMenuStrip(components);
            listaToolStripMenuItem = new ToolStripMenuItem();
            ocenyToolStripMenuItem = new ToolStripMenuItem();
            iconButtonWyloguj = new FontAwesome.Sharp.IconButton();
            iconButtonKadra = new FontAwesome.Sharp.IconButton();
            iconButtonWydzialy = new FontAwesome.Sharp.IconButton();
            menuWydzialy = new ContextMenuStrip(components);
            MenuItemKierunki = new ToolStripMenuItem();
            elektrycznyToolStripMenuItem = new ToolStripMenuItem();
            mechanicznyToolStripMenuItem1 = new ToolStripMenuItem();
            zarządzaniaINaukOJakościToolStripMenuItem1 = new ToolStripMenuItem();
            działArmatorskiToolStripMenuItem1 = new ToolStripMenuItem();
            logo = new PictureBox();
            menuKadra = new ContextMenuStrip(components);
            kontaktToolStripMenuItem = new ToolStripMenuItem();
            kontaktToolStripMenuItem1 = new ToolStripMenuItem();
            panelBanera = new Panel();
            labelTytulu = new Label();
            iconMenuItem1 = new FontAwesome.Sharp.IconMenuItem();
            panelBar = new Panel();
            iconButtonMin = new FontAwesome.Sharp.IconButton();
            iconButtonMaks = new FontAwesome.Sharp.IconButton();
            iconButtonZamknij = new FontAwesome.Sharp.IconButton();
            panelUserControl = new Panel();
            tableLayoutPanel = new TableLayoutPanel();
            panelglowny = new Panel();
            panelMenu.SuspendLayout();
            menuUczniowie.SuspendLayout();
            menuWydzialy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logo).BeginInit();
            menuKadra.SuspendLayout();
            panelBanera.SuspendLayout();
            panelBar.SuspendLayout();
            tableLayoutPanel.SuspendLayout();
            panelglowny.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(64, 64, 64);
            panelMenu.Controls.Add(iconButtonPlany);
            panelMenu.Controls.Add(iconButtonOgloszenia);
            panelMenu.Controls.Add(iconButtonKalendarz);
            panelMenu.Controls.Add(iconButtonUczniowie);
            panelMenu.Controls.Add(iconButtonWyloguj);
            panelMenu.Controls.Add(iconButtonKadra);
            panelMenu.Controls.Add(iconButtonWydzialy);
            panelMenu.Controls.Add(logo);
            panelMenu.Dock = DockStyle.Fill;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Margin = new Padding(0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(286, 605);
            panelMenu.TabIndex = 0;
            // 
            // iconButtonPlany
            // 
            iconButtonPlany.Dock = DockStyle.Top;
            iconButtonPlany.FlatAppearance.BorderSize = 0;
            iconButtonPlany.FlatStyle = FlatStyle.Flat;
            iconButtonPlany.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonPlany.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonPlany.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            iconButtonPlany.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonPlany.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonPlany.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonPlany.Location = new Point(0, 423);
            iconButtonPlany.Margin = new Padding(0);
            iconButtonPlany.Name = "iconButtonPlany";
            iconButtonPlany.Size = new Size(286, 60);
            iconButtonPlany.TabIndex = 6;
            iconButtonPlany.Text = "Plany lekcji";
            iconButtonPlany.UseVisualStyleBackColor = true;
            iconButtonPlany.Click += iconButtonPlany_Click;
            // 
            // iconButtonOgloszenia
            // 
            iconButtonOgloszenia.Dock = DockStyle.Top;
            iconButtonOgloszenia.FlatAppearance.BorderSize = 0;
            iconButtonOgloszenia.FlatStyle = FlatStyle.Flat;
            iconButtonOgloszenia.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            iconButtonOgloszenia.ForeColor = Color.FromArgb(224, 224, 224);
            iconButtonOgloszenia.IconChar = FontAwesome.Sharp.IconChar.Bell;
            iconButtonOgloszenia.IconColor = Color.FromArgb(224, 224, 224);
            iconButtonOgloszenia.IconFont = FontAwesome.Sharp.IconFont.Solid;
            iconButtonOgloszenia.ImageAlign = ContentAlignment.MiddleLeft;
            iconButtonOgloszenia.Location = new Point(0, 363);
            iconButtonOgloszenia.Margin = new Padding(0);
            iconButtonOgloszenia.Name = "iconButtonOgloszenia";
            iconButtonOgloszenia.Size = new Size(286, 60);
            iconButtonOgloszenia.TabIndex = 5;
            iconButtonOgloszenia.Text = "Dod. Ogłoszenie";
            iconButtonOgloszenia.TextAlign = ContentAlignment.MiddleRight;
            iconButtonOgloszenia.UseVisualStyleBackColor = true;
            iconButtonOgloszenia.Click += iconButtonogloszenia_Click;
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
            iconButtonKalendarz.Size = new Size(286, 60);
            iconButtonKalendarz.TabIndex = 4;
            iconButtonKalendarz.Text = "Kalendarz";
            iconButtonKalendarz.UseVisualStyleBackColor = true;
            iconButtonKalendarz.Click += iconButtonKalendarz_Click;
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
            iconButtonUczniowie.Size = new Size(286, 60);
            iconButtonUczniowie.TabIndex = 3;
            iconButtonUczniowie.Text = "Studenci";
            iconButtonUczniowie.UseVisualStyleBackColor = false;
            iconButtonUczniowie.Click += iconButtonUczniowie_Click;
            // 
            // menuUczniowie
            // 
            menuUczniowie.BackColor = Color.Gray;
            menuUczniowie.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuUczniowie.ImageScalingSize = new Size(20, 20);
            menuUczniowie.Items.AddRange(new ToolStripItem[] { listaToolStripMenuItem, ocenyToolStripMenuItem });
            menuUczniowie.Name = "menuUczniowie";
            menuUczniowie.Size = new Size(182, 108);
            // 
            // listaToolStripMenuItem
            // 
            listaToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            listaToolStripMenuItem.Padding = new Padding(0, 4, 0, 4);
            listaToolStripMenuItem.Size = new Size(181, 52);
            listaToolStripMenuItem.Text = "Lista";
            listaToolStripMenuItem.Click += listaToolStripMenuItem_Click;
            // 
            // ocenyToolStripMenuItem
            // 
            ocenyToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            ocenyToolStripMenuItem.Name = "ocenyToolStripMenuItem";
            ocenyToolStripMenuItem.Padding = new Padding(0, 4, 0, 4);
            ocenyToolStripMenuItem.Size = new Size(181, 52);
            ocenyToolStripMenuItem.Text = "Oceny";
            ocenyToolStripMenuItem.Click += ocenyToolStripMenuItem_Click;
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
            iconButtonWyloguj.Location = new Point(0, 545);
            iconButtonWyloguj.Margin = new Padding(3, 4, 3, 4);
            iconButtonWyloguj.Name = "iconButtonWyloguj";
            iconButtonWyloguj.Size = new Size(286, 60);
            iconButtonWyloguj.TabIndex = 2;
            iconButtonWyloguj.Text = "Wyloguj";
            iconButtonWyloguj.UseVisualStyleBackColor = true;
            iconButtonWyloguj.Click += iconButtonWyloguj_Click;
            // 
            // iconButtonKadra
            // 
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
            iconButtonKadra.Size = new Size(286, 60);
            iconButtonKadra.TabIndex = 1;
            iconButtonKadra.Text = "Kadra";
            iconButtonKadra.UseVisualStyleBackColor = true;
            iconButtonKadra.Click += iconButtonKadra_Click;
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
            iconButtonWydzialy.Size = new Size(286, 60);
            iconButtonWydzialy.TabIndex = 0;
            iconButtonWydzialy.Text = "Wydziały";
            iconButtonWydzialy.UseVisualStyleBackColor = true;
            iconButtonWydzialy.Click += iconButtonWydzialy_Click;
            // 
            // menuWydzialy
            // 
            menuWydzialy.BackColor = Color.Gray;
            menuWydzialy.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuWydzialy.ImageScalingSize = new Size(20, 20);
            menuWydzialy.Items.AddRange(new ToolStripItem[] { MenuItemKierunki, elektrycznyToolStripMenuItem, mechanicznyToolStripMenuItem1, zarządzaniaINaukOJakościToolStripMenuItem1, działArmatorskiToolStripMenuItem1 });
            menuWydzialy.Name = "contextMenuStripWydzialy";
            menuWydzialy.Size = new Size(464, 240);
            // 
            // MenuItemKierunki
            // 
            MenuItemKierunki.BackColor = Color.Gray;
            MenuItemKierunki.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            MenuItemKierunki.ForeColor = Color.FromArgb(224, 224, 224);
            MenuItemKierunki.Name = "MenuItemKierunki";
            MenuItemKierunki.Padding = new Padding(0, 4, 0, 4);
            MenuItemKierunki.Size = new Size(463, 52);
            MenuItemKierunki.Text = "Nawigacyjny";
            // 
            // elektrycznyToolStripMenuItem
            // 
            elektrycznyToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            elektrycznyToolStripMenuItem.Name = "elektrycznyToolStripMenuItem";
            elektrycznyToolStripMenuItem.Size = new Size(463, 46);
            elektrycznyToolStripMenuItem.Text = "Elektryczny";
            // 
            // mechanicznyToolStripMenuItem1
            // 
            mechanicznyToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
            mechanicznyToolStripMenuItem1.Name = "mechanicznyToolStripMenuItem1";
            mechanicznyToolStripMenuItem1.Size = new Size(463, 46);
            mechanicznyToolStripMenuItem1.Text = "Mechaniczny";
            // 
            // zarządzaniaINaukOJakościToolStripMenuItem1
            // 
            zarządzaniaINaukOJakościToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
            zarządzaniaINaukOJakościToolStripMenuItem1.Name = "zarządzaniaINaukOJakościToolStripMenuItem1";
            zarządzaniaINaukOJakościToolStripMenuItem1.Size = new Size(463, 46);
            zarządzaniaINaukOJakościToolStripMenuItem1.Text = "Zarządzania i nauk o jakości";
            // 
            // działArmatorskiToolStripMenuItem1
            // 
            działArmatorskiToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
            działArmatorskiToolStripMenuItem1.Name = "działArmatorskiToolStripMenuItem1";
            działArmatorskiToolStripMenuItem1.Size = new Size(463, 46);
            działArmatorskiToolStripMenuItem1.Text = "Dział armatorski";
            // 
            // logo
            // 
            logo.BackColor = Color.FromArgb(64, 64, 64);
            logo.Dock = DockStyle.Top;
            logo.Image = Properties.Resources.logo_usos3;
            logo.Location = new Point(0, 0);
            logo.Name = "logo";
            logo.Size = new Size(286, 123);
            logo.TabIndex = 0;
            logo.TabStop = false;
            logo.Click += logo_Click;
            // 
            // menuKadra
            // 
            menuKadra.BackColor = Color.Gray;
            menuKadra.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            menuKadra.ImageScalingSize = new Size(20, 20);
            menuKadra.Items.AddRange(new ToolStripItem[] { kontaktToolStripMenuItem, kontaktToolStripMenuItem1 });
            menuKadra.Name = "menuKadra";
            menuKadra.Size = new Size(198, 108);
            // 
            // kontaktToolStripMenuItem
            // 
            kontaktToolStripMenuItem.ForeColor = Color.FromArgb(224, 224, 224);
            kontaktToolStripMenuItem.Name = "kontaktToolStripMenuItem";
            kontaktToolStripMenuItem.Padding = new Padding(0, 4, 0, 4);
            kontaktToolStripMenuItem.Size = new Size(197, 52);
            kontaktToolStripMenuItem.Text = "Lista";
            // 
            // kontaktToolStripMenuItem1
            // 
            kontaktToolStripMenuItem1.ForeColor = Color.FromArgb(224, 224, 224);
            kontaktToolStripMenuItem1.Name = "kontaktToolStripMenuItem1";
            kontaktToolStripMenuItem1.Padding = new Padding(0, 4, 0, 4);
            kontaktToolStripMenuItem1.Size = new Size(197, 52);
            kontaktToolStripMenuItem1.Text = "Kontakt";
            // 
            // panelBanera
            // 
            panelBanera.BackColor = Color.Navy;
            panelBanera.Controls.Add(labelTytulu);
            panelBanera.Dock = DockStyle.Top;
            panelBanera.Location = new Point(0, 0);
            panelBanera.Margin = new Padding(0);
            panelBanera.Name = "panelBanera";
            panelBanera.Size = new Size(896, 123);
            panelBanera.TabIndex = 2;
            // 
            // labelTytulu
            // 
            labelTytulu.Dock = DockStyle.Fill;
            labelTytulu.Font = new Font("Segoe UI", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            labelTytulu.ForeColor = SystemColors.Control;
            labelTytulu.Location = new Point(0, 0);
            labelTytulu.Name = "labelTytulu";
            labelTytulu.Size = new Size(896, 123);
            labelTytulu.TabIndex = 0;
            labelTytulu.Text = "Strona główna";
            labelTytulu.TextAlign = ContentAlignment.MiddleCenter;
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
            panelBar.Size = new Size(1182, 48);
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
            iconButtonMin.Location = new Point(1005, 0);
            iconButtonMin.Name = "iconButtonMin";
            iconButtonMin.Padding = new Padding(0, 0, 0, 8);
            iconButtonMin.Size = new Size(59, 48);
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
            iconButtonMaks.Location = new Point(1064, 0);
            iconButtonMaks.Name = "iconButtonMaks";
            iconButtonMaks.Size = new Size(59, 48);
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
            iconButtonZamknij.Location = new Point(1123, 0);
            iconButtonZamknij.Name = "iconButtonZamknij";
            iconButtonZamknij.Size = new Size(59, 48);
            iconButtonZamknij.TabIndex = 0;
            iconButtonZamknij.UseVisualStyleBackColor = false;
            iconButtonZamknij.Click += iconButtonZamknij_Click;
            // 
            // panelUserControl
            // 
            panelUserControl.Dock = DockStyle.Fill;
            panelUserControl.Location = new Point(0, 123);
            panelUserControl.Margin = new Padding(0);
            panelUserControl.Name = "panelUserControl";
            panelUserControl.Size = new Size(896, 482);
            panelUserControl.TabIndex = 5;
            // 
            // tableLayoutPanel
            // 
            tableLayoutPanel.ColumnCount = 2;
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 286F));
            tableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Controls.Add(panelMenu, 0, 0);
            tableLayoutPanel.Controls.Add(panelglowny, 1, 0);
            tableLayoutPanel.Dock = DockStyle.Fill;
            tableLayoutPanel.Location = new Point(0, 48);
            tableLayoutPanel.Margin = new Padding(0);
            tableLayoutPanel.Name = "tableLayoutPanel";
            tableLayoutPanel.RowCount = 1;
            tableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel.Size = new Size(1182, 605);
            tableLayoutPanel.TabIndex = 0;
            // 
            // panelglowny
            // 
            panelglowny.Controls.Add(panelUserControl);
            panelglowny.Controls.Add(panelBanera);
            panelglowny.Dock = DockStyle.Fill;
            panelglowny.Location = new Point(286, 0);
            panelglowny.Margin = new Padding(0);
            panelglowny.Name = "panelglowny";
            panelglowny.Size = new Size(896, 605);
            panelglowny.TabIndex = 1;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 653);
            ControlBox = false;
            Controls.Add(tableLayoutPanel);
            Controls.Add(panelBar);
            Name = "Form2";
            Load += Form2_Load;
            panelMenu.ResumeLayout(false);
            menuUczniowie.ResumeLayout(false);
            menuWydzialy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)logo).EndInit();
            menuKadra.ResumeLayout(false);
            panelBanera.ResumeLayout(false);
            panelBar.ResumeLayout(false);
            tableLayoutPanel.ResumeLayout(false);
            panelglowny.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMenu;
        private Panel panelBanera;
        private Label labelTytulu;
        private FontAwesome.Sharp.IconButton iconButtonKadra;
        private ContextMenuStrip menuWydzialy;
        private ToolStripMenuItem MenuItemKierunki;
        private FontAwesome.Sharp.IconButton iconButtonWyloguj;
        private ContextMenuStrip menuKadra;
        private ToolStripMenuItem kontaktToolStripMenuItem;
        private ToolStripMenuItem kontaktToolStripMenuItem1;
        private FontAwesome.Sharp.IconButton iconButtonUczniowie;
        private FontAwesome.Sharp.IconButton iconButtonOgloszenia;
        private FontAwesome.Sharp.IconButton iconButtonKalendarz;
        private ContextMenuStrip menuUczniowie;
        private ToolStripMenuItem ocenyToolStripMenuItem;
        private FontAwesome.Sharp.IconMenuItem iconMenuItem1;
        private Panel panelBar;
        private FontAwesome.Sharp.IconButton iconButtonMin;
        private FontAwesome.Sharp.IconButton iconButtonMaks;
        private FontAwesome.Sharp.IconButton iconButtonZamknij;
        private Panel panelUserControl;
        private ToolStripMenuItem listaToolStripMenuItem;
        private FontAwesome.Sharp.IconButton iconButtonWydzialy;
        private PictureBox logo;
        private TableLayoutPanel tableLayoutPanel;
        private Panel panelglowny;
        private ToolStripMenuItem elektrycznyToolStripMenuItem;
        private ToolStripMenuItem mechanicznyToolStripMenuItem1;
        private ToolStripMenuItem zarządzaniaINaukOJakościToolStripMenuItem1;
        private ToolStripMenuItem działArmatorskiToolStripMenuItem1;
        private FontAwesome.Sharp.IconButton iconButtonPlany;
    }
}