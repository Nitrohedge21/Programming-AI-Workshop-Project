using UnityEngine;
using System.Linq;

public class DesireManager : MonoBehaviour
{
    RunDesire desire1 = new RunDesire();
    FightDesire desire2 = new FightDesire();

    public void Update()
    {
        float desire1Val = desire1.desireVal;
        float desire2Val = desire2.desireVal;

        float[] desireList = { desire1Val, desire2Val };

        float higherFloat = desireList.Max();
        string higherText = higherFloat == desire1Val ? desire1.state : desire2.state; 
        //Got the line above from ChatGPT because I couldn't figure it out.

        Debug.Log("Current highest desire is: " + higherText + " with a value of " + higherFloat + "!");
    }
}
