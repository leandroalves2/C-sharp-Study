namespace _5___heranca_multipla.Entities
{
    abstract class Device
    {
        public string SerialNumber { get; set; }

        public abstract void ProcessDoc(string doc);       
 
    }
}
