using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EkhayaMeals.Modules.Authentication.Infrastructure;
public class DateTimeProvider : Application.Common.Interfaces.IDateTimeProvider
{
    public DateTime UtcNow => DateTime.UtcNow;
}