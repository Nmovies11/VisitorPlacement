using VisitorPlacementLibrary;



Section section1 = new Section("a", 3, 3);
Section section2 = new Section("b", 2, 10);

List<Section> sections = new List<Section>();

sections.Add(section1);
sections.Add(section2);

foreach (var section in sections)
{
    Console.WriteLine($"Section: {section.SectionLetter}");

    foreach (var row in section.rows)   
    {
        Console.WriteLine($"  Row: {row.RowName}");

        // Concatenate seat codes horizontally with proper formatting
        string seatCodes = string.Join(", ", row.seats.Select(seat => seat.SeatCode));

        // Print seat codes with a line separator
        Console.WriteLine($"    Seats: {seatCodes}");
        Console.WriteLine($"    ---------------------------------------------");
    }

    // Add an empty line between sections
    Console.WriteLine();
}