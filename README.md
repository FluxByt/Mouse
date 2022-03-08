# Mouse
C# Library for mouse controls with simplified syntax

Allows for controlling of various mouse functions such as clicking, moving and scrolling.


# Usage

press(int)
> Press/Hold a mouse button, define button to press with Variables or corresponding value.

release(int)
> Release a mouse button, define button to release with Variables or corresponding value.

click(int)
> Press and Release a mouse button, define button to click with Variables or corresponding value.

MoveMouseTo(int, int)
> Move mouse to a coordinate on screen, define coordnites by passing values x and y.

MoveMouseRelative(int, int)
> Move mouse relative to cursor on screen, define displacement by passing values x and y.

GetCursorPos()
> Get current position of the cursor, returns (int, int) x and y respectively 



# Variables
MOUSEEVENTF_LEFTUP or 0x04 = Release Left Mouse Button

MOUSEEVENTF_RIGHTUP or 0x10 = Release Right Mouse Button

MOUSEEVENTF_MIDDLEUP or 0x40 = Release Middle Mouse Button

MOUSEEVENTF_LEFTDOWN or 0x02 = Press Left Mouse Button

MOUSEEVENTF_RIGHTDOWN or 0x08 = Press Right Mouse Button

MOUSEEVENTF_MIDDLEDOWN or 0x20 = Press Middle Mouse Button

MOUSEEVENTF_LEFTCLICK = Click Left Mouse Button

MOUSEEVENTF_RIGHTCLICK = Click Right Mouse Button

MOUSEEVENTF_MIDDLECLICK = Click Middle Mouse Button


