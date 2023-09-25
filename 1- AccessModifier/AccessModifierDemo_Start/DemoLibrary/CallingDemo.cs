using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo accessDemoInstance =  new AccessDemo();
            accessDemoInstance.InternalDemo();
        }
        
    }
}
