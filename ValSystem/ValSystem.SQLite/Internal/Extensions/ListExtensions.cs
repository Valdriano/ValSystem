﻿using System.Collections.Generic;

namespace ValSystem.SQLite.Internal.Extensions
{
    public static class ListExtensions
    {
        public static void AddIfNotNull<T>( this ICollection<T> list, T element )
        {
            if ( list == null || element == null )
            {
                return;
            }

            list.Add( element );
        }
    }
}