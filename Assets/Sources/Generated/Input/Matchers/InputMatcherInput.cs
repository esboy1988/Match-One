//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class InputMatcher {

    static IMatcher<InputEntity> _matcherInput;

    public static IMatcher<InputEntity> Input {
        get {
            if(_matcherInput == null) {
                var matcher = (Matcher<InputEntity>)Matcher<InputEntity>.AllOf(InputComponentsLookup.Input);
                matcher.componentNames = InputComponentsLookup.componentNames;
                _matcherInput = matcher;
            }

            return _matcherInput;
        }
    }
}
