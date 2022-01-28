namespace jogo_rpg.src.Entities
{
    public class WhiteWizzard : Hero
    {
        public WhiteWizzard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HitPoints = 200;
            this.MagicPoints = 100;
        }
        public override string Moto()
        {
            return this.Name + " Diz: Pela luz!";
        }
        public override string Action()
        {
            return this.Name + "Ataca com o cajado. Dano:" + " " + base.AttackPower() + 7;
        }
        public override string SpecialMove()
        {
            return base.SpecialMove() + "Cura:" + " " + Level * 2 + " " + "pontos de vida.";
        }
    }
}