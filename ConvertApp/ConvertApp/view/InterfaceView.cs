using System;
using ConvertApp.model;

namespace ConvertApp.view
{
    public class InterfaceView : IConvertingView
    {
        public InterfaceView()
        {
        }

        public void renderInputSizeError()
        {
            throw new NotImplementedException();
        }

        public void renderMenu(ref Convertable convertable)
        {
            throw new NotImplementedException();
        }

        public void renderOutput(ref Convertable convertable)
        {
            throw new NotImplementedException();
        }
    }
}
