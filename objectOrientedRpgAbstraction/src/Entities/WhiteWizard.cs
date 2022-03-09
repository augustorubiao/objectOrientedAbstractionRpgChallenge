namespace objectOrientedRpgAbstraction.src.Entities
{
    public class WhiteWizard : Hero
    {
        public WhiteWizard(string Name, int Level, string HeroType, int HP, int MP)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
            this.HP = HP;
            this.MP = MP;
        }
        public override string Attack()
        {
            return this.Name + " lançou uma magia!";
        }

        public string Attack(int Bonus){

            if (Bonus > 6){
                            return this.Name + " casted an overcharged spell. Bonus damage of " + Bonus + ".";
            }else
                return this.Name + " casted a spell. There were additional damange of " + Bonus + ".";
        }

    }
}