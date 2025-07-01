using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System.Windows.Forms
{

    /// <summary>
    ///  Helper class for scaling.
    /// </summary>
    internal static partial class ScaleHelper
    {
        /// <summary>
        ///  Enters a scope during which the current thread's DPI awareness context is set to
        ///  <paramref name="awareness"/>
        /// </summary>
        /// <param name="awareness">The new DPI awareness for the current thread</param>
        /// <returns>
        ///  An object that, when disposed, will reset the current thread's DPI awareness to the value it had when the
        ///  object was created.
        /// </returns>
        public static IDisposable EnterDpiAwarenessScope(
            DPI_AWARENESS_CONTEXT awareness,
            DPI_HOSTING_BEHAVIOR dpiHosting = DPI_HOSTING_BEHAVIOR.DPI_HOSTING_BEHAVIOR_MIXED)
            => new DpiAwarenessScope(awareness, dpiHosting);

    }
}
