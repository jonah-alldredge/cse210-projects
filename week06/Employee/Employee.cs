namespace employee_Demo
{
        
    public abstract class Employee
    {
        private string _name;
        private string _idNumber;
        public string SetName()
        {
            return _name;
        }
        public string SetIdNumber()
        {
            return _idNumber;
        }
        public void GetName(string name)
        {
            _name = name;
        }
        public void GetIdNumber(string idNumber)
        {
            _idNumber = idNumber;
        }
        public virtual float GetPay() //Virtual tell C# that I am going to override it
        {
            return -1;
        }
        public abstract float GetPay();
    }
}