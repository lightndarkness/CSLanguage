using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    /************************
     * Delegate declaration
     * A delegate declaration must be a public declaration
     * with the keyword delegate
     * it must have a return type (not important)
     * what is important is the parameters types (obejct sender, AnotherObjectType args)
     * AnotherObjectType is a reference type variable that has all the arguments required for the events.
    */

    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);
}
