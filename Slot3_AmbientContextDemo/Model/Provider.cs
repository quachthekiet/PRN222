namespace Slot3_AmbientContextDemo.Model
{
    public abstract class DepartmentProvider
    {
        private static DepartmentProvider current;
        public static DepartmentProvider Current
        {
            get
            {
                if(current == null)
                {
                    current = new DefaultDepartmentProvider();
                }
                return current;
            }
            set
            {
                current = value ?? new DefaultDepartmentProvider();
            }
        } // end Current

        public virtual Department Department { get; }
    }

    // -----------------------------
    public class DefaultDepartmentProvider : DepartmentProvider
    {
        public override Department Department => new Engineering();
    }

    // -----------------------------
    public class MarketingProvider : DepartmentProvider
    {
        public override Department Department => new Marketing();
    }

}
