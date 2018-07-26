namespace SimpleFactory
{
    /// <summary>
    /// 运算工厂
    /// </summary>
    public class OperationFactory
    {
        //工厂：顾名思义，生产对象
        //根据传入的参数，判断选择生成相应的对象
        public static Operation CreateOperate(string operate)
        {
            Operation ope = null;
            switch (operate)
            {
                case "+":
                    ope = new OperationAdd();
                    break;
                case "-":
                    ope = new OperationSub();
                    break;
                default:
                    break;
            }
            return ope;
        }
    }
}
