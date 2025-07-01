// See https://aka.ms/new-console-template for more information
using System.Windows.Forms;

Console.WriteLine("Hello, World!");

var win = new NativeWindow();

const int WS_OVERLAPPEDWINDOW = 0x00CF0000;
const int WS_VISIBLE = 0x10000000;
var cp = new CreateParams
{
    Caption = "MiniForms NativeWindow",
    X = 100,
    Y = 100,
    Width = 400,
    Height = 300,
    Style = WS_OVERLAPPEDWINDOW | WS_VISIBLE,
};

win.CreateHandle(cp);

Application.Run();