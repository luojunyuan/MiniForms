# MiniForms

MiniForms is a C# wrapper around WinForms' `NativeWindow`, providing a low-level encapsulation of a window handle and a window procedure. It is based on the open-source WinForms library, with the main difference being that it extracts and isolates the `NativeWindow` class, allowing you to use it without the need for the entire WinForms framework or dependencies like `System.Windows.Forms.Application` or `ThreadContext`.

The goal of MiniForms is to provide a simplified API for creating Win32 windows in C# while staying in sync with the upstream WinForms repository.

- **Target Framework**: .NET 9
- **DLL Size**: ~50 KB

For more details on the modification to `NativeWindow.ForceExitMessageLoop()`, refer to this [commit](https://github.com/luojunyuan/winforms/blob/0d9feee0b61472a37baddc4ed95098ffb48385c3/src/System.Windows.Forms/System/Windows/Forms/NativeWindow.cs#L88).
