namespace SII_House_Prediction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Load sample data
            var sampleData = new MLModel1.ModelInput()
            {
                Longitude = -122.22F,
                Latitude = 37.86F,
                Housing_median_age = 21F,
                Total_rooms = 7099F,
                Total_bedrooms = 1106F,
                Population = 2401F,
                Households = 1138F,
                Median_income = 8.3014F,
                Ocean_proximity = @"NEAR BAY",
            };

            //Load model and predict output
            var result = MLModel1.Predict(sampleData);
            Console.WriteLine($"Pret: {result.Score}");
            Console.ReadLine();
        }
    }
}
