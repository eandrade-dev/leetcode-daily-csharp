using LeetcodeDaily.Problems;
using System;
using System.Windows.Forms;
using static LeetcodeDaily.Problems.Essential;

namespace LeetcodeDaily
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = Essential.TwoSum(new int[] { 2, 7, 11, 15 }, 9);

            string resultStr = string.Empty;
            foreach(var num in result)
            {
                resultStr += num + ", ";
            }
            listBoxResults.Items.Add($"TwoSum: {resultStr}");
        }

        private void btnValidParenthesis_Click(object sender, EventArgs e)
        {
            var result = Essential.ValidParenthesis("()");
            listBoxResults.Items.Add($"Valid Parenthesis (): {result}");
            result = Essential.ValidParenthesis("()[]{}");
            listBoxResults.Items.Add($"Valid Parenthesis ()[]{{}}: {result}");
            result = Essential.ValidParenthesis("(]");
            listBoxResults.Items.Add($"Valid Parenthesis (]: {result}");
            result = Essential.ValidParenthesis("([)]");
            listBoxResults.Items.Add($"Valid Parenthesis ([)]: {result}");
            result = Essential.ValidParenthesis("(([]){})");
            listBoxResults.Items.Add($"Valid Parenthesis (([]){{}}): {result}");
        }

        private void btnMergeSortedLists_Click(object sender, EventArgs e)
        {
            // Test 1
            var result = Essential.MergeTwoLists(
                new ListNode(1, new ListNode(3)),
                new ListNode(2, new ListNode(4))
            );
            var resultStr = string.Empty;
            while(result != null)
            {
                resultStr += $"{result.val}, ";
                result = result.next;
            }
            listBoxResults.Items.Add($"ListNode Head: {resultStr}");

            // Test 2
            result = Essential.MergeTwoLists(
                new ListNode(1, new ListNode(2, new ListNode(4))),
                new ListNode(1, new ListNode(3, new ListNode(4)))
            ); resultStr = string.Empty;
            while (result != null)
            {
                resultStr += $"{result.val}, ";
                result = result.next;
            }
            listBoxResults.Items.Add($"ListNode Head: {resultStr}");
        }

        private void btnBestTimeBuyStock_Click(object sender, EventArgs e)
        {
            var result = Essential.BestTimeBuyStock(new int[] { 7, 1, 5, 3, 6, 4 });
            listBoxResults.Items.Add($"Time to buy: {result}");

            result = Essential.BestTimeBuyStock(new int[] { 7, 6, 4, 3, 1 });
            listBoxResults.Items.Add($"Time to buy: {result}");
        }

        private void btnValidPalindrome_Click(object sender, EventArgs e)
        {
            var result = Essential.IsPalindrome("A man, a plan, a canal: Panama");
            listBoxResults.Items.Add($"A man, a plan, a canal: Panama: {result}");

            result = Essential.IsPalindrome("race a car");
            listBoxResults.Items.Add($"race a car: { result}");

            result = Essential.IsPalindrome(" ");
            listBoxResults.Items.Add($"<empty>: { result}");

            result = Essential.IsPalindrome("0P");
            listBoxResults.Items.Add($"0P: { result}");

        }
    }
}
