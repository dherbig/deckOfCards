namespace ConsoleApplication{
    public class Card
    {
        private string stringVal;
        private string suit;
        private int val;

        public Card(string anzug, int num){
            //Anzug? Is this German?
            suit = anzug;
            val = num+1;
            string[] sV = {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King"};
            stringVal = sV[num];
        }
        //This could be done by overriding ToString
        public string Is()
        {
            return stringVal + " of " + suit;
        }

        //Example
        public override string ToString()
        {
            return stringVal + " of " + suit;
        }
    }
}