using System.Collections.Generic;
using System.Linq;

namespace BlazorWASM.MemoryCardsGame.Pages
{
    public partial class Index
    {
        public List<int> lstCardNo = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 1, 2, 3, 4, 5, 6, 7, 8 };
        //public List<int> lstCardNoRandom = new List<int>();

        protected override void OnInitialized()
        {
            Generate();
        }

        void Generate()
        {
            Random random = new Random();

            for (int i = 0; i < lstCardNo.Count; i++)
            {
                int j = random.Next(i, lstCardNo.Count);
                int temp = lstCardNo[i];
                lstCardNo[i] = lstCardNo[j];
                lstCardNo[j] = temp;
            }
        }
    }
}
