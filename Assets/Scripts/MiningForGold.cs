using UnityEngine;
using System.Threading;

public class MiningForGold : State<Miner>
{
    private bool startedMining = false;
    //private bool messageDisplayed = false;  //This variable is created to test something out.

    //TODO: Ask Jay how to slow things down.

    public override void Execute(Miner miner)
    {
        #region Stuff to fix if possible
        /*
        if (!startedMining && !messageDisplayed)
        {
            Debug.Log("The miner wants to bring his pet with him. Are you allowing this? [y/n]");
            if (Input.GetKeyDown(KeyCode.Y)) 
            {
                Debug.Log("What was the pet's name again?");
                miner.petPointer.p_name = Input.inputString; // Use Input from Unity for user input
                Thread.Sleep(500);
                Debug.Log("Ah yes, " + miner.petPointer.p_name + "!");
                Thread.Sleep(500);
                Debug.Log("The miner can get to work with his pet now!!");
                Thread.Sleep(500);
                startedMining = true;
                messageDisplayed = true;
            }
            else if (Input.GetKeyDown(KeyCode.N))
            {
                Debug.Log("Wow.");
                Thread.Sleep(500);
                Debug.Log("Ok.");
                Thread.Sleep(500);
                startedMining = true;
                miner.petPointer.ChangeState(new PetIdle());
                messageDisplayed = true;
            }
        }
        */

        /*if (startedMining)
        {
            Debug.Log("Digging for gold!");

            miner.m_Gold++;
        }*/

        #endregion

        Debug.Log("Digging for gold!");
        miner.m_Gold++;
        if (miner.m_Gold > 1)
        {
            miner.m_Tiredness += Random.Range(0, 2);
            Debug.Log("Miner tiredness level: " + miner.m_Tiredness);
        }

        //if (miner.m_Gold >= 10) { miner.ChangeState(new BankingGold()); }

        //if (miner.m_Tiredness >= 5) { miner.ChangeState(new TakeBreak()); }
    }
}

