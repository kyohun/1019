namespace 멤버_필드와_속성
{
    internal class Man
    {
        private int mno;
        internal int MNo
        {
            get
            {
                return mno;
            }
            private set
            {
                if(value <0)
                {
                    value = 0;
                }

                mno = value;
            }
        }
        internal int GetMNo()
        {
            return mno;
        }
        private void SetMNo(int value)
        {
            mno = value;
        }
        internal string Name
        {
            get;
            private set;
        }


        public Man(int mno, string name)
        {
            this.mno = mno;
            Name = name;
        }
    }
}