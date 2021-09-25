using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Komodo_Insurance_Library
{
    public class DevTeamRepo
    {
        private List<DeveloperTeam> _listOfTeams = new List<DeveloperTeam>();


        //Create
        public void AddDeveloperToTeam(DeveloperTeam developer)
        {
            _listOfTeams.Add(developer);
        }
        //Read
        public List<DeveloperTeam> GetTeamList()
        {
            return _listOfTeams;
        }

        //Update
        public bool UpdateTeam(string name, int id)
        {
            DeveloperTeam oldTeam = GetTeamById(id);
            if (oldTeam != null)
            {
                oldTeam.TeamName = name;
                return true;
            }
            return false;

        }

        public DeveloperTeam GetTeamById(int id)
        {
            foreach (DeveloperTeam developerTeam in _listOfTeams)
            {
                if (developerTeam.TeamID == id)
                {
                    return developerTeam;

                }
            }
            return null;
        }

        //Delete
        public bool RemoveTeam(string name, int id)
        {
            DeveloperTeam developerTeam = GetTeamById(id);

            if (developerTeam == null)
            {
                return false;
            }
            int initialCount = _listOfTeams.Count;
            _listOfTeams.Remove(developerTeam);

            if (initialCount > _listOfTeams.Count)
            {
                return true;
            }
            else
            {
                return false;
            }


        }


    }
}
