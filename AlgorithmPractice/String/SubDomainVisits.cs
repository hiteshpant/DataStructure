using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.String
{
    public class SubDomainVisits
    {
        Dictionary<string, int> _VistedDomainCount;

        public IList<string> SubdomainVisits(string[] cpdomains)
        {
            List<string> output = new List<string>();
            _VistedDomainCount = new Dictionary<string, int>();
            foreach (var domain in cpdomains)
            {
                var splittedInput = domain.Split(' ');
                var visitedCOunt = int.Parse(splittedInput[0]);
                var splitedDomainItem = splittedInput[1].Split('.');
                AddToVistedList(splittedInput[1],int.Parse(splittedInput[0]));
                List<string> SplittedSubDomains = new List<string>();          
                if (splitedDomainItem.Length==3)
                {
                    AddToVistedList(domain.Substring(domain.IndexOf('.') + 1), visitedCOunt);
                }
                AddToVistedList(domain.Substring(domain.LastIndexOf('.') + 1), visitedCOunt);

            }

            foreach (var visted in _VistedDomainCount)
            {
                output.Add(visted.Value + " " + visted.Key);
            }
            return output;
        }

        private void AddToVistedList(string splittedInput,int visitedCount)
        {
            if (!_VistedDomainCount.ContainsKey(splittedInput))
            {
                _VistedDomainCount[splittedInput] = visitedCount;
            }
            else
            {
                _VistedDomainCount[splittedInput] += visitedCount;
            }
        }
    }
}
