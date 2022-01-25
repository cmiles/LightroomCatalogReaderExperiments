using LrDb.Queries;
using LrDb.Models;
using Microsoft.EntityFrameworkCore;

var context = new LrDbContext();

var adobeFile = await context.AgLibraryFile.SingleAsync(x => x.id_local == 7507809);
var image = (await AgLibraryFileQueries.AdobeImages(adobeFile, context)).First();
var metadata = await AdobeImageQueries.AgHarvestedExifMetadata(image, context);

Console.WriteLine(adobeFile.Dump());
Console.WriteLine(image.Dump());
Console.WriteLine(metadata.Dump());