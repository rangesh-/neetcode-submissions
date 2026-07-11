public class Solution {
    public bool ValidTree(int n, int[][] edges) {
        // 1. A valid tree with n nodes MUST have exactly n - 1 edges.
        // Too many edges = cycle; too few edges = disconnected.
        if (edges.Length != n - 1) return false;

        // 2. Build the adjacency list for the undirected graph.
        List<int>[] adj = new List<int>[n];
        for (int i = 0; i < n; i++) {
            adj[i] = new List<int>();
        }
        foreach (var edge in edges) {
            adj[edge[0]].Add(edge[1]);
            adj[edge[1]].Add(edge[0]);
        }

        // 3. Use BFS to check if the graph is fully connected.
        HashSet<int> visited = new HashSet<int>();
        Queue<int> queue = new Queue<int>();

        // Start from node 0
        queue.Enqueue(0);
        visited.Add(0);

        while (queue.Count > 0) {
            int current = queue.Dequeue();
            foreach (int neighbor in adj[current]) {
                // If we find a new node, visit it.
                if (!visited.Contains(neighbor)) {
                    visited.Add(neighbor);
                    queue.Enqueue(neighbor);
                }
            }
        }

        // 4. Final Verification:
        // If we visited all n nodes, the graph is connected.
        // Combined with the (n-1) edge check, this guarantees it's a tree.
        return visited.Count == n;
    }
}