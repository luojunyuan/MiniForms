namespace System.Windows.Forms
{
    public sealed partial class Application
    {
        /// <remarks>
        ///  <para>
        ///   Don't never ever change this name, since the window class and partner teams
        ///   dependent on this. Changing this will introduce breaking changes.
        ///   If there is some reason need to change this, notify any partner teams affected.
        ///  </para>
        /// </remarks>
        internal static string WindowsFormsVersion => "WindowsForms10";

        internal static bool CustomThreadExceptionHandlerAttached = false;
        //=> ThreadContext.FromCurrent().CustomThreadExceptionHandlerAttached;

        /// <summary>
        /// 运行消息循环，支持普通窗口应用程序
        /// </summary>
        public static void Run()
        {
            // 使用传统的 GetMessage 循环
            MSG msg = default;
            while (PInvoke.GetMessage(out msg, HWND.Null, 0, 0) > 0)
            {
                PInvoke.TranslateMessage(msg);
                PInvoke.DispatchMessage(msg);
            }
        }

        /// <summary>
        /// 运行消息循环，支持DirectX等需要持续渲染的应用程序
        /// </summary>
        /// <param name="renderCallback">渲染回调函数，在每帧执行</param>
        public static void RunWithRendering(Action renderCallback)
        {
            MSG msg = default;
            bool running = true;

            while (running)
            {
                // 处理所有待处理的Windows消息，但不阻塞
                while (PInvoke.PeekMessage(out msg, HWND.Null, 0, 0, PEEK_MESSAGE_REMOVE_TYPE.PM_REMOVE))
                {
                    // 检查是否收到退出消息
                    if (msg.message == PInvoke.WM_QUIT)
                    {
                        running = false;
                        break;
                    }

                    PInvoke.TranslateMessage(msg);
                    PInvoke.DispatchMessage(msg);
                }

                // 如果应用程序仍在运行，执行渲染回调
                if (running && renderCallback != null)
                {
                    renderCallback();
                }
            }
        }
    }
}
