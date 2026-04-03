using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fleet_Manager
{
    internal class Job //Class for jobs to be constructed
    {
        int jobID;
        int currentRoute;

        public int _jobID
        {
            get { return jobID; }
            set { jobID = value; }
        }

        public int _currentRoute
        {
            get { return currentRoute; }
            set { currentRoute = value; }
        }

        public Job() { }

        public Job(int _jobID, int _currentRoute)
        {
            this.jobID = _jobID;
            this.currentRoute = _currentRoute;
        }
    }
}
