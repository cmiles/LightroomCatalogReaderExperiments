using System.Diagnostics.Tracing;
using LrDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LrDb.Queries;

public static class AdobeImageQueries
{
    public static async Task<AgHarvestedExifMetadata> AgHarvestedExifMetadata(Adobe_images source, LrDbContext context)
    {
        return await context.AgHarvestedExifMetadata.SingleAsync(x => x.image == source.id_local);
    }

    public static async Task<AgLibraryFile?> AgLibraryFiles(Adobe_images source, LrDbContext context)
    {
        return await context.AgLibraryFile.SingleOrDefaultAsync(x => x.id_local == source.rootFile)
            .ConfigureAwait(false);
    }

    public static async Task<AdobeImageConsolidatedData> ConsolidatedData(Adobe_images source, LrDbContext context)
    {
        var metaData = await AdobeImageQueries.AgHarvestedExifMetadata(source, context);

        return new AdobeImageConsolidatedData
        {
            Image = source,
            Camera = await AgHarvestedExifMetadataQueries.CameraModel(metaData, context),
            CameraSerialNumber = await AgHarvestedExifMetadataQueries.CameraSerialNumber(metaData, context),
            Lens = await AgHarvestedExifMetadataQueries.Lens(metaData, context),
            File = await AgLibraryFiles(source, context)
        };

    }
}