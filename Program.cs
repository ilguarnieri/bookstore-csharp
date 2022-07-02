string title = "Harry Potter e i doni della morte";
string author = "J. K. Rowling";
string isbn = "978-8831003445";
short pagesNum = 688;
short weight = 480;
float width = 13.6f;
float height = 20.3f;
float depth = 4.8f;
float rating = 4.9f;
float reviewsNum = 2548;
bool kindleVersion = true;
bool flexCover = true;


Console.WriteLine("\nBOOK INFO:");
Console.WriteLine($"Title: {title}");
Console.WriteLine($"Author: {author}");
Console.WriteLine($"ISBN: {isbn}");
Console.WriteLine($"Pages: {pagesNum}");
Console.WriteLine($"Weight: {weight}g");
Console.WriteLine($"Dimensions: {height}cm x {width}cm x {depth}cm");
Console.WriteLine($"Rating: {rating}/5");
Console.WriteLine($"Reviews: {reviewsNum}");

Console.Write("Kindle version available: ");
if (kindleVersion)
{
    Console.Write("yes\n");
}
else
{
    Console.Write("no\n");
}

Console.Write("Flexible cover version available: ");
if (flexCover)
{
    Console.Write("yes\n");
}
else
{
    Console.Write("no\n");
}