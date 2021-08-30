using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Array
{
    public class MyCalendar
    {
        int? startValue = null;
        int? endValue = null;
        List<Tuple<int, int>> _Calendar = new List<Tuple<int, int>>();
        public MyCalendar()
        {

        }

        //public bool Book(int start, int end)
        //{
        //    if (_Calendar.Count == 0)
        //        _Calendar.Add(new Tuple<int, int>(start, end));
        //    else
        //        CheckConflicts(start, end);
        //        //Check Ifconflict happens an item
        //}

        //private bool CheckConflicts(int start, int end)
        //{
        //    for (int i = 0; i < _Calendar.Count; i++)
        //    {
        //        var currentItemStart = _Calendar[i].Item1;
        //        var currrentItemEnd = _Calendar[i].Item2;

        //        if (start >= currrentItemEnd || start)
        //        {                    
        //            return true;
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //}
    }
}
