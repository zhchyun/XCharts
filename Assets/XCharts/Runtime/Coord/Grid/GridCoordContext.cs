/************************************************/
/*                                              */
/*     Copyright (c) 2018 - 2021 monitor1394    */
/*     https://github.com/monitor1394           */
/*                                              */
/************************************************/

using UnityEngine;

namespace XCharts
{
    public class GridCoordContext : MainComponentContext, IRectContext
    {
        public float x { get; internal set; }
        public float y { get; internal set; }
        public float width { get; internal set; }
        public float height { get; internal set; }
        public Vector3 position { get; internal set; }
        public float left { get; internal set; }
        public float right { get; internal set; }
        public float bottom { get; internal set; }
        public float top { get; internal set; }
        public bool runtimeIsPointerEnter { get; set; }
    }
}