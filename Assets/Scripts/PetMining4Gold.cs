using UnityEngine;
using System.Threading;
public class PetMining4Gold : State<Pet>
{
    public override void Execute(Pet pet)
    {
        Debug.Log("The pet is mining hard right now!!! (I got bored!!)");
        //Thread.Sleep(500);
        Debug.Log("Imagine that there is an if statement here that");
        Debug.Log("checks whether the pet has x gold and tells the miner to get back to work");
    }
}
