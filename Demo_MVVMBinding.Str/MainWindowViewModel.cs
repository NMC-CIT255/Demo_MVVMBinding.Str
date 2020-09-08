using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MVVMBinding
{
    public class MainWindowViewModel : ObservableObject
    {
        private Widget _widget;

        public Widget Widget
        {
            get { return _widget; }
            set { _widget = value; }
        }

        public MainWindowViewModel()
        {
            Widget = InitializeWidget();
        }

        private Widget InitializeWidget()
        {
            return new Widget()
            {
                Name = "Furry",
                Color = "Purple",
                UnitPrice = 5.95,
                CurrentInventory = 10
            };
        }
    }
}
