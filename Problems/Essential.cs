using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LeetcodeDaily.Problems
{
    public class Essential
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            var result = new int[] { };
            var search = new Dictionary<int, int>();

            for(int i=0; i<nums.Length; i++)
            {
                if(search.ContainsKey(target - nums[i]))
                {
                    result = new int[] { search[target - nums[i]], i };
                }
                search[nums[i]] = i;
            }

            return result;
        }

        public static bool ValidParenthesis(string input)
        {
            var startChars = new List<char>() { '(', '[', '{' };
            var endChars = new List<char>() { ')', ']', '}' };

            var stack = new Stack<char>();

            foreach(char p in input)
            {
                if (startChars.Contains(p))
                {
                    stack.Push(p);
                }
                else if (endChars.Contains(p))
                {
                    if(stack.Count == 0)
                    {
                        return false;
                    }

                    int index = endChars.IndexOf(p);
                    char matching = startChars[index];

                    if (stack.Peek() != matching)
                    {
                        return false;
                    }
                    stack.Pop();
                }
                else
                {
                    return false;
                }
            }

            if(stack.Count > 0)
            {
                return false;
            }

            return true;
        }

        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            ListNode l1 = list1, l2 = list2;
            ListNode head = new ListNode(0), current = head;
            
            while(l1 != null && l2 != null)
            {
                if(l1.val <= l2.val)
                {
                    current.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    current.next = l2;
                    l2 = l2.next;
                }
                current = current.next;
            }

            if(l1 != null)
            {
                current.next = l1;
            }
            else
            {
                current.next = l2;
            }

            return head.next;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val = 0, ListNode next = null)
            {
                this.val = val;
                this.next = next;
            }
        }

        public static int BestTimeBuyStock(int[] prices)
        {
            int minPrice = int.MaxValue;
            int maxProfit = 0;

            for(int i=0; i<prices.Length; i++)
            {
                if(prices[i] < minPrice)
                {
                    minPrice = prices[i];
                }
                else
                {
                    maxProfit = Math.Max(maxProfit, prices[i] - minPrice);
                }
            }
            return maxProfit;
        }

        public static bool IsPalindrome(string s)
        {
            if (string.IsNullOrWhiteSpace(s))
            {
                return true;
            }
            s = s.ToLower();

            var cleanStr = string.Empty;
            foreach (char c in s)
            {
                if ((c >= 'a' && c <= 'z') 
                    || (c >= '0' && c <= '9')){
                    cleanStr += c;
                }
            }

            var halfLength = Convert.ToInt32(Math.Floor((double)cleanStr.Length/2));


            for(int i=0; i< halfLength; i++)
            {
                if(cleanStr[i] != cleanStr[cleanStr.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
