using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IStorable
    {
        void Read(string fileName);
        void Write(string fileName);
    }
}
