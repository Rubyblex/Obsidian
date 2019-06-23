﻿using System;
using System.Threading.Tasks;

namespace Obsidian.PlayerData.Info
{
    public abstract class PlayerInfoAction
    {
        public Guid Uuid { get; set; }

        public abstract Task<byte[]> ToArrayAsync();
    }
}
