using System;
using System.Windows.Forms;

namespace Po.Winforms.Logging
{
    public partial class Logger
    {
        /// <summary>
        /// Logs the given info to <see cref="LogBox"/> and file.
        /// When calling from a different thread, use <see cref="InvokeLog(string, TextBox, Form)"/> or its overloads instead.
        /// </summary>
        /// <exception cref="NullReferenceException"/>
        public void Log(string info)
        {
            if (LogBox != null)
            {
                Log(info, LogBox);
            }
            else
            {
                throw new NullReferenceException("TextBox logBox cannot be null");
            }
        }
        /// <summary>
        /// Logs the given info to <see cref="LogBox"/> and file.
        /// </summary>
        public void Log(string info, TextBox log)
        {
            if (info == null || info.Trim().Length == 0)
            {
                return;
            }

            log.AppendText(GetInfoLine(LogBoxDatePattern, info));
            if (!TryLogToFile(info, out string ex))
            {
                log.AppendText(GetInfoLine(LogBoxDatePattern, ex));
            }
        }
    }
}
