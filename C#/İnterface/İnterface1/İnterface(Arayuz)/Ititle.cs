using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace İnterface_Arayuz_
{
    public interface ITitle
    {
        string TitleName();
        string MainTitle();
        string SubTitle();
        string Output();

    }

    public interface ITitleSpecs
    {
        string Width();
        string Lenght();
        string Thickness();
        string Output();

    }
}
