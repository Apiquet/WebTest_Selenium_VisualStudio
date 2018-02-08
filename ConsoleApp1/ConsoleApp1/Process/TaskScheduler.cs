using Microsoft.Win32.TaskScheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebTests
{
    public class TaskScheduler
    {
        public void ScheduleTask(string heure, string minute)
        {
            using (TaskService RegisterTask = new TaskService())
            {
                // Create a new task
                TaskDefinition td = RegisterTask.NewTask();
                td.RegistrationInfo.Description = "Fiddler runner";

                // Create a trigger
                td.Triggers.Add(new TimeTrigger
                {
                    StartBoundary =
                        Convert.ToDateTime(DateTime.Today.Date.ToString("MM/dd/yyyy") + " " + heure + ":" + minute + ":00 AM")
                });

                // Create an action that will launch Fiddler in quiet mode
                td.Actions.Add(new ExecAction("C:/Users/AppData/Local/Programs/Fiddler/Fiddler.exe",
                    "/quiet", null));

                // Register the task in the root folder
                RegisterTask.RootFolder.RegisterTaskDefinition(@"CScheduler\FiddlerRunner", td);
            }
        }
    }
}
