﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LrDb.Models
{
    public partial class AgLibraryKeywordFace
    {
        public long id_local { get; set; }
        public long face { get; set; }
        public long? keyFace { get; set; }
        public byte[] rankOrder { get; set; }
        public long tag { get; set; }
        public long? userPick { get; set; }
        public long? userReject { get; set; }
    }
}