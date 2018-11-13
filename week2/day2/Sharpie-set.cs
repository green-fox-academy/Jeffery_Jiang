using System.Collections.Generic;

namespace sharpeset
{




    class Sharpie
    {
        public string Color;
        public float Width;
        public float InkAmount;

        public Sharpie(string Color, float Width, float InkAmount)
        {
            this.Color = Color;
            this.Width = Width;
            this.InkAmount = InkAmount;
        }

        public Sharpie(string Color, float Width) : this(Color, Width, 100)
        {
        }

        public void use()
        {
            InkAmount--;
        }

    }

    class Sharpieset
    {
        public List<Sharpie> SharpieList=new List<Sharpie>();

        public List<Sharpie> AddList(Sharpie sharpie)
        {
            SharpieList.Add(sharpie);

            return SharpieList;
        }

        public int CountUsable()
        {
            //sharpielist = this.SharpieList;
            int count = 0;
            foreach (var sharpie in SharpieList)
            {
                if (sharpie.InkAmount > 0)
                {
                    count++;
                }
            }

            return count;
        }

        public void RemoveTrash()
        {
            for (int i = 0; i < SharpieList.Count; i++)
            {
                if (SharpieList[i].InkAmount <= 0)
                {
                    SharpieList.Remove(SharpieList[i]);
                }
            }
        }
    }

}