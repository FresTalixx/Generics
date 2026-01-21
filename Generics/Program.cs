
double num1 = 10.1;
double num2 = 20.34;
double num3 = 15.2;

Console.WriteLine("Max of three integers: " + MathOperations<double>.MaxFromThree(num1, num2, num3));

Console.WriteLine("Min of three integers: " + MathOperations<double>.MinFromThree(num1, num2, num3));


double[] arr = { 10.5, 20.3, 30.2, 40.4, 50.1 };

Console.WriteLine("Sum of array elements: " + MathOperations<double>.SumOfArray(arr));

var stack = new GenericStack<double>();

stack.Push(num1);
stack.Push(num2);
stack.Push(num3);

Console.WriteLine($"Stack Length: {stack.Count()}");

Console.WriteLine($"Stack popped: {stack.Pop()}");
Console.WriteLine($"Stack Length: {stack.Count()}");

Console.WriteLine($"Stack peeked: {stack.Peek()}");
Console.WriteLine($"Stack Length: {stack.Count()}");



var alphabet = new Alphabet();

foreach ( char c in alphabet )
{
    Console.Write($"{c} ");
}



Console.WriteLine("Task6");

List<int> list1 = new List<int>() { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };

Predicate<int> isEvenPredicate = (int num1) => num1 % 2 == 0;
Predicate<int> isNegativePredicate = (int num2) => num2 >= 0;

List<int> newList = ListSort<int>.FilterByTwoCriteria(list1, isEvenPredicate, isNegativePredicate);

foreach ( int i in newList )
{
    Console.Write(i + " ");
}

Console.WriteLine();


var resident1 = new Resident()
{
    Name = "John",
    Age = 26,
    Job = "Chief of police"
};


var resident2 = new Resident()
{
    Name = "Alice",
    Age = 22,
    Job = "Builder"
};


var resident3 = new Resident()
{
    Name = "Olivia",
    Age = 12,
    Job = "Student"
};

var resident4 = new Resident()
{
    Name = "William",
    Age = 44,
    Job = "Developer"
};

var resident5 = new Resident()
{
    Name = "Mark",
    Age = 34,
    Job = "Supervisor"
};

Resident[] apartment1Residents = [resident1, resident2];
Resident[] apartment2Residents = [resident3, resident4];
Resident[] apartment3Residents = [resident5];

var apartment1 = new Apartment()
{
    Residents = apartment1Residents
};

var apartment2 = new Apartment()
{
    Residents = apartment2Residents
};

var apartment3 = new Apartment()
{
    Residents = apartment3Residents
};

Apartment[] buildingApartments = [apartment1, apartment2, apartment3];

var building = new Building()
{
    Apartments = buildingApartments
};

foreach (var apart in building)
{
    Console.WriteLine(apart);
}


var book1 = new EBook()
{
    Title = "The Great Gatsby",
    Author = "F. Scott Fitzgerald",
    ReleaseDate = "1925",
    Genre = "Novel",
    FontSize = 12
};

var book2 = new EBook()
{
    Title = "1984",
    Author = "George Orwell",
    ReleaseDate = "1949",
    Genre = "Dystopian",
    FontSize = 14
};

var book3 = new EBook()
{
    Title = "To Kill a Mockingbird",
    Author = "Harper Lee",
    ReleaseDate = "1960",
    Genre = "Southern Gothic",
    FontSize = 14
};


var ELirary = new Library<EBook>();

ELirary.AddBook(book1);
ELirary.AddBook(book2);
ELirary.AddBook(book3);

foreach (var book in ELirary)
{
    Console.WriteLine(book);
}

Predicate<EBook> sortByFont14 = (EBook book) => book.FontSize == 14;

List<EBook> books = ELirary.SortBooksByCriteria(sortByFont14);

Console.WriteLine();

foreach (EBook book in books)
{
    Console.WriteLine(book);
}