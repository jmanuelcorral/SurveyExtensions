namespace SurveyExtensions.Builders
{
    using Elements;
    using SurveyExtensions.Elements.Questions;

    public class BooleanQuestionBuilder<TEntity> :
        QuestionBuilderBase<TEntity, BooleanQuestion>,
        IBuilder<SurveyItem> where TEntity : new()
    {

        public BooleanQuestionBuilder<TEntity> HasName(string value)
        {
            _item.Name = value;
            return this;
        }
        public BooleanQuestionBuilder<TEntity> HasTitle(string value)
        {
            _item.Title = value;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> HasDescription(string value)
        {
            _item.Description = value;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> IsRequired()
        {
            _item.IsRequired = true;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> IsHidden()
        {
            _item.Visible = false;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> ContinueInSameLine()
        {
            _item.StartWithNewLine = false;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> HasLabel(string label)
        {
            _item.Label = label;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> HasLabelTrue(string labelTrue)
        {
            _item.LabelTrue = labelTrue;
            return this;
        }

        public BooleanQuestionBuilder<TEntity> HasLabelFalse(string labelFalse)
        {
            _item.LabelFalse = labelFalse;
            return this;
        }
    }
}