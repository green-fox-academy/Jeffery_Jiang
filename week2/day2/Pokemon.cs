class Pokemon
        {
            public string name;
            public string type;
            private  static string[] types = {"water","fire"};

            public void IseffectiveAgainst(string aginst)
            {
                if (types.Contains(this.name))
                {
                    if (this.name == "fire" && aginst=="water")
                    {
                        Console.WriteLine("cannot win");
                    }

                    if (this.name=="water" && aginst=="fire")
                    {
                        Console.WriteLine("you can win");
                    }
                }
                else
                {
                    Console.WriteLine("no such type");
                    return;
                    
                }
            }
        }