using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeneticExperints
{
    public class CompoundSynthesizer
    {
        private readonly string _compositeCompound;

        public CompoundSynthesizer(string compositeCompound)
        {
            _compositeCompound = compositeCompound;
        }

        public string Synthesize()
        {
            var compoundsReduced = GetReduced(_compositeCompound);
            var result = new StringBuilder();

            foreach (var compound in compoundsReduced)
            {
                var occurences = _compositeCompound.Count(c => c.Equals(compound));
                result.Append(compound).Append(occurences.ToString());
            }

            return result.ToString();
        }

        /// <summary>
        /// Gets the reduced compounds list, keeping the same order of occurence.
        /// </summary>
        /// <param name="compounds"></param>
        /// <returns></returns>
        private string GetReduced(string compounds)
        {
            var distinctCompounds = compounds.Distinct();

            var reduced = new Dictionary<char, int>();

            foreach (var c in distinctCompounds)
            {
                reduced.Add(c, compounds.IndexOf(c));
            }

            var reducedList = reduced.OrderBy(c => c.Value).Select(c => c.Key);

            return String.Join("", reducedList);
        }
    }
}
