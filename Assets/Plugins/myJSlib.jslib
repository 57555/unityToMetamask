var plugin = {
    myConnect: function()
    {
        getConnection();
    },
    myTxSender: function( myAz, myTo, myMz)
    {
        mySendTx(Pointer_stringify(myAz), Pointer_stringify(myTo), Pointer_stringify(myMz));
    },
    myTxConfirmer: function( myTxHash)
    {
        myConfirmTx(Pointer_stringify(myTxHash));
    }
};

mergeInto(LibraryManager.library, plugin);