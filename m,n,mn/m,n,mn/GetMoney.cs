using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace m_n_mn
{
    class GetMoney
    {
        public static void salary()
        {
            //برای شکل خونه
            Console.WriteLine("Please Enter ShapeRoom:(Squre=1 , Tranangle=2 , Rectangle=3)");
            string Room = Console.ReadLine();
            double priceShapes = Convert.ToDouble(Room);


            if (Room == "1")
            {
                priceShapes = 100;
            }

            if (Room == "2")
            {
                priceShapes = 200;
            }

            if (Room == "3")
            {
                priceShapes = 300;
            }



            IMultiple multiple;

            //برای هر متر
            Console.WriteLine("PLease Enter Meters Of Home:)");
            string meter = Console.ReadLine();
            int meters = int.Parse(meter);

            multiple = new Multiple();


            if (Room == "1")
            {
                int metrs = 10;
                int m1= multiple.Multiple(meters ,metrs);
                Room = Convert.ToString(m1);
            }
            if (Room == "2")
            {
                int metrs = 20;
                int m2 = multiple.Multiple(meters, metrs);
                Room = Convert.ToString(m2);
            }
            if (Room == "3")
            {
                int metrs = 30;
               int m3 = multiple.Multiple(meters, metrs);
                Room = Convert.ToString(m3);
            }



            //برای جنس رنگ
            Console.WriteLine("Please Enter Gender Of Color:(Matt=1 , Gloosy=2)");
            string colorGender = Console.ReadLine();
            double priceGender = Convert.ToDouble(colorGender);


            if (colorGender == "1")
            {
                priceGender = 100;
            }
            if (colorGender == "2")
            {
                priceGender = 500;
            }



            int room = Convert.ToInt32(priceShapes);
            int metr = Convert.ToInt32(Room);
            int gender = Convert.ToInt32(priceGender);



            int plus = room + gender + metr;
            Console.WriteLine("Sum Is :" + plus);

        }
    }

  public interface IMultiple
        {
        int Multiple(int number1, int number2);
        }
    public class Multiple : IMultiple
    {
        int IMultiple.Multiple(int number1, int number2)
        {
            return number1 * number2;
        }
    }
}
