using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace SPZ_Lab5.Model
{
    [DataContract]
    class Group
    {
        [DataMember]
        public string GroupNumber { get; set; }
        public static List<string> GroupNamesList;
        private static string[] groupNamesArray = new string[] {"ВПВПС", "КБИКС", "КИУКИ"};
        public Group(Random random)
        {
            GroupNumber = groupNamesArray[random.Next(0, groupNamesArray.Length)] + '-' + 19 + '-' + random.Next(1, 4);
        }
        public Group(string groupNumber)
        {
            GroupNumber = groupNumber;
        }
        public Group()
        { }
        static Group()
       {
           GroupNamesList = new List<string>();
            GroupNamesList.Add("Все группы");
           for (int j = 0; j < groupNamesArray.Length; j++)
           {
               for(int i = 1; i < 4; i++)
                   GroupNamesList.Add(groupNamesArray[j] + '-' + 19 + '-' + i);
           }
       }
        public static void Remove(string groupName)
        {
            GroupNamesList.Remove(groupName);
        }
        public static void Rename(string groupName, string newGroupName)
        {
           int index = GroupNamesList.IndexOf(groupName);
            GroupNamesList[index] = newGroupName;
        }
        public static void Add(string groupName)
        {
            if(!GroupNamesList.Contains(groupName))
            GroupNamesList.Add(groupName);
        }
        public override string ToString()
        {
            return GroupNumber;
        }
    }
}
