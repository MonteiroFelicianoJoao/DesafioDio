namespace jogo_rpg.src.Entities
{
    public class Hero
    {
        public Hero(string name, int level, string heroType)
        {
            this.Name = name;
            this.Level = level;
            this.HeroType = heroType;
            this.HitPoints = 0;
            this.MagicPoints = 0;
        }

        public string Name;
        public int Level;
        public string HeroType;
        public int HitPoints;
        public int MagicPoints;

        public override string ToString()
        {
            return this.Name + " " + this.Level + " " + this.HeroType + "\n" + "HP: " + this.HitPoints + " " + "MP: " + this.MagicPoints;
        }
        public virtual string Moto()
        {
            return this.Name + "Diz: Minha função é... ";
        }
        public virtual string Action( )
        {
            return this.Name + "Does... ";
        }
        public virtual int AttackPower()
        {
            return 10 + Level; 
        }
        public virtual string SpecialMove()
        {
            return this.Name + "Uses special move: ";
        }
    }
}