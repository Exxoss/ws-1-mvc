using System;
using ConvertApp.model;
using ConvertApp.view;

namespace ConvertApp.controller
{
    public class ConvertingController
    {
        private static int MAX_ENTRY_LENGHT = 8;

        private IConvertingView view = new ConsoleView();
        private Convertable convertable = new Convertable();

        public ConvertingController()
        {
        }

        public void execution()
        {
            this.view.renderMenu(ref this.convertable);

            if (null != this.convertable.input && this.convertable.input.Length >= 1 && this.convertable.input.Length <= MAX_ENTRY_LENGHT)
            {
                this.convertable.output = this.convert(this.convertable.input);

                this.view.renderOutput(ref this.convertable);
            } else
            {
                this.view.renderInputSizeError();
            }
            this.execution();
        }

        private String convert(String input)
        {
            return input.ToUpper();
        }
    }
}
