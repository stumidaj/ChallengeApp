using to_ten;

User employee1 = new User("Stasiu", "Nowak", "25");
User employee2 = new User("Maniek", "Kowalski", "36");
User employee3 = new User("Stefan", "Szela", "47");



employee1.AddScore(5);
employee1.AddScore(10);
employee1.AddScore(1);  
employee1.AddScore(2);

employee2.AddScore(3);
employee2.AddScore(9);
employee2.AddScore(7);
employee2.AddScore(12);

employee3.AddScore(1);
employee3.AddScore(10);
employee3.AddScore(9);
employee3.AddScore(2);

int scoreOfEmpl1 = employee1.Result;
int scoreOfEmpl2 = employee2.Result;
int scoreOfEmpl3 = employee3.Result;


if (scoreOfEmpl1 > scoreOfEmpl2 && scoreOfEmpl1 > scoreOfEmpl3)
{
    Console.WriteLine("największy wynik uzyskał: " + employee1.imie + " " + employee1.nazwisko + " w wieku " + employee1.wiek + " z łączną sumą punktów: " + scoreOfEmpl1 + " Gratulacje");
}

else if (employee2.Result > employee1.Result && employee2.Result > employee3.Result)
{
    Console.WriteLine("największy wynik uzyskał: " + employee2.imie + " " + employee2.nazwisko + " w wieku " + employee2.wiek + " z łączną sumą punktów: " + scoreOfEmpl2 + " Gratulacje");
}

else if (employee3.Result > employee1.Result && employee3.Result > employee2.Result) 
{
    Console.WriteLine("największy wynik uzyskał: " + employee3.imie + " " + employee3.nazwisko + " w wieku " + employee3.wiek + " z łączną sumą punktów: " + scoreOfEmpl3 + " Gratulacje");
}







