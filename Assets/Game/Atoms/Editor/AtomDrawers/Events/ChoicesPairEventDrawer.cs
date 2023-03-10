#if UNITY_2019_1_OR_NEWER
using UnityEditor;
using UnityAtoms.Editor;

namespace UnityAtoms.Editor
{
    /// <summary>
    /// Event property drawer of type `ChoicesPair`. Inherits from `AtomDrawer&lt;ChoicesPairEvent&gt;`. Only availble in `UNITY_2019_1_OR_NEWER`.
    /// </summary>
    [CustomPropertyDrawer(typeof(ChoicesPairEvent))]
    public class ChoicesPairEventDrawer : AtomDrawer<ChoicesPairEvent> { }
}
#endif
