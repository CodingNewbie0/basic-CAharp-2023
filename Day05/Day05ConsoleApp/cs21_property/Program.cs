using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs21_property
{
    class Boiler
    {
        public int Temp // 프로퍼티(속성)
        {
            get { return temp; }
            set { 
                if (value <= 10 ||  value >= 70)
                {
                    temp = 10; // 제일 낮은 온도로 변경설정
                }
                else
                {
                    temp = value;
                }
            }
        }

        public int temp; // 멤버변수

        // 위의 get; set;과 비교 // 아래의 Get메서드와 Set메서드는 Java에서만 사용, C#은 거의 안씀
        public void SetTemp(int temp)
        {
            if (temp <= 10 || temp > 70)
            {
                //Console.WriteLine("수온설정값이 비정상적입니다. 10~70도 사이로 지정해주세요.");
                //return;
                this.temp = 10;
            }
            else
            {
                this.temp = temp;
            }
        }

        public int GetTemp() { return this.temp;}
    }

    class Car
    {
        int year;
        string fuelType;
        //string tireType;
        //string company;
        int price;
        //string carIdNumber;
        //string carPlateNumber;

        public string Name { get; set; } // 필터링이 필요없으면 멤버변수 없이 프로퍼티로 대체
        public string Color { get; set; }

        // 들어오는 데이터를 필터링할때는 private 멤버변수와 public 프로퍼티를 둘다 사용
        public int Year {
            get { return year; } // get => year; 람다식
            set {
                if (value <= 1990 || value >= 2023)
                {
                    value = 2023;
                }
                year = value;
            }
        }
        public string FuelType { get => fuelType;
            set {
                if (value != "휘발유" || value != "경유")
                {
                    value = "휘발유";
                }
                fuelType = value;
            } 
        } 
        public int Door {
            get { return Door; }
            set { 
                if (value != 2 || value != 4)
                {
                    value = 4;
                }
                Door = value;
            }
        }
        public string TireType { get; set; }
        public string Company { get; set; } = "현대자동차";
        public int Price { get => price; set => price = value; }
        public string CarIdNumber { get; set; }
        public string CarPlateNumber { get; set; }
    }

    interface IProduct
    {
        string ProductName { get; set; }

        void Produce();
    }

    class MyProduct : IProduct
    {
        private string productName;
        public string ProductName { 
            get { return productName; }
            set { productName = value; } 
        }

        public void Produce()
        {
            Console.WriteLine("{0}을(를) 생산합니다. ", ProductName);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            //kitturami.temp = 60;

            //// ...
            //kitturami.temp = 300000; // 보일러 물수온이 30만도는 초큼... 
            //kitturami.temp = -120;
            kitturami.SetTemp(50);
            Console.WriteLine(kitturami.GetTemp()); // 예전방식

            Boiler navien = new Boiler();
            navien.Temp = 5000;
            Console.WriteLine(navien.Temp);

            Car ionic = new Car();
            ionic.Name = "아이오닉"; // get만 있으면 읽기전용이므로 멤버 변수를 설정할 수 없음
            Console.WriteLine(ionic.Name); // set만 있으면 값을 읽어들일 수가 없음.

            // 생성할 때 프로퍼티로 초기화
            Car genesis = new Car()
            {
                Name = "제네시스",
                FuelType = "휘발유",
                Color = "흰색",
                Door = 4,
                TireType = "광폭타이어",
                Year = 0,
            };

            Console.WriteLine("자동차 제조회사는 {0}", genesis.Company);
            Console.WriteLine("자동차 제조년도는 {0}년", genesis.Year);
            Console.WriteLine("자동차 이름은 {0}", genesis.Name);
            Console.WriteLine("자동차 색깔은 {0}", genesis.Color);
            Console.WriteLine("자동차 타이어 종류는 {0}", genesis.TireType);
        }
    }
}
