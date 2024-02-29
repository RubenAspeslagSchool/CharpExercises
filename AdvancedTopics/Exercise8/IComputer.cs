namespace AdvancedTopics.Exercise8
{
    public interface IComputer
    {
        string Brand { get; set; }
        Color DeviceColor { get; set; }
        bool? PoweredOn { get; }

        void Deconstruct(out int id, out string brand, out Color colour);
        void ExecuteProgram(string program);
        void PowerOn();
        string ToString();
    }
}