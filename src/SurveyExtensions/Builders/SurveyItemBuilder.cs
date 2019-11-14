namespace SurveyExtensions.Builders
{
    using Elements;

    public interface IBuilder<TObjectToBuild>
    {
        TObjectToBuild Build();
    }
    //public abstract class SurveyItemBuilder
    //{
    //    public abstract SurveyItem Build();
    //}
}