﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using System.Collections.Generic;
using osu.Game.Rulesets.Replays;
using osuTK;

namespace osu.Game.Rulesets.EmptyFreeform.Replays
{
    public class EmptyFreeformReplayFrame : ReplayFrame
    {
        public List<EmptyFreeformRulesetAction> Actions = new List<EmptyFreeformRulesetAction>();
        public Vector2 Position;

        public EmptyFreeformReplayFrame(EmptyFreeformRulesetAction? button = null)
        {
            if (button.HasValue)
                Actions.Add(button.Value);
        }
    }
}
