namespace GeneratorNpc
{
    partial class Form1
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
            this.buttonRandom = new System.Windows.Forms.Button();
            this.Cha = new System.Windows.Forms.Label();
            this.Wis = new System.Windows.Forms.Label();
            this.Int = new System.Windows.Forms.Label();
            this.Con = new System.Windows.Forms.Label();
            this.Dex = new System.Windows.Forms.Label();
            this.Str = new System.Windows.Forms.Label();
            this.Feat = new System.Windows.Forms.ComboBox();
            this.penalty = new System.Windows.Forms.Label();
            this.Skills = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Feats = new System.Windows.Forms.Label();
            this.Level = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Classes = new System.Windows.Forms.ComboBox();
            this.bab = new System.Windows.Forms.Label();
            this.Armor = new System.Windows.Forms.ComboBox();
            this.Weapons = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WeaponComplect = new System.Windows.Forms.Label();
            this.HpSpeedRes = new System.Windows.Forms.Label();
            this.SaveThrowsRes = new System.Windows.Forms.Label();
            this.HpSpeed = new System.Windows.Forms.Label();
            this.SaveThrows = new System.Windows.Forms.Label();
            this.Char = new System.Windows.Forms.Label();
            this.AC = new System.Windows.Forms.Label();
            this.Language = new System.Windows.Forms.Label();
            this.Init = new System.Windows.Forms.Label();
            this.Listen = new System.Windows.Forms.Label();
            this.Spot = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.NPCgetter = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NPC = new System.Windows.Forms.TextBox();
            this.Languages = new System.Windows.Forms.ComboBox();
            this.Spells = new System.Windows.Forms.ListBox();
            this.Spell = new System.Windows.Forms.Label();
            this.uperNaturalAbilities = new System.Windows.Forms.Label();
            this.SuperNaturalAbilities = new System.Windows.Forms.ListBox();
            this.ScrShot = new System.Windows.Forms.Button();
            this.Reach = new System.Windows.Forms.Label();
            this.CR = new System.Windows.Forms.Label();
            this.Alignment = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // buttonRandom
            // 
            this.buttonRandom.Font = new System.Drawing.Font("Monotype Corsiva", 19F, System.Drawing.FontStyle.Italic);
            this.buttonRandom.Location = new System.Drawing.Point(820, 445);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(204, 46);
            this.buttonRandom.TabIndex = 73;
            this.buttonRandom.Text = "Мне повезёт";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // Cha
            // 
            this.Cha.AutoSize = true;
            this.Cha.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Cha.Location = new System.Drawing.Point(380, 131);
            this.Cha.Name = "Cha";
            this.Cha.Size = new System.Drawing.Size(35, 29);
            this.Cha.TabIndex = 72;
            this.Cha.Text = "10";
            // 
            // Wis
            // 
            this.Wis.AutoSize = true;
            this.Wis.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Wis.Location = new System.Drawing.Point(306, 131);
            this.Wis.Name = "Wis";
            this.Wis.Size = new System.Drawing.Size(35, 29);
            this.Wis.TabIndex = 71;
            this.Wis.Text = "10";
            // 
            // Int
            // 
            this.Int.AutoSize = true;
            this.Int.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Int.Location = new System.Drawing.Point(230, 131);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(35, 29);
            this.Int.TabIndex = 70;
            this.Int.Text = "10";
            // 
            // Con
            // 
            this.Con.AutoSize = true;
            this.Con.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Con.Location = new System.Drawing.Point(157, 131);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(35, 29);
            this.Con.TabIndex = 69;
            this.Con.Text = "10";
            // 
            // Dex
            // 
            this.Dex.AutoSize = true;
            this.Dex.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Dex.Location = new System.Drawing.Point(89, 131);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(35, 29);
            this.Dex.TabIndex = 68;
            this.Dex.Text = "10";
            // 
            // Str
            // 
            this.Str.AutoSize = true;
            this.Str.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.Str.Location = new System.Drawing.Point(19, 132);
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(35, 29);
            this.Str.TabIndex = 67;
            this.Str.Text = "10";
            // 
            // Feat
            // 
            this.Feat.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Feat.FormattingEnabled = true;
            this.Feat.Location = new System.Drawing.Point(587, 110);
            this.Feat.Name = "Feat";
            this.Feat.Size = new System.Drawing.Size(121, 23);
            this.Feat.TabIndex = 65;
            // 
            // penalty
            // 
            this.penalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.penalty.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.penalty.Location = new System.Drawing.Point(18, 477);
            this.penalty.Name = "penalty";
            this.penalty.Size = new System.Drawing.Size(153, 31);
            this.penalty.TabIndex = 64;
            this.penalty.Text = "penalty 0";
            // 
            // Skills
            // 
            this.Skills.BackColor = System.Drawing.SystemColors.HighlightText;
            this.Skills.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Skills.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Skills.Location = new System.Drawing.Point(121, 326);
            this.Skills.Name = "Skills";
            this.Skills.Size = new System.Drawing.Size(885, 33);
            this.Skills.TabIndex = 63;
            this.Skills.Text = "gggg";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 29);
            this.label5.TabIndex = 62;
            this.label5.Text = "Навыки";
            // 
            // Feats
            // 
            this.Feats.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Feats.Location = new System.Drawing.Point(487, 101);
            this.Feats.Name = "Feats";
            this.Feats.Size = new System.Drawing.Size(94, 49);
            this.Feats.TabIndex = 61;
            this.Feats.Text = "Feats:";
            // 
            // Level
            // 
            this.Level.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Level.Location = new System.Drawing.Point(608, 67);
            this.Level.Name = "Level";
            this.Level.Size = new System.Drawing.Size(100, 22);
            this.Level.TabIndex = 60;
            this.Level.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(380, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(189, 29);
            this.label4.TabIndex = 59;
            this.label4.Text = "Выберите класс";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(453, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 58;
            this.label3.Text = "Уровень: ";
            // 
            // Classes
            // 
            this.Classes.FormattingEnabled = true;
            this.Classes.Location = new System.Drawing.Point(587, 22);
            this.Classes.Name = "Classes";
            this.Classes.Size = new System.Drawing.Size(121, 24);
            this.Classes.TabIndex = 57;
            // 
            // bab
            // 
            this.bab.AutoSize = true;
            this.bab.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bab.Location = new System.Drawing.Point(766, 163);
            this.bab.Name = "bab";
            this.bab.Size = new System.Drawing.Size(212, 19);
            this.bab.TabIndex = 56;
            this.bab.Text = "Бонус Атаки melee / ranged";
            // 
            // Armor
            // 
            this.Armor.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Armor.FormattingEnabled = true;
            this.Armor.Location = new System.Drawing.Point(219, 293);
            this.Armor.Name = "Armor";
            this.Armor.Size = new System.Drawing.Size(787, 27);
            this.Armor.TabIndex = 55;
            // 
            // Weapons
            // 
            this.Weapons.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Weapons.FormattingEnabled = true;
            this.Weapons.Location = new System.Drawing.Point(219, 255);
            this.Weapons.Name = "Weapons";
            this.Weapons.Size = new System.Drawing.Size(787, 27);
            this.Weapons.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 53;
            this.label2.Text = "ArmorComplect:";
            // 
            // WeaponComplect
            // 
            this.WeaponComplect.AutoSize = true;
            this.WeaponComplect.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WeaponComplect.Location = new System.Drawing.Point(7, 250);
            this.WeaponComplect.Name = "WeaponComplect";
            this.WeaponComplect.Size = new System.Drawing.Size(198, 29);
            this.WeaponComplect.TabIndex = 52;
            this.WeaponComplect.Text = "WeaponComplect:";
            // 
            // HpSpeedRes
            // 
            this.HpSpeedRes.AutoSize = true;
            this.HpSpeedRes.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.HpSpeedRes.Location = new System.Drawing.Point(291, 211);
            this.HpSpeedRes.Name = "HpSpeedRes";
            this.HpSpeedRes.Size = new System.Drawing.Size(108, 29);
            this.HpSpeedRes.TabIndex = 51;
            this.HpSpeedRes.Text = "10       30ft";
            // 
            // SaveThrowsRes
            // 
            this.SaveThrowsRes.AutoSize = true;
            this.SaveThrowsRes.Font = new System.Drawing.Font("Monotype Corsiva", 15F, System.Drawing.FontStyle.Italic);
            this.SaveThrowsRes.Location = new System.Drawing.Point(19, 211);
            this.SaveThrowsRes.Name = "SaveThrowsRes";
            this.SaveThrowsRes.Size = new System.Drawing.Size(136, 29);
            this.SaveThrowsRes.TabIndex = 50;
            this.SaveThrowsRes.Text = "0         0         0";
            // 
            // HpSpeed
            // 
            this.HpSpeed.AutoSize = true;
            this.HpSpeed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.HpSpeed.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HpSpeed.Location = new System.Drawing.Point(281, 172);
            this.HpSpeed.Name = "HpSpeed";
            this.HpSpeed.Size = new System.Drawing.Size(124, 29);
            this.HpSpeed.TabIndex = 49;
            this.HpSpeed.Text = "HP   Speed";
            // 
            // SaveThrows
            // 
            this.SaveThrows.AutoSize = true;
            this.SaveThrows.BackColor = System.Drawing.SystemColors.ControlDark;
            this.SaveThrows.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveThrows.Location = new System.Drawing.Point(18, 172);
            this.SaveThrows.Name = "SaveThrows";
            this.SaveThrows.Size = new System.Drawing.Size(153, 29);
            this.SaveThrows.TabIndex = 48;
            this.SaveThrows.Text = "Fort  Ref  Will";
            // 
            // Char
            // 
            this.Char.AutoSize = true;
            this.Char.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Char.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Italic);
            this.Char.Location = new System.Drawing.Point(12, 80);
            this.Char.Name = "Char";
            this.Char.Size = new System.Drawing.Size(393, 35);
            this.Char.TabIndex = 45;
            this.Char.Text = "Str   Dex   Con   Int   Wis   Cha";
            // 
            // AC
            // 
            this.AC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AC.ForeColor = System.Drawing.SystemColors.ControlText;
            this.AC.Location = new System.Drawing.Point(18, 536);
            this.AC.Name = "AC";
            this.AC.Size = new System.Drawing.Size(296, 24);
            this.AC.TabIndex = 44;
            this.AC.Text = "AC:10  touch:10  flat-footed:10";
            // 
            // Language
            // 
            this.Language.AutoSize = true;
            this.Language.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Language.Location = new System.Drawing.Point(766, 120);
            this.Language.Name = "Language";
            this.Language.Size = new System.Drawing.Size(56, 19);
            this.Language.TabIndex = 43;
            this.Language.Text = "Языки";
            // 
            // Init
            // 
            this.Init.AutoSize = true;
            this.Init.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Init.Location = new System.Drawing.Point(766, 80);
            this.Init.Name = "Init";
            this.Init.Size = new System.Drawing.Size(102, 19);
            this.Init.TabIndex = 42;
            this.Init.Text = "Инициатива";
            // 
            // Listen
            // 
            this.Listen.AutoSize = true;
            this.Listen.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Listen.Location = new System.Drawing.Point(766, 40);
            this.Listen.Name = "Listen";
            this.Listen.Size = new System.Drawing.Size(43, 19);
            this.Listen.TabIndex = 41;
            this.Listen.Text = "Cлух";
            // 
            // Spot
            // 
            this.Spot.AutoSize = true;
            this.Spot.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spot.Location = new System.Drawing.Point(766, 9);
            this.Spot.Name = "Spot";
            this.Spot.Size = new System.Drawing.Size(135, 19);
            this.Spot.TabIndex = 40;
            this.Spot.Text = "Внимательность";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Monotype Corsiva", 20F, System.Drawing.FontStyle.Italic);
            this.button1.Location = new System.Drawing.Point(854, 513);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 51);
            this.button1.TabIndex = 39;
            this.button1.Text = "Погнали!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Monotype Corsiva", 14F, System.Drawing.FontStyle.Italic);
            this.button2.Location = new System.Drawing.Point(12, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(201, 40);
            this.button2.TabIndex = 74;
            this.button2.Text = "Выберите NPC";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // NPCgetter
            // 
            this.NPCgetter.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NPCgetter.Location = new System.Drawing.Point(12, 19);
            this.NPCgetter.Name = "NPCgetter";
            this.NPCgetter.Size = new System.Drawing.Size(201, 40);
            this.NPCgetter.TabIndex = 74;
            this.NPCgetter.Text = "Выберите NPC";
            this.NPCgetter.UseVisualStyleBackColor = true;
            this.NPCgetter.Click += new System.EventHandler(this.NPCgetter_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NPC
            // 
            this.NPC.Font = new System.Drawing.Font("Monotype Corsiva", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NPC.Location = new System.Drawing.Point(219, 22);
            this.NPC.Name = "NPC";
            this.NPC.Size = new System.Drawing.Size(155, 33);
            this.NPC.TabIndex = 75;
            this.NPC.TextChanged += new System.EventHandler(this.NPC_TextChanged);
            // 
            // Languages
            // 
            this.Languages.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Languages.FormattingEnabled = true;
            this.Languages.Location = new System.Drawing.Point(840, 120);
            this.Languages.Name = "Languages";
            this.Languages.Size = new System.Drawing.Size(152, 23);
            this.Languages.TabIndex = 76;
            // 
            // Spells
            // 
            this.Spells.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spells.FormattingEnabled = true;
            this.Spells.ItemHeight = 15;
            this.Spells.Items.AddRange(new object[] {
            "Огненный шар",
            "Молния ",
            "Невидимость"});
            this.Spells.Location = new System.Drawing.Point(256, 377);
            this.Spells.Name = "Spells";
            this.Spells.Size = new System.Drawing.Size(194, 154);
            this.Spells.TabIndex = 80;
            // 
            // Spell
            // 
            this.Spell.AutoSize = true;
            this.Spell.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spell.Location = new System.Drawing.Point(166, 373);
            this.Spell.Name = "Spell";
            this.Spell.Size = new System.Drawing.Size(84, 33);
            this.Spell.TabIndex = 81;
            this.Spell.Text = "Spells";
            // 
            // uperNaturalAbilities
            // 
            this.uperNaturalAbilities.AutoSize = true;
            this.uperNaturalAbilities.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.uperNaturalAbilities.Location = new System.Drawing.Point(456, 377);
            this.uperNaturalAbilities.Name = "uperNaturalAbilities";
            this.uperNaturalAbilities.Size = new System.Drawing.Size(152, 33);
            this.uperNaturalAbilities.TabIndex = 82;
            this.uperNaturalAbilities.Text = "SN Abilities";
            // 
            // SuperNaturalAbilities
            // 
            this.SuperNaturalAbilities.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SuperNaturalAbilities.FormattingEnabled = true;
            this.SuperNaturalAbilities.ItemHeight = 15;
            this.SuperNaturalAbilities.Items.AddRange(new object[] {
            "Оглушающий удар",
            "Укус",
            "Невидимость"});
            this.SuperNaturalAbilities.Location = new System.Drawing.Point(614, 377);
            this.SuperNaturalAbilities.Name = "SuperNaturalAbilities";
            this.SuperNaturalAbilities.Size = new System.Drawing.Size(181, 154);
            this.SuperNaturalAbilities.TabIndex = 83;
            // 
            // ScrShot
            // 
            this.ScrShot.Enabled = false;
            this.ScrShot.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ScrShot.Location = new System.Drawing.Point(818, 392);
            this.ScrShot.Name = "ScrShot";
            this.ScrShot.Size = new System.Drawing.Size(204, 47);
            this.ScrShot.TabIndex = 84;
            this.ScrShot.Text = "Сделать скрин";
            this.ScrShot.UseVisualStyleBackColor = true;
            this.ScrShot.Click += new System.EventHandler(this.ScrShot_Click);
            // 
            // Reach
            // 
            this.Reach.AutoSize = true;
            this.Reach.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reach.Location = new System.Drawing.Point(13, 377);
            this.Reach.Name = "Reach";
            this.Reach.Size = new System.Drawing.Size(66, 25);
            this.Reach.TabIndex = 85;
            this.Reach.Text = "Reach";
            // 
            // CR
            // 
            this.CR.AutoSize = true;
            this.CR.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CR.Location = new System.Drawing.Point(18, 425);
            this.CR.Name = "CR";
            this.CR.Size = new System.Drawing.Size(50, 27);
            this.CR.TabIndex = 86;
            this.CR.Text = "CR ";
            // 
            // Alignment
            // 
            this.Alignment.AutoSize = true;
            this.Alignment.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Alignment.Location = new System.Drawing.Point(766, 196);
            this.Alignment.Name = "Alignment";
            this.Alignment.Size = new System.Drawing.Size(122, 19);
            this.Alignment.TabIndex = 87;
            this.Alignment.Text = "Мировоззрение";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(481, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(194, 37);
            this.button3.TabIndex = 88;
            this.button3.Text = "Ссылка на бестиарий";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Куда Сохранять";
            this.folderBrowserDialog1.Tag = "Куда Сохранять";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1036, 569);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Alignment);
            this.Controls.Add(this.CR);
            this.Controls.Add(this.Reach);
            this.Controls.Add(this.ScrShot);
            this.Controls.Add(this.SuperNaturalAbilities);
            this.Controls.Add(this.uperNaturalAbilities);
            this.Controls.Add(this.Spell);
            this.Controls.Add(this.Spells);
            this.Controls.Add(this.Languages);
            this.Controls.Add(this.NPC);
            this.Controls.Add(this.NPCgetter);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.Cha);
            this.Controls.Add(this.Wis);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.Str);
            this.Controls.Add(this.Feat);
            this.Controls.Add(this.penalty);
            this.Controls.Add(this.Skills);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Feats);
            this.Controls.Add(this.Level);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Classes);
            this.Controls.Add(this.bab);
            this.Controls.Add(this.Armor);
            this.Controls.Add(this.Weapons);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.WeaponComplect);
            this.Controls.Add(this.HpSpeedRes);
            this.Controls.Add(this.SaveThrowsRes);
            this.Controls.Add(this.HpSpeed);
            this.Controls.Add(this.SaveThrows);
            this.Controls.Add(this.Char);
            this.Controls.Add(this.AC);
            this.Controls.Add(this.Language);
            this.Controls.Add(this.Init);
            this.Controls.Add(this.Listen);
            this.Controls.Add(this.Spot);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "GeneratorNPC";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Label Cha;
        private System.Windows.Forms.Label Wis;
        private System.Windows.Forms.Label Int;
        private System.Windows.Forms.Label Con;
        private System.Windows.Forms.Label Dex;
        private System.Windows.Forms.Label Str;
        private System.Windows.Forms.ComboBox Feat;
        private System.Windows.Forms.Label penalty;
        private System.Windows.Forms.TextBox Skills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Feats;
        private System.Windows.Forms.TextBox Level;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Classes;
        private System.Windows.Forms.Label bab;
        private System.Windows.Forms.ComboBox Armor;
        private System.Windows.Forms.ComboBox Weapons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label WeaponComplect;
        private System.Windows.Forms.Label HpSpeedRes;
        private System.Windows.Forms.Label SaveThrowsRes;
        private System.Windows.Forms.Label HpSpeed;
        private System.Windows.Forms.Label SaveThrows;
        private System.Windows.Forms.Label Char;
        private System.Windows.Forms.Label AC;
        private System.Windows.Forms.Label Language;
        private System.Windows.Forms.Label Init;
        private System.Windows.Forms.Label Listen;
        private System.Windows.Forms.Label Spot;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button NPCgetter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox NPC;
        private System.Windows.Forms.ComboBox Languages;
        private System.Windows.Forms.ListBox Spells;
        private System.Windows.Forms.Label Spell;
        private System.Windows.Forms.Label uperNaturalAbilities;
        private System.Windows.Forms.ListBox SuperNaturalAbilities;
        private System.Windows.Forms.Button ScrShot;
        private System.Windows.Forms.Label Reach;
        private System.Windows.Forms.Label CR;
        private System.Windows.Forms.Label Alignment;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

