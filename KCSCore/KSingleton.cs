using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KCSCore
{
    /// <summary>
    /// Singletonクラス
    /// </summary>
    /// <typeparam name="T">Singletonにするクラス</typeparam>
    public static class KSingleton<T> where T : new()
    {
        /// <summary>
        /// インスタンス
        /// </summary>
        private static readonly T s_instance = new();

        /// <summary>
        /// インスタンス
        /// </summary>
        public static T Instance => s_instance;
    }
}
