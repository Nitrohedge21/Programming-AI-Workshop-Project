using UnityEngine;
using System.Threading;

public class TakeBreak : State<Miner>
{
    public State<Pet> PetMineGold = new PetMining4Gold();
    public State<Miner> MineGold = new MiningForGold();
    public override void Execute(Miner miner)
    {
        Debug.Log("The miner is currently on a break");
        //Thread.Sleep(5000);
        Debug.Log("The miner will go back to work in a few seconds.");
        //Thread.Sleep(5000);
        Debug.Log("Back to work!");
        miner.m_Tiredness = 0;
        //Thread.Sleep(2000);
        miner.ChangeState(MineGold);

        #region RngMiningWithPet
        /*
        int randomState = Random.Range(0, 2); // Generates either 0 or 1
        if (randomState == 0)
        {
            Debug.Log("The miner has sent " + miner.petPointer.p_name + " to mine some gold for him!");
            Thread.Sleep(5000);
            miner.petPointer.ChangeState(PetMineGold);
        }
        else
        {
            Debug.Log("Back to work!");
            miner.m_Tiredness = 0;
            Thread.Sleep(2000);
            miner.ChangeState(MineGold);
        }
        */
        #endregion
    }

}

