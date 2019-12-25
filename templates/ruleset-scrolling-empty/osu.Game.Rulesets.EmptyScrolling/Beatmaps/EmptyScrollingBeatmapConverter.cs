﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.EmptyScrolling.Objects;

namespace osu.Game.Rulesets.EmptyScrolling.Beatmaps
{
    public class EmptyScrollingBeatmapConverter : BeatmapConverter<EmptyScrollingHitObject>
    {
        // todo: Check for conversion types that should be supported (ie. Beatmap.HitObjects.Any(h => h is IHasXPosition))
        // https://github.com/ppy/osu/tree/master/osu.Game/Rulesets/Objects/Types
        public override bool CanConvert() => true;

        public EmptyScrollingBeatmapConverter(IBeatmap beatmap, Ruleset ruleset)
            : base(beatmap, ruleset)
        {
        }

        protected override IEnumerable<EmptyScrollingHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap)
        {
            yield return new EmptyScrollingHitObject
            {
                Samples = original.Samples,
                StartTime = original.StartTime,
            };
        }
    }
}
