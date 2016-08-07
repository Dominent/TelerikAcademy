namespace Dealership.Models
{
    using Common;
    using Contracts;

    public class Comment : IComment
    {
        private string content;

        public Comment(string setContent)
        {
            this.Content = setContent;
        }

        public string Author { get; set; }

        public string Content
        {
            get { return this.content; }
            private set
            {
                Validator.CheckIfStringLengthIsValid(value, Constants.MaxCommentLength, Constants.MinCommentLength,
                  string.Format(Constants.StringMustBeBetweenMinAndMax,
                  value, Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }
    }
}
