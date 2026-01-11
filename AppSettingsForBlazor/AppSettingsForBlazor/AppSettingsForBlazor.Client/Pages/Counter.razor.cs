namespace AppSettingsForBlazor.Client.Pages
{
    public partial class Counter
    {
        private int currentCount = 0;

        private void IncrementCount()
        {
            currentCount++;
            Console.WriteLine($"Count incremented to: {currentCount}"); // I don't know if this was even necessary
        }
    }
}
