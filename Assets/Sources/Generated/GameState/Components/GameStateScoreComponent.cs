//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentEntityGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameStateEntity {

    public ScoreComponent score { get { return (ScoreComponent)GetComponent(GameStateComponentsLookup.Score); } }
    public bool hasScore { get { return HasComponent(GameStateComponentsLookup.Score); } }

    public void AddScore(int newValue) {
        var component = CreateComponent<ScoreComponent>(GameStateComponentsLookup.Score);
        component.value = newValue;
        AddComponent(GameStateComponentsLookup.Score, component);
    }

    public void ReplaceScore(int newValue) {
        var component = CreateComponent<ScoreComponent>(GameStateComponentsLookup.Score);
        component.value = newValue;
        ReplaceComponent(GameStateComponentsLookup.Score, component);
    }

    public void RemoveScore() {
        RemoveComponent(GameStateComponentsLookup.Score);
    }
}
