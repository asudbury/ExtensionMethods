namespace Scorchio.ExtensionMethods
{
    using System.IO;

    /// <summary>
    /// File Extensions. 
    /// </summary>
    public static class FileExtensions
    {
        /// <summary>
        /// Deletes if exists.
        /// </summary>
        /// <param name="path">The path.</param>
        public static void DeleteIfExists(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }
    }
}
