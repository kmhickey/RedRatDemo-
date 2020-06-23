using System;

namespace RedRat.TestRemote 
{
	/// <summary>
	/// Button associated with an IR action.
	/// </summary>
	public class IRButton : System.Windows.Forms.Button 
    {
        protected ButtonInfo info = new ButtonInfo();

		public IRButton() : base() {
		}

        public ButtonInfo Info {
          get { return info; }
          set 
            { 
                info = value; 
            }
        }
    }
}
