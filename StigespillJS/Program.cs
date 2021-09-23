using System;

namespace StigespilletJS
{
    public class Program
    {
        static void Main(string[] args)
        {
            Model model = new Model();
            model.initModel();

            var a1 = model.isLadderStartUp;
            var a2 = model.isLadderEndUp;
            var a3 = model.isLadderStartDown;
            var a4 = model.isLadderEndDown;
    }
    }
}
