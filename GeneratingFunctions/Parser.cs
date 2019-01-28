using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace GeneratingFunctions
{
    public class Parser
    {
        public Poly Parse(string line)
        {
            var listOfStringTerms = ParseToStringTerms(line);

            var poly = new Poly();

            foreach (var stringTerm in listOfStringTerms)
            {
                var parsedTerm = ParseTerm(stringTerm);

                if (parsedTerm != null)
                {
                    poly.Add(parsedTerm);
                }
            }

            return poly;
        }

        private List<string> ParseToStringTerms(string line)
        {
            var result = new List<string>();

            result = line.Split(' ').ToList();

            var indexToDelete = new List<int>();

            for (int i = 0; i < result.Count; i++)
            {
                if (result[i] == "" || result[i] == " ")
                {
                    indexToDelete.Add(i);
                }
            }

            for (int i = 0; i < indexToDelete.Count; i++)
            {
                result.RemoveAt(indexToDelete[i] - i);
            }

            return result;
        }

        private TermSimple ParseTerm(string term)
        {
            var rx = new Regex(@"(?<coefficient>[1-9]\d?)(?<term>[a-z]+)(?<exponent>[1-9]\d?)");

            var match = rx.Match(term);
            if (match.Success)
            {
                return new TermSimple
                {
                    Coefficient = Int32.Parse(match.Groups["coefficient"].Value),
                    Exponent = Int32.Parse(match.Groups["exponent"].Value),
                    Name = match.Groups["term"].Value
                };
            }

            return null;
        }
    }
}