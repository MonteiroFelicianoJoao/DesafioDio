namespace jogo_rpg.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HitPoints = 200;
            this.MagicPoints = 100;
        }
        public override string Moto()
        {
            return this.Name + " Diz: Pela Aliança!";
        }
        public override string Action()
        {
            return this.Name + " Ataca com a espada. Dano:" + " " + $"{base.AttackPower()}";
        }
        public override string SpecialMove()
        {
            return base.SpecialMove() + " Divine Smite, Dano:" + " " + AttackPower() * 2 ;
        }
    }
}