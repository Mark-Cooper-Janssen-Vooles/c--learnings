using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExercises
{
    public class WorkflowEngine
    {
        public void Run(List<IActivity> workflow)
        {
            foreach (var activity in workflow)
            {
                activity.Execute();
            }
        }
    }

    public interface IActivity
    {
        void Execute();
    }

    public class Dishes : IActivity
    {

        public void Execute()
        {
            Console.WriteLine("Executing the dishes");
        }
    }

    public class Walking : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Executing a walk");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var workflowEngine = new WorkflowEngine();
            workflowEngine.Run(new List<IActivity> { new Walking(), new Dishes() });
        }
    }
}
