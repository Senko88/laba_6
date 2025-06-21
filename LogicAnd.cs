using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace laba_6
{
    public class LogicAnd
    {
        
        private bool free;         
        private bool stair;        
        private bool logic_and;    


      

        public LogicAnd()
        {
            logic_and = false; 
        }


    
        public LogicAnd(bool free, bool stair)
        {
            this.free = free;
            this.stair = stair;

        }


        
        public LogicAnd(LogicAnd a1)
        {
            this.free = a1.free;
            this.stair = a1.stair;

        }


        /// Проверка возможности найма сотрудников
        public bool CanHireEmployees(bool free, bool stair)
        {
         
            bool canHire = free && stair;

       
            Console.WriteLine(canHire ?
                "Вы можете нанимать сотрудников!" :
                "Вам нельзя нанимать сотрудников!");

            return canHire;
        }
        //метод проверки наличия роста по карьерной лестнице
        public bool CanGrowStairs(bool free, bool stair)
        {
         
            bool canHire = free && (stair=false);

         
            Console.WriteLine(canHire ?
                "У вас не доступен рост по карьерной лестнице!" :
                "Вам доступен рост по карьерной лестнице");

            return canHire;
        }
        //метод проверки наличия свободных мест
        public bool CanGetFree(bool free, bool stair)
        {
       
            bool canHire = (free=false) && stair;

         
            Console.WriteLine(canHire ?
                "У вас нет свободных мест!" :
                "У вас есть свободные места");

            return canHire;
        }
        /// Переопределение метода для строкового представления объекта
        public override string ToString()
        {
            return $"Состояние: Free={free}, Stair={stair}";
        }
    }
}
