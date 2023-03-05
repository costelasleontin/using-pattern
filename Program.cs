//The old using pattern
using (FileStream file1 = File.OpenWrite(Path.Combine(Environment.CurrentDirectory, "file2.txt")))
{
    using (StreamWriter writer1 = new StreamWriter(file1))
    {
        try
        {
            writer1.WriteLine("Testing the old -Using Pattern- ");
        }
        catch (Exception ex)
        {
            WriteLine($"{ex.GetType()} says {ex.Message}");
        }
    } // automatically calls Dispose if the object is not null
} // automatically calls Dispose if the object is not null


//The new using pattern
//Comment out this section to use the old pattern
using FileStream file2 = File.OpenWrite(Path.Combine(Environment.CurrentDirectory, "file2.txt"));
using StreamWriter writer2 = new(file2);
try
{
    writer2.WriteLine("Testing the new -Using Pattern- ");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
// at the end off the streams usage the compiler schedulles the call to Dispose