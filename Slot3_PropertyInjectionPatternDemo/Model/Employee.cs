namespace Slot3_PropertyInjectionPatternDemo.Model
{
    public class Employee
    {
        public int EmployeeId;
        public string EmployeeName;
        private IDepartment _employeeDept;
        public Employee(int id, string name)
        {
            EmployeeId = id;
            EmployeeName = name;
        }
        public IDepartment EmployeeDept
        {
            get
            {
                if(this._employeeDept == null)
                {
                    this._employeeDept = new Engineering();
                }
                return this._employeeDept;
            }
            set
            {
                if(value == null)
                {
                    throw new System.ArgumentNullException("Null");
                }
                if(this._employeeDept != null)
                {
                    throw new InvalidOperationException();
                }
                this._employeeDept = value;
            }
        }
        public override string ToString()
        {
            return $"EmpID: {EmployeeId},Emp Name: {EmployeeName}, Department: {_employeeDept.DeptName}";
        }
    }
}
