using GenerikusPeldaProjekt;

string jegy1 = "5";
string jegy2 = "4";

Cserelo<string>.Csere(ref jegy1, ref jegy2);

Console.WriteLine(jegy1);
Console.WriteLine(jegy2);

Student lukrecia = new Student
{
    Name = "Lukrécia",
    Age = 16
};
Student szerenke = new Student
{
    Name = "Szerénke",
    Age = 17
};
