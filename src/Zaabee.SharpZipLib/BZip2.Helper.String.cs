﻿namespace Zaabee.SharpZipLib;

public static partial class Bzip2Helper
{
    public static byte[] Compress(string str, Encoding? encoding = null) =>
        Compress(str.GetBytes(encoding ?? Consts.DefaultEncoding));

    public static string DecompressToString(byte[] compressedBytes, Encoding? encoding = null) =>
        Decompress(compressedBytes).GetString(encoding ?? Consts.DefaultEncoding);
}
