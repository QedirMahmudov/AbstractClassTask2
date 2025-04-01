namespace AbstractClass2.Models
{
    internal abstract class Vehicle
    {
        private string _factoryName;
        private string _model;
        private string _color;
        private int _driveTime;
        private int _drivePath;

        public string FactoryName
        {
            get
            {
                return _factoryName;
            }
            set
            {
                value = value.Trim();
                _factoryName = value;

                if (value.Length >= 3)
                {
                    Console.WriteLine($"Factory adi:{_factoryName}");
                }
                else
                {
                    Console.WriteLine("Factory adi 3 herfden qisa ola bilmez!");
                }

            }
        }
        public string Model
        {
            get
            {
                return _model;
            }
            set
            {
                value = value.Trim();
                _model = value;

                if (value.Length >= 2)
                {
                    Console.WriteLine($"Model adi:{_model}");
                }
                else
                {
                    Console.WriteLine("Model adi 2 herfden qisa ola bilmez!");
                }

            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
            set
            {
                value = value.Trim();
                _color = value;

                if (value.Length >= 2)
                {
                    Console.WriteLine($"Reng adi:{_color}");
                }
                else
                {
                    Console.WriteLine("Reng adi 2 herfden qisa ola bilmez!");
                }

            }
        }


        public int DriveTime
        {
            get
            {
                return _driveTime;
            }
            set
            {
                if (value > 0)
                {
                    _driveTime = value;
                    Console.WriteLine($"DriveTime : {_driveTime}");
                }
                else
                {
                    Console.WriteLine("DriveTime menfi ola bilmez!");
                }
            }
        }

        public int DrivePath
        {
            get
            {
                return _drivePath;
            }
            set
            {
                if (value > 0)
                {
                    _drivePath = value;
                    Console.WriteLine($"DrivePath : {_drivePath}");
                }
                else
                {
                    Console.WriteLine("DrivePath menfi ola bilmez!");
                }
            }
        }

        public int AverageSpeed()
        {
            return _drivePath / _driveTime;
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"FactoryName: {FactoryName} ,Model: {Model}, Color: {Color}, DriveTime: {DriveTime} , DrivePath: {DrivePath}");
        }

        public override string ToString()
        {
            return $"FactoryName: {FactoryName},Model: {Model}";
        }

        public abstract void DefineNatureHarmness();

    }
}

