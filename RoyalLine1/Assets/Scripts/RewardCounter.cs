using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RewardCounter : MonoBehaviour
{
    Text rCounterText;

    void Start()
    {
        rCounterText = GetComponent<Text>();
    }

    void Update()
    {
        if (rCounterText.text != Reward.totalReward.ToString())
        {
            rCounterText.text = Reward.totalReward.ToString();
        }
        
    }
}
