namespace Scorchio.ExtensionMethods
{
    using System;

    /// <summary>
    /// DateTime Extensions
    /// </summary>
    public static class DateTimeExtensions
    {
        /// <summary>
        /// Determines whether this instance is yesterday.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public static bool IsYesterday(this DateTime instance)
        {
            return instance.Date == DateTime.Today.AddDays(-1);
        }

        /// <summary>
        /// Yesterdays the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static DateTime Yesterday(this DateTime instance)
        {
            return instance.AddDays(-1);
        }

        /// <summary>
        /// Determines whether this instance is today.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public static bool IsToday(this DateTime instance)
        {
            return instance.Date == DateTime.Today;
        }

        /// <summary>
        /// Determines whether this instance is tomorrow.
        /// </summary>
        /// <param name="instance">The instance.</param>
        public static bool IsTomorrow(this DateTime instance)
        {
            return instance.Date == DateTime.Today.AddDays(1);
        }

        /// <summary>
        /// Tomorrows the specified instance.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static DateTime Tomorrow(this DateTime instance)
        {
            return  DateTime.Today.AddDays(1);
        }

        /// <summary>
        /// Determines whether [is week day].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if [is week day] [the specified instance]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWeekDay(this DateTime instance)
        {
            return !(instance.DayOfWeek == DayOfWeek.Saturday || 
                     instance.DayOfWeek == DayOfWeek.Sunday);
        }

        /// <summary>
        /// Determines whether [is weekend day].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns>
        ///   <c>true</c> if [is weekend day] [the specified instance]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWeekendDay(this DateTime instance)
        {
            return instance.DayOfWeek == DayOfWeek.Saturday || 
                   instance.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Determines whether [is time equal] [the specified time to compare].
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <param name="timeToCompare">The time to compare.</param>
        /// <returns>
        ///   <c>true</c> if [is time equal] [the specified time to compare]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsTimeEqual(
            this DateTime instance, 
            DateTime timeToCompare)
        {
            return (instance.TimeOfDay == timeToCompare.TimeOfDay);
        }

        /// <summary>
        /// Starts the of year.
        /// </summary>
        /// <param name="instance">The instance.</param>
        /// <returns></returns>
        public static DateTime StartOfYear(this DateTime instance)
        {
            return new DateTime(instance.Year, 1, 1);
        }
    }
}
