using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elinder2C1
{
    public partial class Form1 : Form
    {
        byte byte1, byte2, byte3;
        sbyte sbyte1, sbyte2, sbyte3;
        short short1, short2, short3;
        ushort ushort1, ushort2, ushort3;
        int int1, int2, int3;
        uint uint1, uint2, uint3;
        long long1, long2, long3;
        ulong ulong1, ulong2, ulong3;
        float float1, float2, float3;
        double double1, double2, double3;
        decimal decimal1, decimal2, decimal3;

        private void divideButton_Click(object sender, EventArgs e)
        {

        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 / byte2);
                this.byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 / sbyte2);
                this.sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 / short2);
                this.short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 / ushort2);
                this.ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 / int2);
                this.int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 / uint2);
                this.uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 / long2);
                this.long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 / ulong2);
                this.ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 / float2);
                this.float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 / double2);
                this.double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 / decimal2);
                this.decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "error"; }
        }

      

        private void subtractButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 - byte2);
                this.byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 - sbyte2);
                this.sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 - short2);
                this.short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 - ushort2);
                this.ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 - int2);
                this.int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 - uint2);
                this.uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 - long2);
                this.long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 - ulong2);
                this.ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "error"; }
            try
            {
                this.float3 = checked(this.float1 - float2);
                this.float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 - double2);
                this.double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 - decimal2);
                this.decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "error"; }
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.byte3 = Convert.ToByte(this.byte1 + byte2);
                this.byte3TextBox.Text = byte3.ToString();
            }
            catch (Exception) { byte3TextBox.Text = "error"; }
            try
            {
                this.sbyte3 = Convert.ToSByte(this.sbyte1 + sbyte2);
                this.sbyte3TextBox.Text = sbyte3.ToString();
            }
            catch (Exception) { sbyte3TextBox.Text = "error"; }
            try
            {
                this.short3 = Convert.ToInt16(this.short1 + short2);
                this.short3TextBox.Text = short3.ToString();
            }
            catch (Exception) { short3TextBox.Text = "error"; }
            try
            {
                this.ushort3 = Convert.ToUInt16(this.ushort1 + ushort2);
                this.ushort3TextBox.Text = ushort3.ToString();
            }
            catch (Exception) { ushort3TextBox.Text = "error"; }
            try
            {
                this.int3 = checked(this.int1 + int2);
                this.int3TextBox.Text = int3.ToString();
            }
            catch (Exception) { int3TextBox.Text = "error"; }
            try
            {
                this.uint3 = checked(this.uint1 + uint2);
                this.uint3TextBox.Text = uint3.ToString();
            }
            catch (Exception) { uint3TextBox.Text = "error"; }
            try
            {
                this.long3 = checked(this.long1 + long2);
                this.long3TextBox.Text = long3.ToString();
            }
            catch (Exception) { long3TextBox.Text = "error"; }
            try
            {
                this.ulong3 = checked(this.ulong1 +ulong2);
                this.ulong3TextBox.Text = ulong3.ToString();
            }
            catch (Exception) { ulong3TextBox.Text = "error"; }
                        try
            {
                this.float3 = checked(this.float1 + float2);
                this.float3TextBox.Text = float3.ToString();
            }
            catch (Exception) { float3TextBox.Text = "error"; }
            try
            {
                this.double3 = checked(this.double1 + double2);
                this.double3TextBox.Text = double3.ToString();
            }
            catch (Exception) { double3TextBox.Text = "error"; }
            try
            {
                this.decimal3 = checked(this.decimal1 + decimal2);
                this.decimal3TextBox.Text = decimal3.ToString();
            }
            catch (Exception) { decimal3TextBox.Text = "error"; }

        }



        private void imput2TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(imput2TextBox.Text);
                byte2TextBox.Text = byte2.ToString();
            }
            catch (Exception) { byte2TextBox.Text = "error"; }
            try
            {
                sbyte2 = Convert.ToSByte(imput2TextBox.Text);
                sbyte2TextBox.Text = sbyte2.ToString();
            }
            catch (Exception) { sbyte2TextBox.Text = "error"; }
            try
            {
                short2 = Convert.ToInt16(imput2TextBox);
                short2TextBox.Text = short2.ToString();
            }
            catch (Exception) { short2TextBox.Text = "error"; }
            try
            {
                ushort2 = Convert.ToUInt16(imput2TextBox.Text);
                ushort2TextBox.Text = ushort2.ToString();
            }
            catch (Exception) { ushort2TextBox.Text = "error"; }
            try
            {
                int2 = Convert.ToInt32(imput2TextBox.Text);
                int2TextBox.Text = int2.ToString();
            }
            catch (Exception) { int2TextBox.Text = "error"; }
            try
            {
                uint2 = Convert.ToUInt32(imput2TextBox.Text);
                uint2TextBox.Text = uint2.ToString();
            }
            catch (Exception) { uint2TextBox.Text = "error"; }
            try
            {
                long2 = Convert.ToInt64(imput2TextBox.Text);
                long2TextBox.Text = long2.ToString();
            }
            catch (Exception) { long2TextBox.Text = "error"; }
            try
            {
                ulong2 = Convert.ToUInt64(imput2TextBox.Text);
                ulong2TextBox.Text = ulong2.ToString();
            }
            catch (Exception) { ulong2TextBox.Text = "error"; }
            try
            {
                float2 = Convert.ToSingle(imput2TextBox.Text);
                float2TextBox.Text = float2.ToString();
            }
            catch (Exception) { float2TextBox.Text = "error"; }
            try
            {
                double2 = Convert.ToDouble(imput2TextBox.Text);
                double2TextBox.Text = double2.ToString();
            }
            catch (Exception) { double2TextBox.Text = "error"; }
            try
            {
                decimal2 = Convert.ToDecimal(imput2TextBox.Text);
                decimal2TextBox.Text = decimal2.ToString();
            }
            catch (Exception) { decimal2TextBox.Text = "error"; }
        }

 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void setMinButton_Click(object sender, EventArgs e)
        {
            byte1 = Byte.MinValue; 
            byte1TextBox.Text = byte1.ToString();
            sbyte1 = SByte.MinValue; 
            sbyte1TextBox.Text = sbyte1.ToString();
            short1 = Int16.MinValue;
            short1TextBox.Text = short1.ToString();
            ushort1 = UInt16.MinValue;
            ushort1TextBox.Text = ushort1.ToString();
            int1 = Int32.MinValue;
            int1TextBox.Text = int1.ToString();
            ulong1 = UInt64.MinValue;
            ulong1TextBox.Text = ulong1.ToString();
            float1 = Single.MinValue;
            long1 = Int64.MinValue;
            long1TextBox.Text = long1.ToString();
            float1TextBox.Text = float1.ToString();
            double1 = Double.MinValue;
            double1TextBox.Text = double1.ToString();
            decimal1 = Decimal.MinValue;
            decimal1TextBox.Text = decimal1.ToString();

        }

        private void setMaxButton_Click(object sender, EventArgs e)
        {
            byte2 = Byte.MaxValue;
            byte2TextBox.Text = byte2.ToString();
            sbyte2 = SByte.MaxValue;
            sbyte2TextBox.Text = sbyte2.ToString();
            short2 = Int16.MaxValue;
            short2TextBox.Text = short2.ToString();
            ushort2 = UInt16.MaxValue;
            ushort2TextBox.Text = ushort2.ToString();
            int2 = Int32.MaxValue;
            int2TextBox.Text = int2.ToString();
            ulong2 = UInt64.MaxValue;
            ulong2TextBox.Text = ulong2.ToString();
            float2 = Single.MaxValue;
            long2 = Int64.MaxValue;
            long2TextBox.Text = long2.ToString();
            float2TextBox.Text = float2.ToString();
            double2 = Double.MaxValue;
            double2TextBox.Text = double2.ToString();
            decimal2 = Decimal.MaxValue;
            decimal2TextBox.Text = decimal2.ToString();
        }

        private void imput1TextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte1 = Convert.ToByte(imput1TextBox.Text);
                byte1TextBox.Text = byte1.ToString();
            }
            catch (Exception) { byte1TextBox.Text = "error"; byte1 = 0; }
            try
            {
                sbyte1 = Convert.ToSByte(imput1TextBox.Text);
                sbyte1TextBox.Text = sbyte1.ToString();
            }
            catch (Exception) { sbyte1TextBox.Text = "error"; sbyte1 = 0; }
            try
            {
                short1 = Convert.ToInt16(imput1TextBox);
                short1TextBox.Text = short1.ToString();
            }
            catch (Exception) { short1TextBox.Text = "error"; short1 = 0; }
            try
            {
                ushort1 = Convert.ToUInt16(imput1TextBox.Text);
                ushort1TextBox.Text = ushort1.ToString();
            }
            catch (Exception) { ushort1TextBox.Text = "error"; ushort1 = 0; }
            try
            {
                int1 = Convert.ToInt32(imput1TextBox.Text);
                int1TextBox.Text = int1.ToString();
            }
            catch (Exception) { int1TextBox.Text = "error"; int1 = 0; }
            try
            {
                uint1 = Convert.ToUInt32(imput1TextBox.Text);
                uint1TextBox.Text = uint1.ToString();
            }
            catch (Exception) { uint1TextBox.Text = "error"; uint1 = 0; }
            try
            {
                long1 = Convert.ToInt64(imput1TextBox.Text);
                long1TextBox.Text = long1.ToString();
            }
            catch (Exception) { long1TextBox.Text = "error"; long1 = 0; }
            try
            {
                ulong1 = Convert.ToUInt64(imput1TextBox.Text);
                ulong1TextBox.Text = ulong1.ToString();
            }
            catch (Exception) { ulong1TextBox.Text = "error"; ulong1 = 0; }
            try
            {
                float1 = Convert.ToSingle(imput1TextBox.Text);
                 float1TextBox.Text = float1.ToString();
            }
            catch (Exception) { float1TextBox.Text = "error"; float1 = 0.0f; }
            try
            {
                double1 = Convert.ToDouble(imput1TextBox.Text);
                double1TextBox.Text = double1.ToString();
            }
            catch (Exception) { double1TextBox.Text = "error"; double1 = 0.0; }
            try
            {
                decimal1 = Convert.ToDecimal(imput1TextBox.Text);
                decimal1TextBox.Text = decimal1.ToString();
            }
            catch (Exception) { decimal1TextBox.Text = "error"; decimal1 = 0m;  }
        }
    }
}
