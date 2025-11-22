using System.Collections.Generic;
public class Solution {
    public string IntToRoman(int num) {
        int hoge = 1000;
        var stringList = new List<String>();
        var result = "";

        while (true)
        {
            if(num < hoge){
                hoge /= 10;
                continue;
            }

            int targetNum = num / hoge; //1, 2, 3....
            int targetNum2 = targetNum * hoge;
            num %= hoge;

            switch (targetNum2)
            {
                case 1000:
                    if (targetNum < 4)
                    {
                        stringList.Add("C" * 4);
                    }
                    else if (targetNum == 4)
                    {
                        stringList.Add("DC");
                    }
                    else if (targetNum == 5)
                    {
                        stringList.Add("D");
                    }
                    else if (targetNum < 9)
                    {
                        stringList.Add("D");
                        stringList.Add("C" * (targetNum - 5));
                    }
                    else if (targetNum == 9)
                    {
                        stringList.Add("CM");
                    }
                    else
                    {
                        stringList.Add("M");
                    }
            }

            //hogeが１になったら終わり
            if (hoge == 1)
            {
                break;
            }

            hoge /= 10;
        }


        return result;
    }
}