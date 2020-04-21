using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderExample
{
    class AssemblyBay
    {
        public void Construct(CombotBuilder combotBuilder)
        {
            combotBuilder.BuildTorso();
            combotBuilder.BuildLegs();
            combotBuilder.BuildArm();
        }
    }
}
