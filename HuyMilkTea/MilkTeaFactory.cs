using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HuyMilkTea
{
    class MilkTeaFactory
    {
        static MilkTea MakeClassicMilkTea(MilkTeaSize size)
        {
            return new ClassicMilkTea(size);
        }
        static MilkTea MakeThaiGreenTea(MilkTeaSize size)
        {
            return new ThaiGreenTea(size); 
        }
        static MilkTea MakeBubbleMilkTea(MilkTeaSize size)
        {
            return new BubbleMilkTea(size);

        }
        static MilkTea MakeCocoaMilkTea(MilkTeaSize size)
        {
            return new CocoaMilkTea(size);



        }
    }

    
}
