using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Po.Winforms.Logging
{
    /// <summary>
    /// Class for logging information throughout the entire application.
    /// </summary>
    public partial class Logger : Component
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Logger"/> class.
        /// </summary>
        public Logger(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        /// <summary>
        /// Date pattern for logging to text box.
        /// </summary>
        [Category("Date patterns")]
        [DefaultValue("[HH:mm:ss] ")]
        [Description("Date pattern for logging to text box.")]
        public string LogBoxDatePattern { get; set; } = "[HH:mm:ss] ";
        /// <summary>
        /// Date pattern for logging to message box.
        /// </summary>
        [Category("Date patterns")]
        [DefaultValue("[HH:mm:ss] ")]
        [Description("Date pattern for logging to message box.")]
        public string MessageDatePattern { get; set; } = "[HH:mm:ss] ";
        /// <summary>
        /// Date pattern for logging to file.
        /// </summary>
        [Category("Date patterns")]
        [DefaultValue("[HH:mm:ss] ")]
        [Description("Date pattern for logging to file.")]
        public string RecordDatePattern { get; set; } = "[HH:mm:ss] ";
        /// <summary>
        /// Date pattern for log file name.
        /// </summary>
        [Category("Date patterns")]
        [DefaultValue("[yyyy-MM-dd] ")]
        [Description("Date pattern for log file name.")]
        public string FileNameDatePattern { get; set; } = "[yyyy-MM-dd] ";
        /// <summary>
        /// Log file name.
        /// </summary>
        [Category("Output")]
        [DefaultValue("Log.txt")]
        [Description("Log file name.")]
        public string FileName { get; set; } = "Log.txt";
        /// <summary>
        /// Log file output directory.
        /// </summary>
        [Category("Output")]
        [DefaultValue(@".\")]
        [Description("Log file output directory.")]
        public string Directory { get; set; } = @".\";

        /// <summary>
        /// The <see cref="TextBox"/> used for logging.
        /// </summary>
        [Category("Controls")]
        [DefaultValue(null)]
        [Description("TextBox for logging.")]
        public TextBox LogBox { get; set; } = null;
        /// <summary>
        /// The <see cref="Form"/> used for logging.
        /// </summary>
        [Category("Controls")]
        [DefaultValue(null)]
        [Description("Form for logging.")]
        public Form LogForm { get; set; } = null;
        
        private string GetInfoLine(string datePattern, string text)
        {
            return
                DateTime.Now.ToString(datePattern) + text + Environment.NewLine;
        }
    }
}
