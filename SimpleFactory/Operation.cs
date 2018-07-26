namespace SimpleFactory
{
    /// <summary>
    /// 基类，定义通用元素
    /// </summary>
    public class Operation
    {
        /// <summary>
        /// 操作数A
        /// </summary>
        public double NumberA { get; set; }

        /// <summary>
        /// 操作数B
        /// </summary>
        public double NumberB { get; set; }

        /// <summary>
        /// 虚方法：计算结果
        /// </summary>
        /// <returns></returns>
        public virtual double GetResult()
        {
            double result = 0;
            return result;
        }
    }
}
