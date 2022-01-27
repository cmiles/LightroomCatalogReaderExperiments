using System.Text;

namespace LrDb.Queries;

public static class AdobeImageDevelopSettingsQueries
{
    //public async Task<AdobeImageDevelopSettingsCommonSettings> CommonSettings(Adobe_imageDevelopSettings source,
    //    LrDbContext context)
    //{
    //}


    public static Dictionary<string, string> ParseDevelopString(string source)
    {
        if (string.IsNullOrWhiteSpace(source)) return new Dictionary<string, string>();

        if (source.StartsWith("s = {")) source = source.Substring(5, source.Length - 6);

        var developDictionary = new Dictionary<string, string>();

        var buildingKey = true;

        var bracketCounter = 0;
        var quoteCounter = 0;

        var currentKey = string.Empty;

        var keyStringBuilder = new StringBuilder();
        var valueStringBuilder = new StringBuilder();

        foreach (var loopChar in source)
        {
            if (buildingKey)
            {
                //When looking for a key ignore new lines - they will be preserved 'inside' values
                if (loopChar is '\n' or '\r') continue;

                if (loopChar == '=')
                {
                    currentKey = keyStringBuilder.ToString().Trim();
                    buildingKey = false;
                    keyStringBuilder.Clear();
                    continue;
                }

                keyStringBuilder.Append(loopChar);
                continue;
            }

            if (bracketCounter == 0 && quoteCounter % 2 == 0 && loopChar == ',')
            {
                developDictionary.Add(currentKey, valueStringBuilder.ToString().Trim());
                currentKey = string.Empty;
                valueStringBuilder.Clear();
                buildingKey = true;
                continue;
            }

            valueStringBuilder.Append(loopChar);

            if (loopChar == '{') bracketCounter++;
            if (loopChar == '}') bracketCounter--;
            if (loopChar == '"') quoteCounter++;
        }

        return developDictionary;
    }
}

public class AdobeImageDevelopSettingsCommonSettings
{
    public double Blacks { get; set; }
    public double Clarity { get; set; }
    public double Contrast { get; set; }
    public double Dehaze { get; set; }
    public double Exposure { get; set; }
    public double Highlights { get; set; }

    public string LensProfileName { get; set; }

    public string ProcessVersion { get; set; }
    public string Profile { get; set; }
    public double Saturation { get; set; }
    public double Shadows { get; set; }
    public double Temp { get; set; }
    public double Texture { get; set; }
    public double Tint { get; set; }

    public string Treatment { get; set; }
    public double Vibrance { get; set; }
    public string WhiteBalance { get; set; }
    public double Whites { get; set; }
}