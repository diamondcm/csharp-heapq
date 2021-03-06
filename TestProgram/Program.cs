using System;
using BinaryHeap;
using System.Linq;
using System.Collections.Generic;

namespace TestProgram
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var heap = new List<int> ();

			var rng = new Random ();

			var list = new List<int>(
				Enumerable.Range(0,20)
				.Select( k => rng.Next(20) ) );

			Console.WriteLine (string.Join(", ", list));

#if true
			foreach(var i in list)
			{
				heap.HeapPush(i);
			}

			list.Heapify();
			//list.HeapSort ();

			var pops = Enumerable.Range(0,list.Count).Select( 
			                                                 //k => list.HeapPop() 
			                                                 k => heap.HeapPop() 
			                                                 );
#else
			for (int k=0; k< list.Count; k++) {
				list.MinHeapify (list.Count - 1 - k);
			}
#endif
			//Console.WriteLine (string.Join(", ", list));
			Console.WriteLine (string.Join(", ", heap));
			Console.WriteLine (heap.IsMinHeap ());
			Console.WriteLine (string.Join(", ", pops));

			//Console.WriteLine ("Hello World!");
			//Console.ReadLine ();
		}
	}
}
