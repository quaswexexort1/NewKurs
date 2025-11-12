using System;
using System.Collections.Generic;

namespace KursovayaaClient.Models
{

    public partial class Ekzemplyari
    {
        public int IdKniga { get; set; }

        public string Kolichestvo { get; set; } = null!;

        public string Nazvanie { get; set; } = null!;
    }
}