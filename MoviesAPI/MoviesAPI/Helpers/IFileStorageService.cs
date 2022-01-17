namespace MoviesAPI.Helpers
{
    public interface IFileStorageService
    {
        Task DeleteFile(string filePath, string containerName);

    }
}
