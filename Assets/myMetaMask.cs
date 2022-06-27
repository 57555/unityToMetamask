using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class myMetaMask : MonoBehaviour
{



    [DllImport("__Internal")]
    private static extern void myConnect();

    [DllImport("__Internal")]
    private static extern void myTxSender( string myAz, string myTo, string myMz);

    [DllImport("__Internal")]
    private static extern void myTxConfirmer(string myTxHash);



    public void connectingMetaMask()
    {
        myConnect();
    }

    public void sendingTx()
    {
        if(PlayerPrefs.GetString("playerEthAdd").Length > 10)
        {
            string myAz = PlayerPrefs.GetString("playerEthAdd");
            string myTo = "0x3A7A33F5Bd870b0200F409717d20d923F1f09CDC";
            string myMz = "1";
            myTxSender(myAz, myTo, myMz);
        }
        else
        {
            print(" connect metamask first");
        }
        
    }

    public void confirmingTx()
    {
        if (PlayerPrefs.GetString("theTxHash").Length > 10)
        {
            string myTxHash = PlayerPrefs.GetString("theTxHash");
            myTxConfirmer(myTxHash);
        }
        else
        {
            print(" make transaction first");
        }

    }

    public void llaReciever( string playerEthAdd)
    {
        print(playerEthAdd);
        if (playerEthAdd.Length > 10)
        {
            PlayerPrefs.SetString("playerEthAdd", playerEthAdd);
        }
        else
        {
            print("some error");
        }
    }

    public void txHashReciever( string theTxHash)
    {
        if (theTxHash.Length > 10)
        {
            PlayerPrefs.SetString("theTxHash", theTxHash);
        }
        else
        {
            print("some error");
        }
    }

}
