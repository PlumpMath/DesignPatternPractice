using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternPractice.Test
{
    [TestClass]
    public class UnitTestState
    {
        [TestMethod]
        public void Test_State()
        {
            Context c = new Context(new ConcreteStateA());
            c.Request();
            c.Request();
            c.Request();
            c.Request();
        }

        [TestMethod]
        public void Test_WorkState()
        {
            Work emergencyProjects = new Work();
            emergencyProjects.Hour = 9;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 10;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 12;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 13;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 14;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 17;
            emergencyProjects.WriteProgram();

            ////emergencyProjects.TaskFinished = true;
            emergencyProjects.TaskFinished = false;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 19;
            emergencyProjects.WriteProgram();
            emergencyProjects.Hour = 22;
            emergencyProjects.WriteProgram();
        }
    }
}
