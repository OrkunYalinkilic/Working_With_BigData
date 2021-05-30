using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Base
{
   public class Yardim
    { 
        public void TryCatchKullan(Action _Action)
        {
			try
			{
				_Action();
			}
			catch (Exception ex)
			{
				// Loglama
			}
        }
    }
}
