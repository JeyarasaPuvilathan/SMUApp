using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmuInterviewApp
{
    public class SmuClass
    {

        // Elements of ListA not in ListB
        public  List<StudentProgrammeInfo> GetListAElementsNotInListB(List<StudentProgrammeInfo> ListA, List<StudentProgrammeInfo> ListB)
        {
            return ListA.Except(ListB).ToList();
        }


        // Elements of ListA which are also in ListB, but having different non-primary-key values
        public  List<StudentProgrammeInfo> GetListAElementsInListBWithDifferentValues(List<StudentProgrammeInfo> ListA, List<StudentProgrammeInfo> ListB)
        {
            return ListA.Join(ListB,
                a => new { a.StudentID, a.ProgrammeID },
                b => new { b.StudentID, b.ProgrammeID },
                (a, b) => new { A = a, B = b })
                .Where(ab => ab.A.Status != ab.B.Status || ab.A.LastUpdateDateTime != ab.B.LastUpdateDateTime)
                .Select(ab => ab.A)
                .ToList();
        }

        // Elements of ListB not in ListA
        public  List<StudentProgrammeInfo> GetListBElementsNotInListA(List<StudentProgrammeInfo> ListA, List<StudentProgrammeInfo> ListB)
        {
            return ListB.Except(ListA).ToList();
        }

    }
}
