//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.MatcherGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Entitas;

public sealed partial class GameMatcher {

    static IMatcher<GameEntity> _matcherGameBoardElement;

    public static IMatcher<GameEntity> GameBoardElement {
        get {
            if(_matcherGameBoardElement == null) {
                var matcher = (Matcher<GameEntity>)Matcher<GameEntity>.AllOf(GameComponentsLookup.GameBoardElement);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherGameBoardElement = matcher;
            }

            return _matcherGameBoardElement;
        }
    }
}
