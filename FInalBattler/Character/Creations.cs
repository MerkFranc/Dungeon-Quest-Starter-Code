namespace FinalBattler.Character
{
    public class Creations
    {
        public string Name { get; set; } = string.Empty;
        public int Level { get; set; }
        private int _totalHealth;
        public int TotalHealth { get => _totalHealth; set => _totalHealth = value < 0 ? 0 : value; }
        private int _totalPower;
        public int TotalPower { get => _totalPower; set => _totalPower = value < 0 ? 0 : value; }
        private int _totalLuck;
        public int TotalLuck { get => _totalLuck; set => _totalLuck = value < 0 ? 0 : value; }
    }
}
