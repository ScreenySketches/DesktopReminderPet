using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;
using System.IO;


namespace TaskPet
{
    internal class ReminderDatabase
    {

        public List<ReminderTimer> rT = new List<ReminderTimer>();
        
        
        public ReminderDatabase()
        {
            if (File.Exists(@"C:\TaskPet_Data\Timerdb.txt"))
            {
                string json = File.ReadAllText(@"C:\TaskPet_Data\Timerdb.txt");
                rT = JsonConvert.DeserializeObject<List<ReminderTimer>>(json);
            }
        }
        
        

        public async Task NewReminderTimer(string title, string description, string seconds, string minutes, string hours)
        {
            
            if(rT == null)
            {
                rT = new List<ReminderTimer>();
            }
            

            rT.Add(new ReminderTimer()
            {
                Title = title,
                Description = description,
                Seconds = seconds,
                Minutes = minutes,
                Hours = hours
            });

            string json = JsonConvert.SerializeObject(rT.ToArray(), Formatting.Indented);
            Directory.CreateDirectory(@"C:\TaskPet_Data");
            System.IO.File.WriteAllText(@"C:\TaskPet_Data\Timerdb.txt", json);

            await Task.Delay(10);
            
        }

        //public async Task NewSpecificTimer()

    }

    //---------------------------------------------------------------------//

    public class ReminderTimer
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Hours { get; set; }
        public string Minutes { get; set; }
        public string Seconds { get; set; }
    }

    /*public class ReminderSpecific
    {
        public string
    }*/
}
