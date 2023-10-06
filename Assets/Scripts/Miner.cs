using System.Xml;
using UnityEngine;

public class Miner : MonoBehaviour
{

    private State<Miner> m_State;
    public Pet petPointer;
    public StateManager m_StateManager = new StateManager();

    State<Miner> initialMiningState = new MiningForGold();

    public int m_Gold;
    public int m_BankedGold;
    public int m_Tiredness;
    //public bool m_StartedMining = false;
    public string m_currentState;

    private void Start()
    {
        m_State = initialMiningState;
    }

    /*public void Update() //Use Invoke to delay the function.
    { 
        UpdateState();
        m_StateManager.Execute(this);

        #region Same thing as the switch case but with ifs.
        //if(m_State == new MiningForGold()) { m_currentState = "MiningForGold"; }
        //if(m_State == new BankingGold()) { m_currentState = "BankingGold"; }
        //if(m_State == new TakeBreak()) { m_currentState = "TakeBreak"; }
        #endregion

        switch (m_State)
        {
            case BankingGold:
                m_currentState = "BankingGold";
                break;
            case TakeBreak:
                m_currentState = "TakeBreak";
                break;
            default:
                m_currentState = "MiningForGold";
                break;
        }
    }*/

    public void DelayedUpdate() 
    { 
        UpdateState();
        m_StateManager.Execute(this);
        switch (m_State)
        {
            case BankingGold:
                m_currentState = "BankingGold";
                break;
            case TakeBreak:
                m_currentState = "TakeBreak";
                break;
            default:
                m_currentState = "MiningForGold";
                break;
        }
    }

    public void ChangeState(State<Miner> newState) { m_State = newState; }

    private void UpdateState() { m_State?.Execute(this); }
}

public class StateManager   //Instead of having a seperate script, made the class here so that it's "brain" doesn't work outside of the mine.
{
    State<Miner> miningState = new MiningForGold();
    State<Miner> bankingState = new BankingGold();
    State<Miner> breakState = new TakeBreak();
    public void Execute(Miner miner)
    {
        if (miner.m_Gold >= 10) { miner.ChangeState(bankingState); }

        if (miner.m_Tiredness >= 5) { miner.ChangeState(breakState); }

        if ((miner.m_currentState == "BankingGold") && (miner.m_Tiredness == 5))
        {
            Debug.Log("Miner is tired from working for too long! >:(");
            Debug.Log("Miner is gonna take a break now");
            miner.ChangeState(breakState);
        }
        else if (miner.m_currentState == "BankingGold") { Debug.Log("Back to Mining!!!"); miner.ChangeState(miningState); }
    }
}

