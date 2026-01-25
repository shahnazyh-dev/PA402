//Console.BackgroundColor = ConsoleColor.Yellow;
//Console.WriteLine( "hello world");
//Console.ReadLine();

//

////
//
//using System.Threading.Channels;

//Console.WriteLine("salam");
//int data = Convert.ToInt32(Console.ReadLine());
//data = 5;

////string yes = "0 dan kicikdir:";

//string something = data switch
//{
//    <= 0 => "kicikdir",

//    >= 3 => "boyukdur ",

//    _ => "hecne yoxdur",

//}; Console.WriteLine(something);




//Console.WriteLine("eded ver");
//int a = Convert.ToInt32(Console.ReadLine());


//switch (a)
//{
//    case 1:
//        Console.WriteLine("1ci gun");
//        break;
//    case 3:
//        Console.WriteLine("3 cu gun");
//        break;
//    default:
//        Console.WriteLine("hec birine aid deyil");
//        break;
//}
Console.WriteLine("en boyuk reqem");
int a= Convert.ToInt32(Console.ReadLine());
int b= Convert.ToInt32(Console.ReadLine());
int c= Convert.ToInt32(Console.ReadLine());

if (a>b && a>c)
{
    Console.WriteLine("en boyuk1"+a);
}
else if (b>a && b>c)
{
    Console.WriteLine("en boyuk2" +b);
}
else

    Console.WriteLine("en boyuk3" + c);


