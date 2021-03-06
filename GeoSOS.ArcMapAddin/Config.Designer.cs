//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace GeoSOS.ArcMapAddIn {
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcMapUI;
    using System;
    using System.Collections.Generic;
    using ESRI.ArcGIS.Desktop.AddIns;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "GeoSOS for ArcGIS";
            }
        }
        
        internal static string AddInID {
            get {
                return "{ea3e103b-fc5c-4eeb-bf28-d7e59875f0ba}";
            }
        }
        
        internal static string Company {
            get {
                return "Prof. Xia Li";
            }
        }
        
        internal static string Version {
            get {
                return "2.0.0a";
            }
        }
        
        internal static string Description {
            get {
                return "This is an ArcMap Add-In provides GeoSOS CA (Cellular Automata) simulation functi" +
                    "ons and area optimization function.";
            }
        }
        
        internal static string Author {
            get {
                return "Dr. Dan Li, Prof. Xia Li";
            }
        }
        
        internal static string Date {
            get {
                return "2016/10/4";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonANNCA', the id declared for Add-in Button class 'ButtonANNCA'
            /// </summary>
            internal static string ButtonANNCA {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonANNCA";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonDTCA', the id declared for Add-in Button class 'ButtonDTCA'
            /// </summary>
            internal static string ButtonDTCA {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonDTCA";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonLogisticCA', the id declared for Add-in Button class 'ButtonLogisticCA'
            /// </summary>
            internal static string ButtonLogisticCA {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonLogisticCA";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonAreaOptimization', the id declared for Add-in Button class 'ButtonAreaOptimization'
            /// </summary>
            internal static string ButtonAreaOptimization {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonAreaOptimization";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonStart', the id declared for Add-in Button class 'ButtonStart'
            /// </summary>
            internal static string ButtonStart {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonStart";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonPause', the id declared for Add-in Button class 'ButtonPause'
            /// </summary>
            internal static string ButtonPause {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonPause";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonStop', the id declared for Add-in Button class 'ButtonStop'
            /// </summary>
            internal static string ButtonStop {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonStop";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonSimulationConfiguration', the id declared for Add-in Button class 'ButtonSimulationConfiguration'
            /// </summary>
            internal static string ButtonSimulationConfiguration {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonSimulationConfiguration";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonLanduseHistoricalTrends', the id declared for Add-in Button class 'ButtonHistoricalTrends'
            /// </summary>
            internal static string ButtonHistoricalTrends {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonLanduseHistoricalTrends";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonImagesCompare', the id declared for Add-in Button class 'ButtonImagesCompare'
            /// </summary>
            internal static string ButtonImagesCompare {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonImagesCompare";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonOutputWindow', the id declared for Add-in Button class 'ButtonOutputWindow'
            /// </summary>
            internal static string ButtonOutputWindow {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonOutputWindow";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonGraphyWindow', the id declared for Add-in Button class 'ButtonGraphyWindow'
            /// </summary>
            internal static string ButtonGraphyWindow {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonGraphyWindow";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonUserManual', the id declared for Add-in Button class 'ButtonUserManual'
            /// </summary>
            internal static string ButtonUserManual {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonUserManual";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonAbout', the id declared for Add-in Button class 'ButtonAbout'
            /// </summary>
            internal static string ButtonAbout {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_ButtonAbout";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowAreaOptimization', the id declared for Add-in DockableWindow class 'DockableWindowAreaOptimization+AddinImpl'
            /// </summary>
            internal static string DockableWindowAreaOptimization {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowAreaOptimization";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowOutput', the id declared for Add-in DockableWindow class 'DockableWindowOutput+AddinImpl'
            /// </summary>
            internal static string DockableWindowOutput {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowOutput";
                }
            }
            
            /// <summary>
            /// Returns 'Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowGraphy', the id declared for Add-in DockableWindow class 'DockableWindowGraphy+AddinImpl'
            /// </summary>
            internal static string DockableWindowGraphy {
                get {
                    return "Prof._Xia_Li_GeoSOS_ArcMapAddIn_DockableWindowGraphy";
                }
            }
        }
    }
    
internal static class ArcMap
{
  private static IApplication s_app = null;
  private static IDocumentEvents_Event s_docEvent;

  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IMxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IMxDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document as IMxDocument;

      return null;
    }
  }
  public static IMxApplication ThisApplication
  {
    get { return Application as IMxApplication; }
  }
  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }
  public static IDocumentEvents_Event Events
  {
    get
    {
      s_docEvent = Document as IDocumentEvents_Event;
      return s_docEvent;
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
