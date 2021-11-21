using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace SPZ_Lab5.Model
{
  
    static class Storage
    {
        [DataMember]
        static public List<Student> Students { get; set; }
        static Storage()
        { 
            Students = new List<Student>(); 
        }
        static public void Generate()
        {
            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                Students.Add(new Student());
            }
        }
       static public List<Student> SortByLastName(List<Student> students)
        {
            return students.OrderBy(student => student.LastName).ToList();
        }
        static public List<Student> SortByGroupNumber(List<Student> students)
        {
           return students.OrderBy(student => student.Group.GroupNumber).ToList();
        }
        static public List<Student> OutputList(string groupName)
        {
            return Students.Where(student => student.Group.GroupNumber == groupName).ToList();
        }
        static public void Remove(Student student)
        {
            if(Students.Contains(student))
            {
                Students.Remove(student);
            }
        }
        static public void RemoveGroup(string groupName)
        {
            Group.Remove(groupName);
            Students.RemoveAll(student => student.Group.GroupNumber == groupName);
        }
        static public void RenameGroup(string groupName, string newGroupName)
        {
            foreach(var student in Students)
            {
                if (student.Group.GroupNumber == groupName)
                    student.Group.GroupNumber = newGroupName;
            }
        }
        static public void Add(Student student)
        {
                Students.Add(student);
        }
       

    }
}
