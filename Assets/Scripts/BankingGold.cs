using UnityEngine;
using System.Threading;

public class BankingGold : State<Miner>
{
    public override void Execute(Miner miner)
    {
        miner.m_BankedGold += miner.m_Gold;
        Debug.Log("Banked gold amount: " + miner.m_BankedGold);
        //Thread.Sleep(2000);
        miner.m_Gold = 0;
        Debug.Log("Current gold amount: " + miner.m_Gold);

        /*if (miner.m_Tiredness == 5)
        {
            //Thread.Sleep(2000);
            Debug.Log("Miner is tired from working for too long! >:(");
            //Thread.Sleep(2000);
            Debug.Log("Miner is gonna take a break now");
            miner.ChangeState(new TakeBreak());
        }
        else
        {
            //Thread.Sleep(2000);
            Debug.Log("Back to Mining!!!");
            //Thread.Sleep(2000);
            miner.ChangeState(new MiningForGold());
        }*/
    }
}

