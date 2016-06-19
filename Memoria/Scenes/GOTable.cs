﻿using UnityEngine;

namespace Memoria
{
    internal sealed class GOTable<T> : GOArray<T> where T : GOBase
    {
        public readonly UITable Table;

        public GOTable(GameObject obj)
            : base(obj)
        {
            Table = obj.GetExactComponent<UITable>();
        }
    }
}