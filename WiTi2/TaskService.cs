using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiTi2
{

    public class Task
    {
        public int time, punishment, deadline;
    };

    class TaskService
    {

        public Task[] ReadData(string filename)
        {
            string directory = System.IO.Directory.GetCurrentDirectory();
            string[] lines = System.IO.File.ReadAllLines(directory + "\\" + filename);
            int tasksCount = int.Parse(lines[0]);
            Task[] data = new Task[tasksCount];

            for (int i = 1; i < lines.Length; ++i)
            {
                if (lines[i] == "" || lines[i] == null)
                    continue;
                Task currentTask = new Task();
                string[] line = lines[i].Split(' ');
                currentTask.time = int.Parse(line[0]);
                currentTask.punishment = int.Parse(line[1]);
                currentTask.deadline = int.Parse(line[2]);
                data[i-1] = currentTask;
            }
            return data;
        }
    }
}
