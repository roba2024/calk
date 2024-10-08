public interface Ikalkulator
{
    /// <summary>
    /// legger sammen input 1 og 2
    /// </summary>
    /// <param name="Input1"></param>
    /// <param name="Input2"></param>
    /// <returns>input 1 + input 2</returns> 
    double AddNumber(double Input1, double Input2);
    /// <summary>
    /// trekker input 2 fra input 1
    /// </summary>
    /// <param name="Input1"></param>
    /// <param name="Input2"></param>
    /// <returns>input 1 - input 2</returns>
    double SubtractNumber(double Input1, double Input2);
    /// <summary>
    /// input 1 ganger med input 2
    /// </summary>
    /// <param name="Input1"></param>
    /// <param name="Input2"></param>
    /// <returns>input 2 ganger med input 1</returns>
    double MultiplyNumber(double Input1, double Input2);
    /// <summary>
    /// input 1 delt på input 2
    /// </summary>
    /// <param name="Input1"></param>
    /// <param name="Input2"></param>
    /// <returns>input 1 delt på input2</returns>
    double DivideNumber(double Input1, double Input2);
        
    
}
