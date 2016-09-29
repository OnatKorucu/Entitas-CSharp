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

        public Array3DComponent array3D { get { return (Array3DComponent)GetComponent(VisualDebuggingComponentIds.Array3D); } }
        public bool hasArray3D { get { return HasComponent(VisualDebuggingComponentIds.Array3D); } }

        public Entity AddArray3D(string[,,] newArray3d) {
            var component = CreateComponent<Array3DComponent>(VisualDebuggingComponentIds.Array3D);
            component.array3d = newArray3d;
            return AddComponent(VisualDebuggingComponentIds.Array3D, component);
        }

        public Entity ReplaceArray3D(string[,,] newArray3d) {
            var component = CreateComponent<Array3DComponent>(VisualDebuggingComponentIds.Array3D);
            component.array3d = newArray3d;
            ReplaceComponent(VisualDebuggingComponentIds.Array3D, component);
            return this;
        }

        public Entity RemoveArray3D() {
            return RemoveComponent(VisualDebuggingComponentIds.Array3D);
        }
    }
}

    public partial class VisualDebuggingMatcher {

        static IMatcher _matcherArray3D;

        public static IMatcher Array3D {
            get {
                if(_matcherArray3D == null) {
                    var matcher = (Matcher)Matcher.AllOf(VisualDebuggingComponentIds.Array3D);
                    matcher.componentNames = VisualDebuggingComponentIds.componentNames;
                    _matcherArray3D = matcher;
                }

                return _matcherArray3D;
            }
        }
    }
