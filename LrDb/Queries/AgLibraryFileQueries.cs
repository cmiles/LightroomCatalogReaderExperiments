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
}