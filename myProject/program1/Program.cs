using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverCode
{

    class GFG
    {
        static void Main(string[] args)
        {
            //string s = "i.like.this.program.very.much";
                
            // Solution obj = new Solution();
            // string res = obj.reverseWords(s);
            // Console.Write(res);
            // Console.Write("\n");

            //string a = "geeksforgeeks";
            //string b = "forgeeksgeeks"; // 1, 6, 2, 8, 5, 6
            int[] ints= new int[] { 1,6,2,8,5, 16, 3, 15, 18};
            Solution obj = new Solution();

            //foreach (int var in obj.dupArray(ints)){
                Console.WriteLine(obj.dupFind(ints));
           // }

            //obj.runningSum(ints);
            //int res = obj.isAnagram(a,b);
            // if(res==0){
            //     Console.Write("YES");
            // }
            // else{
            //     Console.Write("NO");    
            // }
            // Console.Write("\n");
        }
    }
    
}

class Solution
{
    //Complete this function
    public string reverseWords(string s)
    {
    string[] split = s.Split('.');

        Array.Reverse(split);
        string reversedString = string.Join('.', split);
        return reversedString;
    }

    public int isAnagram(string a, string b)
    {
        char[] charArray = a.ToCharArray();
        char[] charArray2 = b.ToCharArray();

        Array.Sort(charArray); // Sort the characters in the charArray in ascending order
        Array.Sort(charArray2);

        string sortedString = new string(charArray);
        string sortedString2 = new string(charArray2);
        int res = sortedString.CompareTo(sortedString2);
        return res;
    }

    public void runningSum(int[] arr){
        int rSum =0;
        for(int i=0;i<arr.Length; i++){
            rSum += arr[i];
            arr[i]=rSum;
        }
        for(int i=0;i<arr.Length; i++){
                Console.WriteLine(arr[i]);
        }
    }

    public int dupFind(int[] arr){
        HashSet<int> ht = new HashSet<int>();
        //bool flag=false;
        int number=0;
        for(int i=0; i< arr.Length; i++){
            if(ht.Contains(arr[i])){
               // flag=true;
                number=arr[i];
                break;
            }
            else{
                ht.Add(arr[i]);
            }
        }
        return number;
    }

    public int dupArray(int[] arr){
        Dictionary<int, int> dict = new Dictionary<int, int>();
        List<int> dupLi = new List<int>();
        List<int> rahul = new List<int>();
        int a=0;
        for(int i=0; i < arr.Length; i++){
            if(dict.ContainsKey(arr[i])){
                //dupLi.Add(arr[i]);
                a=arr[i];
                break;
            }
            else{
                rahul.Add(arr[i]);
                dict.Add(arr[i], i);
            }
        }
        foreach(int var in rahul){
            Console.WriteLine(var);
        }
        Console.WriteLine("________________");
        return a;
    }


}

