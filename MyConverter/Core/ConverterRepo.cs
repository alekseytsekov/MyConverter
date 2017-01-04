namespace MyConverter.Core
{
    using System.Collections.Generic;
    using System.Diagnostics;

    public class ConverterRepo
    {
        private ICollection<Process> processCollection;

        public ConverterRepo()
        {
            this.processCollection = new HashSet<Process>();
        }

        public string Add(Process process)
        {
            this.processCollection.Add(process);

            return null;
        }

        public string Remove(Process process)
        {
            this.processCollection.Remove(process);
            
            return null;
        }

        public ICollection<Process> GetAll()
        {
            return new HashSet<Process>(this.processCollection);
        }

        public bool Clear()
        {
            this.processCollection.Clear();

            return this.processCollection.Count == 0;
        }

        public int Count
        {
            get { return this.processCollection.Count; }
        }
    }
}
