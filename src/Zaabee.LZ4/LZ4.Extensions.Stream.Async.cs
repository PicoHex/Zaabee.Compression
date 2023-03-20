﻿namespace Zaabee.LZ4;

public static partial class Lz4Extensions
{
    public static async Task ToLz4Async(
        this Stream rawStream,
        Stream outputStream,
        LZ4Level level = Lz4Helper.Level,
        int extraMemory = Lz4Helper.ExtraMemory,
        CancellationToken cancellationToken = default) =>
        await Lz4Helper.CompressAsync(rawStream, outputStream, level, extraMemory, cancellationToken);

    public static async Task UnLz4Async(
        this Stream compressedStream,
        Stream outputStream,
        LZ4DecoderSettings? settings = Lz4Helper.Settings,
        bool interactive = Lz4Helper.Interactive,
        CancellationToken cancellationToken = default) =>
        await Lz4Helper.DecompressAsync(compressedStream, outputStream, settings, interactive, cancellationToken);

    public static async Task<MemoryStream> ToLz4Async(
        this Stream rawStream,
        LZ4Level level = Lz4Helper.Level,
        int extraMemory = Lz4Helper.ExtraMemory,
        CancellationToken cancellationToken = default) =>
        await Lz4Helper.CompressAsync(rawStream, level, extraMemory, cancellationToken);

    public static async Task<MemoryStream> UnLz4Async(
        this Stream compressedStream,
        LZ4DecoderSettings? settings = Lz4Helper.Settings,
        bool interactive = Lz4Helper.Interactive,
        CancellationToken cancellationToken = default) =>
        await Lz4Helper.DecompressAsync(compressedStream, settings, interactive, cancellationToken);
}