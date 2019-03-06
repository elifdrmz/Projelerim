using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SC_Interface
{
    class BangOlufsenTV : ITitle
    {
        string ITitle.MainTitle()
        {
            throw new NotImplementedException();
        }

        string ITitle.Output()
        {
            return "ITitle Çıkışlar burada";
        }

        string ITitle.SubTitle()
        {
            throw new NotImplementedException();
        }

        string ITitle.TitleName()
        {
            return "ITitle TitleName i buraya";
        }
    }
}
