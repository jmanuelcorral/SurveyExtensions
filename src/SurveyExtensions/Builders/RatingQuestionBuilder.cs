namespace SurveyExtensions.Builders
{
    using Elements;
    using SurveyExtensions.Elements.ChoiceItems;
    using SurveyExtensions.Elements.Questions;

    public class RatingQuestionBuilder<TEntity> : 
        QuestionBuilderBase<TEntity, RatingQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public RatingQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public RatingQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public RatingQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public RatingQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasRateMin(int value)
        {
            _item.RateMin = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasRateMax(int value)
        {
            _item.RateMax = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasRateStep(int value)
        {
            _item.RateStep = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> AddRateValue(string value, string text)
        {
            _item.RateValues.Add(new Choice() { Value = value, Text = text});
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasMinRateDescription(string value)
        {
            _item.MinRateDescription = value;
            return this;
        }

        public RatingQuestionBuilder<TEntity> HasMaxRateDescription(string value)
        {
            _item.MaxRateDescription = value;
            return this;
        }
    }
}