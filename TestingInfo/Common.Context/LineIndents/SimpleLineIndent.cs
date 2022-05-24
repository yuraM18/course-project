using System;

namespace Common.Context.LineIndents
{
    public class SimpleLineIndent : LineIndent
    {
        private char fillChar = ' ';

        public SimpleLineIndent(int step, char fillChar)
        {
            this.Step = step > 0 ? step : 2;
            this.fillChar = fillChar;
        }

        public SimpleLineIndent() : this(2,' ') { }

        public string value = "";

        public override string Value
        {
            get { return value; }
        }

        public override void Increase()
        {
            value = new String(fillChar, Length += Step);
        }

        public override void Decrease()
        {
            if (Length < Step) return;
            value = new String(fillChar, Length -= Step);
        }

        public override void Clear()
        {
            Length = 0;
            value = "";
        }
    }
}
