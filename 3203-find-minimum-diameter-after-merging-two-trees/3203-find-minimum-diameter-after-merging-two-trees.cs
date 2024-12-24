public class Solution
{
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2)
		{
			int n = edges1.Length + 1;
			int m = edges2.Length + 1;

			List<List<int>> adj1 = BuildAdjList(n, edges1);
			List<List<int>> adj2 = BuildAdjList(m, edges2);

			int diam1 = FindDiameter(n, adj1);
			int diam2 = FindDiameter(m, adj2);

			int combinedDiameter = (int)Math.Ceiling(diam1 / 2.0) + (int)Math.Ceiling(diam2 / 2.0) + 1;

			return Math.Max(Math.Max(diam1, diam2), combinedDiameter);
		}

		public List<List<int>> BuildAdjList(int n, int[][] edges)
		{
			List<List<int>> adjList = new List<List<int>>();
			for (int i = 0; i < n; i++)
			{
				adjList.Add(new List<int>());
			}

			foreach (int[] edge in edges)
			{
				adjList[edge[0]].Add(edge[1]);
				adjList[edge[1]].Add(edge[0]);
			}

			return adjList;
		}

		public int FindDiameter(int n, List<List<int>> adjList)
		{
			Pair first = FindFarthestNode(n, adjList, 0);
			return FindFarthestNode(n, adjList, first.first).second;
		}

		private Pair FindFarthestNode(int n, List<List<int>> adjList, int sourceNode)
		{
			Queue<int> queue = new Queue<int>();
			bool[] visited = new bool[n];
			queue.Enqueue(sourceNode);
            visited[sourceNode] = true;
            
			int maxDistance = 0, farthestNode = sourceNode;

			while (queue.Count > 0)
			{
				int size = queue.Count;
				for (int i = 0; i < size; i++)
				{
					int currentNode = queue.Dequeue();
					farthestNode = currentNode;
					foreach (int neighbor in adjList[currentNode])
					{
						if (!visited[neighbor])
						{
							visited[neighbor] = true;
							queue.Enqueue(neighbor);
						}
					}
				}

				if (queue.Count > 0)
					maxDistance++;
			}

			return new Pair
			{
				first = farthestNode,
				second = maxDistance
			};
		}

		private class Pair
		{
			public int first;
			public int second;
		}
}