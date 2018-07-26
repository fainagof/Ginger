#region License
/*
Copyright © 2014-2018 European Support Limited

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

using Amdocs.Ginger.Common;
using Amdocs.Ginger.Repository;
using System;

namespace Amdocs.Ginger.Common.UIElement
{
    public class ElementLocator : RepositoryItemBase
    {
        private eLocateBy mLocateBy { get; set; }
        [IsSerializedForLocalRepository]
        public eLocateBy LocateBy { get { return mLocateBy; } set { mLocateBy = value; OnPropertyChanged(nameof(LocateBy)); } }

        private string mLocateValue { get; set; }
        [IsSerializedForLocalRepository]
        public string LocateValue { get { return mLocateValue; } set { mLocateValue = value; OnPropertyChanged(nameof(LocateValue)); } }

        private string mHelp { get; set; }
        public string Help { get { return mHelp; } set { mHelp = value; OnPropertyChanged(nameof(Help)); } }

        private int? mCount { get; set; }
        public int? Count { get { return mCount; } set { mCount = value; OnPropertyChanged(nameof(Count)); } }

        public override string ItemName { get { throw new NotImplementedException(); } set { throw new NotImplementedException(); } }
    }
}