// Source : https://leetcode.com/problems/combination-sum/ 
// Author : codeyu 
// Date : Tuesday, October 25, 2016 11:14:47 PM 

/**********************************************************************************
*
* 
* Given a set of candidate numbers (C) and a target number (T), find all unique combinations in C where the candidate numbers sums to T. 
* 
* 
* The same repeated number may be chosen from C unlimited number of times.
* 
* 
* Note:
* 
* All numbers (including target) will be positive ints.
* The solution set must not contain duplicate combinations.
* 
* 
* 
* 
* For example, given candidate set [2, 3, 6, 7] and target 7, 
* A solution set is: 
* 
* [
*   [7],
*   [2, 2, 3]
* ]
* 
* 
*
**********************************************************************************/

using System;
using System.Collections.Generic;
using Algorithms.Utils;
using System.Linq;
namespace Algorithms
{
    public class Solution039 
    {
        public static IList<IList<int>> CombinationSum(int[] candidates, int target) 
        {
            IList<IList<int>> result = new List<IList<int>>();
            if(candidates == null || candidates.Length==0)
                return result;
            Array.Sort(candidates);
            helper(candidates, 0, target, new List<int>(), result);
            return result;
            
        }
        private static void helper(int[] candidates, int start, int target, IList<int> item, 
                                    IList<IList<int>> result)
        {
            if(target<0)
                return;
            if(target==0)
            {
                result.Add(new List<int>(item));
                return;
            }
            for(int i=start;i<candidates.Length;i++)
            {
                if(i>0 && candidates[i]==candidates[i-1])
                    continue;
                item.Add(candidates[i]);
                helper(candidates,i,target-candidates[i],item,result);
                item.RemoveAt(item.Count-1);
            }
        }
    }
}

