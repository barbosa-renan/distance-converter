namespace DistanceConverterAPI;

public static class DistanceConverter
{
    /// <summary>
    /// Multiplies the miles value by a constant and returns the result in kilometers
    /// </summary>
    /// <param name="miles">Value in Miles</param>
    /// <returns>Result in kilometers</returns>
    public static double ToKilometers(double miles)
    {
        return Math.Round(miles * 1.609344, 1);
    }

    /// <summary>
    /// Multiplies the kilometer value by a constant and returns the result in miles
    /// </summary>
    /// <param name="kilometers"></param>
    /// <returns></returns>
    public static double ToMiles(double kilometers)
    {
        return Math.Round(kilometers * 0.621371192, 1);
    }
}