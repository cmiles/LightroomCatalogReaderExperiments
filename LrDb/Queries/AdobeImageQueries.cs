using LrDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LrDb.Queries;

public static class AdobeImageQueries
{
    public static async Task<AgHarvestedExifMetadata> AgHarvestedExifMetadata(Adobe_images source, LrDbContext context)
    {
        return await context.AgHarvestedExifMetadata.SingleAsync(x => x.image == source.id_local);
    }

    public static async Task<List<AgLibraryFile>> AgLibraryFiles(Adobe_images source, LrDbContext context)
    {
        return await context.AgLibraryFile.Where(x => x.id_local == source.rootFile).ToListAsync()
            .ConfigureAwait(false);
    }
}