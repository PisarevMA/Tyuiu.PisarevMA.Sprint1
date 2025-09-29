using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.PisarevMA.Sprint1.Task6.V11.Lib
{
    public class DataService : ISprint1Task6V11
    {
        public bool CheckeFirstLetterRepetition(string value)
        {
            if (value.IndexOf(value.ToCharArray()[0]) != -1) { return true; }
            return false;
        }
    }
}