using System;
using System.IO;

namespace Po.Winforms.Logging
{
    public partial class Logger
    {
        /// <summary>
        /// Writes the given info to <see cref="FileName"/>.
        /// </summary>
        public bool TryLogToFile(string info) => TryLogToFile(info, out _);
        /// <summary>
        /// Writes the given info to <see cref="FileName"/>.
        /// </summary>
        public bool TryLogToFile(string info, out string exceptionMessage)
        {
            exceptionMessage = null;
            if (info == null || info.Trim().Length == 0)
            {
                return true;
            }

            try
            {
                File.AppendAllText(
                    (!string.IsNullOrEmpty(FileNameDatePattern)
                    ? DateTime.Now.ToString(FileNameDatePattern)
                    : "") + FileName,
                    GetInfoLine(RecordDatePattern, info));
                return true;
            }
            catch (Exception ex)
            {
                exceptionMessage = $"Error logging to file: {ex.Message}";
                return false;
            }
        }
    }
}
