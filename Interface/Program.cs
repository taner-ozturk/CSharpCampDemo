using System;

namespace Interface
{
    class Program
    {

        static void Main (string[] args)
        {
            //IPersonManager customerManager = new CustomerManager();

            //IPersonManager employeeManager = new EmployeeManager();
            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new InternManager());
            projectManager.Delete(new EmployeeManager());
           

        }



        interface IPersonManager
        {
            void Add();
            void Delete();
        }



        class CustomerManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("müsteri eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("müşteri silindi");
            }
        }

        class EmployeeManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Çalışan eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("Çalışan silindi");
            }
        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajer eklendi");
            }

            public void Delete()
            {
                Console.WriteLine("Stajer silindi");
            }
        }



        class ProjectManager
        {
            public void Add(IPersonManager personManager)
            {
                personManager.Add();
            }

            public void Delete(IPersonManager personManager)
            {
                personManager.Delete();
            }

        }

    }
}
