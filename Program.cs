namespace GPCI;

internal class Program {
    private static void Main(string[] args) {
        string userHomePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string gtaSanAndreasUserFiles = Path.Combine(userHomePath, "GTA San Andreas User Files");

        var hash = GPCI.Calculate(gtaSanAndreasUserFiles[4..]);

        Console.WriteLine($"GPCI Hash: {hash}");
    }
}