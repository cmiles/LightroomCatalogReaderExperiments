using LrDb.Models;

namespace LrDb.Queries;

public class AgLibraryFileConsolidatedData
{
    public AgLibraryFile? File { get; set; }

    public List<AdobeImageConsolidatedData> Images { get; set; } = new List<AdobeImageConsolidatedData>();
}