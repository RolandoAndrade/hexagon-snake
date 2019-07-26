using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Utils
{
    public static int IntParseFast(string value)
    {
        int result = 0;
        for (int i = 0; i < value.Length; i++)
        {
            char letter = value[i];
            if (letter < 48 || letter > 57)
                return -1;
            result = 10 * result + (letter - 48);
        }
        return result;
    }

}
