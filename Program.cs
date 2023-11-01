namespace listkoleksyon;

class Program
{
    static void Main(string[] args)
    {
        // list<T> class
        //System.Collection.Generic
        // Object türündedir
/*
        List<int> numberList=new List<int>();
        numberList.Add(21);
        numberList.Add(23);
        numberList.Add(56);
        numberList.Add(5);
        numberList.Add(34);

        List<string> colourList=new List<string>();
        colourList.Add("red");
        colourList.Add("yellow");
        colourList.Add("pink");
        colourList.Add("black");

        //count
        Console.WriteLine("-----------------");
        Console.WriteLine(numberList.Count());
        Console.WriteLine(colourList.Count());

        //foreach
        Console.WriteLine("-----------------");
        foreach(var item in numberList){
            Console.WriteLine(item);
        }
        foreach(var item in colourList){
            Console.WriteLine(item);
        }
        // List foreach
        Console.WriteLine("-----------------");
        numberList.ForEach(item=>Console.WriteLine(item));
        colourList.ForEach(item=>Console.WriteLine(item));

        //listeden eleman çıkatmak
        Console.WriteLine("-----------------");
        numberList.Remove(21);
        colourList.Remove("pink");
        numberList.ForEach(item=>Console.WriteLine(item));
        colourList.ForEach(item=>Console.WriteLine(item));

        //removeAT

        numberList.RemoveAt(1);
        colourList.RemoveAt(1);
        Console.WriteLine("-----------------");
        numberList.ForEach(item=>Console.WriteLine(item));
        colourList.ForEach(item=>Console.WriteLine(item));

        //lİST İÇERİNDE ARAMA
        Console.WriteLine("-----------------");

        
        if(numberList.Contains(34)){
            Console.WriteLine("34 liste içerisinde bulundu.");
        }
        
        Console.WriteLine(colourList.BinarySearch("red"));

        //diziyi list e cevirme

        string[] animalsString= {"cat","dog","bird"};
        List<string> animalsList=new List<string>(animalsString);

        //list temizleme
        animalsList.Clear();
*/
        //Liste içerinde nesne tutmak

        List<Users> userList=new List<Users>();
        Users user1=new Users();
        Users user2=new Users();
        user1.Name="TURAN";
        user1.Surname="BARUT";
        user1.Age=27;

        user2.Name="Berna";
        user2.Surname="Barut";
        user2.Age=28;

        userList.Add(user1);
        userList.Add(user2);

        foreach(var item in userList){
            Console.WriteLine(item.Name+item.Surname+item.Age);
        }
        
       // userList.ForEach(item=>Console.WriteLine(item));
        Users user3=new Users();
        user3.Name="Doğa";
        user3.Surname="Barut";
        user3.Age=0;

        Console.WriteLine(user3.Name+user3.Surname+user3.Age);

        userList.Add(user3);

        foreach(var item in userList){
            Console.WriteLine(item.Name+item.Surname+item.Age);
        }

       
        userList.Clear();
     }
 
        
        
    }
}
public class Users{
    string name;
    string surname;
    int age;

    public string Surname { get => surname; set => surname = value; }
    public string Name { get => name; set => name = value; }
    public int Age { get => age; set => age = value; }
}
