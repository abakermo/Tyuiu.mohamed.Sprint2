using tyuiu.cources.programming.interfaces.Sprint2;
namespace Tyuiu.mohamed.Sprint2.Task0.V28.lib
{
    public class DataService : ISprint2Task0V28
    {
        public bool[] GetCompareOperations(int x, int y)
        {
            return new bool[]
                 {
                x == y,   // == 
                x != y,   // != 
                x < y,    // < 
                x > y,    // > 
                x <= y,   // <= 
                x >= y    // >= 
            };
        }
    }
}
