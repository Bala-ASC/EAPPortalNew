using System;
using System.Collections.Generic;
using System.Text;

namespace EAPAccess.Common.Classes
{
   public class RandomPassword
    {
        public static string RandomGeneratePassword()
        {
            string allowedChars = "";

            allowedChars = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z,";

            allowedChars += "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z,";

            allowedChars += "1,2,3,4,5,6,7,8,9,0,!,@,#,$,%,&,?";

            char[] sep = { ',' };

            string[] arr = allowedChars.Split(sep);

            string passwordString = "";

            string temp = "";

            Random rand = new Random();

            for (int i = 0; i < 8; i++)

            {

                temp = arr[rand.Next(0, arr.Length)];

                passwordString += temp;

            }
            return passwordString;
        }
    }
}
