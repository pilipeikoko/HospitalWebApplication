using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hospital.Models
{
    public class SearchTypes
    {
        public static List<Type> GetTypes()
        {
            List<Type> result = new List<Type>();
            foreach (Type type in (Type[])Enum.GetValues(typeof(Type)))
            {
                result.Add(type);
            }
            return result;
        }
    }

    public enum Type
    {
        SURNAME_OR_ADDRESS,
        BIRTHDAY,
        FULL_DOCTORS_NAME_OR_RECEIPT_DATE
    }


}
