namespace _04.BorderControl.Models
{
    public class Robot : IRobot
    {
        public Robot(string id, string model)
        {
            Id = id;
            Model = model;
        }

        public string Id { get; private set; }
        public string Model { get; private set; }
    }
}
