using LrDb.Models;
using Microsoft.EntityFrameworkCore;

namespace LrDb.Queries;

public static class AgHarvestedExifMetadataQueries
{
    public static async Task<AgInternedExifCameraModel?> CameraModel(AgHarvestedExifMetadata source,
        LrDbContext context)
    {
        return await context.AgInternedExifCameraModel.SingleOrDefaultAsync(x => x.id_local == source.cameraModelRef)
            .ConfigureAwait(false);
    }

    public static async Task<AgInternedExifCameraSN?> CameraSerialNumber(AgHarvestedExifMetadata source,
        LrDbContext context)
    {
        return await context.AgInternedExifCameraSN.SingleOrDefaultAsync(x => x.id_local == source.cameraSNRef)
            .ConfigureAwait(false);
    }

    public static async Task<AgInternedExifLens?> Lens(AgHarvestedExifMetadata source, LrDbContext context)
    {
        return await context.AgInternedExifLens.SingleOrDefaultAsync(x => x.id_local == source.lensRef)
            .ConfigureAwait(false);
    }
}