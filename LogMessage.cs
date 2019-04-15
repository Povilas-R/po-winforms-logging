using System.Windows.Forms;

namespace Po.Winforms.Logging
{
    public partial class Logger
    {
        /// <summary>
        /// Pops a <see cref="MessageBox"/> with the given info and writes it to file.
        /// </summary>
        public void ShowMessage(string info)
        {
            if (info == null || info.Trim().Length == 0)
            {
                return;
            }

            TryLogToFile(GetInfoLine(RecordDatePattern, info));
            MessageBox.Show(GetInfoLine(MessageDatePattern, info));
        }
    }
}
