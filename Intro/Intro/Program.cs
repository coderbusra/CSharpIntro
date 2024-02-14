using Intro.Business;
using Intro.DateAccess.Concreat;
using Intro.Entities;

Console.WriteLine("Hello, World!");

string message1 = "Krediler";
string message2 = "Krediler";
string message3 = "Krediler";
string message4 = "Krediler";
string message5 = "Krediler";

int term = 12;
double amoun = 100;

//variables --> camelCase
bool isAuthenticated = false;
Console.WriteLine(message1);

// condition
if (isAuthenticated) //(isAuthenticated==true) aynı şey
{
    Console.WriteLine("Buton --> Hoşgeldin Engin");
}
else
{
    Console.WriteLine("Buton-->Sisteme giriş yap");
}

//Diziler Arrays
string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4", "Kredi 5", "Kredi 6" }; 
/*db den gelecek(veri tabanından)
                                                                                       
string[] loans2 = new string[]                                                                             
{
};*/

//string[] loans2 = new string[6];
//loans2[0] = "Kredi 1";

// start     condition      increment     
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}

CourseManager courseManager = new(new DapperCourseDal());

List<Course> courses2 = courseManager.GetAll();
for (int i = 0; i < courses2.Count; i++)
{
    Console.WriteLine(courses2[i].Name + "/" + courses2[i].Price);
}



Console.WriteLine("Kod bitti");

IndividualCustomer customer1 = new IndividualCustomer();
customer1.Id = 1;
customer1.NationalIdentity = "12345678910";
customer1.FirstName = "Aslı";
customer1.LastName = "Karayiğit";
customer1.CustomerNumber = "123456";

IndividualCustomer customer2 = new IndividualCustomer();
customer2.Id = 1;
customer2.NationalIdentity = "12345678910";
customer2.FirstName = "Özgür";
customer2.LastName = "Atılgan";
customer2.CustomerNumber = "123457";

CorporateCustomer customer3 = new CorporateCustomer();
customer3.Id = 3;
customer3.Name = "Kodlama.io";
customer3.CustomerNumber = "654779";
customer3.TaxNumber = "12345678985";

CorporateCustomer customer4 = new CorporateCustomer();
customer4.Id = 4;
customer4.Name = "ABC";
customer4.CustomerNumber = "654780";
customer4.TaxNumber = "12345678986";

//value types --> int, bool, double...
int number1 = 10;
int number2 = 30;
number1 = number2;
number2 = 50;
Console.WriteLine(number1);


//reference types --> array, class, interface...
string[] cities1 = { "Ankara", "İstanbul", "İzmir" };
string[] cities2 = { "Bursa", "Bolu", "Kahramanmaraş" };

cities2 = cities1;
cities1[0] = "Adana";

Console.WriteLine(cities2[0]);

//Inherit ve Implemente eden sınıflar Inherit ve Implemnete edildiiği sınıfların referasını tutabilir.
                              //101     //102       //103      //104

BaseCustomer[] customers = {customer1, customer2, customer3, customer4 };

//polymorphism
foreach (BaseCustomer customer in customers)
{
    Console.WriteLine(customer.CustomerNumber);
}

