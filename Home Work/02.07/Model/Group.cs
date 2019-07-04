using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jule02
{
    public class Group
    {
        public int Id;
        public string Name;
        public int ProfessionId;
        
    }
    public class Profession
    {
        public int Id;
        public string Name;

    }
    public class Student
    {
        public int Id;
        public string Name;
        public int GroupId;
    }
}
