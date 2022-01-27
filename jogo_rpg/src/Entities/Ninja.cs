namespace jogo_rpg.src.Entities
{
    public class Ninja : Hero
    {
        public Ninja(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HitPoints = 150;
            this.MagicPoints = 80;
        }
        public override string Moto()
        {
            return this.Name + " Eu sou um com as sombras!";
        }
        public override string Action()
        {
            return this.Name + " Ataca com a shuriken. Dano:" + " " + $"{base.AttackPower()}";
        }
        public override string SpecialMove()
        {
            return base.SpecialMove() + " Shadow Strike, Dano:" + " "  + AttackPower() + 5 ;
        }
    }
}