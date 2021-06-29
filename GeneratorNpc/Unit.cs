
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace GeneratorNpc
{
    public class Unit
    {
        public int StrMod = 0;
        public int DexMod = 0;
        public int ConMod = 0;
        public int IntMod = 0;
        public int WisMod = 0;
        public int ChaMod = 0;
        public int NaturalAC = 0;
        protected double CR = 1;
        public string[] Alignment;
        public string[] ConstLanguages;
        public string ConstSkills;
        protected int Melee = 0;
        protected int TotalHP = 0;
        protected int Speed = 0;
        private string path;
        private string WebPath;
        public double GetCR
        {
            get { return CR; }
            set { if (CR > 0) { CR = value; } }
        }
        public int GetSpeed
        {
            get { return Speed; }
            set { if (value >= 0) { Speed = value; } }
        }
        public int GetMelee
        {
            get { return Melee; }
            set { Melee = value; }
        }
        public int GetTotalHp
        {
            get { return TotalHP; }
            set { if (value > 0) { TotalHP = value; } }
        }
        public string GetWebPath
        {
            get
            {
                return WebPath;
            }
            set
            {
                this.WebPath = value;
            }
        }
        public string GetPath
        {
            get { return path; }
            set { path = value; }
        }
        public int SpeedPenalty(string text)
        {
            if (!(text.Contains("light") || text == ""))

                if (Speed == 30)
                {
                    Speed = 20;
                }
                else if (Speed == 20)
                {
                    Speed = 15;
                }
            return Speed;
        }
        public static void Transfer(Unit temp, Unit unit)
        {
            temp.GetMelee = unit.GetMelee;
            temp.GetSpeed = unit.GetSpeed;
            temp.GetTotalHp = unit.GetTotalHp;
            temp.ConstLanguages = unit.ConstLanguages;
            temp.ConstSkills = unit.ConstSkills;
            temp.GetCR = unit.GetCR;
            temp.StrMod = unit.StrMod;
            temp.DexMod = unit.DexMod;
            temp.ConMod = unit.ConMod;
            temp.IntMod = unit.IntMod;
            temp.WisMod = unit.WisMod;
            temp.ChaMod = unit.ChaMod;
            temp.NaturalAC = unit.NaturalAC;
            temp.Alignment = unit.Alignment;


        }

    }
}