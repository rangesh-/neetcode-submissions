public class Solution {
    public int CountComponents(int n, int[][] edges) {
        // Renamed back to 'dict' as requested
        var dict = new List<int>[n];
        bool[] visited = new bool[n];
        var component = 0;

        for (int i = 0; i < n; i++) {
            dict[i] = new List<int>();
        }

        foreach (var edge in edges) {
            // FIX: Add the integer ID, not the List object
            dict[edge[0]].Add(edge[1]);
            dict[edge[1]].Add(edge[0]);
        }

        // FIX: We need an outer loop to find all disconnected "islands"
        for (int i = 0; i < n; i++) {
            if (!visited[i]) {
                component++; // Found a new starting point = new component
                
                var queue = new Queue<int>();
                queue.Enqueue(i);
                visited[i] = true;

                while (queue.Count > 0) {
                    var node = queue.Dequeue();
                    
                    // FIX: Iterate through the neighbors list inside 'dict'
                    foreach (var e in dict[node]) {
                        if (!visited[e]) {
                            visited[e] = true;
                            queue.Enqueue(e);
                        }
                    }
                }
            }
        }

        return component;
    }
}