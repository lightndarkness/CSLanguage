using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    /* This is a reference type that contains all the arguments 
     * needed for an event.
     * Must derive from the EventArgs and contains the words 
     * EventsArgs at the end of its name
     * it has to be public
    */
    public class NameChangedEventArgs : EventArgs
    {
        public string ExistingName { get; set; }
        public string NewName { get; set; }
    }
}
