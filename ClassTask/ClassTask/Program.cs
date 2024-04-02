//Task1
//internal class Program
//{
//static void Main(string[]args)
//{

// int[] arr1 = { 2, 3, 4, 7 };
// int[] arr2 = { 3, 4,7};
//    bool check=false;
//    for (int i = 0; i < arr1.Length; i++)
//    {
//       for (int j = 1; j < arr2.Length; j++)
//        {
//            if (arr2[j] > arr2[j-1] &&arr1[i] == arr2[j])
//            {
//                check = true;

//            }
//            else
//            {
//                check = false;
//            }



//        }
//    }
//        Console.WriteLine(check);

//Task2
internal class Program
{
    static void Main(string[] args)
    {
        User[] user = new User[]
        {
            new User{UserName="pashama",Password="Salam123",Name="Pasha",Surname="Allahverdiyev"},
        new Student { UserName = "asdf", Password = "Salam123", Name = "Pasha", Surname = "Allahverdiyev",Grade=99 }
        };
        Console.WriteLine("User Name daxil edin: ");
        string username = Console.ReadLine();
        Console.WriteLine("Parolunuzu daxil edin: ");
        string password = Console.ReadLine();

        User currentUser = null;
        foreach (User user1 in user)
        {

            if (user1.UserName == username && user1.Password == password)
            {
                currentUser = user1;
                break;
            }
        }
        if (currentUser != null)
        {
            Console.WriteLine($"Xoş geldiniz, {currentUser.Name} {currentUser.Surname}");

            if (currentUser is Student)
            {
                Student student = (Student)currentUser;
                Console.WriteLine($"Qiymet: {student.Grade}");
            }
        }
        else
        {
            Console.WriteLine("User Name ve ya Sifre yalnisdir  ");
        }


    }


}

public class User
{
    public string Name { get; set; }
    public string Surname { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

}
public class Student : User
{
    public int Grade { get; set; }
}
