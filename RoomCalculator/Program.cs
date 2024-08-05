/*Task: Calculate the perimeter and area of a room.

What will the application do?
1 Point The application prompts the user to enter values of length and width of the classroom.
2 Points: The application displays the area and perimeter of that classroom.
2 Points: The application classifies the room as small (up to and including 250 square feet), medium (more than 250 but less than 650 square feet), or large (650 square feet or more).

Build Specifications:
1 Point: Assume that the rooms are rectangles (90 degree corners).
1 Point: Assume that the user will enter valid numeric data for length and width.
1 Point: The application should accept decimal entries.
*/

using System.Formats.Asn1;

Console.WriteLine("Welcome to Room Calculator!");
Console.WriteLine();

Console.WriteLine("Please enter the length of your classroom in feet.");
double length = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("What is the width of your classroom in feet?");
double width = double.Parse(Console.ReadLine());
Console.WriteLine();

Console.WriteLine("Please enter the height of your classroom in feet.");
double height = double.Parse(Console.ReadLine());
Console.WriteLine();

var area = length * width;
Console.WriteLine($"The area of the room is {area} square feet.");

var perimeter = (length * 2) + (width * 2);
Console.WriteLine($"The perimeter of the room is {perimeter} feet.");

var surface = ((length * width) * 2) + ((height * length) * 2) + ((width * height) * 2);
Console.WriteLine($"The surface area is {surface} square feet.");

var volume = (length * width * height);
Console.WriteLine($"The volume of the room is {volume} cubic feet.");
Console.WriteLine();

if (area <= 250)
{
    Console.WriteLine("Your classroom seems small.");
}
else if (area > 250 && area <= 650)
{
    Console.WriteLine("Your classroom size is medium.");
}
else if (area > 650)
{
    Console.WriteLine("Whoa there, big dawg! Your classroom is large!");
}