public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        int l = s.Length / k;
        bool add = false;
        if(s.Length % k != 0){
            l++;
            add = true;
        }

        string[] ret = new string[l];
        if(add){
            l--;
        }

        int index = 0;
        bool init = true;
        for(int i = 0; i < l; i++){
            ret[i] = s.Substring(index, k);
            index = index + k - 1;
            init = false;
            if(!init){
                index++;
            }
        }

        string conc = s.Substring(index, s.Length - index);
        if(add){
            while(conc.Length < k){
                conc = conc + fill;
            }
            ret[l] = conc;
        }
        return(ret);
    }
}
