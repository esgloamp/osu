﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System;
using osu.Game.Rulesets.Objects;

namespace osu.Game.Rulesets.Mania.Beatmaps.Patterns
{
    /// <summary>
    /// Generator to create a pattern <see cref="Pattern"/> from a hit object.
    /// </summary>
    internal abstract class PatternGenerator
    {
        /// <summary>
        /// The last pattern.
        /// </summary>
        protected readonly Pattern PreviousPattern;

        /// <summary>
        /// The hit object to create the pattern for.
        /// </summary>
        protected readonly HitObject HitObject;

        /// <summary>
        /// The beatmap which <see cref="HitObject"/> is a part of.
        /// </summary>
        protected readonly ManiaBeatmap Beatmap;

        protected readonly int TotalColumns;

        protected PatternGenerator(HitObject hitObject, ManiaBeatmap beatmap, Pattern previousPattern)
        {
            if (hitObject == null) throw new ArgumentNullException(nameof(hitObject));
            if (beatmap == null) throw new ArgumentNullException(nameof(beatmap));
            if (previousPattern == null) throw new ArgumentNullException(nameof(previousPattern));

            HitObject = hitObject;
            Beatmap = beatmap;
            PreviousPattern = previousPattern;

            TotalColumns = Beatmap.TotalColumns;
        }

        /// <summary>
        /// Generates the pattern for <see cref="HitObject"/>, filled with hit objects.
        /// </summary>
        /// <returns>The <see cref="Pattern"/> containing the hit objects.</returns>
        public abstract Pattern Generate();
    }
}
