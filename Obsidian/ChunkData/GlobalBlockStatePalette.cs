﻿using Obsidian.Net;
using Obsidian.Util.Registry;
using System.Threading.Tasks;

namespace Obsidian.ChunkData
{
    public class GlobalBlockStatePalette : IBlockStatePalette
    {
        public bool IsFull { get { return false; } }

        public int GetIdFromState(Block block) => block.Id;

        public Block GetStateFromIndex(int index) => Registry.GetBlock(index);

        public Task WriteToAsync(MinecraftStream stream) => Task.CompletedTask;

        public void WriteTo(NetWriteStream stream) { }

        public Task ReadFromAsync(MinecraftStream stream) => Task.CompletedTask;
    }
}
