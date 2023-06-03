int number = 1998;
char[] digits = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
int[] noOfDigits = new int[digits.Length];

char[] cNumber = number.ToString().ToArray();
foreach (var item in cNumber)
{
    for (int i = 0; i < digits.Length; i++)
    {
        if (item == digits[i])
        {
            noOfDigits[i]++;
            break;
        }
    }
}
for (int i = 0; i < digits.Length; i++)
{
    Console.WriteLine(digits[i] + " ==> " + noOfDigits[i]);
}