using UnityEngine;

public class Desire : MonoBehaviour
{
    [HideInInspector] public float desireVal;
    [HideInInspector] public string state;

    //public virtual void CalculateDesire() { }
}

class RunDesire : Desire
{
    public RunDesire() { state = "RunDesire"; desireVal = 0.5f; }
    //public override void CalculateDesire() { desireVal = 0.95f; }
}

class FightDesire : Desire
{
    public FightDesire() { state = "FightDesire"; desireVal = 0.95f; }
    //public override void CalculateDesire() { desireVal = 0.5f; }
}

#region First Attempt
/*
 public int SortByDesire(Desire lhs, Desire rhs) { return lhs.desireVal.CompareTo(rhs.desireVal); }

 Desire d = mainDesire.SortByDesire(desire1, desire2);
 */
#endregion