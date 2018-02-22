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
        /// <param name="this">This.</param>
        /// <returns>
        ///   <c>true</c> if the specified this is yesterday; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsYesterday(this DateTime @this)
        {
            return @this.Date == DateTime.Today.AddDays(-1);
        }

        /// <summary>
        /// Yesterdays the specified instance.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static DateTime Yesterday(this DateTime @this)
        {
            return @this.AddDays(-1);
        }

        /// <summary>
        /// Determines whether this instance is today.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns>
        ///   <c>true</c> if the specified this is today; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsToday(this DateTime @this)
        {
            return @this.Date == DateTime.Today;
        }

        /// <summary>
        /// Determines whether this instance is tomorrow.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns>
        ///   <c>true</c> if the specified this is tomorrow; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsTomorrow(this DateTime @this)
        {
            return @this.Date == DateTime.Today.AddDays(1);
        }

        /// <summary>
        /// Tomorrows the specified instance.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static DateTime Tomorrow(this DateTime @this)
        {
            return  DateTime.Today.AddDays(1);
        }

        /// <summary>
        /// Determines whether [is week day].
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns>
        ///   <c>true</c> if [is week day] [the specified instance]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWeekDay(this DateTime @this)
        {
            return !(@this.DayOfWeek == DayOfWeek.Saturday || 
                     @this.DayOfWeek == DayOfWeek.Sunday);
        }

        /// <summary>
        /// Determines whether [is weekend day].
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns>
        ///   <c>true</c> if [is weekend day] [the specified instance]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsWeekendDay(this DateTime @this)
        {
            return @this.DayOfWeek == DayOfWeek.Saturday || 
                   @this.DayOfWeek == DayOfWeek.Sunday;
        }

        /// <summary>
        /// Determines whether [is time equal] [the specified time to compare].
        /// </summary>
        /// <param name="this">This.</param>
        /// <param name="timeToCompare">The time to compare.</param>
        /// <returns>
        ///   <c>true</c> if [is time equal] [the specified time to compare]; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsTimeEqual(
            this DateTime @this, 
            DateTime timeToCompare)
        {
            return @this.TimeOfDay == timeToCompare.TimeOfDay;
        }

        /// <summary>
        /// Starts the of year.
        /// </summary>
        /// <param name="this">This.</param>
        /// <returns></returns>
        public static DateTime StartOfYear(this DateTime @this)
        {
            return new DateTime(@this.Year, 1, 1);
        }
    }
}
