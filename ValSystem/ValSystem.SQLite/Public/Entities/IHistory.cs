﻿using System;

namespace ValSystem.SQLite.Public.Entities
{
    public interface IHistory
    {
        int Id { get; set; }
        string Hash { get; set; }
        string Context { get; set; }
        DateTime CreateDate { get; set; }
    }
}