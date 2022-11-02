using System.Collections.Generic;

namespace ArithmeticProgression
{
    public class ArithmeticProgressionChecker
    {
        private readonly List<int> _sequence;

        public ArithmeticProgressionChecker(List<int> sequence)
        {
            _sequence = sequence;
        }

        public bool IsProgression()
        {
            _sequence.Sort();

            var increment = _sequence[1] - _sequence[0];

            for (int i = 1; i < _sequence.Count; i++)
            {
                int delta = _sequence[i] - _sequence[i - 1];

                if (delta != increment)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
