using System;
using System.Windows.Forms;

namespace Po.Winforms.Logging
{
    public partial class Logger
    {
        /// <summary>
        /// Invokes the appending of the given info to default <see cref="TextBox"/> and file.
        /// </summary>
        /// <exception cref="NullReferenceException"/>
        public void InvokeLog(string info)
        {
            if (LogBox == null)
            {
                throw new NullReferenceException("TextBox logBox cannot be null");
            }
            else if (LogForm == null)
            {
                throw new NullReferenceException("Form LogForm cannot be null");
            }

            if (info == null || info.Trim().Length == 0)
            {
                return;
            }

            if (LogForm.IsHandleCreated)
            {
                LogForm.Invoke((MethodInvoker)delegate
                {
                    Log(info);
                });
            }
        }
        /// <summary>
        /// Invokes the appending of the given info to the given <see cref="TextBox"/> in the default <see cref="LogForm"/> and file.
        /// </summary>
        /// <exception cref="NullReferenceException"/>
        public void InvokeLog(string info, TextBox logBox)
        {
            if (logBox == null)
            {
                throw new NullReferenceException("TextBox logBox cannot be null");
            }
            else if (LogForm == null)
            {
                throw new NullReferenceException("Form LogForm cannot be null");
            }

            if (LogForm.IsHandleCreated)
            {
                LogForm.Invoke((MethodInvoker)delegate
                {
                    Log(info, logBox);
                });
            }
        }
        /// <summary>
        /// Invokes the appending of the given info to the given <see cref="TextBox"/> in the given <see cref="Form"/> and file.
        /// </summary>
        /// <exception cref="NullReferenceException"/>
        public void InvokeLog(string info, TextBox logBox, Form logForm)
        {
            if (logBox == null)
            {
                throw new NullReferenceException("TextBox log cannot be null");
            }
            else if (logForm == null)
            {
                throw new NullReferenceException("Form form cannot be null");
            }

            if (logForm.IsHandleCreated)
            {
                logForm.Invoke((MethodInvoker)delegate
                {
                    Log(info, logBox);
                });
            }
        }
    }
}
