using Project.RepositoryService;
using Project.View.Students;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Controllers
{
    //Trainer Controller
    class TrainerController
    {
        TrainerRepository trainerService = new TrainerRepository();
        public void ReadAllTrainers()
        {
            var trainers = trainerService.GetAll();
            ViewTrainer.PrintTrainers(trainers);
        }
        public void CreateTrainer()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Create a new Trainer");
            Console.ResetColor();
            Console.WriteLine();
            var trainer = ViewTrainer.CreateTrainer();
            trainerService.Add(trainer);
        }
        
    }
}
