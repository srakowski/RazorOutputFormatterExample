// MIT License - Copyright (C) Shawn Rakowski
// This file is subject to the terms and conditions defined in
// file 'LICENSE', which is part of this source code package.

using System.Collections.Generic;

namespace RazorOutputFormatterExample.Models
{
    public class Gargoyle
    {
        public string Name { get; set; }

        public string Color { get; set; }

        public bool IsLeader { get; set; }

        public static IEnumerable<Gargoyle> GetAll() =>
            new []
            {
                new Gargoyle
                {
                    Name = "Goliath",
                    Color = "RebeccaPurple",
                    IsLeader = true,
                },
                new Gargoyle
                {
                    Name = "Hudson",
                    Color = "Brown",
                },
                new Gargoyle
                {
                    Name = "Lexington",
                    Color = "Olive",
                },
                new Gargoyle
                {
                    Name = "Broadway",
                    Color = "Cyan",
                },
                new Gargoyle
                {
                    Name = "Brooklyn",
                    Color = "FireBrick",
                },
                new Gargoyle
                {
                    Name = "Bronx",
                    Color = "MediumSlateBlue",
                },
                
            };
    }
}
