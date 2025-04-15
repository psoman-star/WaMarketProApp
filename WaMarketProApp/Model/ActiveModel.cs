using System;

namespace WaMarketProApp.Model
{
    public class ActiveModel
    {
        public string ActiveCode { get; set; }
        public int Days { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

    }
}
