using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstAI
{
    public class DataCentry
    {
        public DataCentry(double personId, double personGenre, double personAge, double personAai, double personSpendingScore)
        {
            id = personId;
            genre = personGenre;
            age = personAge;
            aai = personAai;
            spendingScore = personSpendingScore;
        }
        public double id;
        public double genre; // Male = 1 // Female = 0
        public double age;
        public double aai; // средний доход
        public double spendingScore;// средняя оценка покупки для сравнения и обучения

        public string GetAll()
        {
            string str = id + " " + genre + " " + age + " " + aai + " " + spendingScore;
            return str;
        }
    }
}
