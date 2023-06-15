using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elibrary3.Models
{
    public class ELVM
    {
        public ElStudentMsts ELStudentMstsObj { get; set; }
        public List<ElStudentMsts> ELStudentMstsa { get; set; }
        public ElTeacherMsts ELTeacherMstsobj { get; set; }
        public List<ElTeacherMsts> ELTeacherMstsb { get; set; }
        public ElAdmistratorMsts ELAdministratorMstsObj { get; set; }
        public List<ElAdmistratorMsts> ELAdministratorMstsc { get; set; }
    }
}
