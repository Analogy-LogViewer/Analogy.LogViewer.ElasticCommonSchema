﻿
namespace Analogy.LogViewer.ElasticCommonSchema.DataTypes
{
    public class Rendering
    {
        public string Name { get; }
        public string Format { get; }
        public string Rendered { get; }

        public Rendering(string name, string format, string rendered)
        {
            Name = name;
            Format = format;
            Rendered = rendered;
        }
    }
}