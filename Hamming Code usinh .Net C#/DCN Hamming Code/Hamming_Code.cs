using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace DCN_Hamming_Code
{
   public class Hamming_Code
    {
       public Error_Checker obj1;

        public Hamming_Code(Error_Checker obj2)
        {
            obj1 = obj2;
        }
        public void HammingSender(int a1, int a2, int a3,int a4,int a5,int a6,int a7)
        {
            int[] a = new int[12];

            int i;
            //sending input

            a[3] = a1;
            a[5] = a2;
            a[6] = a3;
            a[7] = a4;
            a[9] = a5;
            a[10] = a6;
            a[11] = a7;

            a[1] = a[3] ^ a[5] ^ a[7] ^ a[9] ^ a[11];
            a[2] = a[3] ^ a[6] ^a[7] ^ a[10] ^ a[11];
            a[4] = a[5] ^ a[6] ^ a[7];
            a[8] = a[9] ^ a[10] ^ a[11];

            for (i = 1; i <=11; i++)
            {
                string display = Convert.ToString(a[i]);
                obj1.displaysendingBits.Text +=display+" ";
            }
            // recieving input 
        }
        public void HammingReciever(int b1, int b2, int b3, int b4, int b5, int b6, int b7,int b8,int b9,int b10,int b11)
        {
            int[] b = new int[12];
            int i,c1, c2, c3, c4 ;
            b[1] = b1;
            b[2] = b2;
            b[3] = b3;
            b[4] = b4;
            b[5] = b5;
            b[6] = b6;
            b[7] = b7;
            b[8] = b8;
            b[9] = b9;
            b[10] = b10;
            b[11] = b11;

            // checking parity bits value
            c1 = b[1] ^ b[3] ^ b[5] ^ b[7] ^ b[9] ^ b[11];
            c2 = b[2] ^ b[3] ^ b[6] ^ b[7] ^ b[10] ^ b[11];
            c3 = b[4] ^ b[5] ^ b[6] ^ b[7];
            c4 = b[8] ^ b[9] ^ b[10] ^ b[11];
            // converting parity bits into decimal
            int parity = c1 * 1 + c2 * 2 + c3 * 4 + c4*8;

            // if parity==0 then no error other wise error

            if (parity == 0)
            {
                MessageBox.Show("No Error");
            }
            else
            {
                MessageBox.Show("There is an error in position "+parity);
                if (b[parity] == 0)
                {
                    b[parity] = 1;
                }
                else
                {
                    b[parity] = 0;
                }
            }
            for (i = 1; i <= 11; i++)
            {
                string display = Convert.ToString(b[i]);
                obj1.displayRecievingBits.Text += display + " ";
            }
        }
   }
}

   
        
    

