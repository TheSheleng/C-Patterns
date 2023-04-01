using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    internal class Dispatcher
    {
        List<Airplane> LandingStrips = new List<Airplane>();
        List<Helicopter> LandingPads = new List<Helicopter>();
        public void PrintGarage()
        {
            Console.WriteLine($"LandingStrips: {LandingStrips.Count}");
            Console.WriteLine($"LandingPads: {LandingPads.Count}");
            Console.WriteLine();
        }
        public void Notify(Airplane sender, string msg)
        {
            if (msg == "Запрашиваю разрешение на посадку")
            {
                if (LandingStrips.Contains(sender)) 
                    sender.Notify(this, "Отказанно. Вы уже на полоссе.");
                else sender.Notify(this, "Разрешаю посадку.");
            }
            else if (msg == "Запрашиваю разрешение на взлёт")
            {
                if (!LandingStrips.Contains(sender))
                    sender.Notify(this, "Отказанно. Вас нет на полосе.");
                else sender.Notify(this, "Разрешаю взлёт.");
            }
            else if (msg == "Начанаю посадку.")
            {
                LandingStrips.Add(sender);
                sender.Notify(this, "Посадка прошла успешка.");
            }
            else if (msg == "Начинаю взлёт.")
            {
                LandingStrips.Remove(sender);
                sender.Notify(this, "Взлёт прошёл успешно.");
            }
        }

        public void Notify(Helicopter sender, string msg)
        {
            if (msg == "Запрашиваю разрешение на посадку")
            {
                if (LandingPads.Contains(sender))
                    sender.Notify(this, "Отказанно. Вы уже на полоссе.");
                else sender.Notify(this, "Разрешаю посадку.");
            }
            else if (msg == "Запрашиваю разрешение на взлёт")
            {
                if (!LandingPads.Contains(sender))
                    sender.Notify(this, "Отказанно. Вас нет на полосе.");
                else sender.Notify(this, "Разрешаю взлёт.");
            }
            else if (msg == "Начанаю посадку.")
            {
                LandingPads.Add(sender);
                sender.Notify(this, "Посадка прошла успешка.");
            }
            else if (msg == "Начинаю взлёт.")
            {
                LandingPads.Remove(sender);
                sender.Notify(this, "Взлёт прошёл успешно.");
            }
        }
    }
}
