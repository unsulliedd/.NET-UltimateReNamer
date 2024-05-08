namespace UltimateReNamer.MVVM.Model
{
    public class FileInformation
    {
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string FilePath { get; set; }
        public double FileSize { get; set; }
        public DateTime FileCreationDate { get; set; }
        public DateTime FileModifiedDate { get; set; }
        public DateTime FileAccessDate { get; set; }
        public DateTime FileLastAccessDate { get; set; }
        public DateTime FileLastWriteDate { get; set; }
    }
}
