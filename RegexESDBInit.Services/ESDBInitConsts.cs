using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grondzal.RegexESDBInit.Services
{
    public class ESDBInitConsts
    {
        public const string FilePathIsNullErrorMessage = "There was a problem to load a file. Try again";
        public const string DefaultRegExPattern = @"(DateTime\.Parse\(""(\d{2})-(\d{2})-(\d{4})\s(\d{2}):(\d{2}).*""\))";
    }
}
