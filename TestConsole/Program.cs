using LrDb.Queries;
using LrDb.Models;
using LrDb.Utilities;
using Microsoft.EntityFrameworkCore;

var context = new LrDbContext();

var adobeFile = await context.AgLibraryFile.SingleAsync(x => x.id_local == 7507809);
var image = (await AgLibraryFileQueries.AdobeImages(adobeFile, context)).First();
var metadata = await AdobeImageQueries.AgHarvestedExifMetadata(image, context);
var camera = await AgHarvestedExifMetadataQueries.CameraModel(metadata, context);
var cameraSn = await AgHarvestedExifMetadataQueries.CameraSerialNumber(metadata, context);
var lens = await AgHarvestedExifMetadataQueries.Lens(metadata, context);


Console.WriteLine(adobeFile.Dump());
Console.WriteLine(image.Dump());
Console.WriteLine(metadata.Dump());
Console.WriteLine(camera.Dump());
Console.WriteLine(cameraSn.Dump());
Console.WriteLine(lens.Dump());

var cutoffDate = ConversionHelpers.DateTimeToLrTimeStamp(DateTime.Now.AddDays(-28));
var fileSet = await context.AgLibraryFile.Where(x => x.modTime > cutoffDate).ToListAsync();
var consolidateData = await AgLibraryFileQueries.ConsolidateData(fileSet, context);

Console.WriteLine(consolidateData.First().Dump());