namespace GChartsBlazorfied
{
    public class gcObjectArray : List<object>
    {
        public gcObjectArray AddRow(params object[] objects)
        {
            var o = new List<object>();
            foreach (var obj in objects)
            {
                o.Add(obj);
            }
            this.Add(o);
            return this;
        }
    }
}
