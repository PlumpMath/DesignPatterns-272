using System.Collections.Generic;

namespace DesignPatterns.Creational.Multiton
{
    // A multiton which creates a birthday party for every year.
    // As per wikipedia, the multiton is not just a singleton with a 
    // Dictionary<>, because of 2 distinctions. 1, caller can't add instances; 
    // 2, null is never returned.
    // 
    // The thought behind this being a multiton is because you can't have 
    // more than 1 birthday per year per life. Unless you are reincarnated... yeah...
    class BirthdayParties
    {
        private static Dictionary<uint, BirthdayParty> _birthdayParties = new Dictionary<uint, BirthdayParty>();
        
        public static BirthdayParty GetBirthdayParty(uint age)
        {
            BirthdayParty party;
            if (!_birthdayParties.TryGetValue(age, out party))
            {
                party = new BirthdayParty(age);
                _birthdayParties.Add(age, party);
            }

            return party;
        }
    }
}
