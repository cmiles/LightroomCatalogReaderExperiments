﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace LrDb.Models
{
    public partial class AgVideoInfo
    {
        public long id_local { get; set; }
        public byte[] duration { get; set; }
        public byte[] frame_rate { get; set; }
        public long has_audio { get; set; }
        public long has_video { get; set; }
        public long image { get; set; }
        public byte[] poster_frame { get; set; }
        public long poster_frame_set_by_user { get; set; }
        public byte[] trim_end { get; set; }
        public byte[] trim_start { get; set; }
    }
}