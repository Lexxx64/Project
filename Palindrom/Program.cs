Console.WriteLine("Проверка на палиндром 1.0");
Console.WriteLine("Введите данные для проверки: ");
string text = Console.ReadLine()!;
text = text.Replace(" ", "");
char[] obrtext = text.ToCharArray();
Array.Reverse(obrtext);
string revertext = new string(obrtext);
if (text == revertext){
    Console.Write($"Является палиндромом!");
}
else{
    Console.Write($"Не является палиндромом!");
}

