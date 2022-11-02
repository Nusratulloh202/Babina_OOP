
System.Console.Write("As salomu alaykum hurmatli foydalanuvchi\nIsmingizni kiriting:");
string? userName=Console.ReadLine();
System.Console.Write($"{userName} yoshingizni kiriting:");
int userAge =Convert.ToInt32(Console.ReadLine());

Random rand = new Random();
int number1=rand.Next(1,100);
int number2=rand.Next(1,99);
System.Console.Write($"Robot emasligezni aniqlaymiz.\n{number1}+{number2}=");
int javob= Convert.ToInt32(Console.ReadLine());
if (javob == number1+number2)
    System.Console.WriteLine("Siz robot emasligez tasdiqlandi.\nTizimga kirishingiz mumkin!");
else
{
    System.Console.WriteLine("Javob notug'ri");
}    
System.Console.Write($"{userName} tizimga kirish kodingizni kiriting:");
string? password=Console.ReadLine();
switch (password)
{
    case "AC1929891":
        System.Console.WriteLine("Xo'jayin siz tizimga kirdingiz!");
        break;
    case "":
        System.Console.WriteLine("Siz kod kiritmadingiz!!!");
        switch (password)
        {
            case "":
            break;
           
        }
        break;
    case "kod":
        System.Console.WriteLine("Ishchi siz tizimga kirdingiz!");    
        break;


    default:
    {
        System.Console.WriteLine("Foydalanuvchi siz tizimga kirdingiz!");
        break;
    }
}
string[] dostlar={"Nazarbek","Asilbek","Muhammadsodiq", "Komron"};
int x=dostlar.Length;
System.Console.WriteLine($"Sizning do'stlaringiz soni {x} ta");
for (int i = 0; i < dostlar.Length; i++)
{
    System.Console.Write($"{i+1} chi do'stingiz {dostlar[i]}, ");
}





