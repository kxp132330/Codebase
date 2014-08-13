// Names : Shravan Chinta, Krishna Mohan Pulipati

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;

public class InsertionSort {
 
    public static void main (String[] args) throws IOException 
    {
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
        insertionSort(a);
        long endTime=System.nanoTime();
        
        b[i]=(endTime-startTime);
        
        for(int x=0;x<size-1;x++)
        {
        	if(a[x]>a[x+1])
        		{
        		System.out.println(i+"not sorted");
        		}
        	}
    	}
    
    for(int i=1;i<1000;i++)
    {
    	b[0]+=b[i];
    }
    System.out.println(b[0]/1000);
    }
 

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
    
    public static void insertionSort(int array[]) {
        int n = array.length;
        for (int j = 1; j < n; j++) {
            int key = array[j];
            int i = j-1;
            while ( (i > -1) && ( array [i] > key ) ) {
                array [i+1] = array [i];
                i--;
            }
            array[i+1] = key;
        }
    }
}
