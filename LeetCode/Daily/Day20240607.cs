using System.Text;

namespace LeetCode.Daily
{
    //    In English, we have a concept called root, which can be followed by some other word to form another longer word - let's call this word derivative.
    //    For example, when the root "help" is followed by the word "ful", we can form a derivative "helpful".

    //Given a dictionary consisting of many roots and a sentence consisting of words separated by spaces,
    //replace all the derivatives in the sentence with the root forming it.If a derivative can be replaced by more than one root, replace it with the root that has the shortest length.

    //Return the sentence after the replacement.



    //Example 1:

    //Input: dictionary = ["cat", "bat", "rat"], sentence = "the cattle was rattled by the battery"
    //Output: "the cat was rat by the bat"
    //Example 2:

    //Input: dictionary = ["a", "b", "c"], sentence = "aadsfasf absbs bbab cadsfafs"
    //Output: "a a b c"
    public class Day20240607
    {
        public class TrieNode
        {
            public Dictionary<char, TrieNode> children = new Dictionary<char, TrieNode>();
            public string word = null;
        }
        public class Trie
        {
            private TrieNode root;

            public Trie()
            {
                root = new TrieNode();
            }

            public void Insert(string word)
            {
                TrieNode node = root;
                foreach (char c in word)
                {
                    if (!node.children.ContainsKey(c))
                    {
                        node.children[c] = new TrieNode();
                    }
                    node = node.children[c];
                }
                node.word = word;
            }

            public string SearchPrefix(string word)
            {
                TrieNode node = root;
                foreach (char c in word)
                {
                    if (!node.children.ContainsKey(c))
                    {
                        break;
                    }
                    node = node.children[c];
                    if (node.word != null)
                    {
                        return node.word;
                    }
                }
                return word;
            }
        }
        public string ReplaceWords(IList<string> dictionary, string sentence)
        {
            Trie trie = new Trie();
            foreach (string root in dictionary)
            {
                trie.Insert(root);
            }

            string[] words = sentence.Split(' ');
            StringBuilder result = new StringBuilder();

            foreach (string word in words)
            {
                if (result.Length > 0)
                {
                    result.Append(" ");
                }
                result.Append(trie.SearchPrefix(word));
            }
            return result.ToString();
        }
        //public string ReplaceWords(IList<string> dictionary, string sentence)
        //{

        //    dictionary = dictionary.OrderBy(x => x).ToList();
        //    StringBuilder stringBuilder = new StringBuilder();
        //    for (var i = 0; i < sentence.Length;)
        //    {
        //        var endOfTheWord = sentence.IndexOf(" ", i);
        //        if (endOfTheWord == -1)
        //        {
        //            endOfTheWord = sentence.Length;
        //        }
        //        var replaced = "";
        //        for (var j = 0; j < dictionary.Count; j++)
        //        {
        //            var b = i;
        //            var isFind = true;
        //            for (var k = 0; k < dictionary[j].Length && b < endOfTheWord; k++)
        //            {
        //                if (sentence[b] != dictionary[j][k])
        //                {
        //                    isFind = false;
        //                    break;
        //                }
        //                b++;
        //                if (b >= endOfTheWord)
        //                {
        //                    isFind = false;
        //                    break;
        //                }
        //            }
        //            if (isFind)
        //            {
        //                replaced = dictionary[j];
        //                break;
        //            }
        //        }
        //        if (replaced == "")
        //        {
        //            var length = 0;
        //            if (endOfTheWord == -1)
        //            {
        //                length = sentence.Length - i;
        //            }
        //            else
        //            {
        //                length = endOfTheWord - i;
        //            }
        //            stringBuilder.Append(" " + sentence.Substring(i, length));
        //        }
        //        else
        //        {
        //            stringBuilder.Append(" " + replaced);
        //        }
        //        i = endOfTheWord + 1;
        //    }
        //    return stringBuilder.ToString().Trim();


        //    //var charArray = sentence.ToCharArray();
        //    //for (var i = 0; i < sentence.Length; i++)
        //    //{
        //    //    while (i < sentence.Length && (String.IsNullOrEmpty(sentence[i].ToString())))
        //    //    {
        //    //        i++;
        //    //    }
        //    //    var replaced = "";
        //    //    for (var j = 0; j < dictionary.Count; j++)
        //    //    {
        //    //        var b = i;
        //    //        for (var k = 0; k < dictionary.Count; k++)
        //    //        {
        //    //            if (sentence[b] == dictionary[j][k])
        //    //            {
        //    //                break;
        //    //            }
        //    //        }
        //    //    }
        //    //    if (replaced != "")
        //    //    {

        //    //    }
        //    //}
        //    //return new string(charArray);

        //}
    }
}
