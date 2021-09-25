using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Library
{
    public class DeveloperTeam
    {
        public string TeamName { get; set; }
        public int TeamID { get; set; }

        public List<Developer> DeveloperList { get; set; }
        public object Name { get; set; }
        public object ID { get; set; }

        public DeveloperTeam(string name, int id, List<Developer> developer )
        {
            TeamName = name;
            TeamID = id;
            DeveloperList = developer;
            
        }

        public DeveloperTeam(string name)
        {
            Name = name;
        }

        public bool AddDevToTeam(DeveloperTeam devTeam, Developer devToAdd)
        {
            int count = devTeam.DeveloperList.Count;
            devTeam.DeveloperList.Add(devToAdd);
            if (count < devTeam.DeveloperList.Count)
            {
                return true;
            }
            return false;
        }

        
        public bool RemoveDevFromTeam(DeveloperTeam devteam, Developer devToRemove)
        {
            int count = devteam.DeveloperList.Count;
            devteam.DeveloperList.Remove(devToRemove);
            if (count > devteam.DeveloperList.Count)
            {
                return true;
            }
            return false;
        }

    }

}
