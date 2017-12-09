﻿using System;
using System.Data.Entity;
using toofz.NecroDancer.Data;

namespace toofz.Data
{
    public interface INecroDancerContext : IDisposable
    {
        DbSet<Item> Items { get; }
        DbSet<Enemy> Enemies { get; }
    }
}