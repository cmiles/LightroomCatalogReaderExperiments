﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LrDb.Models
{
    public partial class AgLibraryPublishedCollection
    {
        public long id_local { get; set; }
        public byte[] creationId { get; set; }
        public byte[] genealogy { get; set; }
        public byte[] imageCount { get; set; }
        public byte[] isDefaultCollection { get; set; }
        public byte[] name { get; set; }
        public long? parent { get; set; }
        public byte[] publishedUrl { get; set; }
        public byte[] remoteCollectionId { get; set; }
        public byte[] systemOnly { get; set; }
    }
}