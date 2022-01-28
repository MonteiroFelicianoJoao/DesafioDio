namespace jogo_rpg.src.Entities
{
    public class BlackWizzard : Hero
    {
        public BlackWizzard(string name, int level, string heroType) : base(name, level, heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HitPoints = 80;
            this.MagicPoints = 180;
        }
        public override string Moto()
        {
            return this.Name + " Diz: Muahhahhahhaha!!!!!";
        }
        public override string Action()
        {
            return this.Name + "Ataca com a varinha das trevas. Dano:" + " " + base.AttackPower() + 5;
        }
        public override string SpecialMove()
        {
            return base.SpecialMove() + "Invocar esqueletos, Quantidade:" + " " + Level / 3;
        }
    }
}