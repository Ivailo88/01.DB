using System;
using System.Collections.Generic;
using System.Text;

namespace Click_counter
{
    class Button
    {
        public EventHandler Click;

        public void PerformClick()
        {
            Click?.Invoke(this, EventArgs.Empty);
        }
    }
}
