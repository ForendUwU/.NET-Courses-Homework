using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursDZ
{
    internal class ChessPlayer
    {
        public int Rank { get; set;  }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public int Rating { get; set; }
        public int BirthDate { get; set; }

        public override string ToString() 
        {
            return $"This player Name is {Name} his Rank is {Rank}, his Country is {Country}, his Rating is {Rating}, his Birth Date is {BirthDate}";
        }

        public static ChessPlayer ParseCSV(string line) 
        {
            string[] parts = line.Split(';');
            return new ChessPlayer()
            {
                Rank = int.Parse(parts[0].Trim('"')),
                Name = parts[1].Split(',')[0].Trim('"'),
                LastName = parts[2].Trim('"').Trim(),
                Country = parts[4],
                Rating = int.Parse(parts[5]),
                BirthDate = int.Parse(parts[7].Trim('"'))
            };
        }

    }
}
