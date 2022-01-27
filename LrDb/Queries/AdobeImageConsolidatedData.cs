using LrDb.Models;

namespace LrDb.Queries;

public class AdobeImageConsolidatedData
{
    public Adobe_images? Image { get; set; }
    public AgInternedExifCameraModel? Camera { get; set; }
    public AgInternedExifLens? Lens { get; set; }
    public AgInternedExifCameraSN? CameraSerialNumber { get; set; }
    public AgLibraryFile? File { get; set; }
}