using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {

        //only accessible with the AccessDemo class
        private void PrivateDemo()
        {
            
        }

        //available in AccessDemo and its inherited class. But if the inherited class is outside the library (Demo Library) then it is not available.
        private protected void PrivateProtectedDemo()
        {

        }

        //only accessible to this class or the classes that inherits this class
        //only used in inheritance purposes
        //it can be also accessible to the inherited class that exists outsie the current library (Demo Library)
        protected void ProtectedDemo()
        {

        }

        //accessible anywhere inside DemoLibrary just like Internal
        //and accessible anywhere outside DemoLibrary inside the class that inherits the AccessDemo just like protected
        protected internal void ProtectedInternalDemo()
        {

        }

        //similar to private but the scope is not limited to the class but the entire library i.e DemoLibrary. Library is also known as assembly
        internal void InternalDemo()
        {

        }

        //accessible for all classes
        public void PublicDemo()
        {

        }
    }
}
