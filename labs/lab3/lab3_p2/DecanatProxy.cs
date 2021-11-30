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

        Documents IDecanat.GetDocuments(int id)
        {
            if (docs != null)
            {
                docs = new Documents();
            }
            if (dec == null)
            {
                dec = new Decanat();
            }
            if (Student.students[id - 1].Grade > 60)
            {
                docs = dec.GetDocuments(id);
            }
            else
            {
                Console.WriteLine("Cannot create documents, marks are too low");
            }

            return docs;
        }
    }
}