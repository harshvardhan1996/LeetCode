// Source : https://leetcode.com/problems/count-and-say/ 
// Author : codeyu 
// Date : Monday, October 17, 2016 7:38:57 PM 

/**********************************************************************************
*
* The count-and-say sequence is the sequence of integers beginning as follows:
* 1, 11, 21, 1211, 111221, ...
* 
* 
* 
* 1 is read off as "one 1" or 11.
* 11 is read off as "two 1s" or 21.
* 21 is read off as "one 2, then one 1" or 1211.
* 
* 
* 
* Given an integer n, generate the nth sequence.
* 
* 
* 
* Note: The sequence of integers will be represented as a string.
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
namespace Algorithms
{
    public class Solution038 
    {
        public static string CountAndSay(int n) 
        {
            string s = "1";
            for (int i = 1; i < n; i++)
            {
                s = Cal(s);
            } 
            return s;
        }
        static string Cal(string s)
        {
            string ans = "";
            int cnt =1;
            int len = s.Length;
            for (int i = 0; i < len; i++)
            {
                if (i + 1 < len && s[i] != s[i + 1])
                {
                    ans = ans + cnt.ToString() + s[i];
                    cnt = 1;
                }			
                else if (i + 1 < len)
                {
                    cnt++;
                }   
            }
            ans = ans + cnt.ToString() + s[len-1];
            return ans;
        }
    }
}

