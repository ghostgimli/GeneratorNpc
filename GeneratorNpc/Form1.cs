using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
namespace GeneratorNpc
{
    public enum LightArmor { Padded=180, Leather=260, StudLeather=351, Ringmail=442 }//первая цифра бонус к AC,вторая maxdex,третья штраф к проверкам 
    public enum MiddleArmor { Hide=343, ScaleMail=434, ChainMail=525, BreastPlate=534 }
    public enum HeavyArmor { SplintMail=607, BandedMail=616, HalfPlate=707, FullPlate=816 }
    public enum Shields { Buckler=11,SmallWooden=11,SmallSteel=11,LargeWooden=22,LargeSteel=22,TowerShield=410}//первая цифра,бонус к AC,вторая штраф

    public partial class Form1 : Form
    {   int Amount, Dice,MoreThanZero;
        Unit unit = new Unit();
        Unit temp = new Unit();
        Random r = new Random();
        NumberFormatInfo inf =  NumberFormatInfo.CurrentInfo;
        
        public bool error = false;
        //public string catcher;
        //public bool DirectoryChosen = false;
        //public int counter = 0;//считает кол-во сгенеренных персов 
        static string conversion(string str1, string str2)
        {

            if (str1.Contains(".") && (str2 != "."))
                return str1.Replace('.', ',');
            if (str1.Contains(",") && (str2 != ","))
                return str1.Replace(',', '.');
            return str1;
        }
       

        public int RollTheInit()
        {
            int res = r.Next(1, 20) + unit.DexMod;
            if (res >= 1)
            {
                return res;
            }
            else { return 1; }
            
        }
        public int HpCalc()
        {
            int result = Dice + unit.ConMod;
            for (int i = 1; i < Amount; i++)
            {   MoreThanZero= r.Next(1,Dice) +unit.ConMod;
                result += (MoreThanZero > 0) ? MoreThanZero : 1;
            }
            
            return result;
        }
        

        public void ArmorIncrement(ref LightArmor arm)
    {
        if (Armor.Text.Contains("Войлочный"))
            arm = LightArmor.Padded;
        if (Armor.Text.Contains("Кожаный") || Armor.Text.Contains("leather") && !(Armor.Text.Contains("studded")))
            arm = LightArmor.Leather;
        if (Armor.Text.Contains("Из выдубленной кожи"))
            arm = LightArmor.StudLeather;
        if (Armor.Text.Contains("Кольчуга"))
            arm = LightArmor.Ringmail;
    }
        public void ArmorIncrement(ref MiddleArmor arm)
        {
            if (Armor.Text.Contains("Из шкуры"))
                arm = MiddleArmor.Hide;
            if (Armor.Text.Contains("Чешуйчатый") || Armor.Text.Contains("Чешуйчатая кольчуга"))
                arm = MiddleArmor.ScaleMail;
            if (Armor.Text.Contains("Стандартная кольчуга"))
                arm = MiddleArmor.ChainMail;
            if (Armor.Text.Contains("Кираса"))
                arm = MiddleArmor.BreastPlate;
        }
        public void ArmorIncrement(ref HeavyArmor arm)
        {
            if (Armor.Text.Contains("Шплинтованная кольчуга"))
                arm = HeavyArmor.SplintMail;
            if (Armor.Text.Contains("Окаймлённая кольчуга"))
                arm = HeavyArmor.BandedMail;
            if (Armor.Text.Contains("Полу-пластинчатые латы"))
                arm = HeavyArmor.HalfPlate;
            if (Armor.Text.Contains("Пластинчатые латы"))
                arm = HeavyArmor.FullPlate;
        }
        public void FeatIncrement()
        {
            string[] skills = unit.ConstSkills.Split(','); string text = "";
            switch (Feat.Text)
            {
                case "Alertness":
                    
                    Skills.Text = "";
                    for (int i = 0; i < skills.Length; i++)
                    {
                        if (skills[i].Contains("Listen") || skills[i].Contains("Spot"))
                        {
                            string[] temp = skills[i].Split('+', '(', ')'); int bonus = Int32.Parse(temp[2]) + 2;
                            if (bonus > 0) { skills[i] = temp[0] + " (+" + bonus + ")"; }
                            else { skills[i] = temp[0] + " (" + bonus + ")"; }
                        }
                        if (i != skills.Length - 1) { text += skills[i] + ","; }
                        else { text += skills[i]; }

                    }
                    temp.ConstSkills = text;
                    break;
                case "Стойкость (+3 хита)":
                    temp.GetTotalHp += 3;
                    HpSpeedRes.Text = temp.GetTotalHp + "       " + temp.GetSpeed + "ft";
                    Console.WriteLine(unit.GetTotalHp);
                    break;
                case "Toughness":
                    HpCalc();
                    temp.GetTotalHp += 3;
                    HpSpeedRes.Text = temp.GetTotalHp + "       " + temp.GetSpeed + "ft";
                    break;
                case "Владение двумя оружиями(-2/-2)":
                    bab.Text = "Бонус атаки  melee " + Convert.ToString(temp.GetMelee + unit.StrMod + PenaltyForTwoWeapons()) + " / ranged " + Convert.ToString(temp.GetMelee + unit.DexMod);
                    break;
                case "Скрытность (+2 к проверком Move Silently и Hide)":
                    Skills.Text = "";
                    for (int i = 0; i < skills.Length; i++)
                    {
                        if (skills[i].Contains("Move Silently") || skills[i].Contains("Hide"))
                        {
                            string[] temp = skills[i].Split('+', '(', ')'); int bonus = Int32.Parse(temp[2]) + 2;
                            if (bonus > 0) { skills[i] = temp[0] + " (+" + bonus + ")"; }
                            else { skills[i] = temp[0] + " (" + bonus + ")"; }
                        }
                        if (i != skills.Length - 1) { text += skills[i] + ","; }
                        else { text += skills[i]; }

                    }
                    temp.ConstSkills = text;
                    break;
                default:
                    break;
            }
        }
        public void FillingEmptyGaps()
        {
            try
            {
                if (!Armor.Items.Contains(Armor.Text))
                {
                    Armor.Text = Armor.Items[r.Next(0, Armor.Items.Count)].ToString();
                }
                if (!Weapons.Items.Contains(Weapons.Text))
                {
                    Weapons.Text = Weapons.Items[r.Next(0, Weapons.Items.Count)].ToString();
                }
                if (!Feat.Items.Contains(Feat.Text))
                {
                    Feat.Text = Feat.Items[r.Next(0, Feat.Items.Count)].ToString();
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Ну хоть что-то заполни(Имя NPC)", "Внимание", MessageBoxButtons.OK);

            }

        }
        public void GeneratingUnit()
        {   
            Level.Enabled = true;
            if (File.Exists(unit.GetPath))// unit.GetPath.Contains(Application.StartupPath)
            {
                using (StreamReader sr = File.OpenText(unit.GetPath))
                {
                    try
                    {
                        Armor.Items.Clear(); Feat.Items.Clear(); Weapons.Items.Clear(); Languages.Items.Clear();
                        Armor.Text = ""; Feat.Text = ""; Weapons.Text = ""; Skills.Text = ""; Languages.Text = "";
                        NPC.Text = sr.ReadLine();//Название существа

                        Classes.Items.AddRange(sr.ReadLine().Split('_'));//список классов для данного существа

                        string[] Values = sr.ReadLine().Split('_');//Для характеристик и  модификаторов
                        Str.Text = Values[0]; Dex.Text = Values[1]; Con.Text = Values[2]; Int.Text = Values[3]; Wis.Text = Values[4]; Cha.Text = Values[5];
                        unit.StrMod = Int32.Parse(Str.Text) / 2 - 5; unit.DexMod = Int32.Parse(Dex.Text) / 2 - 5;
                        unit.ConMod = Int32.Parse(Con.Text) / 2 - 5; unit.IntMod = Int32.Parse(Int.Text) / 2 - 5;
                        unit.WisMod = Int32.Parse(Wis.Text) / 2 - 5; unit.ChaMod = Int32.Parse(Cha.Text) / 2 - 5;


                        Values = sr.ReadLine().Split('_');//Для спасбросков
                        int[] IntValues = new int[Values.Length];
                        for (int i = 0; i < Values.Length; i++)
                        {
                            IntValues[i] = Int32.Parse(Values[i]);
                        }
                        SaveThrowsRes.Text = IntValues[0] + "        " + IntValues[1] + "        " + IntValues[2];


                        Values = sr.ReadLine().Split('_', 'd');//для хп и скорости
                        IntValues = new int[Values.Length];
                        for (int i = 0; i < Values.Length; i++)
                        {
                            IntValues[i] = Int32.Parse(Values[i]);
                        }
                        Amount = IntValues[0]; Dice = IntValues[1];
                        unit.GetSpeed = IntValues[2];
                        unit.GetTotalHp = HpCalc();
                        HpSpeedRes.Text = unit.GetTotalHp + "       " + unit.GetSpeed + "ft";//вычисляем хиты по формуле и скорость тоже


                        Values = sr.ReadLine().Split('_');//ВНимательность,СЛух,инициатива,бонус атаки
                        IntValues = new int[Values.Length];
                        for (int i = 0; i < Values.Length; i++)
                        {
                            IntValues[i] = Int32.Parse(Values[i]);
                        }
                        Spot.Text = "Внимательность  " + IntValues[0];
                        Listen.Text = "Слух  " + IntValues[1];
                        Init.Text = "Инициатива  " + Convert.ToString(RollTheInit() + IntValues[2]);
                        unit.GetMelee = IntValues[3];
                        bab.Text = "Бонус атаки  melee " + Convert.ToString(unit.GetMelee + unit.StrMod + PenaltyForTwoWeapons()) + " / ranged " + Convert.ToString(unit.GetMelee + unit.DexMod);
                        Reach.Text = "Reach " + IntValues[4] + "ft";
                        unit.NaturalAC = IntValues[5];
                        unit.GetCR = Double.Parse(conversion(sr.ReadLine(), inf.CurrencyDecimalSeparator));
                        CR.Text = "CR " + unit.GetCR;
                        unit.Alignment = sr.ReadLine().Split('_');
                        Alignment.Text = "Мировоззрение " + unit.Alignment[r.Next(0, unit.Alignment.Length - 1)];//рандомное мировоззреник

                        Values = sr.ReadLine().Split('_');
                        unit.ConstLanguages = Values;
                        if (Values[0] != "нет")
                        {
                            Languages.Items.AddRange(Values);//Языки
                        }

                        Values = sr.ReadLine().Split('_');
                        Armor.Items.Clear();
                        if (Values[0] != "нет")
                        {
                            Armor.Items.AddRange(Values);//Доспехи
                        }
                        else { Armor.Items.Add("нет"); }

                        Values = sr.ReadLine().Split('_');
                        Weapons.Items.Clear();
                        if (Values[0] != "нет")
                        {
                            Weapons.Items.AddRange(Values);//Оружие
                        }
                        else { Weapons.Items.Add("нет"); }

                        Values = sr.ReadLine().Split('_');
                        Feat.Items.Clear();
                        if (Values[0] != "нет")
                        {
                            Feat.Items.AddRange(Values);//Фиты
                        }
                        else { Feat.Items.Add("нет"); }


                        unit.ConstSkills = sr.ReadLine();
                        if (unit.ConstSkills != "нет")
                        {
                            Skills.Text = unit.ConstSkills;//Навыки
                        }

                        Values = sr.ReadLine().Split('_');
                        Spells.Items.Clear();
                        if (Values[0] != "нет")
                        {
                            Spells.Items.AddRange(Values);//Заклинания
                        }

                        Values = sr.ReadLine().Split('_');
                        SuperNaturalAbilities.Items.Clear();
                        if (Values[0] != "нет")
                        {
                            SuperNaturalAbilities.Items.AddRange(Values);//Сверхестественные способности
                        }

                        Values = sr.ReadLine().Split('_');
                        if (Values[0] == "нет")
                        {
                            Level.Enabled = false;
                        }
                        else if (Values[0] == "да")
                        {
                            Level.Enabled = true;
                        }
                        if (!(sr.EndOfStream))
                        {
                            unit.GetWebPath = sr.ReadLine();
                        }



                        sr.Close();
                    }
                    catch (NullReferenceException)
                    {
                        MessageBox.Show("Возможно бестиарий не совсем полностью  составлен......Обратитесь к файлу help за помощью");
                    }

                }
            }
            else
            {
                MessageBox.Show("Таких здесь не водятся,глянь в bestiary");
            }

        }
        public bool LevelTextWrong()
        {
            int a;

            if (!(Int32.TryParse(Level.Text, out a)))
            {
                MessageBox.Show("Выберите значение уровня от 1 до 20", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            else
            {
                if (Int32.Parse(Level.Text) < 1 || Int32.Parse(Level.Text) > 20)
                {
                    MessageBox.Show("Выберите значение уровня от 1 до 20", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                else { return true; }

            }
        }
        public void LvlUp()
        {
            for (int i = 1; i < Int32.Parse(Level.Text); i++)
            {
                MoreThanZero = r.Next(1, Dice) + temp.ConMod;
                temp.GetTotalHp += (MoreThanZero > 0) ? MoreThanZero : 1;
            }

            HpSpeedRes.Text = temp.GetTotalHp + "       " + temp.GetSpeed + "ft";
            bab.Text = "Бонус атаки  melee " + Convert.ToString(temp.GetMelee + unit.StrMod + PenaltyForTwoWeapons()) + " / ranged " + Convert.ToString(temp.GetMelee + unit.DexMod);
        }
        public int PenaltyForTwoWeapons()
        {
            int PenaltyForTwoWeapons = 0;
            if (Weapons.Text.Contains("Dual wield") && Feat.Text == "Владение двумя оружиями(-2/-2)") { PenaltyForTwoWeapons = -2; }
            else if (Weapons.Text.Contains("Dual wield") && !(Feat.Text == "Владение двумя оружиями(-2/-2)")) { PenaltyForTwoWeapons = -4; }
            return PenaltyForTwoWeapons;
        }
        public void ResultingTemp()
        {

            if (!LevelTextWrong())
            {
                return;
            }
            Unit.Transfer(temp,unit);
            temp.GetTotalHp = HpCalc();
            Init.Text = "Инициатива  " + Convert.ToString(RollTheInit() + temp.ChaMod);

            FeatIncrement();
            temp.SpeedPenalty(Armor.Text);//штраф по скорости

            int ShieldBonus = 0; int ShieldPenalty = 0;

            if (Armor.Text.Contains("щит") || Armor.Text.Contains("shield"))
            {
                Shields shield = 0; ShieldIncrement(ref shield);

                if (Armor.Text.Contains("Ростовой щит"))
                {
                    ShieldBonus = (int)shield / 100;
                    ShieldPenalty = (int)shield % 100;
                }
                else
                {
                    ShieldBonus = (int)shield / 10;
                    ShieldPenalty = (int)shield % 10;
                }
            }
            Skills.Text = temp.ConstSkills;

            if (Armor.Text.Contains("type light"))
            {
                LightArmor la = 0; ArmorIncrement(ref la);//MaxDex = (int)la/10%10  бонус обычный к AC = la/100 аналогично с другими типами доспехов; la%10
                int DexBonus = ((int)la / 10 % 10 > temp.DexMod) ? temp.DexMod : (int)la / 10 % 10;
                AC.Text = "AC:" + Convert.ToString(10 + (int)la / 100 + DexBonus + ShieldBonus + temp.NaturalAC) + " touch:" + Convert.ToString(DexBonus + 10) + " flat-footed:" + Convert.ToString(((int)la / 100) + ShieldBonus + 10 + temp.NaturalAC);
                penalty.Text = "penalty " + Convert.ToString((int)la % 10 + ShieldPenalty);
            }
            else if (Armor.Text.Contains("type middle"))
            {
                MiddleArmor ma = 0; ArmorIncrement(ref ma);
                int DexBonus = ((int)ma / 10 % 10 > temp.DexMod) ? temp.DexMod : ((int)ma / 10 % 10);
                AC.Text = "AC:" + Convert.ToString(10 + (int)ma / 100 + DexBonus + ShieldBonus + temp.NaturalAC) + " touch:" + Convert.ToString(DexBonus + 10) + " flat-footed:" + Convert.ToString(((int)ma / 100) + ShieldBonus + 10 + temp.NaturalAC);
                penalty.Text = "penalty " + Convert.ToString((int)ma % 10 + ShieldPenalty);
            }
            else if (Armor.Text.Contains("type heavy"))
            {
                HeavyArmor ha = 0; ArmorIncrement(ref ha);
                int DexBonus = ((int)ha / 10 % 10 > temp.DexMod) ? temp.DexMod : ((int)ha / 10 % 10);
                AC.Text = "AC:" + Convert.ToString(10 + (int)ha / 100 + DexBonus + ShieldBonus + temp.NaturalAC) + " touch:" + Convert.ToString(DexBonus + 10) + " flat-footed:" + Convert.ToString(((int)ha / 100) + ShieldBonus + 10 + temp.NaturalAC);
                penalty.Text = "penalty -" + Convert.ToString((int)ha % 10 + ShieldPenalty);
            }
            else { AC.Text = "AC:" + Convert.ToString(10 + temp.DexMod + ShieldBonus + temp.NaturalAC) + " touch:" + Convert.ToString(temp.DexMod + 10) + " flat-footed:" + Convert.ToString(ShieldBonus + 10 + temp.NaturalAC); }
            //HpSpeedRes.Text = temp.GetTotalHp + "       " + temp.GetSpeed + "ft";
            //bab.Text = "Бонус атаки  melee " + Convert.ToString(temp.GetMelee+unit.StrMod + PenaltyForTwoWeapons())+" / ranged "+ Convert.ToString(temp.GetMelee + unit.DexMod);

            LvlUp();
        }
        public void Screenshot()
        {
            //if (!error)
            //{
            //    Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            //    Graphics g = Graphics.FromImage(bmp);
            //    g.CopyFromScreen(0, 0, 0, 0, bmp.Size);
            //    saveFileDialog1.InitialDirectory = saveFileDialog1.FileName;
            //    saveFileDialog1.Filter = "BitMap Pictures (*.bmp)|*.bmp|All files (*.*)|*.*";
            //        if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            //        {
            //            try
            //            {
            //                bmp.Save(saveFileDialog1.FileName);

            //            }
            //            catch (Exception)
            //            {

            //            }
            //        }
            //}
            //error = false;
            if (!error)
            {
                var bmp = new Bitmap(Form1.ActiveForm.Width,Form1.ActiveForm.Height);
                Form1.ActiveForm.DrawToBitmap(bmp, new Rectangle(new Point(),Form1.ActiveForm.Size));




                saveFileDialog1.InitialDirectory = saveFileDialog1.FileName;
                saveFileDialog1.Filter = "BitMap Pictures (*.bmp)|*.bmp|All files (*.*)|*.*";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        bmp.Save(saveFileDialog1.FileName);

                    }
                    catch (Exception)
                    {

                    }
                }
            }
            error = false;
        }
        public void ShieldIncrement(ref Shields shd)
        {
            if (Armor.Text.Contains("Баклер") || Armor.Text.Contains("Buckler"))
                shd = Shields.Buckler;
            if (Armor.Text.Contains("Малый деревянный щит") || Armor.Text.Contains("small wooden shield"))
                shd = Shields.SmallWooden;
            if (Armor.Text.Contains("Малый стальной щит") || Armor.Text.Contains("small steel shield"))
                shd = Shields.SmallSteel;
            if (Armor.Text.Contains("Большой деревянный щит") || Armor.Text.Contains("heavy wooden shield"))
                shd = Shields.LargeWooden;
            if (Armor.Text.Contains("Большой стальной щит") || Armor.Text.Contains("heavy steel shield"))
                shd = Shields.LargeSteel;
            if (Armor.Text.Contains("Ростовой щит") || Armor.Text.Contains("tower shield"))
                shd = Shields.TowerShield;
        }
        
        
        

        
       
        public Form1()
        {
            InitializeComponent();
        }
        
        private void NPCgetter_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "image (txt) files (*.txt)|*.txt|All files (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    unit.GetPath = openFileDialog1.FileName;
                }
                catch (Exception)
                {

                }
            }
            GeneratingUnit();
            
        }

        private void ScrShot_Click(object sender, EventArgs e)
        {
            Screenshot();
            ScrShot.Enabled = false;
        }

        private void buttonRandom_Click(object sender, EventArgs e)
        {
            try
            {
                
                Armor.Text = Armor.Items[r.Next(0, Armor.Items.Count)].ToString();
                Weapons.Text = Weapons.Items[r.Next(0, Weapons.Items.Count)].ToString();
                Feat.Text = Feat.Items[r.Next(0, Feat.Items.Count)].ToString();
                ResultingTemp();
                ScrShot.Enabled = true;
            }
            catch (ArgumentOutOfRangeException)
            {
                MessageBox.Show("Заполните поле NPC", "Внимание", MessageBoxButtons.OK);
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(unit.GetWebPath);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {   
            FillingEmptyGaps();
            ResultingTemp();
            ScrShot.Enabled = true;
        }

        private void NPC_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
