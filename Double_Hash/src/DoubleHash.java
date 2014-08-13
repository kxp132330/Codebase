
// Buffer Reader for Stdin and Stdout
import java.io.BufferedReader;
import java.io.InputStreamReader;
import java.io.IOException;
import org.omg.PortableInterceptor.SYSTEM_EXCEPTION;

//
public class DoubleHash {

    String[] hashTable;
    boolean[] isDeleted;
    int size;
    float insert;
    float insertProbes;
    float search;
    float searchProbes;
    float unSearch;
    float unSearchProbes;

    DoubleHash(int s) {
        hashTable = new String[s];
        isDeleted = new boolean[s];
        size = 0;
        insert = 0;
        insertProbes = 0;
        search = 0;
        searchProbes = 0;
        unSearch = 0;
        unSearchProbes = 0;
    }

    private int hashValue1(String key) {
        int hashVal = 0;

        for (int i = 0; i < key.length(); i++) {
            hashVal = 37 * hashVal + key.charAt(i);
        }

        hashVal = hashVal % hashTable.length;

        if (hashVal < 0) {
            hashVal += hashTable.length;
        }

        return hashVal;

    }

    private int hashValue2(String key) {
        int hashVal = 0;

        for (int i = 0; i < key.length(); i++) {
            hashVal = 37 * hashVal + key.charAt(i);
        }

        hashVal = hashVal % hashTable.length;

        if (hashVal < 0) {
            hashVal += hashTable.length;
        }

        hashVal = 13 - (hashVal % 13);

        return hashVal;
    }

    public boolean insert(String key, String record) {
        String firstRecord = null;
        int hashVal = hashValue1(key);
        int hashVal2 = hashValue2(key);
        int count = 0;
        while (true) {
            if (hashTable[hashVal] == null)
            {
                hashTable[hashVal] = key + ":" + record;
                size++;
                insert++;
                return true;
            }
            else 
            {
                if (isDeleted[hashVal]) 
                {
                    hashTable[hashVal] = key + ":" + record;
					isDeleted[hashVal]=false;
                    size++;
                    insert++;
                    return true;
                } 
                else 
                {
                    if (hashTable[hashVal].split(":")[0].equalsIgnoreCase(key))
                    {
                        System.out.println("Key " + key + " already exists");
                        return false;
                    }
                    else if (count == 0)
                    {
                        firstRecord = hashTable[hashVal].split(":")[0];
                        insertProbes++;
                        hashVal += hashVal2;
                        hashVal %= hashTable.length;
                        count++;
                    }
                    else
                    {
                        if (firstRecord.equalsIgnoreCase(hashTable[hashVal].split(":")[0])) {
                            System.out.println("Table has overflowed");
                            return false;
                        } else {
                            insertProbes++;
                            hashVal += hashVal2;
                            hashVal %= hashTable.length;
                        }
                    }
                }
            }
        }
    }

    public String isPresent(String key) {
        String record = null;
        int hashVal = hashValue1(key);
        int hashVal2 = hashValue2(key);
        int count = 0;
        int count1 = 0;

        String firstRecord = null;

        while (true) {
            if (hashTable[hashVal] == null) {
                unSearchProbes += count1;
                unSearch++;
                break;
            } else {
                if (!isDeleted[hashVal] && hashTable[hashVal].split(":")[0].equalsIgnoreCase(key)) {
                    record = hashTable[hashVal].split(":")[1];
                    searchProbes += count1;
                    search++;
                    break;
                } else {
                    if (isDeleted[hashVal]) {
                        count1++;
                        hashVal += hashVal2;
                        hashVal %= hashTable.length;
                    } else {
                        if (count == 0) {
                            firstRecord = hashTable[hashVal].split(":")[0];
                            count++;
                            count1++;
                            hashVal += hashVal2;
                            hashVal %= hashTable.length;
                        } else {
                            if (hashTable[hashVal].split(":")[0].equalsIgnoreCase(firstRecord)) {
                                unSearchProbes += count1;
                                unSearch++;
                                break;
                            } else {
                                count1++;
                                hashVal += hashVal2;
                                hashVal %= hashTable.length;
                            }
                        }
                    }
                }
            }
        }

        return record;
    }

    public boolean delete(String key) {
        int hashVal = hashValue1(key);
        int hashVal2 = hashValue2(key);
        int count = 0;
        String firstRecord = null;

        while (true) {
            if (hashTable[hashVal] == null) {
                break;
            } else {
                if (!isDeleted[hashVal] && hashTable[hashVal].split(":")[0].equalsIgnoreCase(key)) {
                    isDeleted[hashVal] = true;
                    size--;
                    return true;
                } else {
                    if (count == 0) {
                        firstRecord = hashTable[hashVal].split(":")[0];
                        count++;
                        hashVal += hashVal2;
                        hashVal %= hashTable.length;
                    } else {
                        if (hashTable[hashVal].split(":")[0].equalsIgnoreCase(firstRecord)) {
                            break;
                        } else {
                            hashVal += hashVal2;
                            hashVal %= hashTable.length;
                        }
                    }
                }
            }
        }

        return false;
    }

    public int size() {
        return size;
    }

    void listAll() {
        for (int i = 0; i < hashTable.length; i++) {
            if (hashTable[i] != null && !isDeleted[i]) {
                System.out.println(i + " " + hashTable[i]);
            }
        }

    }

    public void printStats() {
        if (insertProbes != 0) {
            System.out.println("Average probes in insert = " + String.format("%.1f", insertProbes / insert));
        } else {
            System.out.println("Number of insert probes is 0");
        }

        if (unSearchProbes != 0) {
            System.out.println("Average probes in unsuccessful search " + String.format("%.1f", unSearchProbes / unSearch));
        } else {
            System.out.println("Number of unsuccessful search probes 0");
        }

        if (searchProbes != 0) {
            System.out.println("Average probes in successful search " + String.format("%.1f", searchProbes / search));
        } else {
            System.out.println("Number of search probes 0");
        }
    }

    public static void main(String[] args) throws IOException {
        DoubleHash one = new DoubleHash(1013);

        BufferedReader bufferRead = new BufferedReader(new InputStreamReader(System.in));

        String c = bufferRead.readLine();

        while (!c.equalsIgnoreCase("E")) {
            if (c.equalsIgnoreCase("N")) {
                System.out.println("Shravan Chinta, Krishna Mohan Pulipati");
            } else if (c.equalsIgnoreCase("C")) {
                one.hashTable = null;
            } else if (c.split(" ")[0].equalsIgnoreCase("I")) {
                if (c.split(" ").length > 1) {
                    if (c.split(" ")[1].split(":").length > 1) {
                        if (one.insert(c.split(" ")[1].split(":")[0], c.split(" ")[1].split(":")[1])) {
                            System.out.println("Key " + c.split(" ")[1].split(":")[0] + " inserted");
                        }
                    } else {
                        System.out.println("Inavlid Input");
                    }
                } else {
                    System.out.println("Invalid input");
                }
            } else if (c.split(" ")[0].equalsIgnoreCase("D")) {
                if (c.split(" ").length > 1) {
                    if (one.delete(c.split(" ")[1])) {
                        System.out.println("Key " + c.split(" ")[1] + " deleted");
                    } else {
                        System.out.println("Key " + c.split(" ")[1] + " not present");
                    }
                } else {
                    System.out.println("Invalid input");
                }
            } else if (c.split(" ")[0].equalsIgnoreCase("S")) {
                if (c.split(" ").length > 1) {
                    String result = one.isPresent(c.split(" ")[1]);
                    if (result != null) {
                        System.out.println("Key " + c.split(" ")[1] + ":" + result);
                    } else {
                        System.out.println("Key not found");
                    }
                } else {
                    System.out.println("Invalid input");
                }
            } else if (c.equalsIgnoreCase("Z")) {
                System.out.println("Size is " + one.size());
            } else if (c.equalsIgnoreCase("P")) {
                one.listAll();
            } else if (c.equalsIgnoreCase("T")) {
                one.printStats();
            } else {
                System.out.println("Invalid input");
            }

            c = bufferRead.readLine();
        }
    }
}
