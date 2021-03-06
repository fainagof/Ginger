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
using System.Collections.Generic;
using GingerCore.Drivers.Common;
using GingerCore.Actions.Common;
using GingerCore.WindowExplorer.Common;

namespace GingerCore.Drivers
{
    public interface IWindowExplorer
    {
        List<AppWindow> GetAppWindows();        
        void SwitchWindow(string Title);     
        void HighLightElement(ElementInfo ElementInfo);
        string GetFocusedControl();
        ElementInfo GetControlFromMousePosition();       
        AppWindow GetActiveWindow();
        List<ElementInfo> GetVisibleControls(ObservableList<UIElementFilter> filteringCriterias);
        List<ElementInfo> GetElementChildren(ElementInfo ElementInfo);

        // Get All element properties to be displayed in properties 
        ObservableList<ControlProperty> GetElementProperties(ElementInfo ElementInfo);

        ObservableList<ElementLocator> GetElementLocators(ElementInfo ElementInfo);

        // Get the data of the element
        // For Combo box: will return all valid values - options available - List<ComboBoxElementItem>
        // For Table: will return list of rows data: List<TableElementItem>        
        object GetElementData(ElementInfo ElementInfo, ActUIElement.eLocateBy elementLocateBy, string elementLocateValue);
        
        //TODO: Why here ?
        bool AddSwitchWindowAction(string Title);

        ObservableList<ElementInfo> GetElements(ElementLocator EL);
        void UpdateElementInfoFields(ElementInfo eI);
        ObservableList<UIElementFilter> GetFilteringCreteriaDict();

        bool IsElementObjectValid(object obj);
    }
}
