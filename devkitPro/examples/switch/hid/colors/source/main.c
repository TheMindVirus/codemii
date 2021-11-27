// Include the most common headers from the C standard library
#include <stdio.h>
#include <stdlib.h>
#include <string.h>

// Include the main libnx system header, for Switch development
#include <switch.h>

//See also libnx hid.h.

// Main program entrypoint
int main(int argc, char* argv[])
{
    // This example uses a text console, as a simple way to output text to the screen.
    // If you want to write a software-rendered graphics application,
    //   take a look at the graphics/simplegfx example, which uses the libnx Framebuffer API instead.
    // If on the other hand you want to write an OpenGL based application,
    //   take a look at the graphics/opengl set of examples, which uses EGL instead.
    consoleInit(NULL);

    // Configure our supported input layout: a single player with standard controller styles
    padConfigureInput(1, HidNpadStyleSet_NpadStandard);

    // Initialize the default gamepad (which reads handheld mode inputs as well as the first connected controller)
    PadState pad;
    padInitializeDefault(&pad);

    Result rc=0;

    printf(CONSOLE_ESC(1;1H) "Press PLUS to exit.");

    // Main loop
    while(appletMainLoop())
    {
        // Scan the gamepad. This should be done once for each frame
        padUpdate(&pad);

        // padGetButtonsDown returns the set of buttons that have been
        // newly pressed in this frame compared to the previous one
        u64 kDown = padGetButtonsDown(&pad);

        if (kDown & HidNpadButton_Plus)
            break; // break in order to return to hbmenu

        HidNpadControllerColor colors={0};

        // Note that if a color field is zero that indicates that the color field isn't set.
        // You might want to also use hidGetNpadControllerColorSplit.
        rc = hidGetNpadControllerColorSingle(padIsHandheld(&pad) ? HidNpadIdType_Handheld : HidNpadIdType_No1, &colors);
        if (R_SUCCEEDED(rc)) {
            printf(CONSOLE_ESC(3;1H) "main = 0x%08x, sub = 0x%08x.\n", colors.main, colors.sub);
        }
        else {
            printf(CONSOLE_ESC(3;1H) CONSOLE_ESC(2K));
        }

        // Update the console, sending a new frame to the display
        consoleUpdate(NULL);
    }

    // Deinitialize and clean up resources used by the console (important!)
    consoleExit(NULL);
    return 0;
}
