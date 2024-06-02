using uProgramulDeEmulare.enums;
using uProgramulDeEmulare.uInstr;

namespace uProgramulDeEmulare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // Initialize Mpm instructions array
            Mpm.uInstrs = new uInstruction[]
            {
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.IFCH, otherOp = Others.PLUS2PC, succesor = Successor.IFACLOW, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="IFC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFCIL, index = uIndex.Index1, Tnf = 1, jump = Jump.A },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.A1BE1, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.INT, label="ILLEGAL" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.A1BE0, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.INT, label="PWFAIL" },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.INTAMIN2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="INT" },
                new uInstruction { sbus = Sbus.PdFLAG, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.WR, otherOp = Others.MIN2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdIVR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.A0BEA0BI, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index2, Tnf = 0, jump = Jump.FOSAD, label="A" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.FODADB, label="B" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index6, Tnf = 0, jump = Jump.BEQ, label="C" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index6, Tnf = 0, jump = Jump.CLC, label="D" },
                new uInstruction { sbus = Sbus.PdRG, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.FODADA, label="FOSAD" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.FOSEND, label="FOSAM" },
                new uInstruction { sbus = Sbus.PdRG, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.FOSEND, label="FOSAI" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="FOSAX" },
                new uInstruction { sbus = Sbus.PdRG, dbus = Dbus.PdMDR, aluOp = Alu.ADD, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.FODADA, label="FOSEND" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index4, Tnf = 0, jump = Jump.MOV, label="FODADA" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.ILLEGAL, label="FODAMA" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index4, Tnf = 0, jump = Jump.MOV, label="FODAIA" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdPC, aluOp = Alu.DBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="FODAXA" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdRG, aluOp = Alu.ADD, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index4, Tnf = 0, jump = Jump.MOV },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index5, Tnf = 0, jump = Jump.CLR, label="FOADB" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.ILLEGAL, label="FODAMB" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index4, Tnf = 0, jump = Jump.MOV, label="FODAIB" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdPC, aluOp = Alu.DBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="FODAXB" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdRG, aluOp = Alu.ADD, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index5, Tnf = 0, jump = Jump.CLR },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="MOV" },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="ADD" },
                new uInstruction { sbus = Sbus.PdTN, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.CinPdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="SUB" },
                new uInstruction { sbus = Sbus.PdTN, dbus = Dbus.PdMDR, aluOp = Alu.ADD, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.CinPdCONDa, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="CMP" },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.PdMDR, aluOp = Alu.AND, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="AND" },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.PdMDR, aluOp = Alu.OR, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="OR" },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.PdMDR, aluOp = Alu.XOR, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="XOR" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.Pd0, aluOp = Alu.DBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="CLR" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDRN, aluOp = Alu.DBUS, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.NONE, label="NEG" },
                new uInstruction { sbus = Sbus.Pd0, dbus = Dbus.PdMDR, aluOp = Alu.ADD, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="INC" },
                new uInstruction { sbus = Sbus.PdMinus1, dbus = Dbus.PdMDR, aluOp = Alu.ADD, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="DEC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.ASL, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="ASL" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.ASR, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDa, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="ASR" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.LSR, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="LSR" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.ROL, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="ROL" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.ROR, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="ROR" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.RLC, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="RLC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdMDR, aluOp = Alu.RRC, rbus = Rbus.PmMDR, memOp = MemOp.NONE, otherOp = Others.PdCONDl, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD, label="RRC" },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.WR, otherOp = Others.MIN2SP, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="PUSH" },
                new uInstruction { sbus = Sbus.PdADR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="POP" },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.WRD },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmRG, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="WRD" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.ILLEGAL },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFZ, index = uIndex.Index3, Tnf = 0, jump = Jump.JMPAD, label="BEQ" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFZ, index = uIndex.Index3, Tnf = 1, jump = Jump.JMPAD, label="BNE" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFS, index = uIndex.Index3, Tnf = 0, jump = Jump.JMPAD, label="BMI" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFS, index = uIndex.Index3, Tnf = 1, jump = Jump.JMPAD, label="BPL" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFC, index = uIndex.Index3, Tnf = 0, jump = Jump.JMPAD, label="BCS" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFC, index = uIndex.Index3, Tnf = 1, jump = Jump.JMPAD, label="BCC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFV, index = uIndex.Index3, Tnf = 0, jump = Jump.JMPAD, label="BVS" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.IFV, index = uIndex.Index3, Tnf = 1, jump = Jump.JMPAD, label="BVC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.JMPAD, label="JMP" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index3, Tnf = 0, jump = Jump.CALLAD, label="CALL" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.ILLEGAL, label="CALLAD" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.CALL2, label = "CALLAM" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.CALL3, label="CALLAI" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="CALLAX" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdRG, aluOp = Alu.ADD, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.CALL3 },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdPC, aluOp = Alu.ADD, rbus = Rbus.PmT, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="CALL2" },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.MIN2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="CALL3" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdT, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.ILLEGAL, label="JMPAD" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.JMPAM2, label="JMAPAM" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.PdRG, aluOp = Alu.DBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="JMPAI" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.PLUS2PC, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="JMPAX" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdRG, aluOp = Alu.ADD, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.PdPC, aluOp = Alu.ADD, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="JMPAM2"},
                new uInstruction { sbus = Sbus.PdFLAG, dbus = Dbus.PdIR, aluOp = Alu.AND, rbus = Rbus.PmFLAG, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label = "CLC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdFLAG, dbus = Dbus.PdIR, aluOp = Alu.OR, rbus = Rbus.PmFLAG, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.NONE, label="SEC" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="NOP" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.A0BPO, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label = "HALT" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.A1BVI, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC, label="EI" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.A0BVI, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.IFC, label="DI" },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.MIN2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="PUSH PC" },
                new uInstruction { sbus = Sbus.PdPC, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label = "POP PC" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.JUMPI, index = uIndex.Index0, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.NONE, otherOp = Others.MIN2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="PUSH FLAG" },
                new uInstruction { sbus = Sbus.PdFLAG, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmMDR, memOp = MemOp.WR, otherOp = Others.NONE, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="POP FLAG" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmFLAG, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.NONE, dbus = Dbus.NONE, aluOp = Alu.NONE, rbus = Rbus.NONE, memOp = MemOp.NONE, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label = "RET" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE, label="IRET" },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmPC, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdSP, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmADR, memOp = MemOp.RD, otherOp = Others.NONE, succesor = Successor.STEP, index = uIndex.Index0, Tnf = 0, jump = Jump.NONE },
                new uInstruction { sbus = Sbus.PdMDR, dbus = Dbus.NONE, aluOp = Alu.SBUS, rbus = Rbus.PmFLAG, memOp = MemOp.NONE, otherOp = Others.PLUS2SP, succesor = Successor.JUMPI, index = uIndex.Index7, Tnf = 0, jump = Jump.IFC },
            };

            InitializeComponent();

            var index = 0;
            foreach (var instruction in Mpm.uInstrs)
            {
                mpm_view.Rows.Add(index.ToString("X"), instruction.label, instruction.sbus, instruction.dbus, instruction.aluOp, instruction.rbus, instruction.memOp, instruction.otherOp, instruction.succesor, instruction.index, instruction.Tnf, instruction.jump);
                var sbus = (UInt64)instruction.sbus << 32;
                var dbus = (UInt64)instruction.dbus << 28;
                var aluOp = (UInt64)instruction.aluOp << 24;
                var rbus = (UInt64)instruction.rbus << 20;
                var memOp = (UInt64)instruction.memOp << 18;
                var otherOp = (UInt64)instruction.otherOp << 14;
                var succesor = (UInt64)instruction.succesor << 11;
                var iindex = (UInt64)instruction.index << 8;
                var Tnf = (UInt64)instruction.Tnf << 7;

                Mpm.mpm[index++] = sbus + dbus + aluOp + rbus + memOp + otherOp + succesor + iindex + Tnf + (UInt64)instruction.jump;
            }
        }
    }
}