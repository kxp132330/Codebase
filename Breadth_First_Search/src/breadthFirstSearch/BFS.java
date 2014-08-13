package breadthFirstSearch;

import java.util.LinkedList;

public class BFS {
	
	public class vertex
	{
		
		private int vertexNumber;
		private int vertexPred;
		
		public vertex(int vertexNumber, int vertexPred)
		{
			super();
			this.vertexNumber = vertexNumber;
			this.vertexPred = vertexPred;
		}
		
		public int getVertexNumber()
		{
			return vertexNumber;
		}

		public void setVertexNumber(int vertexNumber) 
		{
			this.vertexNumber = vertexNumber;
		}

		public int getVertexPred()
		{
			return vertexPred;
		}

		public void setVertexPred(int vertexPred) 
		{
			this.vertexPred = vertexPred;
		}

	}
	
	public class Edge
	{
		private int source;
		private int destination;
		
		public Edge(int source, int destination) {
			super();
			this.source = source;
			this.destination = destination;
		}
		
		public int getSource()
		{
			return source;
		}
		
		public void setSource(int source)
		{
			this.source = source;
		}
		
		public int getDestination()
		{
			return destination;
		}
		
		public void setDestination(int destination) 
		{
			this.destination = destination;
		}
	}
	
	
	
	public class adjacent
	{
		private java.util.LinkedList<vertex> adjacentList=new java.util.LinkedList<vertex>();

		
		public adjacent(LinkedList<vertex> adjacentList)
		{
			super();
		}

		public java.util.LinkedList<vertex> getAdjacentList()
		{
			return adjacentList;
		}

		public void setAdjacentList(java.util.LinkedList<vertex> adjacentList) 
		{
			this.adjacentList = adjacentList;
		}
		
	}
	
	
	private vertex[] verteces;
	private Edge[] edges;
	private adjacent[] adjacent;
	
	public BFS()
	{
		super();
	}
	
	public vertex[] getVerteces() 
	{
		return verteces;
	}
	
	public void setVerteces(vertex[] verteces)
	{
		this.verteces = verteces;
	}
	
	public Edge[] getEdges()
	{
		return edges;
	}
	
	public void setEdges(Edge[] edges) {
		this.edges = edges;
	}
	
	
	
	public void breadthFirstSearch(BFS bfs)
	{
			java.util.PriorityQueue<vertex> pQueue = new java.util.PriorityQueue<vertex>();
			
	}
	

}
