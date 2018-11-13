class Counter
    {
        public int num;
        public static int defualt_value = 0;

        public Counter(int num)
        {
            this.num = num;
        }
        public Counter() : this(defualt_value) { }

        public void Add(int num)
        {
            this.num += num;
        }

        public void Add()
        {
            this.num++;
        }

        public string get()
        {
            return $"{this.num}";
        }

        public void Reset()
        {
            this.num = defualt_value;
        }