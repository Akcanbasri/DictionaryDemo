using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryDemo
{
    public class MyDictinorTKey<TKey, TValue>
    {
        //getting address for our own Dictinory in Stack
        TKey[] key;
        TValue[] value;

        //Contsructor to make our empty arrays for dictionary
        public MyDictinorTKey()
        {
           key = new TKey[0];
           value = new TValue[0];
        }

        //Counting mambers of our dictionary via keys
        public int Count()
        {

            return key.Length;           
        }
        // Adding values with Add() function
        public void Add(TKey item, TValue item2)
        {
            TKey[] _tempKey = key;
            TValue[] _tempValue = value;
            key = new TKey[_tempKey.Length + 1];
            value = new TValue[_tempValue.Length + 1];

            for (int i = 0; i < _tempKey.Length; i++)
            {
                key[i] = _tempKey[i];
                value[i] = _tempValue[i];
            }

            key[key.Length - 1] = item;
            value[key.Length - 1] = item2;  
        }

        //calling all Dict. from main
        public void GetDİct()
        {
            for (int i = 0; i < Count(); i++)
            {
                Console.WriteLine("licence plate: "+ key[i]+ " Citiy: "+ value[i]);
            }
        }


    }
}
