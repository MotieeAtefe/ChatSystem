namespace ChatSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomTaskAssignManager customTaskAssignManager = new CustomTaskAssignManager();
            customTaskAssignManager.AssignTask("Complete project report");

        }
    }
}