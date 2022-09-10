using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
    class Team
    {
        private string name;
        private Statitics statitics;
        public Team(string name,Statitics statitics)
        {
            this.name = name;
            this.statitics = statitics;
        }
        public void AddName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
        public Statitics GetStatitics()
        {
            return this.statitics;
        }
    }
}
