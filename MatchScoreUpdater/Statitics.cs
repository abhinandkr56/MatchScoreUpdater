using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchScoreUpdater
{
     class Statitics
    {
        private Hashtable statitics;
        public Statitics()
        {
           this.statitics = new Hashtable();
        }
        
        public  void addStats(string title, int value)
        {
            this.statitics.Add(title, value);
        }

        public Hashtable getStats()
        {
            return this.statitics;
        }
             
    }
}
