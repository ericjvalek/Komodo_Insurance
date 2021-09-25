using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Library
{
    public class DeveloperRepo
    {
        private static List<Developer> _listOfDevelopers = new List<Developer>();
        
        //Create
        public void AddDeveloperToList(Developer developer)
        {
            _listOfDevelopers.Add(developer);
        }

      

        //Read
        public List<Developer> GetDeveloperList()
        {
            return _listOfDevelopers;
        }
        //Update
        public bool UpdateExistingDevelopers(int ID, Developer newDeveloper)
        {
            Developer oldDeveloper = GetDeveloperByID(ID);
            if(oldDeveloper != null)
            {
                oldDeveloper.Name = newDeveloper.Name;
                oldDeveloper.ID = newDeveloper.ID;
                oldDeveloper.HasPluralsight = newDeveloper.HasPluralsight;
                return true;
            }
            return false;
        }
        //Delete
        public bool RemoveDeveloperFromList(int ID, Developer developer)
        {
            Developer developer1 = GetDeveloperByID(ID);
            if (developer == null)
            {
                return false;
            }
            int initialCount = _listOfDevelopers.Count;
            _listOfDevelopers.Remove(developer);
            if (initialCount > _listOfDevelopers.Count)
            {
                return true;
            }
            return false;
        }

        public Developer GetDeveloperByID(int ID)
        {
            foreach(Developer developer in _listOfDevelopers)
            {
                if(developer.ID == ID)
                {
                    return developer;
                }
            }
            return null;
        }

        

    }
}
