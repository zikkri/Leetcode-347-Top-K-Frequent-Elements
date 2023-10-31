public class Solution {    
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
            int[] retArr = new int[k];
            int p = 0;
            // Array.Sort(nums);

            foreach(int i in nums)
            {
                if (dict.ContainsKey(i))
                {
                    dict[i] = dict[i] + 1;
                }

                else
                {
                    dict.Add(i, 1);
                }
            }

            var sortedDict = from entry in dict
                             orderby entry.Value                             
                             descending 
                             select entry;
                        
            var other = sortedDict.Take(k);
            

            foreach (KeyValuePair<int, int > i in other)
            {                
                retArr[p] = i.Key;
                p++;
            }

            return retArr;            
    }
}
