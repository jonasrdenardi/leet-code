using _130_CloneGraph;

var node1 = new Node(1);
var node2 = new Node(2);
var node3 = new Node(3);
var node4 = new Node(4);

// Definition of the neighbors
node1.neighbors.Add(node2);
node1.neighbors.Add(node4);

node2.neighbors.Add(node1);
node2.neighbors.Add(node3);

node3.neighbors.Add(node2);
node3.neighbors.Add(node4);

node4.neighbors.Add(node1);
node4.neighbors.Add(node3);

var clone1 = BFS(node1);

// DFS (Depth-First Search - Busca em Profundidade)
Node DFS(Node node)
{
    if (node == null)
        return null;

    // Dictionary to map original nodes to their clones
    var visited = new Dictionary<Node, Node>();

    // Helper function to clone nodes
    Node Clone(Node current)
    {
        if (visited.ContainsKey(current))
            return visited[current]; // Returns the already cloned node

        // Create a clone of the current node
        var clone = new Node(current.val);

        visited[current] = clone; // Store in the dictionary

        // Clone the neighbors
        foreach (var neighbor in current.neighbors)
        {
            clone.neighbors.Add(Clone(neighbor));
        }
        return clone;
    }

    return Clone(node);
}

// BFS (Breadth-First Search - Busca em Largura)
Node BFS(Node node)
{
    if (node == null)
        return null;

    // Dictionary to map original nodes to their clones
    var visited = new Dictionary<Node, Node>();

    // Create the clone of the initial node
    var clone = new Node(node.val);
    visited[node] = clone;

    // Queue to process nodes
    var queue = new Queue<Node>();
    queue.Enqueue(node);

    while (queue.Count > 0)
    {
        var current = queue.Dequeue();

        foreach (var neighbor in current.neighbors)
        {
            if (!visited.ContainsKey(neighbor))
            {
                // Create a clone of the neighbor and add it to the dictionary
                visited[neighbor] = new Node(neighbor.val);
                queue.Enqueue(neighbor);
            }

            // Add the neighbor clone to the current clone's neighbor list
            visited[current].neighbors.Add(visited[neighbor]);
        }
    }

    return clone;
}