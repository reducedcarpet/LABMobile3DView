
using net.firestaff.mcp.baselab.shapes.util;

namespace net.firestaff.mcp.baselab.patterns
{
    public class Pattern
    {

        string leftText;
        string rightText;
        string L2Text;
        string R2Text;
        ShapeConstants left;
        ShapeConstants right;

        double period;

        int objectNumber = 2;

        string name;

        public Pattern()
        { }

        public Pattern(string left, string right, string name)
        {
            leftText = left;
            rightText = right;
            this.name = name;
            objectNumber = 2;
        }

        public Pattern(string left, string right, string L2, bool isRight, string name)
        {
            leftText = left;
            rightText = right;
            if (isRight) R2Text = L2;
            else L2Text = L2;
            this.name = name;
            objectNumber = 3;
        }

        public Pattern(string left, string right, string L2, string R2, string name)
        {
            leftText = left;
            rightText = right;
            L2Text = L2;
            R2Text = R2;
            this.name = name;
            objectNumber = 4;
        }

        public Pattern(string text)
        {

            int rightstart = text.IndexOf("r.s.pat:"); // 8 long
            int leftstart = text.IndexOf("l.s.pat:"); // 8 long
            int L2start = -1;
            int R2start = -1;
            if (text.Contains("l2.s.pat:"))
            {
                L2start = text.IndexOf("l2.s.pat:"); // 9 long
            }
            if (text.Contains("r2.s.pat:"))
            {
                R2start = text.IndexOf("r2.s.pat:"); // 9 long
            }
            int end = text.Length;

            string right = text.Substring(rightstart + 8, leftstart);
            string left = text.Substring(leftstart + 8, end);
            if (left.Contains("l2.s.pat:")) left = left.Substring(0, left.IndexOf("l2.s.pat:"));
            if (left.Contains("r2.s.pat:")) left = left.Substring(0, left.IndexOf("r2.s.pat:"));

            string R2 = "";
            string L2 = "";
            if (R2start > 0)
            {
                R2 = text.Substring(R2start + 9, end);
                if (R2.Contains("l2.s.pat:")) R2 = R2.Substring(0, R2.IndexOf("l2.s.pat:"));
            }
            if (L2start > 0)
            {
                L2 = text.Substring(L2start + 9, end);
            }


            leftText = left;
            rightText = right;
            objectNumber = 2;
            if (R2start > 0) { R2Text = R2; objectNumber++; }
            if (L2start > 0) { L2Text = L2; objectNumber++; }
            this.name = "loaded pattern";

        }

        public string toString()
        {
            return name;
        }

        public double getPeriod()
        {
            return period;
        }

        public void setPeriod(double period)
        {
            this.period = period;
        }

        public string getName()
        {
            return name;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getLeftText()
        {
            return leftText;
        }

        public string getRightText()
        {
            return rightText;
        }

        public string getR2Text()
        {
            return R2Text;
        }

        public string getL2Text()
        {
            return L2Text;
        }

        public int getPropNumber()
        {
            return objectNumber;
        }
    }
}