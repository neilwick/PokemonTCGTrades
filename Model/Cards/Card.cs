using System.Collections;
using System.Text.Json.Serialization;

namespace Model.Cards {
    public class Card {
        public string Id { get; set; }
        public string Name { get; set; }
        public Images Images { get; set; }
        public Tcgplayer.Prices Prices { get; set; }

    }
}