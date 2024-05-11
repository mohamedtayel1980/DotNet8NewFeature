using System;
using System.Threading;
using System.Threading.Tasks;

using UsingTime;

TimeOfDayService timeOfDayService = new TimeOfDayService(TimeProvider.System);

Console.WriteLine(timeOfDayService.GetTimeOfDay());