namespace WeatherChart.Feature.AreaSelection
{
    public interface IAreaContainer<ChildType> 
        where ChildType : IArea
    {
        List<ChildType> 
    }
}
