// Names: Shravan Chinta, Krishna Mohan Pulipati

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

public class HeapSort 
{ 
    private static int[] a; 
    private static int n; 
    private static int left; 
    private static int right; 
    private static int largest;
    

    private static void exch(int[] a, int i, int j) {
        int swap = a[i];
        a[i] = a[j];
        a[j] = swap;
    }

   
    public static void shuffle(int[] a) {
        int N = a.length;
        for (int i = 0; i < N; i++) {
            int r = i + (int) (Math.random() * (N-i));   
            exch(a, i, r);
        }
    }
    
    public static void buildheap(int []a){ 
        n=a.length-1; 
        for(int i=n/2;i>=0;i--){ 
            maxheap(a,i); 
        } 
    } 
    
    public static void maxheap(int[] a, int i){ 
        left=2*i; 
        right=2*i+1; 
        if(left <= n && a[left] > a[i]){ 
            largest=left; 
        } 
        else{ 
            largest=i; 
        } 
        
        if(right <= n && a[right] > a[largest]){ 
            largest=right; 
        } 
        if(largest!=i){ 
            exchange(i,largest); 
            maxheap(a, largest); 
        } 
    } 
    
    public static void exchange(int i, int j){ 
        int t=a[i]; 
        a[i]=a[j]; 
        a[j]=t; 
        } 
    
    public static void sort(int []a0){ 
        a=a0; 
        buildheap(a); 
        
        for(int i=n;i>0;i--)
        { 
            exchange(0, i); 
            n=n-1; 
            maxheap(a, 0); 
        } 
    } 
    
    public static void main(String[] args) throws IOException { 
    	
    	BufferedReader bufferRead = new BufferedReader(new InputStreamReader(System.in));
    	System.out.println("Please enter the size of unsorted array to be sorted, for example 10000,50000 etc.,");
    	int size = Integer.parseInt(bufferRead.readLine());
    	
    	long b[]=new long[1000];
    	
    	
    for(int i=0;i<1000;i++)
    {
        int a[]= new int[size];
        
        for(int x=0;x<size;x++)
        a[x]=x;
        
        shuffle(a);
        
        long startTime=System.nanoTime();
        sort(a);
        long endTime=System.nanoTime();
       
        b[i]=(endTime-startTime);
        
        for(int x=0;x<size-1;x++)
        {
        	if(a[x]>a[x+1])
        		{
        		System.out.println("not sorted");
        		}
        	}
    	}
    
    for(int i=1;i<1000;i++)
    {
    	b[0]+=b[i];
    }
    System.out.println(b[0]/1000);
    }
}
