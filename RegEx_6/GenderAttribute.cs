using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace lab5
{
    public class GenderAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {
                string Gender = (string)value;
                if (Gender.Equals("Мужской") || Gender.Equals("Женский"))
                    return true;
                else
                    this.ErrorMessage = "Wrong gender!!";
            }
            return false;
        }
    }
}

