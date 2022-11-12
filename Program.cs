
Console.Write("Password : ");
string password = Console.ReadLine();
char[] inputPassword = password.ToCharArray();
int passwordLength = password.Length;
char[] alphabet = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z',
 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'İ', 'J', 'K', 'K', 'M', 'N', 'O', 'P', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
 '.',',','+','-','%','&','@','*','/','0','1','2','3','4','5','6','7','8','9'};
int alphabetLength = alphabet.Length;

string uretilen = " ";

for (int j = 0; j < passwordLength; j++)
{
    for (int i = 0; i < alphabetLength; i++)
    {
        if (inputPassword[j] == alphabet[i])
        {
            uretilen = uretilen + alphabet[i];
        }
    }

}
Console.WriteLine("Password Found : " + uretilen.Trim());