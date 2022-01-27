namespace LrDb.Utilities;

public static class ConversionHelpers
{
    public static string? ExifApertureToHumanReadableString(double? dbValue)
    {
        //Initial Information: https://monster.partyhat.co/article/lightroom-catalog-visualization/
        if (dbValue == null) return null;

        return $"f/{Math.Round(Math.Pow(2, dbValue.Value / 2D), 1)}";
    }

    public static string? ExifShutterSpeedToHumanReadableString(double? dbValue)
    {
        //Initial Information: https://www.lightroomqueen.com/community/threads/lightroom-sqlite-database-structure.40118/
        if (dbValue == null) return null;

        if (dbValue < 0)
        {
            var calculatedValue = Math.Pow(2, dbValue.Value * -1D);
            return $"{calculatedValue:F0} {(calculatedValue > 1 ? "seconds" : "second")}";
        }

        return $"{Math.Round(Math.Pow(2, dbValue.Value), 0):F0} second";
    }

    public static string LrOrientationDescription(string lrOrientation)
    {
        return lrOrientation.ToUpper() switch
        {
            //Initial Information: https://community.adobe.com/t5/lightroom-classic-discussions/thumbnail-orientation/td-p/6811771
            "AB" => "No Orientation Change",
            "BC" => "Rotated 90° Clockwise",
            "CD" => "Rotated 180°",
            "DA" => "Rotated 90° Counter-Clockwise",
            "BA" => "Horizontal Mirror",
            "AD" => "Horizontal Mirror then Rotated 90° Clockwise",
            "DC" => "Vertical Mirror",
            "CB" => "Horizontal Mirror then Rotated 90° Counter-Clockwise",
            _ => $"Unknown LR Code: {lrOrientation}"
        };
    }

    public static DateTime LrTimeStampToDateTime(double lrTimeStamp)
    {
        // Credit to https://www.dpreview.com/forums/thread/4358462
        var baseDateTime = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        baseDateTime = baseDateTime.AddSeconds(lrTimeStamp).ToLocalTime();
        return baseDateTime;
    }

    public static double DateTimeToLrTimeStamp(DateTime toTranslate)
    {
        var baseDateTime = new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        return toTranslate.Subtract(baseDateTime).TotalSeconds;
    }
}