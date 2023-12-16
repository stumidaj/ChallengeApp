namespace to_ten
{
    public class User
    {
        private List<int> score = new List<int>();

        public User(string imie, string nazwisko, string wiek)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.wiek = wiek;
        }

        public string imie { get; private set; }

        public string nazwisko { get; private set; }

        public string wiek { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int numberOfScore)
        {
            this.score.Add(numberOfScore);
        }
    }
}
