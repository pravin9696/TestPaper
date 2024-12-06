using System.Text;

namespace TestPaper
{
    public class SUMA_Soft_Test
    {

        //Input:s = "ADOBECODEBANC", t = "ABC"
        //Output: "BANC"
        public void Q2()
        {
            string inStr = "ADOBECODEBANC"; //10
            string t = "AB";
            char[] tt = t.ToCharArray();
            string outputStr = "";
            int small = int.MaxValue;
            inStr = inStr + ' ';
            int inStrLen = inStr.Length;
           
            for (int i = 0; i < inStr.Length; i++)
            {
                 for (int k = 0; k < inStr.Length-i; k++)
                //for (int k = 0; k < inStr.Substring(i).Length; k++)
                {
                    string temp = inStr.Substring(i, k);

                    //string temp = inStr.Substring(i);
                   // Console.WriteLine("*** temp="+temp);
                    bool flag = true;
                    for (int j = 0; j < tt.Length; j++)
                    {
                        if (!temp.Contains(tt[j]))
                        {
                            flag = false;
                            break;
                        }
                    }

                    if (flag == true)
                    {
                        if (small > temp.Length)
                        {
                            small = temp.Length;
                            outputStr = temp;
                        
                            //Console.WriteLine("small =" + small+" temp len="+temp.Length+" output str=" +outputStr);
                        }
                    }
                }
           }
            if (outputStr != "")
            {
                Console.WriteLine(outputStr);
            }
        }
        public void Q4()
        {
            string str = "pune nashik nagar";
            string[] temp = str.Split(' ');

            for (int i = 0; i < temp.Length; i++)
            {
                //temp[i] = new string(temp[i].Reverse().ToArray());
                string t = new string(temp[i].Reverse().ToArray());
                temp[i] = t;

            }
            string result = string.Join(" ", temp);
            Console.WriteLine("result=" + result);

        }
        public void Q1()
        {
            int[] arr = new int[] { 2, 4, 3, -9, -5, -1 };
            int[] op = new int[arr.Length];

            int odcnt = 0;//negative value index
            int evcnt = 0; //+ve value index
            int index = 0;// output array index
            while (index < op.Length)
            {
                if (index % 2 == 0)// even place in output array for -ve numbers
                {
                    while (arr[odcnt] > 0)
                    {
                        odcnt++;
                    }
                    op[index++] = arr[odcnt++];
                }
                else  // odd places +ve number copy
                {
                    while (arr[evcnt] < 0)
                    {
                        evcnt++;
                    }
                    op[index++] = arr[evcnt++];
                }
            }

            Console.WriteLine("output array:");
            for (int i = 0; i < op.Length; i++)
            {
                Console.Write(" " + op[i]);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            SUMA_Soft_Test obj = new SUMA_Soft_Test();
            // obj.Q1();
            obj.Q2();

            String ss;


        }
    }
}
