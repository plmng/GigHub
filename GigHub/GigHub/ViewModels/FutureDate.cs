namespace GigHub.ViewModels
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Globalization;

    public class FutureDate : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime datetime;
            bool isValid = DateTime.TryParseExact(Convert.ToString(value), "dd-MM-yyyy", CultureInfo.CurrentCulture, DateTimeStyles.None, out datetime);
            return (isValid && datetime > DateTime.Now);
        }
    }
}