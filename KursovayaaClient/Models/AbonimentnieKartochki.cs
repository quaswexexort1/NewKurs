using System;
using System.Collections.Generic;

namespace KursovayaaClient.Models
{

    public partial class AbonimentnieKartochki
    {
        public int ChitatelId { get; set; }

        public DateOnly DataAbonimenta { get; set; }

        public DateOnly? DataVozvrataAbonimenta { get; set; }

        public Chitateli Chitateli { get; set; } = null!;
    }
}