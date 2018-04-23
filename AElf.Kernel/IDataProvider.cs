﻿using AElf.Kernel.Merkle;
using System.Threading.Tasks;

namespace AElf.Kernel
{
    public interface IDataProvider
    {
        IDataProvider GetDataProvider(string name);

        Task SetAsync(Hash key, byte[] obj);

        Task<byte[]> GetAsync(Hash key);
    }
}