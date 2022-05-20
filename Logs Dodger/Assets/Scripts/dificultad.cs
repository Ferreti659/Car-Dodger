using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class dificultad
{

    static float secondsToMaxDifficulty = 60;

    public static float GetDifficultyPercent()
    {
        return Mathf.Clamp01(Time.time / secondsToMaxDifficulty);
    }

}
