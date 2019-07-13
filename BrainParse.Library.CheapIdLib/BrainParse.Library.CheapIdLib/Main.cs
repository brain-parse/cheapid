using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Amazon.Lambda.Core;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.Json.JsonSerializer))]

namespace BrainParse.Library.CheapIdLib
{
    public class Main
    {
        private Server server;

        public Main() {
            server = new Server();
        }
        public string FunctionHandler(string input, ILambdaContext context)
        {
            return input?.ToUpper();
        }
        //public JObject CreateObject(JObject inputObject, ILambdaContext context) {
        //    return server
        //}
    }
}
