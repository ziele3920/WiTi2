
namespace WiTi2
{
    class Witi
    {
        public int WitiAlg(Task[] tasks)
        {
            BitService BS = new BitService();
            int amount = tasks.Length;
            int twoPowAmount = BS.TwoPowX(amount);
            int permutationPunishments, index, minPunishment = int.MaxValue;
            int[] punishment = new int[twoPowAmount];


            for (int step = 1; step < twoPowAmount; ++step)
            {
                minPunishment = int.MaxValue;
                for (int i = 0; i <= amount; ++i)
                    if (BS.CheckBit(step, i))
                    {
                        index = BS.ClearBit(step, i);
                        permutationPunishments = CountPunishment(tasks, index, i, amount);
                        permutationPunishments = permutationPunishments + punishment[index];
                        if (minPunishment > permutationPunishments)
                        {
                            minPunishment = permutationPunishments;
                            punishment[step] = permutationPunishments;
                        }
                    }
            }
            return minPunishment;
        }

        int CountPunishment(Task[] tasks, int index, int i, int amount)
        {
            BitService BS = new BitService();
            int punishment, time = 0;
            for (int j = 0; j < amount; ++j)
                if (BS.CheckBit(index, j))
                    time += tasks[j].time;

            punishment = (time + tasks[i].time - tasks[i].deadline) * tasks[i].punishment;
            return punishment > 0 ? punishment : 0;
        }
    }
}
