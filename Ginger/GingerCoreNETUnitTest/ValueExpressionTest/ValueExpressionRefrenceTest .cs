#region License
/*
Copyright © 2014-2019 European Support Limited

Licensed under the Apache License, Version 2.0 (the "License")
you may not use this file except in compliance with the License.
You may obtain a copy of the License at 

http://www.apache.org/licenses/LICENSE-2.0 

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS, 
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. 
See the License for the specific language governing permissions and 
limitations under the License. 
*/
#endregion

using amdocs.ginger.GingerCoreNET;
using Amdocs.Ginger.CoreNET.RosLynLib.Refrences;
using GingerCoreNET.RosLynLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GingerCoreNETUnitTests.ValueExpressionTest
{
    [TestClass]
    public class ValueExpressionRefrenceTest
    {
        [TestInitialize]
        public void TestInitialize()
        {

        }

        [TestCleanup]
        public void TestCleanUp()
        {

        }


    
        [TestMethod]    
        public void LoadandTestFile()
        {
           foreach(ValueExpressionReference ver in  WorkSpace.Instance.VERefrences.Refrences)
            {
                if (ver.Expression.StartsWith("{CS") && ver.ExpressionResult != null)
                {
                    string actualResult = CodeProcessor.GetResult(ver.Expression);
                  
                        Assert.AreEqual(ver.ExpressionResult, actualResult);
                    
                }

            }
                              
        }


        [TestMethod]
        public void TestCSEvalExhaustive()
        {
            string Expression = string.Empty;

            string Expected = string.Empty;
            foreach (ValueExpressionReference ver in WorkSpace.Instance.VERefrences.Refrences.Where(x => x.Expression.StartsWith(@"{CS") && x.ExpressionResult != null))
            {

                Expression = Expression + "|" + ver.Expression;
                Expected = Expected + "|" + ver.ExpressionResult;
            }
            string Output = CodeProcessor.GetResult(Expression);

            Assert.AreEqual(Expected, Output);

        }

    }
}
