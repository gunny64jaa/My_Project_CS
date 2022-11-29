using System;
using System.Collections;
using System.Collections.Generic;

    

namespace Myproject
{
    class Queue
    {
    int[] table = new int[10];

    public void show_queue()
    {
        foreach(int q in table)
        {
            Console.Write(q+"/");
        }
    }
    }
}