/*

   Copyright 2016 Esri

   Licensed under the Apache License, Version 2.0 (the "License");
   you may not use this file except in compliance with the License.
   You may obtain a copy of the License at

       http://www.apache.org/licenses/LICENSE-2.0

   Unless required by applicable law or agreed to in writing, software
   distributed under the License is distributed on an "AS IS" BASIS,
   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.

   See the License for the specific language governing permissions and
   limitations under the License.

*/
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using ESRI.ArcGIS.ADF.BaseClasses;
using ESRI.ArcGIS.ADF.CATIDs;
using ESRI.ArcGIS.Controls;
using ESRI.ArcGIS.Carto;

namespace MapControlSaveLayerFile
{
  /// <summary>
  /// Summary description for RemoveLayerCmd.
  /// </summary>
  [Guid("d848a775-dc85-4ee3-88a6-a780572139a2")]
  [ClassInterface(ClassInterfaceType.None)]
  [ProgId("MapControlSaveLayerFile.RemoveLayerCmd")]
  public sealed class RemoveLayerCmd : BaseCommand
  {
    #region COM Registration Function(s)
    [ComRegisterFunction()]
    [ComVisible(false)]
    static void RegisterFunction(Type registerType)
    {
      // Required for ArcGIS Component Category Registrar support
      ArcGISCategoryRegistration(registerType);

      //
      // TODO: Add any COM registration code here
      //
    }

    [ComUnregisterFunction()]
    [ComVisible(false)]
    static void UnregisterFunction(Type registerType)
    {
      // Required for ArcGIS Component Category Registrar support
      ArcGISCategoryUnregistration(registerType);

      //
      // TODO: Add any COM unregistration code here
      //
    }

    #region ArcGIS Component Category Registrar generated code
    /// <summary>
    /// Required method for ArcGIS Component Category registration -
    /// Do not modify the contents of this method with the code editor.
    /// </summary>
    private static void ArcGISCategoryRegistration(Type registerType)
    {
      string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
      ControlsCommands.Register(regKey);

    }
    /// <summary>
    /// Required method for ArcGIS Component Category unregistration -
    /// Do not modify the contents of this method with the code editor.
    /// </summary>
    private static void ArcGISCategoryUnregistration(Type registerType)
    {
      string regKey = string.Format("HKEY_CLASSES_ROOT\\CLSID\\{{{0}}}", registerType.GUID);
      ControlsCommands.Unregister(regKey);

    }

    #endregion
    #endregion

    private IHookHelper m_hookHelper;

    public RemoveLayerCmd()
    {
      base.m_category = ".NET Samples";
      base.m_caption = "Remove Layer";
      base.m_message = "Remove Layer";
      base.m_toolTip = "Remove Layer";
      base.m_name = "MapControlSaveLayerFile_RemoveLayerCmd";   

      try
      {
        //
        // TODO: change bitmap name if necessary
        //
        string bitmapResourceName = GetType().Name + ".bmp";
        base.m_bitmap = new Bitmap(GetType(), bitmapResourceName);
      }
      catch (Exception ex)
      {
        System.Diagnostics.Trace.WriteLine(ex.Message, "Invalid Bitmap");
      }
    }

    #region Overriden Class Methods

    /// <summary>
    /// Occurs when this command is created
    /// </summary>
    /// <param name="hook">Instance of the application</param>
    public override void OnCreate(object hook)
    {
      if (hook == null)
        return;

      if (m_hookHelper == null)
        m_hookHelper = new HookHelperClass();

      m_hookHelper.Hook = hook;

      // TODO:  Add other initialization code
    }

    /// <summary>
    /// Occurs when this command is clicked
    /// </summary>
    public override void OnClick()
    {
      //need to get the layer from the custom-property of the map
      if (null == m_hookHelper)
        return;

      //get the mapControl hook
      object hook = null;
      if (m_hookHelper.Hook is IToolbarControl2)
      {
        hook = ((IToolbarControl2)m_hookHelper.Hook).Buddy;
      }
      else
      {
        hook = m_hookHelper.Hook;
      }

      //get the custom property from which is supposed to be the layer to be saved
      object customProperty = null;
      IMapControl3 mapControl = null;
      if (hook is IMapControl3)
      {
        mapControl = (IMapControl3)hook;
        customProperty = mapControl.CustomProperty;
      }
      else
        return;

      if (null == customProperty || !(customProperty is ILayer))
        return;

      m_hookHelper.FocusMap.DeleteLayer((ILayer)customProperty);
    }

    #endregion
  }
}
