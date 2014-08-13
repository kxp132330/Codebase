// Names : Shravan Chinta, Krishna Mohan Pulipati

import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import java.util.Arrays;


public class MergeSort {

    public static void main(String[] args) throws IOException{
    	
    	BufferedReader bufferRead = new BufferedReader(new InputStreamReader(System.in));
    	System.out.println("Please enter the size of unsorted array to be sorted, for example 10000,50000 etc.,");
    	int size = Integer.parseInt(bufferRead.readLine());
    	
        long b[]=new long[1000];
    	
        
    for(int i=0;i<1000;i++)
    {
        int a[]= new int[size];
        
        for(int x=0;x<size;x++)
        a[i]=i;
        
        shuffle(a);
        
        long startTime=System.nanoTime();
        mergeSort(a);
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
    
    static void mergeSort(int[] A) {
        if (A.length > 1) {
            int q = A.length/2;

            int[] leftArray = Arrays.copyOfRange(A, 0, q);
            int[] rightArray = Arrays.copyOfRange(A,q,A.length);

            mergeSort(leftArray);
            mergeSort(rightArray);

            merge(A,leftArray,rightArray);
        }
    }

    static void merge(int[] a, int[] l, int[] r) {
        int totElem = l.length + r.length;

        int i,li,ri;
        i = li = ri = 0;
        while ( i < totElem) {
            if ((li < l.length) && (ri<r.length)) {
                if (l[li] < r[ri]) {
                    a[i] = l[li];
                    i++;
                    li++;
                }
                else {
                    a[i] = r[ri];
                    i++;
                    ri++;
                }
            }
            else {
                if (li >= l.length) {
                    while (ri < r.length) {
                        a[i] = r[ri];
                        i++;
                        ri++;
                    }
                }
                if (ri >= r.length) {
                    while (li < l.length) {
                        a[i] = l[li];
                        li++;
                        i++;
                    }
                }
            }
        }
        

    }

}
