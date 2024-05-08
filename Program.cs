namespace GPCI;

internal class Program {
    private static void Main(string[] args) {
        string gtaSanAndreasUserFiles = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "GTA San Andreas User Files");

        Console.WriteLine($"GPCI Hash: {GPCI.Calculate(gtaSanAndreasUserFiles[4..])}");
    }
}