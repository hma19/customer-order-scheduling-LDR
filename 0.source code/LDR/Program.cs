using System;
using System.IO;
using System.Collections.Generic;
using System.Timers;

namespace LDR
{
    class Program
    {
        public static DoubleData features = new DoubleData();
        public static string ldr_2 = "(- (- (- (- (div (- O_MINESTSTOP O_HM) (If (max (+ (max (+ O_AVGPT O_MINJPT) (If O_WTJPT (+ O_MAXESTPS O_MINJPT) O_AVGPT)) O_AVGPT) (+ O_MAXESTPS O_MINJPT)) (div (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (* O_MINESTPS O_TCWPT)) (+ (* 1.0 PS_UNSON) (+ O_MINESTSTOP O_MAXESTPS)))) (* O_MINESTPS O_WTJPT)) (max (+ (- (+ O_MAXESTSTOP (div PS_ESTST (max (- PS_ESTST (- O_AVGPT O_MINESTSTOP)) (* 1.0 PS_UNSON)))) O_MINESTSTOP) (+ (+ (+ (max (max (- PS_ESTST O_MAXESTSTOP) (If O_WTJPT 0.0 O_AVGPT)) (+ (max (+ (max (+ O_AVGPT O_MINJPT) (If O_WTJPT (- PS_ESTST O_MAXESTSTOP) O_AVGPT)) O_AVGPT) (+ O_MAXESTPS O_MINJPT)) (div (+ O_MAXESTSTOP O_AVGPT) PS_UNSON))) (div 1.0 PS_UNSON)) (div (+ O_MAXESTSTOP O_AVGPT) (max (+ O_AVGPT O_MINJPT) (+ (+ (+ O_AVGPT (max (div (+ O_MINESTPS PS_ESTST) O_MAXESTPS) (+ O_MAXESTSTOP O_AVGPT))) O_MINJPT) O_AVGPT)))) (div (+ O_MAXESTSTOP O_AVGPT) PS_UNSON))) (+ (- (+ O_MAXESTSTOP O_AVGPT) O_MINESTSTOP) (max (+ O_MAXESTPS O_MINJPT) (+ (+ (max (+ O_AVGPT O_MINJPT) (- (+ O_MAXESTSTOP O_AVGPT) O_MINESTSTOP)) (+ (max (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON)) (- O_AVGPT O_MINESTSTOP)) (+ (max (+ (+ O_AVGPT (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON))) O_MINJPT) (- O_AVGPT O_MINESTSTOP)) O_AVGPT))) O_AVGPT))))) (max (max (div (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (- O_MINESTSTOP O_HM)) (+ (max (+ (+ (+ (+ (max (+ O_AVGPT O_MINJPT) (+ (+ (+ O_AVGPT (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON))) O_MINJPT) O_AVGPT)) O_AVGPT) (max (+ O_AVGPT O_MINJPT) (+ (+ PS_UNSON O_MINJPT) O_AVGPT))) O_AVGPT) O_AVGPT) (- O_AVGPT O_MINESTSTOP)) O_AVGPT)) (max (+ (max (+ (+ (+ (+ (max (+ (If O_WTJPT 0.0 O_AVGPT) O_AVGPT) (+ O_MAXESTPS (max (- O_MINESTSTOP O_MINESTSTOP) (- O_AVGPT O_MINESTSTOP)))) (div (+ PS_ESTST O_AVGPT) PS_UNSON)) (div 1.0 PS_UNSON)) (div (+ O_MAXESTSTOP O_AVGPT) PS_UNSON)) O_HM) O_MINESTPS) (div PS_ESTST (max (max (+ O_AVGPT O_MINJPT) (max (+ (+ O_TCWPT O_AVGPT) O_MINJPT) (- O_AVGPT O_MINESTSTOP))) (+ (+ (+ (max (- PS_ESTST O_MAXESTSTOP) (+ (+ O_MAXESTSTOP (div PS_ESTST (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON)))) (+ (max O_AVGPT (- O_AVGPT O_MINESTSTOP)) O_AVGPT))) (max (+ (max (- PS_ESTST O_MAXESTSTOP) (- O_AVGPT O_MINESTSTOP)) O_AVGPT) (- O_AVGPT O_MINESTSTOP))) (max (- PS_ESTST O_MAXESTSTOP) (- (+ O_AVGPT O_MINJPT) (div 0.0 (If O_LM O_WLC O_MAXESTPS))))) O_MINJPT)))) (+ (div (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (- O_MINESTSTOP O_HM)) O_AVGPT)))) (* (If (* (+ 0.0 O_MINESTSTOP) (- O_MINESTSTOP O_MINESTSTOP)) (If (* (+ 0.0 O_MINESTSTOP) (- O_MINESTSTOP O_MINESTSTOP)) (div (+ O_MAXESTSTOP (+ O_MAXESTPS (+ (- (max (max (- PS_ESTST O_MAXESTSTOP) (If O_WTJPT 0.0 O_AVGPT)) (+ (max (+ (max (+ O_AVGPT O_MINJPT) (If O_WTJPT (+ O_MAXESTPS O_MINJPT) O_AVGPT)) O_AVGPT) (+ O_MAXESTPS O_MINJPT)) (div (+ O_MAXESTSTOP O_AVGPT) PS_UNSON))) (- O_AVGPT O_MINESTSTOP)) (max (max O_WTJPT (If O_WTJPT 0.0 O_AVGPT)) (+ (max (+ (max (+ O_AVGPT O_MINJPT) (If O_WTJPT (+ O_MAXESTPS O_MINJPT) O_AVGPT)) O_AVGPT) (+ O_MAXESTPS O_MINJPT)) (div O_AVGPT PS_UNSON)))))) (+ (max (+ (div (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (* O_MINESTPS O_TCWPT)) O_MINJPT) (+ O_MAXESTSTOP (div PS_ESTST (max (+ O_AVGPT O_MINJPT) (+ O_MAXESTSTOP (div PS_ESTST (max (- PS_ESTST (- O_AVGPT O_MINESTSTOP)) (* 1.0 PS_UNSON)))))))) (div (max (+ (+ (+ (+ (max (+ (max (+ O_MAXESTSTOP O_AVGPT) (If O_WTJPT 0.0 O_AVGPT)) O_AVGPT) (+ O_MAXESTPS O_MINJPT)) (If O_WTJPT 0.0 O_AVGPT)) (+ PS_ESTST O_AVGPT)) (+ (+ (+ (* 1.0 PS_UNSON) O_AVGPT) (max (+ O_AVGPT O_MINJPT) (* O_MINESTPS O_WTJPT))) O_AVGPT)) (max (+ (+ (max (+ O_AVGPT (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON))) (+ (- O_AVGPT (* 1.0 PS_UNSON)) O_MINJPT)) (div (+ PS_ESTST O_AVGPT) PS_UNSON)) (div (- O_AVGPT O_MINESTSTOP) PS_UNSON)) (- O_AVGPT (* 1.0 PS_UNSON)))) (- O_AVGPT O_MINESTSTOP)) PS_UNSON))) (+ (* 1.0 PS_UNSON) (+ O_MINESTSTOP O_MAXESTPS))) O_WTJPT) (max (+ (max (+ O_AVGPT O_MINJPT) (+ (+ (+ O_AVGPT (max (+ O_AVGPT (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON))) (* 1.0 PS_UNSON))) O_MINJPT) O_AVGPT)) O_AVGPT) (+ (+ (+ (+ (max (+ O_TCWPT O_AVGPT) (+ O_MAXESTPS (max (- O_MINESTSTOP O_MINESTSTOP) (- O_AVGPT O_MINESTSTOP)))) (div (+ O_MAXESTSTOP O_AVGPT) (max (+ O_AVGPT O_MINJPT) (+ (+ (+ O_AVGPT (+ O_AVGPT (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON)))) O_MINJPT) O_AVGPT)))) (div (+ O_MAXESTSTOP O_AVGPT) PS_UNSON)) (div (max (+ (div (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (* O_MINESTPS O_TCWPT)) O_MINJPT) (+ O_MAXESTSTOP (div PS_ESTST (max (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT) (+ (max (div 1.0 PS_UNSON) (If O_WTJPT 0.0 O_AVGPT)) (div (* O_MINESTPS O_WTJPT) PS_UNSON)))))) PS_UNSON)) (div (+ O_MAXESTSTOP (+ (+ O_MAXESTSTOP (+ O_MAXESTPS (- O_AVGPT O_MINESTSTOP))) (+ (- (div 0.0 (If (div PS_UNSON O_MINESTPS) (div (+ (div PS_ESTST (max (- PS_ESTST O_MAXESTSTOP) (* 1.0 PS_UNSON))) O_AVGPT) (* O_MINESTPS O_TCWPT)) (+ (* 1.0 PS_UNSON) (+ O_MINESTSTOP O_MAXESTPS)))) (+ O_MAXESTPS O_MINJPT)) (max (+ (If O_WTJPT 0.0 O_AVGPT) O_AVGPT) (+ O_MAXESTSTOP O_AVGPT))))) (+ (div PS_ESTST (+ (+ O_MAXESTSTOP O_AVGPT) O_AVGPT)) (* 1.0 PS_UNSON)))))))";
        public static string ldr_test = "(- 0.0 O_MINESTPS)";

        public static string ldr_1 = "(div (div (div O_MAXJPT (+ PS_UNSON O_MINESTPS)) (* (* PS_UNSON O_WTJPT) (+ O_MINJPT O_MAXESTPS))) (+ (* (+ O_HM PS_UNSON) (* O_MINESTPS O_MINESTPS)) (* (* PS_UNSON O_WTJPT) (+ PS_UNSON O_MAXJPT))))";

        public static Node LDR;
        public static double[,] orderData;
        public static int numOrder;
        public static int numMach;

        //all the order information
        public static Order[] totalOrder;

        //the final sequence
        public static List<int> best_sequence;

        public static int unscheduledNum;
        public static int scheduledNum;

        //machine completion time of the current partial schedule
        public static double[] ps_machCTs;
        static void Main(string[] args)
        {
            System.Console.WriteLine("Please enter data file name:");

            string exitstr = "";
            string filename = System.Console.ReadLine();

            while (exitstr != " ")
            {

                System.Diagnostics.Stopwatch oTime = new System.Diagnostics.Stopwatch();
                oTime.Start();
               
                //build the tree
                LDR = buildTree(ldr_1);

                string outStr = "";

                /*for (int i = 121; i<481; i++)
                {
                    //read the data
                    readdata("..\\t2_0"+i);

                    //order schedule
                    System.Diagnostics.Stopwatch oTime = new System.Diagnostics.Stopwatch();
                    oTime.Start();
                    double tct = orderSchedule();
                    clearResults();

                    oTime.Stop();

                    System.Console.WriteLine("Objective = " + tct + "\tCPU time = " + oTime.ElapsedMilliseconds / 1000.0);
                    outStr += "Objective\t" + tct+"\n";
                }*/



                //read the data
                if (!readdata(".\\" + filename))
                {
                    System.Console.WriteLine("Enter space to exit, or enter next data file name:");
                    exitstr = System.Console.ReadLine();
                    filename = exitstr;
                    continue;
                }

                //order schedule
              
                double tct = orderSchedule();
               

                oTime.Stop();

                System.Console.WriteLine("Objective = " + tct + "\tCPU time (seconds) = " + oTime.ElapsedMilliseconds / 1000.0);
                outStr += "Data = " + filename + "\tObjective = " + tct + "\tCPU time (seconds) = " + oTime.ElapsedMilliseconds / 1000.0;


               

                FileStream fs_all = new FileStream(".\\LDR-I_output.txt", FileMode.Append);
                StreamWriter sw_all = new StreamWriter(fs_all);


                sw_all.WriteLine(outStr);

                /*outStr = "";
                for (int i = 0; i < numOrder; i++)
                {
                    outStr += times[i, 0] + "\t" + times[i, 1] + "\n";    
                }

                sw_all.WriteLine(outStr);*/

                sw_all.Flush();
                sw_all.Close();
                fs_all.Close();
                clearResults();

                System.Console.WriteLine("Enter space to exit, or enter next data file name:");
                exitstr = System.Console.ReadLine();
                filename = exitstr;
            }


        }


        //read the tree, construct the tree
        public static string curStr = null;
        public static Node buildTree(string str)
        {
            Node rootNode = new Node("root",-1, -1);
            rootNode.children = new Node[1];
            rootNode.argposition = 0;

            Node curNode = null;
            curStr = str;
            string temp = obtainNextfeature(curStr);
            while (temp != null)
            {
                if (temp == "(")
                {
                    temp = obtainNextfeature(curStr);
                    continue;
                }
                else if (temp == "+" || temp == "-" || temp == "*" || temp == "div" || temp == "max" || temp == "If") //if is function
                {
                    int num = temp == "If" ? 3 : 2;
                    if (curNode == null)
                    {
                        curNode = new Node(temp, getLabelforFeature(temp), -1);
                        curNode.father = null;
                        curNode.children = new Node[num];
                        curNode.argposition = 0;

                        rootNode.children[rootNode.argposition] = curNode;
                        curNode.father = rootNode;
                    }
                    else
                    {
                        Node newNode = new Node(temp, getLabelforFeature(temp), - 1);
                        newNode.children = new Node[num];
                        newNode.argposition = 0;

                        curNode.children[curNode.argposition] = newNode;
                        newNode.father = curNode;
                        curNode.argposition++;

                        curNode = newNode;
                    }
                }
                else if (temp == ")")
                {
                    curNode = curNode.father;
                }
                else //if is feature//optimize here
                {
                    Node newNode = new Node(temp, getLabelforFeature(temp), - 1);

                    newNode.father = curNode;
                    curNode.children[curNode.argposition] = newNode;
                    curNode.argposition++;
                }

                if (curStr.Length > 0)
                {
                    if (curStr.Substring(0, 1) == " ") curStr = curStr.Substring(1, curStr.Length - 1);
                }
                temp = obtainNextfeature(curStr);
            }

            curNode = rootNode.children[rootNode.argposition];

            return curNode;
        }


        public static string obtainNextfeature(string str)
        {
            string temp = null;
            int i = 0;
            while (i < str.Length)
            {
                temp = str.Substring(i, 1);
                if (temp == "(")
                {
                    curStr = curStr.Substring(1, curStr.Length - 1);
                    return temp;
                }
                else if (temp == " ")
                {
                    curStr = curStr.Substring(i + 1, curStr.Length - i - 1);
                    return str.Substring(0, i);
                }
                else if (temp == ")")
                {
                    if (i > 0)
                    {
                        curStr = curStr.Substring(i, curStr.Length - i);
                        return str.Substring(0, i);
                    }
                    else
                    {
                        curStr = curStr.Substring(1, curStr.Length - 1);
                        return temp;
                    }

                }
                else
                    i++;
            }
            return temp;
        }

        public static int getLabelforFeature(string temp)
        {
            int value = -1;
            switch (temp)
            {
                case "PS_AVGWL":
                    value = 1;
                    break;
                case "PS_ESTST":
                    value = 2;
                    break;
                case "PS_LSTST":
                    value = 3;
                    break;
                case "PS_VWL":
                    value = 4;
                    break;
                case "PS_UNSON":
                    value = 5;
                    break;
                case "PS_SON":
                    value = 6;
                    break;
                case "O_AVGPT":
                    value = 7;
                    break;
                case "O_VPT":
                    value = 8;
                    break;
                case "O_MINJPT":
                    value = 9;
                    break;
                case "O_MAXJPT":
                    value = 10;
                    break;
                case "O_WTJPT":
                    value = 11;
                    break;
                case "O_MAXESTSTOP":
                    value = 12;
                    break;
                case "O_MINESTSTOP":
                    value = 13;
                    break;
                case "O_MAXESTPS":
                    value = 14;
                    break;
                case "O_MINESTPS":
                    value = 15;
                    break;
                case "O_HM":
                    value = 16;
                    break;
                case "O_LM":
                    value = 17;
                    break;
                case "O_LC":
                    value = 18;
                    break;
                case "O_WLC":
                    value = 19;
                    break;
                case "O_TCWPT":
                    value = 20;
                    break;
                case "O_EXTRATIME":
                    value = 21;
                    break;
                case "M_MAXWL":
                    value = 22;
                    break;
                case "M_MINWL":
                    value = 23;
                    break;
                case "M_AVGWL":
                    value = 24;
                    break;
                case "M_VWL":
                    value = 25;
                    break;
                case "1.0":
                    value = 26;
                    break;
                case "0.0":
                    value = 27;
                    break;
                case "+":
                    value = 100;
                    break;
                case "-":
                    value = 101;
                    break;
                case "*":
                    value = 102;
                    break;
                case "div":
                    value = 103;
                    break;
                case "If":
                    value = 104;
                    break;
                case "max":
                    value = 105;
                    break;
                default:
                    value = -1;
                    break;
            }
            return value;
        }

        public class Node
        {
            public string name;
            public int label;
            public double value;
            public int argposition;
            public Node[] children;
            public Node father;

            public Node(string _name, int _label, double _value)
            {
                name = _name;
                label = _label;
                value = _value;
            }

            public double evalNode()
            {
                if (this.label == 100)
                {
                    value = children[0].evalNode() + children[1].evalNode();
                }
                else if (this.label == 101)
                {
                    value = children[0].evalNode() - children[1].evalNode();
                }
                else if (this.label == 102)
                {
                    value = children[0].evalNode() * children[1].evalNode();
                }
                else if (this.label == 103)
                {
                    double divi = children[1].evalNode();
                    if (divi != 0)
                        value = children[0].evalNode() / divi;
                    else
                        value = 1.0;
                }
                else if (this.label == 104)
                {
                    value = children[0].evalNode() >= 0 ? children[1].evalNode() : children[2].evalNode();
                }
                else if (this.label == 105)
                {
                    value = Math.Max(children[0].evalNode(), children[1].evalNode());
                }
                else
                    value = features.getFeaturevalue(label);

                return value;
            }
        }

        public class DoubleData
        {
            public double PS_AVGWL;//
            public double PS_ESTST;//
            public double PS_LSTST;//
            public double PS_VWL;//
            public double PS_UNSON;//
            public double PS_SON;//

            //information of the unscheduled order
            public double O_AVGPT;//
            public double O_VPT;//
            public double O_MINJPT;//
            public double O_MAXJPT;//

            public double O_WTJPT;//

            public double O_MAXESTSTOP;//
            public double O_MINESTSTOP;//
            public double O_MAXESTPS;//
            public double O_MINESTPS;//

            public double O_HM;//
            public double O_LM;//
            public double O_LC;//
            public double O_WLC;//
            public double O_TCWPT;//

            public double O_EXTRATIME;


            public double M_MAXWL;//
            public double M_MINWL;//
            public double M_AVGWL;//
            public double M_VWL;//

            public double getFeaturevalue(int str)
            {
                double value = 0;
                switch (str)
                {
                    case 1:
                        value = this.PS_AVGWL;
                        break;
                    case 2:
                        value = this.PS_ESTST;
                        break;
                    case 3:
                        value = this.PS_LSTST;
                        break;
                    case 4:
                        value = this.PS_VWL;
                        break;
                    case 5:
                        value = this.PS_UNSON;
                        break;
                    case 6:
                        value = this.PS_SON;
                        break;
                    case 7:
                        value = this.O_AVGPT;
                        break;
                    case 8:
                        value = this.O_VPT;
                        break;
                    case 9:
                        value = this.O_MINJPT;
                        break;
                    case 10:
                        value = this.O_MAXJPT;
                        break;
                    case 11:
                        value = this.O_WTJPT;
                        break;
                    case 12:
                        value = this.O_MAXESTSTOP;
                        break;
                    case 13:
                        value = this.O_MINESTSTOP;
                        break;
                    case 14:
                        value = this.O_MAXESTPS;
                        break;
                    case 15:
                        value = this.O_MINESTPS;
                        break;
                    case 16:
                        value = this.O_HM;
                        break;
                    case 17:
                        value = this.O_LM;
                        break;
                    case 18:
                        value = this.O_LC;
                        break;
                    case 19:
                        value = this.O_WLC;
                        break;
                    case 20:
                        value = this.O_TCWPT;
                        break;
                    case 21:
                        value = this.O_EXTRATIME;
                        break;
                    case 22:
                        value = this.M_MAXWL;
                        break;
                    case 23:
                        value = this.M_MINWL;
                        break;
                    case 24:
                        value = this.M_AVGWL;
                        break;
                    case 25:
                        value = this.M_VWL;
                        break;
                    case 26:
                        value = 1.0;
                        break;
                    case 27:
                        value = 0.0;
                        break;
                    default:
                        value = -1;
                        break;
                }
                return value;
            }

            /*public double getFeaturevalue(string str)
            {
                double value = 0;
                switch (str)
                {
                    case "PS_AVGWL":
                        value = this.PS_AVGWL;
                        break;
                    case "PS_ESTST":
                        value = this.PS_ESTST;
                        break;
                    case "PS_LSTST":
                        value = this.PS_LSTST;
                        break;
                    case "PS_VWL":
                        value = this.PS_VWL;
                        break;
                    case "PS_UNSON":
                        value = this.PS_UNSON;
                        break;
                    case "PS_SON":
                        value = this.PS_SON;
                        break;
                    case "O_AVGPT":
                        value = this.O_AVGPT;
                        break;
                    case "O_VPT":
                        value = this.O_VPT;
                        break;
                    case "O_MINJPT":
                        value = this.O_MINJPT;
                        break;
                    case "O_MAXJPT":
                        value = this.O_MAXJPT;
                        break;
                    case "O_WTJPT":
                        value = this.O_WTJPT;
                        break;
                    case "O_MAXESTSTOP":
                        value = this.O_MAXESTSTOP;
                        break;
                    case "O_MINESTSTOP":
                        value = this.O_MINESTSTOP;
                        break;
                    case "O_MAXESTPS":
                        value = this.O_MAXESTPS;
                        break;
                    case "O_MINESTPS":
                        value = this.O_MINESTPS;
                        break;
                    case "O_HM":
                        value = this.O_HM;
                        break;
                    case "O_LM":
                        value = this.O_LM;
                        break;
                    case "O_LC":
                        value = this.O_LC;
                        break;
                    case "O_WLC":
                        value = this.O_WLC;
                        break;
                    case "O_TCWPT":
                        value = this.O_TCWPT;
                        break;
                    case "O_EXTRATIME":
                        value = this.O_EXTRATIME;
                        break;
                    case "M_MAXWL":
                        value = this.M_MAXWL;
                        break;
                    case "M_MINWL":
                        value = this.M_MINWL;
                        break;
                    case "M_AVGWL":
                        value = this.M_AVGWL;
                        break;
                    case "M_VWL":
                        value = this.M_VWL;
                        break;
                    case "1.0":
                        value = 1.0;
                        break;
                    case "0.0":
                        value = 0.0;
                        break;
                    default:
                        value = -1;
                        break;
                }
                return value;
            }*/
        }



        public static bool readdata(string filepath)
        {
            char[] delimiterChars = { ' ', '\t' };
            try
            {   // Open the text file using a stream reader.
                using (StreamReader sr = new StreamReader(filepath))
                {
                    // Read the stream to a string, and write the string to the console.
                    string ln;
                    int row = 0;

                    while ((ln = sr.ReadLine()) != null)
                    {
                        if (row == 0)
                        {
                            string[] triple = ln.Split(delimiterChars);
                            numMach = int.Parse(triple[0]);
                            numOrder = int.Parse(triple[1]);
                            totalOrder = new Order[numOrder];
                            //orderData = new double[numOrder, numMach];
                        }
                        else
                        {
                            string[] triple = ln.Split(delimiterChars);

                            //remove spaces
                            string[] machs = new string[numMach];
                            int j = 0;
                            for (int k = 0; k < triple.Length; k++)
                            {
                                if (triple[k] != "")
                                {
                                    machs[j] = triple[k];
                                    j++;
                                }
                            }

                            Order order = new Order(row - 1, numOrder, numMach);

                            for (int i = 0; i < numMach; i++)
                            {
                                order.machs[i] = double.Parse(machs[i]);
                                //orderData[row - 1, i] = double.Parse(machs[i]);
                            }

                            order.setup();

                            totalOrder[row - 1] = order;
                        }

                        row++;
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("The file could not be read:");
                Console.WriteLine(e.Message);
                return false;
            }
            return true;

        }

        public static long[,] times;
        public static double orderSchedule()
        {
            //System.Diagnostics.Stopwatch oTime = new System.Diagnostics.Stopwatch();
            //System.Diagnostics.Stopwatch oTime1 = new System.Diagnostics.Stopwatch();
            //oTime.Start();


            unscheduledNum = numOrder;
            scheduledNum = 0;

            ps_machCTs = new double[numMach];
            best_sequence = new List<int>();

            updateOrderStaticInfo();

            int order = 0;

            while (unscheduledNum != 0)
            {

                int tobescheduled = picklargestPrio();

                //int tobescheduled = order;
                assignOrder(tobescheduled);

                order++;
            }

            double tct = getCompletionTime();

            return tct;
        }

        //select the order with the largest priority
        public static int picklargestPrio()
        {
            int tobeselect = 0;

            double[] priors = new double[numOrder];
            double maxp = double.MinValue;

            for (int i = 0; i < numOrder; i++)
            {
                //set the current order info to feature

                if (totalOrder[i].scheduled == false)
                {
                    updateOrderDynamicInfo(i);

                    setCurOrdertoFeature(i);

                    priors[i] = LDR.evalNode();
                }
                else
                {
                    priors[i] = double.MinValue;// to avoid the default value zero and other orders have negative prioirity
                }

                if (maxp < priors[i])
                {
                    maxp = priors[i];
                    tobeselect = i;
                }
            }

            /*for (int i = 0; i < numOrder; i++)
            {
                if (maxp < priors[i])
                {
                    maxp = priors[i];
                    tobeselect = i;
                }
            }*/

            return tobeselect;
        }

        //assign the selected order
        public static void assignOrder(int _no)
        {
            double minLoad = double.MaxValue;
            double maxLoad = double.MinValue;
            double sumLoad = 0;

            for (int j = 0; j < numMach; j++)
            {
                ps_machCTs[j] += totalOrder[_no].machs[j];

                totalOrder[_no].machCTs[j] = ps_machCTs[j];

                if (minLoad > ps_machCTs[j])
                    minLoad = ps_machCTs[j];
                if (maxLoad < ps_machCTs[j])
                    maxLoad = ps_machCTs[j];

                sumLoad += ps_machCTs[j];
            }

            totalOrder[_no].scheduled = true;

            //record the order completion time
            totalOrder[_no].orderCT = maxLoad;

            best_sequence.Add(_no);

            scheduledNum++;
            unscheduledNum--;


            //update the partial features
            features.PS_AVGWL = sumLoad / (double)numMach;
            features.PS_ESTST = minLoad;
            features.PS_LSTST = maxLoad;
            features.PS_SON = scheduledNum;
            features.PS_UNSON = unscheduledNum;

            //extra time
            //if an order is not scheduled, then what its extra time is if we place it to the next position
            // calculate the extra time of an order
            double[] stoptime = new double[numMach];
            for (int i = 0; i < numOrder; i++)
            {
                if (!totalOrder[i].scheduled)
                {
                    for (int j = 0; j < numMach; j++)
                    {
                        stoptime[j] = totalOrder[i].machs[j] + ps_machCTs[j];
                    }

                    double maxCTnext = maxValue(stoptime);
                    double minCTpre = minValue(ps_machCTs);
                    totalOrder[i].O_EXTRATIME = maxCTnext - minCTpre - totalOrder[i].O_MAXJPT;
                }
            }
        }


        public static void setCurOrdertoFeature(int _no)
        {

            features.O_AVGPT = totalOrder[_no].O_AVGPT;
            //features.O_VPT = totalOrder[_no]. O_VPT;
            features.O_MINJPT = totalOrder[_no].O_MINJPT;
            features.O_MAXJPT = totalOrder[_no].O_MAXJPT;
            features.O_WTJPT = totalOrder[_no].O_WTJPT;

            features.O_MAXESTSTOP = totalOrder[_no].O_MAXESTSTOP;
            features.O_MINESTSTOP = totalOrder[_no].O_MINESTSTOP;
            features.O_MINESTPS = totalOrder[_no].O_MINESTPS;
            features.O_MAXESTPS = totalOrder[_no].O_MAXESTPS;

            features.O_HM = totalOrder[_no].O_HM;
            features.O_LM = totalOrder[_no].O_LM;
            features.O_LC = totalOrder[_no].O_LC;
            features.O_WLC = totalOrder[_no].O_WLC;
            features.O_TCWPT = totalOrder[_no].O_TCWPT;

            features.O_EXTRATIME = totalOrder[_no].O_EXTRATIME;
        }


        /// <summary>
        /// update the order related dynamic info
        /// </summary>
        public static void updateOrderDynamicInfo(int _no)
        {
            double maxStoptime = 0;
            double minStoptime = double.MaxValue;
            double maxStarttime = 0;
            double minStarttime = double.MaxValue;

            double temp = 0;
            for (int j = 0; j < numMach; j++)
            {

                if (ps_machCTs[j] > maxStarttime)
                    maxStarttime = ps_machCTs[j];
                if (ps_machCTs[j] < minStarttime)
                    minStarttime = ps_machCTs[j];

                temp = totalOrder[_no].machs[j] + ps_machCTs[j];
                if (temp > maxStoptime)
                    maxStoptime = temp;
                if (temp < minStoptime)
                    minStoptime = temp;
            }
            totalOrder[_no].O_MAXESTSTOP = maxStoptime;
            totalOrder[_no].O_MINESTSTOP = minStoptime;
            totalOrder[_no].O_MINESTPS = maxStoptime - maxStarttime;
            totalOrder[_no].O_MAXESTPS = maxStoptime - minStarttime;
        }


        //calculate the static information, they are the same during the whole solution procedure
        public static void updateOrderStaticInfo()
        {
            double allprocesstime = 0;

            double[] machineweight = new double[numMach];
            double[] machWorkload = new double[numMach];

            for (int j = 0; j < numMach; j++)
            {
                for (int i = 0; i < numOrder; i++)
                {
                    machWorkload[j] += totalOrder[i].machs[j];
                }
                allprocesstime += machWorkload[j];
            }

            for (int j = 0; j < numMach; j++)
            {
                machineweight[j] = machWorkload[j] / allprocesstime;
            }

            double temp = 0;
            for (int i = 0; i < numOrder; i++)
            {
                temp = 0;
                for (int j = 0; j < numMach; j++)
                {
                    temp += totalOrder[i].machs[j] * machineweight[j];
                }
                //TWPT
                totalOrder[i].O_WTJPT = temp;
            }


            ///get the benchmark related features
            int machHM = 0;
            int machLM = 0;
            int machLC = 0;
            int machWLC = 0;
            int machTCWPT = 0;

            //rule HM, LM
            //find the machine with max workload and min workload
            machLM = minIdx(machWorkload);
            machHM = maxIdx(machWorkload);

            ///rule LC
            int[] sequence = new int[numOrder];
            double[] procs = new double[numOrder];
            double[] allct = new double[numMach];

            //rule WLC
            int[] weightsequence = new int[numOrder];
            double[] weightprocs = new double[numOrder];
            double[] weightallct = new double[numMach];

            //calculate the order weight
            double[] orderweight = new double[numOrder];
            double totalOrderTime = 0;
            for (int i = 0; i < numOrder; i++)
            {
                totalOrderTime += totalOrder[i].O_ALLPT;
            }
            for (int i = 0; i < numOrder; i++)
            {
                orderweight[i] = totalOrder[i].O_ALLPT / totalOrderTime;
            }

            //obtain all the completion time following that machine's sequence
            for (int j = 0; j < numMach; j++)
            {
                for (int i = 0; i < numOrder; i++)
                {
                    procs[i] = totalOrder[i].machs[j];
                    weightprocs[i] = totalOrder[i].machs[j] * orderweight[i];
                }

                ///LC:get a non-decreasing sequence of the orders in a machine
                /////need to optimize
                
                for (int i = 0; i < numOrder; i++)
                {
                    int seq = minIdx(procs);
                    sequence[i] = seq;
                    procs[seq] = double.MaxValue;
                }
                //obtain the completion time in this case
                allct[j] = getCompletiontimeBySeq(sequence);

                ///WLC:get a non-decreasing sequence of the orders in a machine
                /////need to optimize
                for (int i = 0; i < numOrder; i++)
                {
                    int seq = minIdx(weightprocs);
                    weightsequence[i] = seq;
                    weightprocs[seq] = double.MaxValue;
                }
                //obtain the completion time in this case
                weightallct[j] = getCompletiontimeBySeq(weightsequence);
            }

            //find the machine index with smallest completion time
            machLC = minIdx(allct);
            machWLC = minIdx(weightallct);

            //get O_TCWPT
            double[] machweight_ct = new double[numMach];
            double totalct = 0;
            for (int j = 0; j < numMach; j++)
                totalct += allct[j];
            for (int j = 0; j < numMach; j++)
            {
                machweight_ct[j] = allct[j] / totalct;
            }

            //calculate weighted procssing time of order
            for (int i = 0; i < numOrder; i++)
            {
                double weightPT = 0;
                for (int j = 0; j < numMach; j++)
                {
                    weightPT += machweight_ct[j] * totalOrder[i].machs[j];
                }
                totalOrder[i].O_TCWPT = weightPT;
            }


            //update the maxMachProcTime and minMachProcTime in the orders
            for (int i = 0; i < numOrder; i++)
            {
                totalOrder[i].O_HM = totalOrder[i].machs[machHM];
                totalOrder[i].O_LM = totalOrder[i].machs[machLM];
                totalOrder[i].O_LC = totalOrder[i].machs[machLC];
                totalOrder[i].O_WLC = totalOrder[i].machs[machWLC] * orderweight[i];
            }
        }

        //return the index of the minmum value
        public static int minIdx(double[] array)
        {
            int idx = 0;
            double temp = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < temp)
                {
                    temp = array[i];
                    idx = i;
                }
            }

            return idx;
        }

        //return the index of the maximum value
        public static int maxIdx(double[] array)
        {
            int idx = 0;
            double temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > temp)
                {
                    temp = array[i];
                    idx = i;
                }
            }
            return idx;
        }


        //return the min value of an array
        public static double minValue(double[] array)
        {
            double temp = double.MaxValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < temp)
                {
                    temp = array[i];
                }
            }
            return temp;
        }

        //return the max value of an array
        public static double maxValue(double[] array)
        {
            double temp = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > temp)
                {
                    temp = array[i];
                }
            }
            return temp;
        }


        //get the completion time give a fixed sequence
        //need to optimize
        public static double getCompletiontimeBySeq(int[] seq)
        {
            best_sequence = new List<int>();

            for(int i = 0; i < numOrder; i++) { 
                int tobescheduled = seq[i];

                double maxMachtime = 0;
                for (int j = 0; j < numMach; j++)
                {
                    ps_machCTs[j] += totalOrder[tobescheduled].machs[j];

                    totalOrder[tobescheduled].machCTs[j] = ps_machCTs[j];

                    if (totalOrder[tobescheduled].machCTs[j] > maxMachtime)
                        maxMachtime = totalOrder[tobescheduled].machCTs[j];
                }
                totalOrder[tobescheduled].orderCT = maxMachtime;

            }

            double ct = getCompletionTime();

            clearResults();

            return ct;
        }

        public static double getCompletionTime()
        {
            double tct = 0;
            for (int i = 0; i < numOrder; i++)
            {
                tct += totalOrder[i].orderCT;
            }
            return tct;
        }

        public static void clearResults()
        {
            for (int i = 0; i < numOrder; i++)
            {
                totalOrder[i].scheduled = false;
                totalOrder[i].orderCT = 0;

                totalOrder[i].machCTs = new double[numMach];
            }

            unscheduledNum = numOrder;
            scheduledNum = 0;

            ps_machCTs = new double[numMach];
            best_sequence = new List<int>();


            features.PS_UNSON = unscheduledNum;
            features.PS_SON = scheduledNum;
            features.PS_AVGWL = 0;
            features.PS_ESTST = 0;
            features.PS_LSTST = 0;

            features.O_AVGPT = 0;
            features.O_EXTRATIME = 0;
            features.O_HM = 0;
            features.O_LC = 0;
            features.O_LM = 0;
            features.O_MAXESTPS = 0;
            features.O_MAXESTSTOP = 0;
            features.O_MAXJPT = 0;
            features.O_MINESTPS = 0;
            features.O_MINESTSTOP = 0;
            features.O_MINJPT = 0;
            features.O_TCWPT = 0;
            features.O_WLC = 0;
            features.O_WTJPT = 0;

        }


        public class Order
        {
            public Order(int _no, int _order, int _mach)
            {
                no = _no;
                n_order = _order;
                n_mach = _mach;
                machs = new double[n_mach];
                scheduled = false;
                machCTs = new double[n_mach];
            }

            public int n_order;
            public int n_mach;

            public int no;
            public double[] machs;
            public bool scheduled;

            public double[] machCTs;
            public double orderCT;

            //the following are all features
            public double O_ALLPT;//
            public double O_AVGPT;//
            public double O_VPT;//
            public double O_MINJPT;//
            public double O_MAXJPT;//

            public double O_WTJPT;//

            public double O_MAXESTSTOP;//
            public double O_MINESTSTOP;//
            public double O_MAXESTPS;//
            public double O_MINESTPS;//

            public double O_HM;//
            public double O_LM;///
            public double O_LC;//
            public double O_WLC;//
            public double O_TCWPT;//

            public double O_EXTRATIME;//

            public void setup()
            {
                double minVal = double.MaxValue;
                double maxVal = 0;
                double sum = 0;

                for (int i = 0; i < numMach; i++)
                {
                    if (machs[i] > maxVal)
                    {
                        maxVal = machs[i];
                    }
                    if (machs[i] < minVal)
                    {
                        minVal = machs[i];
                    }

                    sum += machs[i];
                }

                O_ALLPT = sum;
                O_AVGPT = sum / numMach;
                O_MINJPT = minVal;
                O_MAXJPT = maxVal;
            }
        }

    }

}
