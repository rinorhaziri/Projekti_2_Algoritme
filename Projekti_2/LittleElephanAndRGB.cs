using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Projekti_2
{
    
    class LittleElephanAndRGB
    {
        public long quadruplets;

        public const int MAX = 2500;
        int i, j;
        public int[,] cnt = new int[MAX,MAX];
        public int[,] cnt2= new int[MAX,MAX];

        public long getNumber(String[] list,int minGreen)
        {
            string s = "";
            string temp = "";
            for (int i = 0; i < (list.Length); ++i)
            {
                s += list[i];
                temp = list[i];
                
                if (temp != null)
                Console.WriteLine("Elementi i "+(i+1)+" i stringut : \"" + list[i] + "\"");
            }
            Console.WriteLine("\nElementet e bashkuara të stringut : \"" + s + "\"");
            
            string s1 = "";
            for (int i = 0; i < 50; ++i)
            {
                s1 += 'G';
            }
            
            string ss="";
            for (int i = 0; i < 50; ++i)
            {
                if (i != 0)
                {
                    ss += ',';
                }
                ss += s1;
                    
               
               
            }
            

            
            Array.Clear(cnt, 0, cnt.Length);
            Array.Clear(cnt2, 0, cnt2.Length);

            int n = s.Length;
            Console.WriteLine("\nGjatesia e stringut : " + n + "\n");
            for (i=0;i<s.Length;i++)
            {
                bool all_g = true;
                int last_gg;
                int first_gg;
                int gg;
                first_gg = last_gg = gg = 0;
                for(j=i;j<n;j++)
                {
                    last_gg = s[j] == 'G' ? last_gg + 1 : 0;
                    all_g = all_g && s[j] == 'G';
                    if(all_g)
                    {
                        first_gg = Math.Max(first_gg, last_gg);

                    }
                    gg = Math.Max(gg, last_gg);
                    if(gg >= minGreen)
                    {
                        cnt[i, minGreen]++;
                    }
                    else
                    {
                        cnt[i,first_gg]++;
                    }

                }

            }
            
            for (i = n - 1; i >= 0; i--)
            {
                for (j = minGreen; j >= 0; j--)
                {
                    cnt2[i,j] = cnt2[i + 1,j] + cnt2[i,j + 1] - cnt2[i + 1,j + 1] + cnt[i,j];
                   
                }
            }

            quadruplets = 0;

            for (i = 0; i < n; i++)
            {
                int last_gg = 0;
                int gg = 0;
                for (j = i; j < s.Length; j++)
                {
                    last_gg = s[j] == 'G' ? last_gg + 1 : 0;
                    gg = Math.Max(gg, last_gg);
                    if (gg >= minGreen)
                    {
                        quadruplets += cnt2[j + 1,0];
                    }
                    else
                    {
                        quadruplets += cnt2[j + 1,minGreen - last_gg];
                    }
                }
            }
            Console.WriteLine("Numri minimal i 'G' të njëpasnjëshme : " + minGreen + "\n");
            return quadruplets;
        }
    }
}
