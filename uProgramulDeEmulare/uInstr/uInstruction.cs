using uProgramulDeEmulare.enums;

namespace uProgramulDeEmulare.uInstr
{
    public class uInstruction
    {
        public Sbus sbus;
        public Dbus dbus;
        public Alu aluOp;
        public Rbus rbus;
        public MemOp memOp;
        public Others otherOp;
        public Successor succesor;
        public uIndex index;
        public Jump jump;
        public int Tnf;
        public string? label;
    }
}
