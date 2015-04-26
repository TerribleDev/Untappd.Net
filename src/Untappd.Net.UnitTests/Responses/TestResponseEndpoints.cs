using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Untappd.Net.Request;

namespace Untappd.Net.UnitTests.Responses
{
    [TestFixture]
    public class TestResponseEndpoints
    {

        /// <summary>
        /// Run through all the endpoints to make sure they all atleast do not error out. 
        /// This is so we can get a high code coverage, while also covering new types that get added.
        /// </summary>
        [Test]
        public void RunAllEndpoints()
        {

            var objects = Assembly.GetAssembly(typeof (IRequest)).GetTypes().Where(myType => 
                myType.IsClass 
                && !myType.IsAbstract 
                && myType.GetInterface("IRequest") != null).Select(type => (IRequest) Activator.CreateInstance(type)).ToList();
            objects.ForEach(a=>Assert.IsNotNullOrEmpty(a.EndPoint("t")));
        }
        [Test]
         public void RunAllEndpointsWithEmptyString()
        {

            var objects = Assembly.GetAssembly(typeof (IRequest)).GetTypes().Where(myType => 
                myType.IsClass 
                && !myType.IsAbstract 
                && myType.GetInterface("IRequest") != null).Select(type => (IRequest) Activator.CreateInstance(type)).ToList();
            objects.ForEach(a=>Assert.IsNotNullOrEmpty(a.EndPoint(string.Empty)));
        }
    }
}
