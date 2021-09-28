using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stigespill_v2
{
    public class PrintToConsole
    {
        public List<List<int>> rows;
        public List<int> row;
        public Model model;
        public Ladder ladder;

        public PrintToConsole(Model model, Ladder ladder)
        {
            model = new Model();

            rows = model.listOfRows;
            createGameMatrix(model);
            printStatus();
        }


      
    }
}


