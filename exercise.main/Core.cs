using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace exercise.main
{

    public class Core
    {

        private readonly Dictionary<char, int> Cards = new Dictionary<char, int> {
            { 'J', 11 },
            { 'Q', 12 },
            { 'K', 13 },
            { 'A', 14 },
        };

        // Note:
        // IEnumerable is a class that the List inherits (ie List has all the functionality of IEnumerable)
        // IEnumerable allows you to use a foreach loop on the variable hands (which is a List of tuples)
        
        //TODO: complete the winningPair method, without changing the method signature
        public bool winningPair(IEnumerable<Tuple<string, string>> hands, out Tuple<string, string> result)
        {

            result = new Tuple<string,string>(string.Empty, string.Empty);

            int BiggestPair = 0;
            foreach (var pair in hands)
            {
                bool isSimilar = true;
                string[] cards = pair.ToString().Trim('(').Trim(')').Split(",").Select(card=>card.Trim()).ToArray();
                for (int j = 0; j < cards.Count(); j++)
                {
                    if (cards[0] != cards[j]) isSimilar = false;
                }

                if (isSimilar)
                {
                    int i = 0;
                    bool isInt = int.TryParse(pair.Item1, out i);
                    if (isInt)
                    {
                        if (BiggestPair < i) BiggestPair = i;
                    }
                    else
                    {
                        char temporaryCard = char.Parse(pair.Item1);
                        if (BiggestPair < Cards[temporaryCard]) BiggestPair = Cards[temporaryCard];
                    }
                }
                
            }

            string BiggestCard = String.Empty;
            if (BiggestPair > 10)
            {
                foreach (var card in Cards)
                {
                    if (card.Value == BiggestPair)
                    {
                        BiggestCard = card.Key.ToString();
                        result = new Tuple<string, string>(BiggestCard, BiggestCard);
                        break;
                    }
                }
            }
            else if (BiggestPair > 0)
            {
                BiggestCard = BiggestPair.ToString();
                result = new Tuple<string, string>(BiggestCard, BiggestCard);
            }

                return BiggestPair != 0 ? true : false;
        }
        public int GetValueOfCard(string card)
        {
            int i = 0;
            bool isInt = int.TryParse(card, out i);
            if (isInt)
            {
                return i;
            }
            else
            {
                char temporaryCard = char.Parse(card);
                return Cards[temporaryCard];
            }
        }
    }
}
