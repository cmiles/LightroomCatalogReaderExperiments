﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LrDb.Utilities;

namespace LrDb.Models
{
    public partial class AgHarvestedExifMetadata
    {
        public long id_local { get; set; }
        public long? image { get; set; }
        public double? aperture { get; set; }
        public long? cameraModelRef { get; set; }
        public long? cameraSNRef { get; set; }
        public long? dateDay { get; set; }
        public long? dateMonth { get; set; }
        public long? dateYear { get; set; }
        public bool? flashFired { get; set; }
        public long? focalLength { get; set; }
        public double? gpsLatitude { get; set; }
        public double? gpsLongitude { get; set; }
        public long gpsSequence { get; set; }
        public bool hasGPS { get; set; }
        public double? isoSpeedRating { get; set; }
        public long? lensRef { get; set; }
        public double? shutterSpeed { get; set; }
        [NotMapped] public string ShutterSpeedStandard => ConversionHelpers.ExifShutterSpeedToHumanReadableString(shutterSpeed);
        [NotMapped] public string ApertureStandard => ConversionHelpers.ExifApertureToHumanReadableString(aperture.Value);
        [NotMapped] public string FocalLengthStandard => focalLength == null ? null : $"{focalLength}mm";
    }
}