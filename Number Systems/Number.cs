using System;

namespace Number_Systems
{
    public class Number
    {
        private readonly string _value;
        private readonly byte _system;

        public Number()
        {
            _value = "0";
            _system = 10;
        }

        public Number(float value)
        {
            _value = value.ToString();
            _system = 10;
        }

        public Number(string value, byte system)
        {
            _value = value;

            _system = system switch
            {
                2 => 2,
                8 => 8,
                10 => 10,
                16 => 16,
                _ => 10,
            };
        }

        public string Value => _value;
        public byte System => _system;

        public static Number operator +(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return new Number((float)newFirst + newSecond);
        }

        public static Number operator -(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return new Number((float)newFirst - newSecond);
        }

        public static Number operator *(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return new Number((float)newFirst * newSecond);
        }

        public static Number operator /(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return new Number((float)newFirst / newSecond);
        }

        public static bool operator ==(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst == newSecond;
        }

        public static bool operator !=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst != newSecond;
        }

        public static bool operator >(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst > newSecond;
        }

        public static bool operator <(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst < newSecond;
        }

        public static bool operator >=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst >= newSecond;
        }

        public static bool operator <=(Number first, Number second)
        {
            ulong newFirst = Convert.ToUInt64(first.Value, first.System);
            ulong newSecond = Convert.ToUInt64(second.Value, second.System);
            return newFirst <= newSecond;
        }

        public string ConvertFromDecimal(byte system)
        {
            long value = long.Parse(Value);
            return Convert.ToString(value, system).ToUpper();
        }
    }
}