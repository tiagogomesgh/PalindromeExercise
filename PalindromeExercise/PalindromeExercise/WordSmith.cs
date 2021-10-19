using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalidrome(string word)
        {
            // reverse the word
            var reversed = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            // compare original with reveresed

            if (reversed == word)
            {
                return true;
            }
            else
            {
                return false;
            }
            // return true or false
            
        }



    }
}
