using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jule02
{
    public static class Datab
    {
        private static List<Profession> Professions = new List<Profession> {
            new Profession() { Id=1,Name="Programming"},
            new Profession() { Id=2,Name="Design"},
            new Profession() { Id=3,Name="System"}
            
            
        };
        private static List<Group> Groups = new List<Group>
        {
            new Group(){Id=1,Name="p110",ProfessionId=1},
            new Group(){Id=2,Name="p210",ProfessionId=1},
            new Group(){Id=3,Name="p310",ProfessionId=1},
            
            
            
            new Group(){Id=4,Name="d110",ProfessionId=2},
            new Group(){Id=5,Name="d130",ProfessionId=2},
            new Group(){Id=6,Name="d410",ProfessionId=2},
            
            
            new Group(){Id=7,Name="s210",ProfessionId=3},
            new Group(){Id=8,Name="s140",ProfessionId=3},
           



        };
        private static List<Student> Students = new List<Student>
        {
            new Student(){Id=1,Name="Ulvi",GroupId=1},
            new Student(){Id=2,Name="Resad",GroupId=1},
            new Student(){Id=3,Name="Kamal",GroupId=1},
            new Student(){Id=4,Name="Ilkin",GroupId=1},
            new Student(){Id=5,Name="Elcin",GroupId=1},
            new Student(){Id=6,Name="Samir",GroupId=2},
            new Student(){Id=7,Name="Kamil",GroupId=2},
            new Student(){Id=8,Name="kamran",GroupId=2},
            new Student(){Id=9,Name="Elmar",GroupId=2},
            new Student(){Id=10,Name="Seyid",GroupId=2},
            new Student(){Id=11,Name="Orxan",GroupId=3},
            new Student(){Id=12,Name="Nurlan",GroupId=3},
            new Student(){Id=13,Name="Qabil",GroupId=3},
            new Student(){Id=14,Name="Eli",GroupId=4},
            new Student(){Id=15,Name="Murvet",GroupId=4},
            new Student(){Id=16,Name="Ehmed",GroupId=4},
            new Student(){Id=17,Name="Circirama",GroupId=5},
            new Student(){Id=18,Name="Namiq",GroupId=5},
            new Student(){Id=19,Name="Zamiq",GroupId=5},
            new Student(){Id=20,Name="Yaver",GroupId=6},
            new Student(){Id=21,Name="Amid",GroupId=6},
            new Student(){Id=22,Name="Balash",GroupId=6},
            new Student(){Id=23,Name="Cavid",GroupId=7},
            new Student(){Id=24,Name="Dadash",GroupId=7},
            new Student(){Id=25,Name="Gozel",GroupId=8},
            new Student(){Id=26,Name="Laravel",GroupId=8},

        };
        public static List<Student> GetStudents()
        {
            return Students;
        }
        public static List<Group> GetGroups()
        {
            return Groups;
        }
        public static List<Profession> GetProfessions()
        {
            return Professions;
        }
    }
}
