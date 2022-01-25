﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using LrDb.Utilities;

namespace LrDb.Models
{
    public partial class Adobe_images
    {
        public long id_local { get; set; }
        public Guid id_global { get; set; }
        public double aspectRatioCache { get; set; }
        public long bitDepth { get; set; }
        public DateTime captureTime { get; set; }
        public long colorChannels { get; set; }
        public byte[] colorLabels { get; set; }
        public long colorMode { get; set; }
        public long copyCreationTime { get; set; }
        public byte[] copyName { get; set; }
        public byte[] copyReason { get; set; }
        public long developSettingsIDCache { get; set; }
        public string fileFormat { get; set; }
        public long fileHeight { get; set; }
        public long fileWidth { get; set; }
        public long? hasMissingSidecars { get; set; }
        public long? masterImage { get; set; }
        public string orientation { get; set; }
        public byte[] originalCaptureTime { get; set; }
        public long? originalRootEntity { get; set; }
        public byte[] panningDistanceH { get; set; }
        public byte[] panningDistanceV { get; set; }
        public bool pick { get; set; }
        public string positionInFolder { get; set; }
        public long propertiesCache { get; set; }
        public string pyramidIDCache { get; set; }
        public double? rating { get; set; }
        public long rootFile { get; set; }
        public long sidecarStatus { get; set; }
        public long touchCount { get; set; }
        public double touchTime { get; set; }

        [NotMapped] public string OrientationStandard => ConversionHelpers.LrOrientationDescription(orientation);
        [NotMapped] public DateTimeOffset TouchTimeStandard => ConversionHelpers.LrTimeStampToDateTime(touchTime).ToLocalTime();

    }
}