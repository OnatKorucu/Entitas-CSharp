//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

namespace Entitas {

    public partial class Entity {

        public DictionaryComponent dictionary { get { return (DictionaryComponent)GetComponent(VisualDebuggingComponentIds.Dictionary); } }
        public bool hasDictionary { get { return HasComponent(VisualDebuggingComponentIds.Dictionary); } }

        public Entity AddDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
            var component = CreateComponent<DictionaryComponent>(VisualDebuggingComponentIds.Dictionary);
            component.dict = newDict;
            return AddComponent(VisualDebuggingComponentIds.Dictionary, component);
        }

        public Entity ReplaceDictionary(System.Collections.Generic.Dictionary<string, string> newDict) {
            var component = CreateComponent<DictionaryComponent>(VisualDebuggingComponentIds.Dictionary);
            component.dict = newDict;
            ReplaceComponent(VisualDebuggingComponentIds.Dictionary, component);
            return this;
        }

        public Entity RemoveDictionary() {
            return RemoveComponent(VisualDebuggingComponentIds.Dictionary);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherDictionary;

        public static IMatcher Dictionary {
            get {
                if(_matcherDictionary == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.Dictionary);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherDictionary = matcher;
                }

                return _matcherDictionary;
            }
        }
    }
