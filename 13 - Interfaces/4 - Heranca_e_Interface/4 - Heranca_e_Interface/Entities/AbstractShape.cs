using _4___Heranca_e_Interface.Enuns;

namespace _4___Heranca_e_Interface.Entities
{
    abstract class AbstractShape : IShape
    {

        public Colors Color { get; set; }

        public abstract double Area();
    }
}
