using System.Collections.Generic;

namespace TD.BCDH.VinhLong.ViewModels
{
    public class ChartOutput
    {
        public List<ChartOutputItem> data { get; set; }
        public string available { get; set; }
        public string type { get; set; }
        public string title { get; set; }
        public string function { get; set; }
    }

    public class ChartOutputItem
    {
        public string title { get; set; }
        public string code { get; set; }
        public int value { get; set; }
    }
}
