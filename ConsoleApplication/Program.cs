using System;
using System.Collections.Generic;
using System.Linq;


namespace ConsoleApplication
{
    public class Node
    {
        public int? Data;
        public Node LNode;
        public Node RNode;

        public Node()
        { }
        public Node(int d)
        {
            Data = d;
            LNode = null;
            RNode = null;
        }

        public Queue<Node> queue = new Queue<Node>();
        public int lcount = 0;


        public int height(ref Node Root)
        {
            if (Root == null)
            {
                return -1;
            }
            int lh = height(ref Root.LNode);
            int rh = height(ref Root.RNode);

            return (lh > rh ? lh : rh) + 1;
        }
        public int Lheight(ref Node Root)
        {
            //int rcount = 0;

            if (Root.LNode != null)
            {

                lcount++;

                Lheight(ref Root.LNode);


            }
            //else
            //{

            //}
            return lcount;
        }

        //public int Rheight(ref Node Root)
        //{
        //    //int rcount = 0;

        //    if (Root.RNode != null)
        //    {
        //        rcount++;

        //        Rheight(ref Root.RNode);


        //    }
        //    return rcount;
        //}

        public void load(ref Node root, int v)
        {
            //Node root = this;

            //Node asd = new Node(v);
            if (root == null)
            { 
                root = new ConsoleApplication.Node(v);
                //return root;
            }
            else
            {
                if (v <= root.Data)
                {
                    load(ref root.LNode, v);
                }
                else
                {
                    load(ref root.RNode, v);
                }
            }



            //return root;

        }

        void print(Node R)
        {
            if (R != null)
            {
                if (R.LNode != null)
                {
                    Console.WriteLine(R.LNode.Data + " ");
                }
                if (R.RNode != null)
                {
                    Console.WriteLine(R.RNode.Data + " ");
                }
            }
        }

        public void preOrder(ref Node Root)
        {
            if (Root == null)
            {
                return;
            }
            else
            {
                Console.WriteLine(Root.Data);

                preOrder(ref Root.LNode);

                preOrder(ref Root.RNode);


            }
        }

        public void INOrder(ref Node Root)
        {
            if (Root == null)
            {
                return;
            }
            else
            {

                INOrder(ref Root.LNode);
                Console.WriteLine(Root.Data);

                INOrder(ref Root.RNode);


            }
        }


        public void levelOrder(ref Node Root)
        {
            if (Root != null)
            {
                queue.Enqueue(Root);

                while (queue.Count != 0)
                {
                    var aa = queue.First();

                    Console.Write(aa.Data);

                    if (aa.LNode != null)
                    {
                        queue.Enqueue(aa.LNode);
                    }
                    if (aa.RNode != null)
                    {
                        queue.Enqueue(aa.RNode);
                    }

                    queue.Dequeue();
                }

                //print(Root.LNode);

                //print(Root.RNode);

                //levelOrder(ref Root.LNode);

                //levelOrder(ref Root.RNode);
            }
            else
            {
                return;
            }
        }

    }
    //  public class ListNode
    //  {
    //    public int val;
    //    public ListNode next;
    //    public ListNode(int x) { val = x; }
    //}

    //  public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    //  {

    //      ListNode q = l1;

    //      string s = "";

    //      string s1 = "";

    //      while (q != null)
    //      {
    //          s = s + q.val.ToString();
    //          q = q.next;
    //      }

    //      q = l2;

    //      while (q != null)
    //      {
    //          s1 = s1 + q.val.ToString();
    //          q = q.next;
    //      }

    //      int qw = Convert.ToInt32(s.Reverse()) + Convert.ToInt32(s1.Reverse());

    //      q = null;

    //      foreach (char c in qw.ToString().Reverse())
    //      {
    //          q.val = Convert.ToInt32(c.ToString());
    //          q = q.next;
    //      }
    //      return q;
    //  }
    //class Program
    //{

    //public static int LengthOfLongestSubstring(string s)
    //{
    //    int cnt = 0;
    //    string ste = "";
    //    int max = 0;
    //    int k = 1;

    //    if (s.Length > k)
    //    {
    //        foreach (char c in s.ToCharArray())
    //        {
    //            int pos = s.Substring(k).IndexOf(c);

    //            max = pos > max ? pos : max;

    //            k++;

    //            //foreach(char d in s.ToCharArray().Skip(k))
    //            //{

    //            //}


    //            //if(ste.Contains(c.ToString()))
    //            //{
    //            //ste = c.ToString();
    //            //max = cnt > max ? cnt : max;
    //            //cnt = 1;
    //            //}
    //            //else
    //            //{
    //            //ste =  ste + c.ToString();
    //            //cnt++;
    //            //}
    //        }

    //        max++;
    //    }
    //    else
    //    {
    //        if (s.Length != 0)
    //            max = k;
    //    }
    //    //max = cnt > max ? cnt : max;

    //    return max;

    //}





    class Program
    {
        static List<string> rd = new List<string>();
        static void Main(string[] args)
        {

            var x = new[] { new int[] { 1, 2, 3 }, new int[] { 4, 5, 6 }, new int[] { 7, 8, 9 } };
            int q = 0;
            string a = "";

            //foreach (var item in x)
            //{
            //    foreach (var item2 in item)
            //    {
            //        if (!rd.Contains(item2))
            //            rd.Add(item2);

            //    }
            //}


            Combo(x, x[q], a, q);

            



            // Balenced Parenthesis
            bool va = balencedParenthesis("){");



            string str1 = "test";
            List<char> chArry = new List<char>();
            string res = "";
            List<string> resList = new List<string>();
            foreach (char item in str1.ToCharArray())
            {
                if(!chArry.Contains(item))
                {
                    chArry.Add(item);
                    res = res + item;
                }
                else
                {
                    resList.Add(res);
                    chArry.Clear();
                    res = "";
                }

            }





            // The below method will return list of string based on their values asc
            // vowels will have double their values like a=2; e=10;
            // Remaining charectors will be the same value like b=2, c=3, d=4
            string[] vals = { "Test", "Code" };
            List<string> stringval = StringVal(vals);


            //RockPaper Scissors
            string result = RockPaperScissors("Rock", "Paper");

           



           




            //string s = "PAYPALISHIRING";

            //int start = 3, Count = 0;
            //int[] arr = new int[start - 1];// { start, 1 };

            //for(int g = 0; g < start -1 ; g++)
            //{
            //    arr[g] = start - g;
            //}

            //for (int k = 0; k < s.Length; k++)
            //{
            //    foreach (int item in arr)
            //    {
            //        k = k + item;
            //        Count++;
            //    }
            //}

            //char[,] val = new char[start, Count + 1];
            //int ith = 0;

            //for (int k = 0; k < s.Length; k++)
            //{

            //    foreach (int item in arr)
            //    {
            //        if (k < s.Length)
            //        {
            //            for (int j = 0; j < s.Substring(k, (s.Length - k > item ? item : s.Length - k)).Length; j++)
            //            {
            //                if (item == 1)
            //                    val[start / 2, ith] = s.Substring(k, (s.Length - k > item ? item : s.Length - k))[j];
            //                else
            //                    val[j, ith] = s.Substring(k, (s.Length - k > item ? item : s.Length - k))[j];

            //            }
            //        }
            //        k = k+item;
            //        ith++;
            //    }
            //    k = k - 1;
            //}

            //string res = "";

            //foreach (char item in val)
            //{
            //    if (item != '\0')
            //        res += item;
            //}

            ////for(int g = 0; g< s.Length;g++)
            ////{
            ////    val[g, g] = true;
            ////}

            //string result = "";


            //if (s.Length == 1)
            //{
            //    Len = 1;
            //}
            //else
            //{
            //    for (int j = 0; j < s.Length-1; j++)
            //    {
            //        if (s[j] == s[j + 1])                    
            //        {
            //            val[j, j + 1] = true;

            //            start = j;
            //            Len = 2;



            //        }
            //    }


            //    for (int i = 3; i <= s.Length; i++)
            //    {
            //        for (int j = 0; j < s.Length - i + 1; j++)
            //        {
            //            if(s[j] == s[i+j-1] && val[j+1, j+i-2])
            //            {
            //                val[j, j + i-1] = true;

            //                start = j;
            //                Len = i;
            //                //result = s.Substring(j, i);
            //            }
            //        }
            //    }
            //}

            //if (s.Length > 1 && Len == 0)
            //    result = s[0].ToString();
            //else
            //    result = s.Substring(start, Len);

            //for (int i = 0; i < s.Length; i++)
            //{
            //    for (int j = 0; j < i; j++)
            //    {
            //        if (s.ToCharArray()[i-1] == s.ToCharArray()[j+1])
            //        {
            //            if (s.Substring(i-1, j+1) == new string(s.Substring(i-1, j+1).Reverse().ToArray()))
            //            {
            //                if (result.Length < s.Substring(i-1, j+1).Length)
            //                {
            //                    result = s.Substring(i-1, j+1);
            //                }
            //            }
            //        }
            //    }
            //}





            // Console.WriteLine("Hello");

            // string qwe = "abcde";

            // string result = "";

            // for (int i = 0; i < qwe.Length; i++)
            // {
            //     string s1 = qwe[i].ToString();// qwe.Substring(i, qwe.LastIndexOf(qwe[i]) - i + 1);

            //     for (int j = i+1; j < qwe.Length; j++)
            //     {
            //         s1 += qwe[j];

            //         if (s1 == new string(s1.Reverse().ToArray()))
            //         {
            //             if (s1.Length > result.Length)
            //             {
            //                 result = s1;
            //             }
            //         }
            //         if (result.Length == 0)
            //             result = qwe[j].ToString();
            //     }
            //  }

            // int[] arr1 = new int[] { 23,26,31,35 };
            // int[] arr2 = new int[] { 3,5,7,9,11,16 };

            // List<int> ay = arr1.ToList();


            // ay.AddRange(arr2.ToList());

            // List<int> full = ay.OrderBy(x => x).ToList();

            // int remainder;
            // int quotient = Math.DivRem(full.Count, 2, out remainder);
            // double val;

            // if (remainder == 1)
            // {           
            //     val = full[quotient];
            // }
            // else
            // {
            //     val = ((full[quotient - 1] + full[quotient]) / (double)2);
            // }


            // //if(arr1.Length > arr2.Length)
            // //{
            //     //end = arr2.Length;
            // //}

            //// int[] partX = arr2.Take((start + end) / 2).ToArray();





            // string s = "abcabcbb";

            // List<char> strQ = new List<char>();

            // int res = 0;
            // var dict = new System.Collections.Generic.Dictionary<char,int>();
            // var start = 0;

            // for (int i = 0; i < s.Length; i++)
            // {
            //     if(strQ.Contains(s[i]))
            //     {
            //         res = res > i-res ? res : i - res;
            //     }
            //     else
            //     {
            //         strQ.Add(s[i]);
            //     }


            //     //if (dict.ContainsKey(s[i]))
            //     //{
            //     //    start = Math.Max(start, dict[s[i]] + 1);
            //     //    dict[s[i]] = i;
            //     //}
            //     //else
            //     //{
            //     //    dict.Add(s[i], i);
            //     //}

            //     //res = Math.Max(res, i - start + 1);
            // }


            // Node q = new ConsoleApplication.Node(3);

            // //q.load(ref q,3);
            // q.load(ref q, 2);
            // q.load(ref q, 5);
            // q.load(ref q, 6);
            // q.load(ref q, 4);
            // q.load(ref q, 1);
            // q.load(ref q, 7);

            // var eeee = q.height(ref q);


            // q.levelOrder(ref q);

            // q.preOrder(ref q);

            // q.INOrder(ref q);

            // getList();
            // //youcreditkarmatopview(ref q);

            
        }


        static bool balencedParenthesis(string s)
        {
            var refer = new List<string> { "()", "{}", "[]" };

            var str = s;

            Stack<char> aaaaa = new Stack<char>();


            foreach (char item in str.ToCharArray())
            {
                if (item == '(' || item == '{' || item == '[')
                {
                    aaaaa.Push(item);

                }
                else
                {
                    if (aaaaa.Count == 0 || !refer.Contains(aaaaa.Peek().ToString() + (item).ToString()))
                    {
                        aaaaa.Push(item);
                        break;
                    }
                    else
                    {
                        aaaaa.Pop();
                    }
                }
            }

            if (s.Length == 0)
                return true;
            else
            {
                if (aaaaa.Count == 0 && s.Length > 1)
                    return true;
                else
                    return false;
            }

        }


        static string RockPaperScissors(string playerA, string playerB )
        {

            if (playerA == playerB)
            {
                return "Tie";
            }
            else
            {
                string result = "";
                if (playerA != null && playerA.Trim() != "" && playerB != null && playerB.Trim() != "")
                {
                    Dictionary<string, string> keyVal = new Dictionary<string, string>();

                    //keyVal.ContainsKey()
                    keyVal.Add("Rock:Paper", "Paper");
                    keyVal.Add("Paper:Scissors", "Scissors");
                    keyVal.Add("Rock:Scissors", "Rock");

                    if (playerA == keyVal[playerA + ":" + playerB])
                        result = "Player 1 Wins";

                    if (playerB == keyVal[playerA + ":" + playerB])
                        result = "Player 2 Wins";
                }
                return result;
            }




        }

        static void Combo(int[][] main, string val)
        {
            if (main.Count() == 0)
                rd.Add(val);
            else
            {
                foreach (var item in main)
                {
                    foreach (var item2 in (int[])item)
                    {
                        List<int[]> aaaaa = new List<int[]>();
                        aaaaa = main.ToList();
                        aaaaa.Remove(item);

                        Combo(aaaaa.ToArray(), val + item2);
                    }
                }
                

               

                //if(chk)
                //foreach (var item in (int[])chk)
                //{
                //    val = val + item;
                //}

            }
        }


        static List<string> StringVal(string[] strs)
        {           

            Dictionary<string, int> Dict = new Dictionary<string, int>();

            List<char> chk = new List<char>() { 'a', 'e', 'i', 'o', 'u' };

            foreach (string s in strs)
            {
                int val = 0;
                foreach (char c in s.ToLower().ToCharArray())
                {
                    if (chk.Contains(c))
                        val = val + (int)c % 32 + (int)c % 32;
                    else
                        val = val + (int)c % 32;
                }

                if (!Dict.ContainsKey(s))
                    Dict.Add(s, val);
            }

            List<string> res = new List<string>();
            foreach (var item in Dict.OrderBy(x => x.Value))
            {
                res.Add(item.Key);
            }

            return res;
        }

    }
}
