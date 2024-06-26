﻿namespace Aoxe.SharpZipLib;

public static partial class GzipHelper
{
    public static MemoryStream Compress(Stream inputStream)
    {
        var outputStream = new MemoryStream();
        Compress(inputStream, outputStream);
        return outputStream;
    }

    public static MemoryStream Decompress(Stream inputStream)
    {
        var outputStream = new MemoryStream();
        Decompress(inputStream, outputStream);
        return outputStream;
    }

    public static void Compress(Stream inputStream, Stream outputStream)
    {
        using (var gzipOutputStream = new GZipOutputStream(outputStream))
        {
            inputStream.CopyTo(gzipOutputStream);
            gzipOutputStream.IsStreamOwner = false;
        }
        inputStream.TrySeek(0, SeekOrigin.Begin);
        outputStream.TrySeek(0, SeekOrigin.Begin);
    }

    public static void Decompress(Stream inputStream, Stream outputStream)
    {
        using (var gzipInputStream = new GZipInputStream(inputStream))
        {
            gzipInputStream.CopyTo(outputStream);
            gzipInputStream.IsStreamOwner = false;
        }
        inputStream.TrySeek(0, SeekOrigin.Begin);
        outputStream.TrySeek(0, SeekOrigin.Begin);
    }
}
