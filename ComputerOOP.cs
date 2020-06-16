namespace ConsoleApp4
{
   [DebuggerDisplay("Class Computer model = {model} price in dollars = {(price * 3.67)}")]
    class Computer
    {
        public string model;
        public int price;
        public int numberOfProcessors;
        public float screenSize;
        public bool isTurnOn = false;

        public int TellMeThePrice()
        {
            return price;
        }
        public float TellMeTheScreenSize()
        {
            return screenSize;
        }
        public void TurnOn()
        {
            Console.WriteLine($"{model} is turning on");
        }
        public void TurnOff()
        {
            Console.WriteLine($"{model} is turning off");
        }
        public void AddProcessor()
        {
            Console.WriteLine($"Processor was added to {model}");
        }

        public override string ToString()
        {
            return $"Class Computer model = {model} number of processors = {numberOfProcessors} screen size = {screenSize}";
        }
    }
}
namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer myLenovo = new Computer();
            {
                myLenovo.model = "ThinkPad";
                myLenovo.price = 2500;
                myLenovo.numberOfProcessors = 2;
                myLenovo.screenSize = 14.5f;
                myLenovo.TellMeThePrice();
                myLenovo.TellMeTheScreenSize();
                myLenovo.TurnOn();
                myLenovo.TurnOff();
                myLenovo.AddProcessor();
                
            }
            

            Computer myAsus = new Computer();
            {
                myAsus.model = "ZenBook";
                myAsus.price = 4750;
                myAsus.numberOfProcessors = 4;
                myAsus.screenSize = 14.2f;
                Console.WriteLine(myAsus);
                Console.WriteLine(myAsus.TellMeThePrice());
                myAsus.TellMeTheScreenSize();
                myAsus.TurnOn();
                myAsus.TurnOff();
                myAsus.AddProcessor();
            }
            

            Computer myHp = new Computer();
            {
                myHp.model = "EliteBook";
                myHp.price = 3800;
                myHp.numberOfProcessors = 8;
                myHp.screenSize = 14.6f;
                myHp.TellMeThePrice();
                myHp.TellMeTheScreenSize();
                myHp.TurnOn();
                myHp.TurnOff();
                myHp.AddProcessor();
            }
            Console.WriteLine(myHp);
        }
    }
}
