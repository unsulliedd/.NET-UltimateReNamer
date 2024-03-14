using System.Collections.ObjectModel;
using UltimateReNamer.Core;
using UltimateReNamer.MVVM.Model;

namespace UltimateReNamer.MVVM.ViewModel
{
    class MainWindowViewModel : ObservableObject
    {
        public ObservableCollection<FileCategoryModel> FileCategories { get; set; }

        public MainWindowViewModel()
        {
            // Instantiate the collection
            FileCategories = new ObservableCollection<FileCategoryModel>()
            {
                new FileCategoryModel
                {
                    CategoryName = "Documents",
                    FileTypes = new List<FileType>
                    {
                        new FileType { Name = "PDF", Extension = ".pdf" },
                        new FileType { Name = "Text Document", Extension = ".txt" },
                        new FileType { Name = "Rich Text Format", Extension = ".rtf" },
                        new FileType { Name = "Open Document Format", Extension = ".odt" },
                        new FileType { Name = "CSV (Comma Separated Values)", Extension = ".csv" },
                        new FileType { Name = "XML Document", Extension = ".xml" },
                        new FileType { Name = "HTML Document", Extension = ".html" },
                        new FileType { Name = "Microsoft Word Document", Extension = ".docx" },
                        new FileType { Name = "Microsoft Word Macro-Enabled Document", Extension = ".docm" },
                        new FileType { Name = "Microsoft Word 97-2003 Document", Extension = ".doc" },
                        new FileType { Name = "Microsoft Word 97-2003 Template", Extension = ".dot" },
                        new FileType { Name = "Microsoft Excel Workbook", Extension = ".xlsx" },
                        new FileType { Name = "Microsoft Excel Macro-Enabled Workbook", Extension = ".xlsm" },
                        new FileType { Name = "Microsoft Excel 97-2003 Workbook", Extension = ".xls" },
                        new FileType { Name = "Microsoft Excel 97-2003 Template", Extension = ".xlt" },
                        new FileType { Name = "Microsoft Excel 97-2003 Add-In", Extension = ".xla" },
                        new FileType { Name = "Microsoft PowerPoint Presentation", Extension = ".pptx" },
                        new FileType { Name = "Microsoft PowerPoint Macro-Enabled Presentation", Extension = ".pptm" },
                        new FileType { Name = "Microsoft PowerPoint 95-2003 Presentation", Extension = ".ppt" },
                        new FileType { Name = "Microsoft PowerPoint 97-2003 Template", Extension = ".pot" },
                        new FileType { Name = "Microsoft PowerPoint 97-2003 Show", Extension = ".pps" },
                    }
                },

                new FileCategoryModel
                {
                    CategoryName = "Images",
                    FileTypes = new List<FileType>
                    {
                        new FileType { Name = "JPEG Image", Extension = ".jpeg" },
                        new FileType { Name = "JPEG Image", Extension = ".jpg" },
                        new FileType { Name = "PNG Image", Extension = ".png" },
                        new FileType { Name = "GIF Image", Extension = ".gif" },
                        new FileType { Name = "BMP Image", Extension = ".bmp" },
                        new FileType { Name = "TIFF Image", Extension = ".tiff" },
                        new FileType { Name = "WebP Image", Extension = ".webp" },
                        new FileType { Name = "SVG Image", Extension = ".svg" },
                        new FileType { Name = "ICO Image", Extension = ".ico" },
                        new FileType { Name = "HEIC Image", Extension = ".heic" }
                    }
                },

                new FileCategoryModel
                {
                    CategoryName = "Music",
                    FileTypes = new List<FileType>
                    {
                        new FileType { Name = "MP3 Audio", Extension = ".mp3" },
                        new FileType { Name = "AAC Audio", Extension = ".aac" },
                        new FileType { Name = "WAV Audio", Extension = ".wav" },
                        new FileType { Name = "FLAC Audio", Extension = ".flac" },
                        new FileType { Name = "OGG Audio", Extension = ".ogg" },
                        new FileType { Name = "MIDI Audio", Extension = ".midi" },
                        new FileType { Name = "WMA Audio", Extension = ".wma" },
                        new FileType { Name = "AIFF Audio", Extension = ".aiff" },
                        new FileType { Name = "ALAC Audio", Extension = ".alac" }
                    }
                },

                new FileCategoryModel
                {
                    CategoryName = "Videos",
                    FileTypes = new List<FileType>
                    {
                        new FileType { Name = "MP4 Video", Extension = ".mp4" },
                        new FileType { Name = "AVI Video", Extension = ".avi" },
                        new FileType { Name = "MKV Video", Extension = ".mkv" },
                        new FileType { Name = "WMV Video", Extension = ".wmv" },
                        new FileType { Name = "MOV Video", Extension = ".mov" },
                        new FileType { Name = "FLV Video", Extension = ".flv" },
                        new FileType { Name = "MPEG Video", Extension = ".mpeg" },
                        new FileType { Name = "WebM Video", Extension = ".webm" },
                        new FileType { Name = "3GP Video", Extension = ".3gp" },
                        // Add more video formats as needed
                    }
                },

                new FileCategoryModel
                {
                    CategoryName = "Others",
                    FileTypes = new List<FileType>
                    {
                        new FileType { Name = "Generic File", Extension = "" },
                        new FileType { Name = "ZIP Archive", Extension = ".zip" },
                        new FileType { Name = "RAR Archive", Extension = ".rar" },
                        new FileType { Name = "7Z Archive", Extension = ".7z" },
                        new FileType { Name = "PDF Document", Extension = ".pdf" },
                        new FileType { Name = "Text Document", Extension = ".txt" },
                        new FileType { Name = "Configuration File", Extension = ".config" },
                        new FileType { Name = "Executable File", Extension = ".exe" },
                        new FileType { Name = "Batch Script", Extension = ".bat" },
                        new FileType { Name = "PowerShell Script", Extension = ".ps1" },
                        new FileType { Name = "Shell Script", Extension = ".sh" },
                    }
                },
            };
        }
    }
}
