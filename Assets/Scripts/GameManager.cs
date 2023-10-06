using UnityEngine;

//This is essentially a replica of MinerApplication.

public class GameManager : MonoBehaviour
{
    #region Script References
    private Miner mainMiner;
    private Pet mainPet;
    private DesireManager desireManager;
    #endregion

    #region Object References
    GameObject minerObject;
    GameObject petObject;
    [SerializeField] GameObject desireObject;
    #endregion

    private void Start()
    {
        desireObject = GameObject.Find("DesireManager");
        desireManager = desireObject.GetComponent<DesireManager>();

        #region Miner & Pet Stuff
        //minerObject = GameObject.Find("Miner");
        //petObject = GameObject.Find("Pet");

        //mainMiner = minerObject.GetComponent<Miner>();
        //mainPet = petObject.GetComponent<Pet>();

        //mainMiner.petPointer = mainPet;
        //mainMiner.InvokeRepeating("DelayedUpdate", 1.0f, 1.0f);
        #endregion
    }

    private void Update()
    {
        //mainMiner.Update();
        //mainPet.Update();
        desireManager.Update();
    }
}

