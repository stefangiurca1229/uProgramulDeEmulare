namespace uProgramulDeEmulare.models
{
    public class MicroInstruction
    {
        public int ControlSignals { get; set; }
        public int NextAddress { get; set; }
        public int ImmediateValue { get; set; }

        public MicroInstruction(int controlSignals, int nextAddress, int immediateValue = 0)
        {
            ControlSignals = controlSignals;
            NextAddress = nextAddress;
            ImmediateValue = immediateValue;
        }
    }
}
