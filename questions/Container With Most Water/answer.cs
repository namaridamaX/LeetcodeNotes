public class Solution {
    public int MaxArea(int[] height) {
        var resultList = new List<int>();

        for (int i=0; i < height.Length; i++)
        {
            var target = height[i];
            var width = 0;

            for (int l=0; l < height.Length; l++)
            {
                if(i == l){continue;}
                var subTarget = height[l];

                if (target <= subTarget)
                {
                    var dis = i - l;
                    if (dis < 0)
                    {
                        dis = dis * -1;
                    }

                    if (width < dis)
                    {
                        width = dis;
                    }
                }
            }
            
            resultList.Add(target * width);
        }

        return resultList.Max();
    }
}