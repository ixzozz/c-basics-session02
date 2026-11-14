//01

using System.Linq.Expressions;

Book myBook = new Book { Title = "the lion", Pages = 100 };
object obj = myBook;
Console.WriteLine(obj);

//02

Book book = new Book { Title = "the lion", Pages = 100 };
Console.WriteLine(book.ToString());
Console.WriteLine(book.Equals(book));
Console.WriteLine(book.GetHashCode());
Console.WriteLine(book.GetType());

//03

    int pages = 464;
    Console.WriteLine(pages);

//04


    int a = 10;
    int b = 0;

    try

    {
        Console.WriteLine("a / b = " + (a / b));
    }

    catch 

    {
        Console.WriteLine("Cannot divide by zero.");
    }
finally
{
    Console.WriteLine("DONE");
}

//05
{
    int pages01 = 300;
    double doublePages = pages01;
    Console.WriteLine(doublePages);
}

//06

double price = 49.99;
int intPrice = (int)price;
Console.WriteLine(intPrice);

//07


{
    string pagesText = "464";
    int pages02 = int.Parse(pagesText);
    Console.WriteLine(pages02);
}

//08 not answered

//09

{
    int pages03 = 464;
    string pagesText02 = pages03.ToString();
    Console.WriteLine(pagesText02.GetType());
}

//10

{

    int copies = 100;
    object boxedCopies = copies;          
    int unboxedCopies = (int)boxedCopies; 
    Console.WriteLine(boxedCopies);       
    Console.WriteLine(unboxedCopies);    
}

class Book
{
    public string Title;
    public int Pages;
}
