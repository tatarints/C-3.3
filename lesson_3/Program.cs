string str = @"Сладких снов и сновидений, Татьяна";
char[] ar = str.ToCharArray();

int c = ar.Length;               // длина массива
int k = c / 2;                   // середина массива
char lastIndex;                  // вспомогательный элемент для обмена значениями
for (int i = 0; i < k; i++)
{
    lastIndex = ar[i];
    ar[i] = ar[c - i - 1];
    ar[c - i - 1] = lastIndex;
}
foreach (int i in ar)
{
    Console.Write((char)(i));
}