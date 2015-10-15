using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WNG.Sequence.Models
{
    public class SequenceCalculator
    {
        public SequenceResult Calculate(int number)
        {
            if (number <= 0)
                throw new ArgumentOutOfRangeException("SequenceRequest.Number");

            SequenceResult result = new SequenceResult();
            result.Number = number;
            result.NumberSequence = FillNumberSequence(number);
            result.OddSequence= FillOddSequence(number);
            result.EvenSequence= FillEvenSequence(number);
            result.CustomSequence = FillCustomSequence(number);
            result.FibinachiSequence = FillFibonachiSequence(number);

            return result;
        }

        private List<int> FillNumberSequence(int number)
        {
            var numberSequence = new List<int>();

            for (int i = 1; i <= number; i++)
                numberSequence.Add(i);

            return numberSequence;
        }

        private List<int> FillOddSequence(int number)
        {
            var oddSequence = new List<int>();

            for (int i = 1; i <= number; i += 2)
                oddSequence.Add(i);

            return oddSequence;
        }

        private List<int> FillEvenSequence(int number)
        {
            var evenSequence = new List<int>();

            for (int i = 2; i <= number; i += 2)
                evenSequence.Add(i);

            return evenSequence;
        }

        private List<string> FillCustomSequence(int number)
        {
            var customSequence = new List<string>();

            for (int i = 1; i < number; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                    customSequence.Add("Z");
                else if (i % 5 == 0)
                    customSequence.Add("E");
                else if (i % 3 == 0)
                    customSequence.Add("C");
                else
                    customSequence.Add(i.ToString());
            }

            return customSequence;
        }

        private List<int> FillFibonachiSequence(int number)
        {
            var fibinachiSequence = new List<int>();

            fibinachiSequence.Add(1);
            int lastFib1 = 1;
            int lastFib2 = 1;
            int newFib = 1;

            while (newFib <= number)
            {
                fibinachiSequence.Add(newFib);
                newFib = lastFib1 + lastFib2;
                lastFib1 = lastFib2;
                lastFib2 = newFib;
            }

            return fibinachiSequence;
        }
    }
}
