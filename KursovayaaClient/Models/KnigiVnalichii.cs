using System;
using System.Collections.Generic;

namespace KursovayaaClient.Models
{

    public partial class KnigiVnalichii
    {
        public int IdKniga { get; set; }

        public bool IsAvailable { get; set; }

        public string Nazvanie { get; set; } = null!;
    }
}
