﻿using System.Collections.Generic;
using Entitas;

public static class EntityIndexContextExtensions {

    public const string PositionKey = "Position";
    const int shiftX = 8;

    public static void AddEntityIndices(this Contexts contexts) {
        var positionIndex = new EntityIndex<GameEntity, int>(
            contexts.game.GetGroup(GameMatcher.Position),
            (e, c) => {
                var positionComponent = c as PositionComponent;
                return positionComponent != null
                    ? (positionComponent.x << shiftX) + positionComponent.y
                    : (e.position.x << shiftX) + e.position.y;
            }
        );

        contexts.game.AddEntityIndex(PositionKey, positionIndex);
    }

    public static HashSet<GameEntity> GetEntitiesWithPosition(this GameContext context, int x, int y) {
        var index = (EntityIndex<GameEntity, int>)context.GetEntityIndex(PositionKey);
        return index.GetEntities((x << shiftX) + y);
    }
}
