using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Assignment_Ds_03_Nov
{
    internal class TaskTtem
    {
        public List<TaskTtem> list = new List<TaskTtem>();

        public int TaskId { get; set; }
        public string? TaskDescriptio { get; set; }
        public bool? IsCompleted { get; set; }


        public void AddDetails(TaskTtem taskItem)
        {
            list.Add(taskItem);


        }
        public void RemoveTask(int id)
        {
            list.RemoveAll(x => x.TaskId == id);
        }
        public void ChangeStatus(int id)
        {
            var n = list.Find(x => x.TaskId == id);
            Console.WriteLine("Change the status is completed then true else false");
            n.IsCompleted = Convert.ToBoolean(n.IsCompleted);
        }
        public void Display()
        {
            foreach (var task in list)
            {
                Console.WriteLine("Task Id = {0} Task Description = {1} Task Is Completed = {2}");
            }
        }
    }
}
