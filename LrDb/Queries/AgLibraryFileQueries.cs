using LrDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LrDb.Queries;

public static class AgLibraryFileQueries
{
    public static async Task<List<Adobe_images>> AdobeImages(AgLibraryFile source, LrDbContext context)
    {
        return await context.Adobe_images.Where(x => x.rootFile == source.id_local).ToListAsync()
            .ConfigureAwait(false);
    }

    public static async Task<List<AgLibraryFileConsolidatedData>> ConsolidateData(List<AgLibraryFile> source, LrDbContext context)
    {
        var returnList = new List<AgLibraryFileConsolidatedData>();

        foreach (var loopFiles in source)
        {
            returnList.Add(await ConsolidateData(loopFiles, context));
        }

        return returnList;
    }

    public static async Task<AgLibraryFileConsolidatedData> ConsolidateData(AgLibraryFile source, LrDbContext context)
    {
        var images = await AdobeImages(source, context);

        var consolidatedImages = new List<AdobeImageConsolidatedData>();

        foreach (var loopImage in images)
        {
            consolidatedImages.Add(await AdobeImageQueries.ConsolidatedData(loopImage, context));
        }

        return new AgLibraryFileConsolidatedData
        {
            File = source,
            Images = consolidatedImages
        };
    }

}