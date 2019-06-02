using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public static class StatisticsCache {
    public static Statistic [] statArray = new Statistic [System.Enum.GetNames (typeof (StatType)).Length];

    static StatisticsCache () {
        for (int i = 0 ; i < statArray.Length ; i++) {

        }

    }
}
