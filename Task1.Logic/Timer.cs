using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1.Logic
{
    /// <summary>
    /// Event arguments for event of <see cref="Timer"/>.
    /// </summary>
    public sealed class TimeIsOverEventArgs : EventArgs
    {
        public string Msg { get; set; }
    }

    /// <summary>
    /// Countdown timer.
    /// </summary>
    public sealed class Timer
    {
        #region Private fields

        private int _time;

        #endregion


        #region Properties


        /// <summary>
        /// Time for countdown.
        /// </summary>
        public int Time
        {
            get => _time;

            set
            {
                if (value <= 0)
                    throw new ArgumentException("Time must be more than zero.");
                _time = value;
            }
        }

        #endregion


        #region Event time is over 

        /// <summary>
        /// The event when time is over.
        /// </summary>
        public event EventHandler<TimeIsOverEventArgs> TimeIsOver = delegate { };

        /// <summary>
        /// Starts the time.
        /// </summary>
        /// <param name="msg"> The message to listeners. </param>
        public void Start(string msg)
        {
            Thread.Sleep(1000 * Time);
            OnTimeIsOver(new TimeIsOverEventArgs() { Msg = msg });
        }

        private void OnTimeIsOver(TimeIsOverEventArgs eventArgs)
        {
            EventHandler<TimeIsOverEventArgs> temp = TimeIsOver;
            temp?.Invoke(this, eventArgs);
        }

        #endregion
    }
}
