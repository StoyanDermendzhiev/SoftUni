using System.Linq;
using System.Reflection;
using ValidationAttributes.Attributes;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] proprties = obj.GetType().GetProperties();

            foreach (var property in proprties)
            {
                MyValidationAttribute[] attributes = property.GetCustomAttributes()
                    .Cast<MyValidationAttribute>()
                    .ToArray();

                var value = property.GetValue(obj);

                foreach (var attribute in attributes)
                {
                    bool isValid = attribute.IsValid(value);

                    if (!isValid)
                    {
                        return false;
                    }
                }
            }
            
            return true;
        }
    }
}
