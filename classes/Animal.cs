class Animal
{
    string name="";
    int age=0;
    

  public void helloName()
  {
    System.Console.Write("As salomu alaykum hurmatli foydalanuvchi\nIsmingizni kiriting:");
    string? userName=Console.ReadLine();  
    this.name=userName;
  }
  public void ageUser()
  {
    string ism =this.name;
    System.Console.Write($"{ism} yoshingizni kiriting:");
    this.age=Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine($"{ism} ma'lum bo'lishicha sizning yoshingiz {this.age} da.");
  }
  public void  randomTest()
  {
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
  }
  public void passwordCod()
  {
    System.Console.Write($"{this.name} tizimga kirish kodingizni kiriting:");
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
  }

public void dostlarr()
{
  string[] dostlar={"Nazarbek","Asilbek","Muhammadsodiq", "Komron"};
  int x=dostlar.Length;
  System.Console.WriteLine($"Sizning do'stlaringiz soni {x} ta");
  for (int i = 0; i < x-1; i++)
  {
      System.Console.Write($"{i+1} chi do'stingiz {dostlar[i]},\n");
  }
  System.Console.Write($"{x} chi do'stingiz {dostlar[x-1]}.");
}







}