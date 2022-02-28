using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment6
{
	class LongestCommonPrefix
	{



		
		static readonly int ALPHABET_SIZE = 26;

		// Trie node
		public class TrieNode
		{
			public TrieNode[] children = new TrieNode[ALPHABET_SIZE];

			
			public bool isLeaf;
			public int WC; 
			
			public TrieNode()
			{
				isLeaf = false;
				for (int i = 0; i < ALPHABET_SIZE; i++)
					children[i] = null;
			}
		};

		static TrieNode root;
		static int indexs;

		
		private void insert(String key)
		{
			int length = key.Length;
			int index;

			TrieNode pCrawl = root;

			for (int level = 0; level < length; level++)
			{
				index = key[level] - 'a';
				if (pCrawl.children[index] == null)
					pCrawl.children[index] = new TrieNode();

				pCrawl = pCrawl.children[index];
			}

			// mark last node as leaf
			pCrawl.isLeaf = true;
		}

		
		private int countChildren(TrieNode node)
		{
			int count = 0;
			for (int i = 0; i < ALPHABET_SIZE; i++)
			{
				if (node.children[i] != null)
				{
					count++;
					indexs = i;
				}
			}
			return (count);
		}

		
		private String walkTrie()
		{
			TrieNode pCrawl = root;
			indexs = 0;
			String prefix = "";

			while (countChildren(pCrawl) == 1 &&
					pCrawl.isLeaf == false)
			{
				pCrawl = pCrawl.children[indexs];
				prefix += (char)('a' + indexs);
			}
			return prefix;
		}

		// A Function to construct trie
		private void constructTrie(String[] arr, int n)
		{
			for (int i = 0; i < n; i++)
				insert(arr[i]);
			return;
		}

		// A Function that returns the longest common prefix
		// from the array of strings
		private String commonPrefix(String[] arr, int n)
		{
			root = new TrieNode();
			constructTrie(arr, n);

			// Perform a walk on the trie
			return walkTrie();
		}

		// Driver program to test above function
		public void main()
		{
			String[] arr = {"apple", "app",
						"april", "appetizer"};
			int n = arr.Length;

			String ans = commonPrefix(arr, n);

			if (ans.Length != 0)
				Console.WriteLine("The longest common prefixstrings
		private String commonPrefix(String[] arr, int n)
		{
			root = new TrieNode();
			constructTrie(arr, n);

			// Perform a walk on the trie
			return walkTrie();
		}

		// Driver program to test above function
		public void main()
		{
			String[] arr = {"apple", "app",
						"april", "appetizer"};
			int n = arr.Length;

			String ans = commonPrefix(arr, n);

			if (ans.Length != 0)
				Console.WriteLine("The longest common prefix is " + ans);
			else
				Console.WriteLine("There is no common prefix");
		}
	}
}

