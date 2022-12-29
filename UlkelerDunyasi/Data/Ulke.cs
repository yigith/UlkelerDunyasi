using System.ComponentModel.DataAnnotations;

namespace UlkelerDunyasi.Data
{
    public class Ulke
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string Ad { get; set; } = null!;
    }
}
