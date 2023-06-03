using System.Globalization;

string sName = "Aga";
char cGender = 'K';
int iAge = 20;

string sText1 = "Kobieta poniżej 30 lat";
string sText2 = "Ewa, lat 33";
string sText3 = "Niepełnoletni mężczyzna";

if (cGender == 'K')
{
    if (iAge < 30)
    {
        Console.WriteLine(sText1);
    }
    else if (sName == "Ewa" && iAge == 33)
    {
        Console.WriteLine(sText2);
    }
}
else if (iAge < 18)
{
    Console.WriteLine(sText3);
}

