using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventAndDelegate
{
    public class DelegateAndEvent
    {
        static void MainDelegateAndEvent(string[] args)
        {
            DelegateAndEvent d = new DelegateAndEvent();
            d.Test();

        }

        delegate void CancelD();/* Function pointer */
        event CancelD Cancel;/* instance of function pointer */

        public DelegateAndEvent()
        {
            this.Cancel += new CancelD(DelegateAndEvent_Cancel);
            this.Cancel += new CancelD(DelegateAndEvent_Cancel1);
            this.MyEvent += new EventHandler(DelegateAndEvent_MyEvent1);
            this.MyEvent += new EventHandler(DelegateAndEvent_MyEvent2);
            this.MyEvent += new EventHandler(DelegateAndEvent_MyEvent3);
        }

        void DelegateAndEvent_Cancel()
        {
        }


        void DelegateAndEvent_Cancel1()
        {
        }

        void DelegateAndEvent_MyEvent1(object sender, EventArgs e)
        {
        }

        void DelegateAndEvent_MyEvent2(object sender, EventArgs e)
        {

        }
        void DelegateAndEvent_MyEvent3(object sender, EventArgs e)
        {

        }

        public void Test()
        {
            if (this.Cancel != null)
                Cancel();

            this._myEvent(null, null);
        }

        private EventHandler _myEvent;

        public event EventHandler MyEvent
        {
            add
            {
                _myEvent = (EventHandler)Delegate.Combine(_myEvent, value);
            }
            remove
            {
                _myEvent = (EventHandler)Delegate.Remove(_myEvent, value);
            }
        }
    }
}
