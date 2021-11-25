namespace System
{
    class DecanatProxy : IDecanat
    {
        Documents docs;
        Decanat dec;

        public DecanatProxy()
        {
            docs = new Documents();
        }

        Documents IDecanat.GetDocuments(int number)
        {
            if (docs != null)
            {
                docs = new Documents();
            }
            if (dec == null)
            {
                dec = new Decanat();
            }
            try
            {
                docs = dec.GetDocuments(number);
            }
            catch
            {
                Console.WriteLine("Cannot create documents, marks are too low");
            }

            return docs;
        }
    }
}