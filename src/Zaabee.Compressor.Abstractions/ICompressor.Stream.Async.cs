namespace Zaabee.Compressor.Abstractions;

public partial interface ICompressor
{
    Task<MemoryStream> CompressAsync(Stream rawStream);
    Task<MemoryStream> DecompressAsync(Stream compressedStream);
    Task CompressAsync(Stream inputStream, Stream outputStream);
    Task DecompressAsync(Stream inputStream, Stream outputStream);
}