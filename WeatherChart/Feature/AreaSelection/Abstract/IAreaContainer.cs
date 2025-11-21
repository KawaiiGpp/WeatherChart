namespace WeatherChart.Feature.AreaSelection.Abstract
{
    public interface IAreaContainer<ChildType>
        where ChildType : IArea
    {
        List<ChildType> Children { get; }

        void Register(ChildType child);
    }
}
