using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace TREgitim.Odeme
{
    public class OdemeIslemleriFactory
    {

        public IOdeme GetInstance(string strFullyQualifiedName)
        {
            var newClass = System.Reflection.Assembly.GetAssembly(typeof(IOdeme)).CreateInstance("TREgitim.Odeme." + strFullyQualifiedName);

            return (IOdeme)newClass;
        }
    }
}
