using NewEra.DepoSimu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEra.DepoSimu
{
    class RafModel
    {
        public string RafAdi { get; set; }
        public int RafY { get; set; }
        public int RafX { get; set; }

        public KoyModel[,] Koy { get; set; }

        public RafModel(string rafAdi, int rafX, int rafY)
        {
            RafAdi = rafAdi;
            RafY = rafX;
            RafX = rafY;
            Koy = CreateKoy();
        }

        private KoyModel[,] CreateKoy()
        {
            try
            {
                KoyModel[,] list = new KoyModel[RafX, RafY];
                for (int i = 0; i < RafX; i++)
                {
                    for (int j = RafY - 1; j >= 0; j--)
                    {
                        list[i, j] = new KoyModel((i + 1).ToString(), Math.Abs(((j - RafY) % (RafY + 1))).ToString(), CreateBool());
                    }
                }

                return list;
            }
            catch (Exception ex)
            {

                throw new Exception("\nCreateKoy\n" + ex.Message);
            }
        }
        Random rnd = new Random();
        private bool CreateBool()
        {

            //System.Threading.Thread.Sleep(10);
            return Convert.ToBoolean(rnd.Next(0, 2));
        }
    }
}
