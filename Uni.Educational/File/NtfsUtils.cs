using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ionic.Zip;

namespace Uni.Educational.File
{
    public class NtfsUtils
    {
        private const string FILE_STORAGE_PATH = "ProjectsArchives";

        public NtfsUtils()
        {
            if (!Directory.Exists(FILE_STORAGE_PATH))
            {
                Directory.CreateDirectory(FILE_STORAGE_PATH);
            }
        }

        public void Store(Guid directoryId, string path)
        {
            var dirPath = Path.Combine(FILE_STORAGE_PATH, directoryId.ToString());

            if (!Directory.Exists(dirPath))
            {
                Directory.CreateDirectory(dirPath);
            }

            var archivePath = Path.Combine(dirPath, string.Concat(directoryId, "_", Path.GetFileName(path)));

            System.IO.File.Copy(path, archivePath);
        }

        public IEnumerable<FileInfo> EnumerateArchive(Guid directoryId)
        {
            var dirPath = Path.Combine(FILE_STORAGE_PATH, directoryId.ToString());

            if (!Directory.Exists(dirPath)) return Enumerable.Empty<FileInfo>();
            return Directory.EnumerateFiles(dirPath).Select(f => new FileInfo(f));
        }
    }
}
