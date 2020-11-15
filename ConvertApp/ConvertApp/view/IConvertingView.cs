using System;
using ConvertApp.model;

namespace ConvertApp.view
{
    public interface IConvertingView
    {
        // Display the menu app view and wait for the user entry
        // to insert in input
        public void renderMenu(ref Convertable convertable);

        // Display the output in view context
        public void renderOutput(ref Convertable convertable);

        // Display input Size Error
        public void renderInputSizeError();
    }
}
