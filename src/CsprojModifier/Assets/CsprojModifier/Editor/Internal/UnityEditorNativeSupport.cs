using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace CsprojModifier.Editor.Internal
{
    internal static class UnityEditorNativeSupport
    {
        public static bool HasRoslynAnalyzerIdeSupport
        {
            get
            {

#if UNITY_2020_2_OR_NEWER && (HAS_ROSLYN_ANALZYER_SUPPORT_RIDER || HAS_ROSLYN_ANALZYER_SUPPORT_VSCODE)
                    // The editor extension for 'Rider' or 'Visual Studio Code' has the functionality to add Roslyn analyzer references.
                    var codeEditorType = Unity.CodeEditor.CodeEditor.CurrentEditor.GetType();
                    if (codeEditorType.Name == "VSCodeScriptEditor" || codeEditorType.Name == "RiderScriptEditor")
                    {
                        return true;
                    }
#endif
                return false;
            }
        }
    }
}
