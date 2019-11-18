namespace SurveyExtensions.Builders
{
    using Elements;

    public interface IBuilder<TObjectToBuild>
    {
        TObjectToBuild Build();
    }
}